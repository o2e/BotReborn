using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

using BotReborn.Packets;

using Microsoft.Extensions.Logging;

using Polly;

namespace BotReborn
{
    public partial class OicqClient
    {
        public void Connect()
        {
            foreach (var ip in Servers)
            {
                if (!TcpClient.Connected)
                {
                    Logger.LogInformation("Connecting to server: {0}", ip);
                    TcpClient.Connect(ip);
                }
            }
            if (!TcpClient.Connected)
            {
                throw new Exception("All servers are unreachable.");
            }
            _once.Wait(TimeSpan.FromSeconds(30));
            ConnectTime = DateTime.Now;
            Task.Factory.StartNew(StartNetLoop, TaskCreationOptions.LongRunning);
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
            try
            {
                stream.Write(pkt);
            }
            catch (Exception e)
            {
                Logger.LogError(e, e.Message);
                Interlocked.Increment(ref Statistics.PacketLost);
            }
        }

        internal object SendAndWait(byte[] pkt, ushort seq, Dictionary<string, object> para = null)
        {
            var ch = Channel.CreateBounded<object>(1);
            _handlers[seq] = new HandlerInfo { Func = o => { ch.Writer.TryWrite(o); }, Params = para };
            Send(pkt);
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
                var l = stream.ReadInt32();
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
                Logger.LogDebug("Original payload: [{0}]", string.Join(",", pkt.Payload));
                if (pkt.Flag2 == 2)
                {
                    try
                    {
                        //RandomKey = new byte[] { 143, 37, 208, 160, 45, 119, 30, 253, 134, 50, 75, 15, 175, 10, 198, 83 };
                        pkt.DecryptPayload(RandomKey, SigInfo.WtSessionTicketKey);
                    }
                    catch (Exception e)
                    {
                        Logger.LogError(e, e.Message);
                        continue;
                    }
                }
                Logger.LogDebug("Decrypted payload: [{0}]", string.Join(",", pkt.Payload));
                errCount = 0;
                Logger.LogDebug("Receive pkt: {0} seq: {1}", pkt.CommandName, pkt.SequenceId);
                Interlocked.Increment(ref Statistics.PacketReceived);
                Task.Run(() =>
                {
                    var decoder = GetDecoderByName(pkt.CommandName);
                    if (decoder is not null)
                    {
                        LoginResponse rsp;
                        if (_handlers.Remove(pkt.SequenceId, out var info))
                        {
                            rsp = (LoginResponse)decoder(this,
                                 new IncomingPacketInfo()
                                 {
                                     CommandName = pkt.CommandName,
                                     SequenceId = pkt.SequenceId,
                                     Params = info.Params
                                 }, pkt.Payload);
                        }
                        else
                        {
                            rsp = (LoginResponse)decoder(this,
                                new IncomingPacketInfo()
                                {
                                    CommandName = pkt.CommandName,
                                    SequenceId = pkt.SequenceId,
                                    Params = null
                                }, pkt.Payload);
                        }
                        info?.Func(rsp);
                    }
                }).Wait();
            }
            // ReSharper disable once FunctionNeverReturns
        }
    }
}
