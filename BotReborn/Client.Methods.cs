using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using BotReborn.Jce;
using BotReborn.Model;
using BotReborn.Model.Exception;

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
                _logger.LogTrace(e, e.Message);
                _logger.LogError("Login failed.");
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
                _logger.LogInformation("Connect to server: {0}", ip);
                try
                {
                    TcpListener = new TcpListener(ip);
                    TcpListener.Start();
                    ConnectTime = DateTime.Now;
                }
                catch (Exception e)
                {
                    _logger.LogTrace(e, e.Message);
                    _logger.LogError("Connect failed.");
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
            TcpListener.Stop();
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
                _logger.LogTrace(e, e.Message);
                _logger.LogError("Quick reconnect failed.");
            }
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
            var payload = new JceWriter().WriteInt64(0, 1).WriteInt64(0, 2).WriteByte(1, 3).WriteString("00000", 4)
                .WriteInt32(100, 5).WriteInt32((int)protocol.AppId, 6)
                .WriteString(DeviceInfo.Default.IMEI, 7).WriteInt64(0, 8).WriteInt64(0, 9).WriteInt64(0, 10)
                .WriteInt64(0, 11).WriteByte(0, 12).WriteInt64(0, 13).WriteByte(1, 14)
                .GetBytes();
            var buf = new JceStructs.RequestDataVersion3()
            {
                Map = new Dictionary<string, byte[]>() {["HttpServerListReq"] = Utils.PackUniRequestData(payload)}
            };
            var pkt = new JceStructs.RequestPacket{
                IVersion=    3,
                SServantName= "ConfigHttp",
                SFuncName="HttpServerListReq",
                SBuffer: buf.
            }
            throw new NotImplementedException();
        }

        public ushort NextSeq() => (ushort)(Interlocked.Increment(ref _sequenceId) & 0x7FFF);
        public int NextPacketSeq() => Interlocked.Add(ref _requestPacketRequestId, 2);
        public int NextGroupSeq() => Interlocked.Add(ref _groupSeq, 2);
        public int NextFriendSeq() => Interlocked.Add(ref _friendSeq, 2);
        public int NextGroupDataTransSeq() => Interlocked.Add(ref _groupDataTransSeq, 2);
        public int NextHighwayApplySeq() => Interlocked.Add(ref _highwayApplyUpSeq, 2);
    }
}
