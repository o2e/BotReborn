using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

using BotReborn.Events;
using BotReborn.Packets;

using Microsoft.Extensions.Logging;

using Polly;

namespace BotReborn
{
    public partial class OicqClient
    {
        public void Connect()
        {
            var ip = Servers[CurrentServerIndex];
            Logger.LogInformation("Connect to server: {0}", ip);
            try
            {
                TcpClient.Connect(ip);
                ConnectTime = DateTime.Now;
            }
            catch (Exception e)
            {
                Logger.LogError("connect server {0} error : {1}", ip, e);
                RetryTimes++;
                if (RetryTimes > Servers.Count)
                {
                    throw new Exception("All servers are unreachable.");
                }
            }
            finally
            {
                CurrentServerIndex++;
                if (CurrentServerIndex >= Servers.Count)
                {
                    CurrentServerIndex = 0;
                }
            }

            Task.Run(() =>
            {
                _once.Wait();//Use a Semaphore which will never be released to simulate a once.
                // TODO event handlers
                Task.Factory.StartNew(StartNetLoop, TaskCreationOptions.LongRunning);
            });
            RetryTimes = 0;
            ConnectTime = DateTimeOffset.Now;
        }

        public void QuickReconnect()
        {
            Disconnect();
            Thread.Sleep(200);
            try
            {
                Connect();
            }
            catch (Exception e)
            {
                Logger.LogTrace(e, e.Message);
                Logger.LogError("Quick reconnect failed.");
            }
        }

        public void Disconnect()
        {
            IsOnline = false;
            TcpClient.Close();
        }

        internal void Send(byte[] pkt)
        {
            var stream = TcpClient.GetStream();
            stream.Write(pkt);
        }

        internal object SendAndWait(byte[] pkt, ushort seq,Dictionary<string, object> para = null)
        {
            var ch = Channel.CreateBounded<object>(1);
            _handlers[seq] = new HandlerInfo { Func = o => { ch.Writer.TryWrite(o); }, Params = para };
            var policy = Policy.Handle<TimeoutException>().Retry(3, (e, i) =>
            {
                if (i < 3)
                {
                    Send(pkt);
                }
                else
                {
                    _handlers.Remove(seq, out _);
                    throw new Exception("Packet timed out");
                }
            });
            var res = policy.Execute(async () => await ch.Reader.ReadAsync().AsTask().WaitAsync(TimeSpan.FromSeconds(15)));
            return res.Result;
        }

        private void StartNetLoop()
        {
            var errCount = 0;
            var stream = TcpClient.GetStream();
            while (true)
            {
                var span = stream.ReadBytes(4);
                var l = BinaryPrimitives.ReadInt32BigEndian(span);
                var data = stream.ReadBytes(l - 4);
                IncomingPacket pkt;
                try
                {
                    pkt = Packet.ParseIncomingPacket(data.ToArray(), SigInfo.D2Key);
                }
                catch (Exception e)
                {
                    Logger.LogError(e, "Parse incoming packet error: {0}", e.Message);
                    errCount++;
                    if (errCount > 2)
                    {
                        QuickReconnect();
                    }
                    continue;
                }
                if (pkt.Flag2 == 2)
                {
                    try
                    {
                        pkt.Payload = Packet.DecryptPayload(_ecdh, pkt.Payload, RandomKey, SigInfo.WtSessionTicketKey);
                    }
                    catch (Exception e)
                    {
                        Logger.LogError("Decrypt payload error: {0} ", e);
                        continue;
                    }
                }
                Logger.LogDebug("Receive pkt: {0} seq: {1}", pkt.CommandName, pkt.SequenceId);
                Interlocked.Increment(ref Statistics.PacketReceived);
                Task.Run(() =>
                {
                    var decoder = GetDecoderByName(pkt.CommandName);
                    if (decoder is not null)
                    {
                        if (_handlers.Remove(pkt.SequenceId, out var info))
                        {
                            decoder(this,
                                new IncomingPacketInfo()
                                {
                                    CommandName = pkt.CommandName,
                                    SequenceId = pkt.SequenceId,
                                    Params = info.Params
                                }, pkt.Payload);
                        }
                        else
                        {
                            decoder(this,
                                new IncomingPacketInfo()
                                {
                                    CommandName = pkt.CommandName,
                                    SequenceId = pkt.SequenceId,
                                    Params = null
                                }, pkt.Payload);
                        }
                    }
                }).Wait();
            }
        }
    }
}
