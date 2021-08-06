using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

using BotReborn.Model;
using BotReborn.Model.Entities;
using BotReborn.Model.Group;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace BotReborn
{
    public partial class OicqClient
    {
        public Uin Uin { get; set; }
        public byte[] PasswordMd5 { get; set; }
        public bool AllowSlider { get; set; } = true;
        public ILogger<OicqClient> Logger { get; set; } = new NullLogger<OicqClient>();
        public Statistics Statistics { get; set; }

        public string NickName { get; set; }
        public ushort Age { get; set; }
        public ushort Gender { get; set; }
        public List<Friend> Friends { get; set; }
        public List<GroupInfo> Groups { get; set; }
        public List<Device> Devices { get; set; }
        public bool IsOnline { get; set; }
        //public QiDianAccountInfo QiDianAccountInfo { get; set; }
        //public bool NetLooping { get; set; }

        public byte[] OutGoingPacketSessionId { get; set; } = new byte[] { 0x02, 0xB0, 0x5B, 0x8B };
        public byte[] RandomKey { get; set; } = new byte[16];
        public TcpClient TcpClient { get; set; } = new TcpClient();
        public DateTimeOffset ConnectTime { get; set; }
        public Hashtable Waiters { get; set; }
        public List<IPEndPoint> Servers { get; set; }
        public int CurrentServerIndex { get; set; }
        public int RetryTimes { get; set; }
        public ClientProtocol Version { get; set; } = ClientProtocol.Ipad;

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
        public LogInSigInfo SigInfo { get; set; } = new LogInSigInfo();
        public BigDataSessionInfo BigDataSession { get; set; }
        public string[] SrvSsoAddresses { get; set; }
        public string[] OtherSrvAddresses { get; set; }
        //fileStorageInfo  *jce.FileStoragePushFSSvcList
        public bool PwdFlag { get; set; }
        public int LastMessageSeq { get; set; }
        public DeviceInfo DeviceInfo => DeviceInfo.Current;
        //lastMessageSeq int32
        //// lastMessageSeqTmp      sync.Map
        //msgSvcCache* utils.Cache

        //lastC2CMsgTime int64

        //transCache* utils.Cache
        //lastLostMsg            string
        //    groupSysMsgCache       *GroupSystemMessages
        //    groupMsgBuilders       sync.Map
        //    onlinePushCache        *utils.Cache

        //    eventHandlers          *eventHandlers
        //    stat                   *Statistics

        //TODO    groupListLock sync.Mutex
    }
}
