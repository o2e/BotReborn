using System;
using System.Collections.Generic;

namespace BotReborn.Jce
{
    public interface IJceStruct
    {
        void ReadFrom(JceStream r);
    }
    public class JceStructs
    {
        public class RequestPacket : IJceStruct
        {
            [JceId(1)] public short IVersion;
            [JceId(2)] public byte CPacketType;
            [JceId(3)] public int IMessageType;
            [JceId(4)] public int IRequestId;
            [JceId(5)] public string SServantName;
            [JceId(6)] public string SFuncName;
            [JceId(7)] public byte[] SBuffer;
            [JceId(8)] public int ITimeout;
            [JceId(9)] public Dictionary<string, string> Context;
            [JceId(10)] public Dictionary<string, string> Status;

            public void ReadFrom(JceStream s)
            {
                Context = new Dictionary<string, string>();
                Status = new Dictionary<string, string>();
                IVersion = s.ReadInt16(1);
                CPacketType = (byte)s.ReadByte(2);
                IMessageType = s.ReadInt32(3);
                IRequestId = s.ReadInt32(4);
                SServantName = s.ReadString(5);
                SFuncName = s.ReadString(6);
                SBuffer = (byte[])s.ReadSlice<byte>( 7);
                ITimeout = s.ReadInt32(8);
                s.ReadMapF(9, (k, v) => { Context[(string)k] = (string)v; });
                s.ReadMapF(10, (k, v) => { Status[(string)k] = (string)v; });
            }
        }

        public class RequestDataVersion3 : IJceStruct
        {
            [JceId(0)] public Dictionary<string, byte[]> Map;
            public void ReadFrom(JceStream s)
            {
                Map = new Dictionary<string, byte[]>();
                s.ReadMapF(0, (k, v) => { Map[(string)k] = (byte[])v; });
            }
        }

        public class RequestDataVersion2 : IJceStruct
        {
            [JceId(0)] public Dictionary<string, Dictionary<string, byte[]>> Map;

            public void ReadFrom(JceStream r) => throw new NotImplementedException();
        }

        public class SsoServerInfo
        {
            [JceId(1)] public string Server;
            [JceId(2)] public int Port;
            [JceId(8)] public string Location;
        }

        public class FileStoragePushFSSvcList
        {
            [JceId(0)] public FileStorageServerInfo[] UploadList;
            [JceId(1)] public FileStorageServerInfo[] PicDownloadList;
            [JceId(2)] public FileStorageServerInfo[] GPicDownloadList;
            [JceId(3)] public FileStorageServerInfo[] QZoneProxyServiceList;
            [JceId(4)] public FileStorageServerInfo[] UrlEncodeServiceList;
            [JceId(5)] public BigDataChannel BigDataChannel;
            [JceId(6)] public FileStorageServerInfo VipEmotionList;
            [JceId(7)] public FileStorageServerInfo[] C2CPicDownList;
            // FmtIPInfo             *FmtIPInfo `jceId:"8"`
            // DomainIPChannel       *DomainIPChannel `jceId:"9"`
            [JceId(10)] public byte[] PttList;
        }

        public class FileStorageServerInfo
        {
            [JceId(1)] public string Server;
            [JceId(2)] public int Port;
        }

        public class BigDataChannel
        {
            [JceId(0)] public BigDataIPList[] IPLists;
            [JceId(1)] public byte[] SigSession;
            [JceId(2)] public byte[] KeySession;
            [JceId(3)] public long SigUin;
            [JceId(4)] public int ConnectFlag;
            [JceId(5)] public byte[] PbBuf;
        }

        public class BigDataIPList
        {
            [JceId(0)] public long ServiceType;
            [JceId(1)] public BigDataIPInfo[] IPList;
            [JceId(3)] public long FragmentSize;
        }

        public class BigDataIPInfo
        {
            [JceId(0)] public long Type;
            [JceId(1)] public string Server;
            [JceId(2)] public string Port;
        }

        public class SvcReqRegister : IJceStruct
        {

