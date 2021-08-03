﻿using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

using BotReborn.Crypto;
using BotReborn.Jce;
using BotReborn.Model;
using BotReborn.Model.Exception;
using BotReborn.Packets;
using Microsoft.Extensions.Logging;

namespace BotReborn
{
    public partial class Client
    {
        public bool TryLogin(out LoginResponse resp)
        {
            try
            {
                resp = Login();
                return true;
            }
            catch
            {
                resp = null;
                return false;
            }
        }

        public LoginResponse Login()
        {
            if (IsOnline) throw new LoginException("Already online.");
            try
            {
                Connect();
            }
            catch (Exception e)
            {
                Logger.LogTrace(e, e.Message);
                Logger.LogError("Login failed.");
                return null;
            }


            throw new LoginException("Unknown exception!");
        }

        public void Connect()
        {
            if (CurrentServerIndex == Servers.Count) CurrentServerIndex = 0;
            while (CanRetry)
            {
                var ip = Servers[CurrentServerIndex];
                Logger.LogInformation("Connect to server: {0}", ip);
                try
                {
                    TcpClient = new TcpClient();
                    TcpClient.Connect(ip);
                    ConnectTime = DateTime.Now;
                }
                catch (Exception e)
                {
                    Logger.LogTrace(e, e.Message);
                    Logger.LogError("Connect failed.");
                    RetryTimes++;
                    CurrentServerIndex++;
                }
            }

            if (!CanRetry)
            {
                throw new HttpListenerException();
            }
        }

        public void Disconnect()
        {
            IsOnline = false;
            TcpClient.Close();
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

        public void Release()
        {
            if (IsOnline)
            {
                Disconnect();
            }

            IsOnline = false;
        }

        public void RegisterClient()
        {
            var seq = NextSeq();
            //TODO 注册客户端
        }

        public List<IPEndPoint> GetSSOAddresses()
        {
            var protocol = DeviceInfo.Default.Protocol;
            var key = Utils.ConvertHexStringToByteArray("F0441F5FF42DA58FDCF7949ABA62D411");
            var payload = new JceStream()
                .WriteInt64(0, 1)
                .WriteInt64(0, 2)
                .WriteByte(1, 3)
                .WriteString("00000", 4)
                .WriteInt32(100, 5)
                .WriteInt32((int)protocol.AppId, 6)
                .WriteString(DeviceInfo.Default.IMEI, 7)
                .WriteInt64(0, 8)
                .WriteInt64(0, 9)
                .WriteInt64(0, 10)
                .WriteInt64(0, 11)
                .WriteByte(0, 12)
                .WriteInt64(0, 13)
                .WriteByte(1, 14)
                .ToArray();
            var buf = new JceStructs.RequestDataVersion3()
            {
                Map = new Dictionary<string, byte[]>() { ["HttpServerListReq"] = Utils.PackUniRequestData(payload) }
            };
            var pkt = new JceStructs.RequestPacket
            {
                IVersion = 3,
                SServantName = "ConfigHttp",
                SFuncName = "HttpServerListReq",
                SBuffer = buf.GetBytes()
            };
            var tea = new Tea(key);
            var req = pkt.GetBytes();
            var tempData = new BinaryStream().WriteIntLvPacket(0, req).ToArray();
            var reqData =
                tea.Encrypt(tempData);
            byte[] rsp;
            try
            {
                rsp = _httpClient.PostBytes("https://configsvr.msf.3g.qq.com/configsvr/serverlist.jsp", reqData);
            }
            catch (Exception e)
            {
                Logger.LogError(e.Message);
                throw new Exception("Unable to fetch server list.");
            }
            var rspPkt = new JceStructs.RequestPacket();
            var data = new JceStructs.RequestDataVersion3();
            rspPkt.ReadFrom(new JceStream(tea.Decrypt(rsp)[4..]));
            data.ReadFrom(new JceStream(rspPkt.SBuffer));
            var stream = new JceStream(data.Map["HttpServerListRes"][1..]);
            var servers = stream.ReadSlice(typeof(JceStructs.SsoServerInfo), 2).Cast<JceStructs.SsoServerInfo>().ToList();
            var addresses = new List<IPEndPoint>(servers.Count);
            foreach (var s in servers)
            {
                if (IPAddress.TryParse(s.Server,out var server))
                {
                    addresses.Add(new IPEndPoint(server, 80));
                }
            }
            return addresses;
        }

        public void DoHeartBeat()
        {
            _heartbeatEnabled = true;
            var times = 0;
            while (IsOnline)
            {
                Thread.Sleep(new TimeSpan(0, 0, 1, 0));
                var seq = NextSeq();
                //todo
                var sso = Packet.BuildSsoPacket(seq, 0, 0, "", "", Array.Empty<byte>(), Array.Empty<byte>(), Array.Empty<byte>(), Array.Empty<byte>());

                times++;
                if (times >= 7)
                {
                    RegisterClient();
                    times = 0;
                }
            }

            _heartbeatEnabled = false;
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
                if (pkt.Flag2==2)
                {
                    
                }
            }
        }

        public ushort NextSeq() => (ushort)(Interlocked.Increment(ref _sequenceId) & 0x7FFF);
        public int NextPacketSeq() => Interlocked.Add(ref _requestPacketRequestId, 2);
        public int NextGroupSeq() => Interlocked.Add(ref _groupSeq, 2);
        public int NextFriendSeq() => Interlocked.Add(ref _friendSeq, 2);
        public int NextGroupDataTransSeq() => Interlocked.Add(ref _groupDataTransSeq, 2);
        public int NextHighwayApplySeq() => Interlocked.Add(ref _highwayApplyUpSeq, 2);
    }
}
