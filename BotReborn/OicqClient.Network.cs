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

        internal object SendAndWait(byte[] pkt, ushort seq)
        {
            var ch = Channel.CreateBounded<object>(1);
            ch.Reader.
            _handlers[seq] = (s,  e) =>
            {
                var args = e as LoginEventArgs;
                ch.Writer.TryWrite(args?.Response);
            };
            Policy.
            var task = ch.Reader.WaitToReadAsync().AsTask().WaitAsync(TimeSpan.FromSeconds(25)).ContinueWith().WaitAsync(TimeSpan.FromSeconds(15));
            Task.WhenAll(task.AsTask()).;
        }

        private void StartNetLoop()
        {
            var stream = TcpClient.GetStream();
            while (true)
            {
                var span = stream.ReadBytes(4);
                var l = BinaryPrimitives.ReadInt32BigEndian(span);
                var data = stream.ReadBytes(l - 4);
                var pkt = Packet.ParseIncomingPacket(data.ToArray(), SigInfo.D2Key);
                // if err != nil {
                // 	c.Error("parse incoming packet error: %v", err)
                // 	if errors.Is(err, packets.ErrSessionExpired) || errors.Is(err, packets.ErrPacketDropped) {
                // 		c.Disconnect()
                // 		go c.dispatchDisconnectEvent(&ClientDisconnectedEvent{Message: "session expired"})
                // 		continue
                // 	}
                // 	errCount++
                // 	if errCount > 2 {
                // 		go c.quickReconnect()
                // 		continue
                // 	}
                // 	continue
                // }
                var payload = pkt.Payload;
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
                        var ok = _handlers.Remove(pkt.SequenceId, out var info);
                        Exception err = null;
                        object rsp = null;
                        try
                        {
                            rsp = decoder(this,
                                new IncomingPacketInfo()
                                {
                                    SequenceId = pkt.SequenceId,
                                    CommandName = pkt.CommandName,
                                    Params = ok ? info.Param : null
                                }, pkt.Payload);
                        }
                        catch (Exception e)
                        {
                            err = e;
                        }

                        if (ok)
                        {
                            info.Func(rsp, err);
                        }
                    }
                    else if (_handlers.Remove(pkt.SequenceId, out var f))
                    {
                        f.Func(null, null);
                    }
                    else
                    {
                        Logger.LogDebug("Unhandled Command: {0}\nSeq: {1}\nThis message can be ignored.", pkt.CommandName, pkt.SequenceId);
                    }

                    throw new NotImplementedException();
                }).Wait();
            }
        }
    }
}