            [JceId(0)] public long Uin;
            [JceId(1)] public long Bid;
            [JceId(2)] public byte ConnType;
            [JceId(3)] public string Other;
            [JceId(4)] public int Status;
            [JceId(5)] public byte OnlinePush;
            [JceId(6)] public byte IsOnline;
            [JceId(7)] public byte IsShowOnline;
            [JceId(8)] public byte KickPC;
            [JceId(9)] public byte KickWeak;
            [JceId(10)] public long Timestamp;
            [JceId(11)] public long IOSVersion;
            [JceId(12)] public byte NetType;
            [JceId(13)] public string BuildVer;
            [JceId(14)] public byte RegType;
            [JceId(15)] public byte[] DevParam;
            [JceId(16)] public byte[] Guid;
            [JceId(17)] public int LocaleId;
            [JceId(18)] public byte SilentPush;
            [JceId(19)] public string DevName;
            [JceId(20)] public string DevType;
            [JceId(21)] public string OSVer;
            [JceId(22)] public byte OpenPush;
            [JceId(23)] public long LargeSeq;
            [JceId(24)] public long LastWatchStartTime;
            [JceId(26)] public long OldSSOIp;
            [JceId(27)] public long NewSSOIp;
            [JceId(28)] public string ChannelNo;
            [JceId(29)] public long CPID;
            [JceId(30)] public string VendorName;
            [JceId(31)] public string VendorOSName;
            [JceId(32)] public string IOSIdfa;
            [JceId(33)] public byte[] B769;
            [JceId(34)] public byte IsSetStatus;
            [JceId(35)] public byte[] ServerBuf;
            [JceId(36)] public byte SetMute;
            [JceId(38)] public long ExtOnlineStatus;
            [JceId(39)] public int BatteryStatus;

            public void ReadFrom(JceStream r) => throw new NotImplementedException();
        }

        public class SvcRespRegister
        {
            [JceId(0)] public long Uin;
            [JceId(1)] public long Bid;
            [JceId(2)] public byte ReplyCode;
            [JceId(3)] public string Result;
            [JceId(4)] public long ServerTime;
            [JceId(5)] public byte LogQQ;
            [JceId(6)] public byte NeedKik;
            [JceId(7)] public byte UpdateFlag;
            [JceId(8)] public long Timestamp;
            [JceId(9)] public byte CrashFlag;
            [JceId(10)] public string ClientIp;
            [JceId(11)] public int ClientPort;
            [JceId(12)] public int HelloInterval;
            [JceId(13)] public int LargeSeq;
            [JceId(14)] public byte LargeSeqUpdate;
            [JceId(15)] public byte[] D769RspBody;
            [JceId(16)] public int Status;
            [JceId(17)] public long ExtOnlineStatus;
            [JceId(18)] public long ClientBatteryGetInterval;
            [JceId(19)] public long ClientAutoStatusInterval;
        }

        public class SvcReqRegisterNew : IJceStruct
        {
            [JceId(0)] public long RequestOptional;
            [JceId(1)] public IJceStruct C2CMsg; // SvcReqGetMsgV2
            [JceId(2)] public IJceStruct GroupMsg; // SvcReqPullGroupMsgSeq
            [JceId(14)] public byte DisGroupMsgFilter;
            [JceId(15)] public byte GroupMask;
            [JceId(16)] public long EndSeq;
            [JceId(20)] public byte[] O769Body;

            public void ReadFrom(JceStream r) => throw new NotImplementedException();
        }

        public class SvcReqGetMsgV2 : IJceStruct
        {
            [JceId(0)] public long Uin;
            [JceId(1)] public int DateTime;
            [JceId(4)] public byte RecivePic;
            [JceId(6)] public short Ability;
            [JceId(9)] public byte Channel;
            [JceId(16)] public byte Inst;
            [JceId(17)] public byte ChannelEx;
            [JceId(18)] public byte[] SyncCookie;
            [JceId(19)] public int SyncFlag;
            [JceId(20)] public byte RambleFlag;
            [JceId(26)] public long GeneralAbi;
            [JceId(27)] public byte[] PubAccountCookie;

            public void ReadFrom(JceStream r) => throw new NotImplementedException();
        }

