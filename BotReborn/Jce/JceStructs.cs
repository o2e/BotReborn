using System.Collections.Generic;

namespace BotReborn.Jce
{
    public interface IJceStruct
    {

    }
    public class JceStructs : IJceStruct
    {
        public struct RequestPacket
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
        }

        public struct RequestDataVersion3 : IJceStruct
        {
            [JceId(0)] public Dictionary<string, byte[]> Map;
        }

        public struct RequestDataVersion2 : IJceStruct
        {
            [JceId(0)] public Dictionary<string, Dictionary<string, byte[]>> Map;
        }

        public struct SsoServerInfo
        {
            [JceId(1)] public string Server;
            [JceId(2)] public int Port;
            [JceId(8)] public string Location;
        }

        public struct FileStoragePushFSSvcList
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

        public struct FileStorageServerInfo
        {
            [JceId(1)] public string Server;
            [JceId(2)] public int Port;
        }

        public struct BigDataChannel
        {
            [JceId(0)] public BigDataIPList[] IPLists;
            [JceId(1)] public byte[] SigSession;
            [JceId(2)] public byte[] KeySession;
            [JceId(3)] public long SigUin;
            [JceId(4)] public int ConnectFlag;
            [JceId(5)] public byte[] PbBuf;
        }

        public struct BigDataIPList
        {
            [JceId(0)] public long ServiceType;
            [JceId(1)] public BigDataIPInfo[] IPList;
            [JceId(3)] public long FragmentSize;
        }

        public struct BigDataIPInfo
        {
            [JceId(0)] public long Type;
            [JceId(1)] public string Server;
            [JceId(2)] public string Port;
        }

        public struct SvcReqRegister : IJceStruct
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
        }

        public struct SvcRespRegister
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

        public struct SvcReqRegisterNew : IJceStruct
        {
            [JceId(0)] public long RequestOptional;
            [JceId(1)] public IJceStruct C2CMsg; // SvcReqGetMsgV2
            [JceId(2)] public IJceStruct GroupMsg; // SvcReqPullGroupMsgSeq
            [JceId(14)] public byte DisGroupMsgFilter;
            [JceId(15)] public byte GroupMask;
            [JceId(16)] public long EndSeq;
            [JceId(20)] public byte[] O769Body;
        }

        public struct SvcReqGetMsgV2 : IJceStruct
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
        }

        public struct SvcReqPullGroupMsgSeq : IJceStruct
        {
            [JceId(0)] public IJceStruct[] GroupInfo; // PullGroupSeqParam
            [JceId(1)] public byte VerifyType;
            [JceId(2)] public int Filter;
        }

        public struct PullGroupSeqParam : IJceStruct
        {
            [JceId(0)] public long GroupCode;
            [JceId(1)] public long LastSeqId;
        }

        public struct SvcRespParam
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

        public struct RequestPushNotify
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

        public struct OnlineInfo
        {
            [JceId(0)] public int InstanceId;
            [JceId(1)] public int ClientType;
            [JceId(2)] public int OnlineStatus;
            [JceId(3)] public int PlatformId;
            [JceId(4)] public string SubPlatform;
            [JceId(5)] public long UClientType;
        }

        public struct SvcReqMSFLoginNotify
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

        public struct InstanceInfo
        {
            [JceId(0)] public int AppId;
            [JceId(1)] public byte Tablet;
            [JceId(2)] public long Platform;
            [JceId(3)] public long ProductType;
            [JceId(4)] public long ClientType;
        }

        public struct PushMessageInfo
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

        public struct SvcRespPushMsg : IJceStruct
        {
            [JceId(0)] public long Uin;
            [JceId(1)] public IJceStruct[] DelInfos;
            [JceId(2)] public int Svrip;
            [JceId(3)] public byte[] PushToken;
            [JceId(4)] public int ServiceType;
        }

        public struct SvcReqGetDevLoginInfo : IJceStruct
        {
            [JceId(0)] public byte[] Guid;
            [JceId(1)] public string AppName;
            [JceId(2)] public long LoginType;
            [JceId(3)] public long Timestamp;
            [JceId(4)] public long NextItemIndex;
            [JceId(5)] public long RequireMax;
            [JceId(6)] public long GetDevListType; // 1: getLoginDevList 2: getRecentLoginDevList 4: getAuthLoginDevList
        }

        public struct SvcDevLoginInfo
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

        public struct DelMsgInfo : IJceStruct
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
        }

        public struct FriendListRequest : IJceStruct
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
        }

        public struct FriendInfo
        {
            //todo
        }

        public struct TroopListRequest : IJceStruct
        {
            //todo
        }

        public struct TroopNumber
        {
            //todo
        }

        public struct TroopMemberListRequest : IJceStruct
        {
            //todo
        }

        public struct TroopMemberInfo
        {
            //todo
        }

        public struct ModifyGroupCardRequest : IJceStruct
        {
            [JceId(0)] public long Zero;
            [JceId(1)] public long GroupCode;
            [JceId(2)] public long NewSeq;
            [JceId(3)] public IJceStruct[] UinInfo;
        }

        public struct UinInfo : IJceStruct
        {
            [JceId(0)] public long Uin;
            [JceId(1)] public long Flag;
            [JceId(2)] public string Name;
            [JceId(3)] public byte Gender;
            [JceId(4)] public string Phone;
            [JceId(5)] public string Email;
            [JceId(6)] public string Remark;
        }

        public struct SummaryCardReq : IJceStruct
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
        }

        public struct SummaryCardReqSearch : IJceStruct
        {
            [JceId(0)] public string Keyword;
            [JceId(1)] public string CountryCode;
            [JceId(2)] public int Version;
            [JceId(3)] public byte[][] ReqServices;
        }

        public struct DelFriendReq : IJceStruct
        {
            [JceId(0)] public long Uin;
            [JceId(1)] public long DelUin;
            [JceId(2)] public byte DelType;
            [JceId(3)] public int Version;
        }


    }
}
