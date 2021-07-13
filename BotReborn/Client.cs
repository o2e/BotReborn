using BotReborn.Model.Exception;
using Microsoft.Extensions.Logging;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;

namespace BotReborn
{
    public partial class Client
    {
        private Client(Uin uin, ILogger logger)
        {
            _logger = logger;
            _ecdh = new EncryptECDH();
            _random = new Random(DateTime.Now.Second);
            _md5 = MD5.Create();

            Uin = uin;
            AllowSlider = true;
            RandomKey = new byte[16];
            OutGoingPacketSessionId = new byte[] { 0x02, 0xB0, 0x5B, 0x8B };//Magic number
            //TCP: &utils.TCPListener{ },
            SigInfo = new LogInSigInfo();
            _requestPacketRequestId = 1921334513; //Magic number
            _groupSeq = _random.Next(20000);
            _friendSeq = 22911;//Magic number
            _highwayApplyUpSeq = 77918;//Magic number
            Ksid = Utils.GetBytes($"|{SystemDeviceInfo.IMEI}|A8.2.7.27f6ea96");
            //eventHandlers:           &eventHandlers{},
            //msgSvcCache: utils.NewCache(time.Second * 15),
            //transCache: utils.NewCache(time.Second * 15),
            //onlinePushCache: utils.NewCache(time.Second * 15),
            //version:                 genVersionInfo(SystemDeviceInfo.Protocol),
            Servers = new List<IPEndPoint>();
            //sso, err:= getSSOAddress()
            //if err == nil && len(sso) > 0 {
            //    cli.servers = append(sso, cli.servers...)

            //}
            var addresses = Dns.GetHostAddresses("msfwifi.3g.qq.com");
            if (addresses.Length > 0)
            {
                Servers.AddRange(addresses.Select(_ => new IPEndPoint(_, 8080)));
            }
        }

        public Client(Uin uin, ILogger logger, string password) : this(uin, logger)
        {
            var bytes = Encoding.UTF8.GetBytes(password);
            PasswordMd5 = _md5.ComputeHash(bytes);
        }

        public Client(Uin uin, ILogger logger, byte[] passwordMd5) : this(uin, logger)
        {
            PasswordMd5 = passwordMd5;
        }

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

        public ushort NextSeq() => (ushort)(Interlocked.Increment(ref _sequenceId) & 0x7FFF);
        public int NextPacketSeq() => Interlocked.Add(ref _requestPacketRequestId, 2);
        public int NextGroupSeq() => Interlocked.Add(ref _groupSeq, 2);
        public int NextFriendSeq() => Interlocked.Add(ref _friendSeq, 2);
        public int NextGroupDataTransSeq() => Interlocked.Add(ref _groupDataTransSeq, 2);
        public int NextHighwayApplySeq() => Interlocked.Add(ref _highwayApplyUpSeq, 2);
    }
}
