using BotReborn.Model.Exception;
using Microsoft.Extensions.Logging;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System;
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
            OutGoingPacketSessionId = new byte[] { 0x02, 0xB0, 0x5B, 0x8B };
            //TCP: &utils.TCPListener{ },
            //sigInfo: &loginSigInfo{ },

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
            if (CurrentServerIndex == Servers.Length) CurrentServerIndex = 0;
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

        public void DisConnect()
        {
            IsOnline = false;
            TcpListener.Stop();
        }

        public void QuickReconnect()
        {
            DisConnect();
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
            //TODO 注册客户端
        }

        public ushort NextSeq() => (ushort)(Interlocked.Increment(ref _sequenceId) & 0x7FFF);
        public int NextPacketSeq() => Interlocked.Add(ref _requestPacketRequestId, 2);
        public int NextGroupSeq() => Interlocked.Add(ref _groupSeq, 2);
        public int NextFriendSeq() => Interlocked.Add(ref _friendSeq, 2);
        public int NextGroupDataTransSeq() => Interlocked.Add(ref _groupDataTransSeq, 2);
        public int NextHighwayApplySeq() => Interlocked.Add(ref HighwayApplyUpSeq, 2);
    }
}