        public class SvcReqPullGroupMsgSeq : IJceStruct
        {
            [JceId(0)] public IJceStruct[] GroupInfo; // PullGroupSeqParam
            [JceId(1)] public byte VerifyType;
            [JceId(2)] public int Filter;

            public void ReadFrom(JceStream r) => throw new NotImplementedException();
        }

        public class PullGroupSeqParam : IJceStruct
        {
            [JceId(0)] public long GroupCode;
            [JceId(1)] public long LastSeqId;

            public void ReadFrom(JceStream r) => throw new NotImplementedException();
        }

        public class SvcRespParam
        {
            [JceId(0)] public int PCStat;
            [JceId(1)] public int IsSupportC2CRoamMsg;
            [JceId(2)] public int IsSupportDataLine;
            [JceId(3)] public int IsSupportPrintable;
            [JceId(4)] public int IsSupportViewPCFile;
            [JceId(5)] public int PcVersion;
            [JceId(6)] public long RoamFlag;
            [JceId(7)] public OnlineInfo[] OnlineInfos;
            [JceId(8)] public int PCClientType;
        }

        public class RequestPushNotify
        {
            [JceId(0)] public long Uin;
            [JceId(1)] public byte Type;
            [JceId(2)] public string Service;
            [JceId(3)] public string Cmd;
            [JceId(4)] public byte[] NotifyCookie;
            [JceId(5)] public int MsgType;
            [JceId(6)] public int UserActive;
            [JceId(7)] public int GeneralFlag;
            [JceId(8)] public long BindedUin;
        }

        public class OnlineInfo
        {
            [JceId(0)] public int InstanceId;
            [JceId(1)] public int ClientType;
            [JceId(2)] public int OnlineStatus;
            [JceId(3)] public int PlatformId;
            [JceId(4)] public string SubPlatform;
            [JceId(5)] public long UClientType;
        }

        public class SvcReqMSFLoginNotify
        {
            [JceId(0)] public long AppId;
            [JceId(1)] public byte Status;
            [JceId(2)] public byte Tablet;
            [JceId(3)] public long Platform;
            [JceId(4)] public string Title;
            [JceId(5)] public string Info;
            [JceId(6)] public long ProductType;
            [JceId(7)] public long ClientType;
            [JceId(8)] public InstanceInfo[] InstanceList;
        }

        public class InstanceInfo
        {
            [JceId(0)] public int AppId;
            [JceId(1)] public byte Tablet;
            [JceId(2)] public long Platform;
            [JceId(3)] public long ProductType;
            [JceId(4)] public long ClientType;
        }

        public class PushMessageInfo
        {
            [JceId(0)] public long FromUin;
            [JceId(1)] public long MsgTime;
            [JceId(2)] public short MsgType;
            [JceId(3)] public short MsgSeq;
            [JceId(4)] public string Msg;
            [JceId(5)] public int RealMsgTime;
            [JceId(6)] public byte[] VMsg;
            [JceId(7)] public long AppShareID;
            [JceId(8)] public byte[] MsgCookies;
            [JceId(9)] public byte[] AppShareCookie;
            [JceId(10)] public long MsgUid;
            [JceId(11)] public long LastChangeTime;
            [JceId(14)] public long FromInstId;
            [JceId(15)] public byte[] RemarkOfSender;
            [JceId(16)] public string FromMobile;
            [JceId(17)] public string FromName;
        }

        public class SvcRespPushMsg : IJceStruct
        {
            [JceId(0)] public long Uin;
            [JceId(1)] public IJceStruct[] DelInfos;
            [JceId(2)] public int Svrip;
            [JceId(3)] public byte[] PushToken;
            [JceId(4)] public int ServiceType;

            public void ReadFrom(JceStream r) => throw new NotImplementedException();
        }

        public class SvcReqGetDevLoginInfo : IJceStruct
        {
            [JceId(0)] public byte[] Guid;
            [JceId(1)] public string AppName;
            [JceId(2)] public long LoginType;
            [JceId(3)] public long Timestamp;
            [JceId(4)] public long NextItemIndex;
            [JceId(5)] public long RequireMax;
            [JceId(6)] public long GetDevListType; // 1: getLoginDevList 2: getRecentLoginDevList 4: getAuthLoginDevList

