﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

using BotReborn.Model;
using BotReborn.Model.Group;

using Version = System.Version;

namespace BotReborn
{
    public partial class Client
    {
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

        public byte[] OutGoingPacketSessionId { get; set; }
        public byte[] RandomKey { get; set; }
        public TcpListener TcpListener { get; set; }
        public DateTimeOffset ConnectTime { get; set; }
        public Hashtable Waiters { get; set; }
        public List<IPEndPoint> Servers { get; set; }
        public int CurrentServerIndex { get; set; }
        public int RetryTimes { get; set; }
        public bool CanRetry
        {
            get => RetryTimes <= Servers.Count;
        }
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

        //    eventHandlers          *eventHandlers
        //    stat                   *Statistics

        //TODO    groupListLock sync.Mutex
    }
}
