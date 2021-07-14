using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