            public void ReadFrom(JceStream r) => throw new NotImplementedException();
        }

        public class SvcDevLoginInfo
        {
            public long AppId;
            public byte[] Guid;
            public long LoginTime;
            public long LoginPlatform;
            public string LoginLocation;
            public string DeviceName;
            public string DeviceTypeInfo;
            public long TerType;
            public long ProductType;
            public long CanBeKicked;
        }

        public class DelMsgInfo : IJceStruct
        {
            [JceId(0)] public long FromUin;
            [JceId(1)] public long MsgTime;
            [JceId(2)] public short MsgSeq;
            [JceId(3)] public byte[] MsgCookies;
            [JceId(4)] public short Cmd;
            [JceId(5)] public long MsgType;
            [JceId(6)] public long AppId;
            [JceId(7)] public long SendTime;
            [JceId(8)] public int SsoSeq;
            [JceId(9)] public int SsoIp;
            [JceId(10)] public int ClientIp;

            public void ReadFrom(JceStream r) => throw new NotImplementedException();
        }

        public class FriendListRequest : IJceStruct
        {
            [JceId(0)] public int Reqtype;
            [JceId(1)] public byte IfReflush;
            [JceId(2)] public long Uin;
            [JceId(3)] public short StartIndex;
            [JceId(4)] public short FriendCount;
            [JceId(5)] public byte GroupId;
            [JceId(6)] public byte IfGetGroupInfo;
            [JceId(7)] public byte GroupStartIndex;
            [JceId(8)] public byte GroupCount;
            [JceId(9)] public byte IfGetMSFGroup;
            [JceId(10)] public byte IfShowTermType;
            [JceId(11)] public long Version;
            [JceId(12)] public long[] UinList;
            [JceId(13)] public int AppType;
            [JceId(14)] public byte IfGetDOVId;
            [JceId(15)] public byte IfGetBothFlag;
            [JceId(16)] public byte[] D50;
            [JceId(17)] public byte[] D6B;
            [JceId(18)] public long[] SnsTypeList;

            public void ReadFrom(JceStream r) => throw new NotImplementedException();
        }

        public class FriendInfo
        {
            [JceId(0)] public long FriendUin;
            [JceId(1)] public byte GroupId;
            [JceId(2)] public short FaceId;
            [JceId(3)] public string Remark;
            [JceId(4)] public byte QQType;
            [JceId(5)] public byte Status;
            [JceId(6)] public byte MemberLevel;
            [JceId(7)] public byte IsMqqOnLine;
            [JceId(8)] public byte QQOnlineState;
            [JceId(9)] public byte IsIphoneOnline;
            [JceId(10)] public byte DetailStatusFlag;
            [JceId(11)] public byte QQOnlineStateV2;
            [JceId(12)] public string ShowName;
            [JceId(13)] public byte IsRemark;
            [JceId(14)] public string Nick;
            [JceId(15)] public byte SpecialFlag;
            [JceId(16)] public byte[] IMGroupID;
            [JceId(17)] public byte[] MSFGroupID;
            [JceId(18)] public int TermType;
            [JceId(20)] public byte Network;
            [JceId(21)] public byte[] Ring;
            [JceId(22)] public long AbiFlag;
            [JceId(23)] public long FaceAddonId;
            [JceId(24)] public int NetworkType;
            [JceId(25)] public long VipFont;
            [JceId(26)] public int IconType;
            [JceId(27)] public string TermDesc;
            [JceId(28)] public long ColorRing;
            [JceId(29)] public byte ApolloFlag;
            [JceId(30)] public long ApolloTimestamp;
            [JceId(31)] public byte Sex;
            [JceId(32)] public long FounderFont;
            [JceId(33)] public string EimId;
            [JceId(34)] public string EimMobile;
            [JceId(35)] public byte OlympicTorch;
            [JceId(36)] public long ApolloSignTime;
            [JceId(37)] public long LaviUin;
            [JceId(38)] public long TagUpdateTime;
            [JceId(39)] public long GameLastLoginTime;
            [JceId(40)] public long GameAppId;
            [JceId(41)] public byte[] CardID;
            [JceId(42)] public long BitSet;
            [JceId(43)] public byte KingOfGloryFlag;
            [JceId(44)] public long KingOfGloryRank;
            [JceId(45)] public string MasterUin;
            [JceId(46)] public long LastMedalUpdateTime;
            [JceId(47)] public long FaceStoreId;
            [JceId(48)] public long FontEffect;
            [JceId(49)] public string DOVId;
            [JceId(50)] public long BothFlag;
            [JceId(51)] public byte CentiShow3DFlag;
            [JceId(52)] public byte[] IntimateInfo;
            [JceId(53)] public byte ShowNameplate;
            [JceId(54)] public byte NewLoverDiamondFlag;
            [JceId(55)] public byte[] ExtSnsFrdData;
            [JceId(56)] public byte[] MutualMarkData;
        }

