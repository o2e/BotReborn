using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;

using BotReborn.Model.Exception;
using BotReborn.Model.Group;

using Microsoft.Extensions.Logging;

namespace BotReborn
{
    public partial class Client
    {
        private EncryptECDH _ecdh;
        private Random _random;
        private MD5 _md5;
        private ILogger _logger;

        public Uin Uin { get; set; }
        public byte[] PasswordMd5 { get; set; }
        public bool AllowSlider { get; set; }

        public string NickName { get; set; }
        public ushort Age { get; set; }
        public ushort Gender { get; set; }
        public List<Friend> Friends { get; set; }
        public List<GroupInfo> Groups { get; set; }
        public List<Device> Devices { get; set; }
        public bool IsOnline { get; set; }
        //public QiDianAccountInfo QiDianAccountInfo { get; set; }
        //public bool NetLooping { get; set; }

        public int SequenceId { get; set; }
        public byte[] OutGoingPacketSessionId { get; set; }
        public byte[] RandomKey { get; set; }
        public TcpListener TcpListener { get; set; }
        public DateTime Time { get; set; }
        public Hashtable Waiters { get; set; }
        public IPAddress[] Servers { get; set; }
        public int CurrentServerIndex { get; set; }
        public int RetryTimes { get; set; }
        public Version Version { get; set; }

        public byte[] Dpwd { get; set; }
        public byte[] SyncCookie { get; set; }
        public byte[] PubAccountCookie { get; set; }
        public byte[] MsgCtrlBuf { get; set; }
        public byte[] Ksid { get; set; }
        public byte[] T104 { get; set; }
        public byte[] T174 { get; set; }
        public byte[] G { get; set; }
        public byte[] T402 { get; set; }
        public byte[] T150 { get; set; }
        public byte[] T149 { get; set; }
        public byte[] T528 { get; set; }
        public byte[] T530 { get; set; }
        public byte[] RollbackSig { get; set; }
        public byte[] RandSeed { get; set; }
        public long TimeDiff { get; set; }
        public LogInSigInfo SigInfo { get; set; }
        public BigDataSessionInfo BigDataSession { get; set; }
        public string[] SrvSsoAddresses { get; set; }
        public string[] OtherSrvAddresses { get; set; }
        //fileStorageInfo  *jce.FileStoragePushFSSvcList
        public bool PwdFlag { get; set; }
        public int LastMessageSeq { get; set; }

        //lastMessageSeq int32
        //// lastMessageSeqTmp      sync.Map
        //msgSvcCache* utils.Cache

        //lastC2CMsgTime int64

        //transCache* utils.Cache
        //lastLostMsg            string
        //    groupSysMsgCache       *GroupSystemMessages
        //    groupMsgBuilders       sync.Map
        //    onlinePushCache        *utils.Cache
        //    requestPacketRequestID int32
        //    groupSeq               int32
        //    friendSeq              int32
        //    heartbeatEnabled       bool
        //    groupDataTransSeq      int32
        //    highwayApplyUpSeq      int32
        //    eventHandlers          *eventHandlers
        //    stat                   *Statistics

        //TODO    groupListLock sync.Mutex
        private Client(Uin uin, ILogger logger)
        {
            _logger = logger;
            _ecdh = new();
            _random = new(DateTime.Now.Second);
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

            throw new LoginException("Unknown exception!");
        }

        public void Connect()
        {
            var ip = Servers[CurrentServerIndex].ToString();
            _logger.LogInformation("Connect to server: {0}",ip);
        }
    }
}