        public class TroopListRequest : IJceStruct
        {
            [JceId(0)] public long Uin;
            [JceId(1)] public byte GetMSFMsgFlag;
            [JceId(2)] public byte[] Cookies;
            [JceId(3)] public long[] GroupInfo;
            [JceId(4)] public byte GroupFlagExt;
            [JceId(5)] public int Version;
            [JceId(6)] public long CompanyId;
            [JceId(7)] public long VersionNum;
            [JceId(8)] public byte GetLongGroupName;

            public void ReadFrom(JceStream r) => throw new NotImplementedException();
        }

        public class TroopNumber
        {
            [JceId(0)] public long GroupUin;
            [JceId(1)] public long GroupCode;
            [JceId(2)] public byte Flag;
            [JceId(3)] public long GroupInfoSeq;
            [JceId(4)] public string GroupName;
            [JceId(5)] public string GroupMemo;
            [JceId(6)] public long GroupFlagExt;
            [JceId(7)] public long GroupRankSeq;
            [JceId(8)] public long CertificationType;
            [JceId(9)] public long ShutUpTimestamp;
            [JceId(10)] public long MyShutUpTimestamp;
            [JceId(11)] public long CmdUinUinFlag;
            [JceId(12)] public long AdditionalFlag;
            [JceId(13)] public long GroupTypeFlag;
            [JceId(14)] public long GroupSecType;
            [JceId(15)] public long GroupSecTypeInfo;
            [JceId(16)] public long GroupClassExt;
            [JceId(17)] public long AppPrivilegeFlag;
            [JceId(18)] public long SubscriptionUin;
            [JceId(19)] public long MemberNum;
            [JceId(20)] public long MemberNumSeq;
            [JceId(21)] public long MemberCardSeq;
            [JceId(22)] public long GroupFlagExt3;
            [JceId(23)] public long GroupOwnerUin;
            [JceId(24)] public byte IsConfGroup;
            [JceId(25)] public byte IsModifyConfGroupFace;
            [JceId(26)] public byte IsModifyConfGroupName;
            [JceId(27)] public long CmdUinJoinTime;
            [JceId(28)] public long CompanyId;
            [JceId(29)] public long MaxGroupMemberNum;
            [JceId(30)] public long CmdUinGroupMask;
            [JceId(31)] public long GuildAppId;
            [JceId(32)] public long GuildSubType;
            [JceId(33)] public long CmdUinRingtoneID;
            [JceId(34)] public long CmdUinFlagEx2;
        }

        public class TroopMemberListRequest : IJceStruct
        {
            [JceId(0)] public long Uin;
            [JceId(1)] public long GroupCode;
            [JceId(2)] public long NextUin;
            [JceId(3)] public long GroupUin;
            [JceId(4)] public long Version;
            [JceId(5)] public long ReqType;
            [JceId(6)] public long GetListAppointTime;
            [JceId(7)] public byte RichCardNameVer;

            public void ReadFrom(JceStream r) => throw new NotImplementedException();
        }

        public class TroopMemberInfo
        {
            [JceId(0)] public long MemberUin;
            [JceId(1)] public short FaceId;
            [JceId(2)] public byte Age;
            [JceId(3)] public byte Gender;
            [JceId(4)] public string Nick;
            [JceId(5)] public byte Status;
            [JceId(6)] public string ShowName;
            [JceId(8)] public string Name;
            [JceId(12)] public string Memo;
            [JceId(13)] public string AutoRemark;
            [JceId(14)] public long MemberLevel;
            [JceId(15)] public long JoinTime;
            [JceId(16)] public long LastSpeakTime;
            [JceId(17)] public long CreditLevel;
            [JceId(18)] public long Flag;
            [JceId(19)] public long FlagExt;
            [JceId(20)] public long Point;
            [JceId(21)] public byte Concerned;
            [JceId(22)] public byte Shielded;
            [JceId(23)] public string SpecialTitle;
            [JceId(24)] public long SpecialTitleExpireTime;
            [JceId(25)] public string Job;
            [JceId(26)] public byte ApolloFlag;
            [JceId(27)] public long ApolloTimestamp;
            [JceId(28)] public long GlobalGroupLevel;
            [JceId(29)] public long TitleId;
            [JceId(30)] public long ShutUpTimestap;
            [JceId(31)] public long GlobalGroupPoint;
            [JceId(33)] public byte RichCardNameVer;
            [JceId(34)] public long VipType;
            [JceId(35)] public long VipLevel;
            [JceId(36)] public long BigClubLevel;
            [JceId(37)] public long BigClubFlag;
            [JceId(38)] public long Nameplate;
            [JceId(39)] public byte[] GroupHonor;
        }

        public class ModifyGroupCardRequest : IJceStruct
        {
            [JceId(0)] public long Zero;
            [JceId(1)] public long GroupCode;
            [JceId(2)] public long NewSeq;
            [JceId(3)] public IJceStruct[] UinInfo;

            public void ReadFrom(JceStream r) => throw new NotImplementedException();
        }

        public class UinInfo : IJceStruct
        {
            [JceId(0)] public long Uin;
            [JceId(1)] public long Flag;
            [JceId(2)] public string Name;
            [JceId(3)] public byte Gender;
            [JceId(4)] public string Phone;
            [JceId(5)] public string Email;
            [JceId(6)] public string Remark;

            public void ReadFrom(JceStream r) => throw new NotImplementedException();
        }

        public class SummaryCardReq : IJceStruct
        {
            [JceId(0)] public long Uin;
            [JceId(1)] public int ComeFrom;
            [JceId(2)] public long QzoneFeedTimestamp;
            [JceId(3)] public byte IsFriend;
            [JceId(4)] public long GroupCode;
            [JceId(5)] public long GroupUin;
            // Seed               []byte`jceId:"6"`
            // SearchName         string`jceId:"7"`
            [JceId(8)] public long GetControl;
            [JceId(9)] public int AddFriendSource;
            [JceId(10)] public byte[] SecureSig;
            [JceId(14)] public byte[][] ReqServices;
            [JceId(15)] public long TinyId;
            [JceId(16)] public long LikeSource;
            [JceId(18)] public byte ReqMedalWallInfo;
            [JceId(19)] public long[] Req0x5ebFieldId;
            [JceId(20)] public byte ReqNearbyGodInfo;
            [JceId(22)] public byte ReqExtendCard;

            public void ReadFrom(JceStream r) => throw new NotImplementedException();
        }

        public class SummaryCardReqSearch : IJceStruct
        {
            [JceId(0)] public string Keyword;
            [JceId(1)] public string CountryCode;
            [JceId(2)] public int Version;
            [JceId(3)] public byte[][] ReqServices;

            public void ReadFrom(JceStream r) => throw new NotImplementedException();
        }

        public class DelFriendReq : IJceStruct
        {
            [JceId(0)] public long Uin;
            [JceId(1)] public long DelUin;
            [JceId(2)] public byte DelType;
            [JceId(3)] public int Version;

            public void ReadFrom(JceStream r) => throw new NotImplementedException();
        }


    }
}
