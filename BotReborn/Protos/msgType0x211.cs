






using ProtoBuf;

import kotlinx.serialization.protobuf.ProtoIntegerType

import kotlinx.serialization.protobuf.ProtoType




[ProtoContract] class SubMsgType0x3  {
    [ProtoContract] class FailNotify{[ProtoMember(1)] public     sessionid  {get;set;} int = 0;
        [ProtoMember(2)] public     retCode  {get;set;} int = 0;
        [ProtoMember(3)] public     reason  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class MsgBody{[ProtoMember(1)] public     msgProgressNotify  {get;set;} ProgressNotify? = null;
        [ProtoMember(2)] public     msgFailNotify  {get;set;} FailNotify? = null;
    }

    [ProtoContract] class ProgressNotify{[ProtoMember(1)] public     sessionid  {get;set;} int = 0;
        [ProtoMember(2)] public     uuid  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(3)] public     progress  {get;set;} int = 0;
        [ProtoMember(4)] public     averageSpeed  {get;set;} int = 0;
    }
}


[ProtoContract] class SubMsgType0x4  {
    [ProtoContract] class MsgBody{[ProtoMember(1)] public     msgNotOnlineFile  {get;set;} ImMsgBody.NotOnlineFile? = null;
        [ProtoMember(2)] public     msgTime  {get;set;} int = 0;
        [ProtoMember(3)] public     onlineFileForPolyToOffline  {get;set;} int = 0;
        [ProtoMember(4)] public     fileImageInfo  {get;set;} HummerResv21.FileImgInfo? = null;
        [ProtoMember(5)] public     msgXtfSenderInfo  {get;set;} HummerResv21.XtfSenderInfo? = null;
        [ProtoMember(6)] public     resvAttr  {get;set;} HummerResv21.ResvAttr? = null;
    }
}


[ProtoContract] class SubMsgType0x5  {
    [ProtoContract] class MsgBody{[ProtoMember(1)] public     sessionid  {get;set;} int = 0;
    }
}


[ProtoContract] class SubMsgType0x7  {
    [ProtoContract] class MsgBody{[ProtoMember(1)] public     subCmd  {get;set;} int = 0;
        [ProtoMember(2)] public     msgHeader  {get;set;} MsgHeader? = null;
        [ProtoMember(3)] public     msgSubcmd0x1FtnNotify  {get;set;} List<FTNNotify> = new();
        [ProtoMember(4)] public     msgSubcmd0x2NfcNotify  {get;set;} List<NFCNotify> = new();
        [ProtoMember(5)] public     msgSubcmd0x3Filecontrol  {get;set;} List<FileControl> = new();
        [ProtoMember(6)] public     msgSubcmd0x4Generic  {get;set;} GenericSubCmd? = null;
        [ProtoMember(7)] public     msgSubcmd0x5MoloNotify  {get;set;} List<MoloNotify> = new();
        [ProtoMember(8)] public     msgSubcmd0x8RnfcNotify  {get;set;} List<RNFCNotify> = new();
        [ProtoMember(9)] public     msgSubcmd0x9FtnThumbNotify  {get;set;} List<FTNNotify> = new();
        [ProtoMember(10)] public     msgSubcmd0xaNfcThumbNotify  {get;set;} List<NFCNotify> = new();
        [ProtoMember(11)] public     msgSubcmd0xbMpfileNotify  {get;set;} List<MpFileNotify> = new();
        [ProtoMember(12)] public     msgSubcmd0xcProgressReq  {get;set;} ProgressReq? = null;
        [ProtoMember(13)] public     msgSubcmd0xdProgressRsp  {get;set;} ProgressRsp? = null;
    } {
        [ProtoContract]
        internal class ActionInfo(
            [ProtoMember(1)] public     serviceName  {get;set;} string = "";
            [ProtoMember(2)] public     buf  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class FileControl(
            [ProtoMember(1)] public     sessionid  {get;set;} long = 0L;
            [ProtoMember(2)] public     operate  {get;set;} int = 0;
            [ProtoMember(3)] public     seq  {get;set;} int = 0;
            [ProtoMember(4)] public     code  {get;set;} int = 0;
            [ProtoMember(5)] public     msg  {get;set;} string = "";
            [ProtoMember(6)] public     groupId  {get;set;} int = 0;
            [ProtoMember(7)] public     groupCurindex  {get;set;} int = 0;
            [ProtoMember(8)] public     batchID  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class FTNNotify(
            [ProtoMember(1)] public     sessionid  {get;set;} long = 0L;
            [ProtoMember(2)] public     fileName  {get;set;} string = "";
            [ProtoMember(3)] public     fileIndex  {get;set;} string = "";
            [ProtoMember(4)] public     fileMd5  {get;set;} byte[] = Array.Empty<byte>();
            [ProtoMember(5)] public     fileKey  {get;set;} string = "";
            [ProtoMember(6)] public     fileLen  {get;set;} long = 0L;
            [ProtoMember(7)] public     originfileMd5  {get;set;} byte[] = Array.Empty<byte>();
            [ProtoMember(8)] public     originfiletype  {get;set;} int = 0;
            [ProtoMember(9)] public     groupId  {get;set;} int = 0;
            [ProtoMember(10)] public     groupSize  {get;set;} int = 0;
            [ProtoMember(11)] public     groupCurindex  {get;set;} int = 0;
            [ProtoMember(20)] public     msgActionInfo  {get;set;} ActionInfo? = null;
            [ProtoMember(21)] public     batchID  {get;set;} int = 0;
            [ProtoMember(22)] public     groupflag  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class MsgItem(
            [ProtoMember(1)] public     type  {get;set;} int = 0;
            [ProtoMember(2)] public     text  {get;set;} string = "";
        }

        [ProtoContract]
        internal class QQDataTextMsg(
            [ProtoMember(1)] public     msgItems  {get;set;} List<MsgItem> = new();
        }

        [ProtoContract]
        internal class WifiPhotoNoPush(
            [ProtoMember(1)] public     json  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class WifiPhotoWithPush(
            [ProtoMember(1)] public     json  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class GenericSubCmd(
            [ProtoMember(1)] public     sessionid  {get;set;} long = 0L;
            [ProtoMember(2)] public     size  {get;set;} int = 0;
            [ProtoMember(3)] public     index  {get;set;} int = 0;
            [ProtoMember(4)] public     type  {get;set;} int = 0;
            [ProtoMember(5)] public     buf  {get;set;} byte[] = Array.Empty<byte>();
            [ProtoMember(6)] public     supportAuth  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class MoloNotify(
            [ProtoMember(1)] public     buf  {get;set;} byte[] = Array.Empty<byte>();
            [ProtoMember(2)] public     groupId  {get;set;} int = 0;
            [ProtoMember(3)] public     groupSize  {get;set;} int = 0;
            [ProtoMember(4)] public     groupCurindex  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class MpFileNotify(
            [ProtoMember(1)] public     sessionid  {get;set;} long = 0L;
            [ProtoMember(2)] public     operate  {get;set;} int = 0;
            @ProtoType(ProtoIntegerType.FIXED) [ProtoMember(3)] public     fixed32Ip  {get;set;} int = 0;
            [ProtoMember(4)] public     port  {get;set;} int = 0;
            [ProtoMember(5)] public     type  {get;set;} int = 0;
            [ProtoMember(6)] public     power  {get;set;} int = 0;
            [ProtoMember(7)] public     json  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class MsgHeader(
            [ProtoMember(1)] public     srcAppId  {get;set;} int = 0;
            [ProtoMember(2)] public     srcInstId  {get;set;} int = 0;
            [ProtoMember(3)] public     dstAppId  {get;set;} int = 0;
            [ProtoMember(4)] public     dstInstId  {get;set;} int = 0;
            [ProtoMember(5)] public     dstUin  {get;set;} long = 0L;
            [ProtoMember(6)] public     srcUin  {get;set;} long = 0L;
            [ProtoMember(7)] public     srcUinType  {get;set;} int = 0;
            [ProtoMember(8)] public     dstUinType  {get;set;} int = 0;
            [ProtoMember(9)] public     srcTerType  {get;set;} int = 0;
            [ProtoMember(10)] public     dstTerType  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class NFCNotify(
            [ProtoMember(1)] public     sessionid  {get;set;} long = 0L;
            [ProtoMember(2)] public     fileName  {get;set;} string = "";
            [ProtoMember(3)] public     fileMd5  {get;set;} byte[] = Array.Empty<byte>();
            @ProtoType(ProtoIntegerType.FIXED) [ProtoMember(4)] public     fixed32Ip  {get;set;} int = 0;
            [ProtoMember(5)] public     port  {get;set;} int = 0;
            [ProtoMember(6)] public     urlNotify  {get;set;} byte[] = Array.Empty<byte>();
            [ProtoMember(7)] public     tokenkey  {get;set;} byte[] = Array.Empty<byte>();
            [ProtoMember(8)] public     fileLen  {get;set;} long = 0L;
            [ProtoMember(9)] public     originfileMd5  {get;set;} byte[] = Array.Empty<byte>();
            [ProtoMember(10)] public     originfiletype  {get;set;} int = 0;
            [ProtoMember(11)] public     groupId  {get;set;} int = 0;
            [ProtoMember(12)] public     groupSize  {get;set;} int = 0;
            [ProtoMember(13)] public     groupCurindex  {get;set;} int = 0;
            [ProtoMember(20)] public     msgActionInfo  {get;set;} ActionInfo? = null;
            [ProtoMember(21)] public     batchID  {get;set;} int = 0;
            [ProtoMember(22)] public     groupflag  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class ProgressReq(
            [ProtoMember(1)] public     cmd  {get;set;} int = 0;
            [ProtoMember(2)] public     cookie  {get;set;} long = 0L;
            [ProtoMember(3)] public     infoflag  {get;set;} int = 0;
            [ProtoMember(4)] public     uint64Sessionid  {get;set;} List<Long> = new();
        }

        [ProtoContract]
        internal class ProgressInfo(
            [ProtoMember(1)] public     sessionid  {get;set;} long = 0L;
            [ProtoMember(2)] public     progress  {get;set;} long = 0L;
            [ProtoMember(3)] public     status  {get;set;} int = 0;
            [ProtoMember(4)] public     filesize  {get;set;} long = 0L;
            [ProtoMember(5)] public     filename  {get;set;} string = "";
            [ProtoMember(6)] public     time  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class ProgressRsp(
            [ProtoMember(1)] public     cmd  {get;set;} int = 0;
            [ProtoMember(2)] public     cookie  {get;set;} long = 0L;
            [ProtoMember(3)] public     packageCount  {get;set;} int = 0;
            [ProtoMember(4)] public     packageIndex  {get;set;} int = 0;
            [ProtoMember(5)] public     msgProgressinfo  {get;set;} List<ProgressInfo> = new();
        }

        [ProtoContract]
        internal class RNFCNotify(
            [ProtoMember(1)] public     sessionid  {get;set;} long = 0L;
            [ProtoMember(2)] public     token  {get;set;} byte[] = Array.Empty<byte>();
            @ProtoType(ProtoIntegerType.FIXED) [ProtoMember(3)] public     fixed32Ip  {get;set;} int = 0;
            [ProtoMember(4)] public     port  {get;set;} int = 0;
            [ProtoMember(5)] public     svrTaskId  {get;set;} long = 0L;
        }
    }
}


[ProtoContract] class C2CType0x211SubC2CType0x8  {
    [ProtoContract] class BusiReqHead{[ProtoMember(1)] public     int32Version  {get;set;} int = 0;
        [ProtoMember(2)] public     int32Seq  {get;set;} int = 0;
    }

    [ProtoContract] class BusiRespHead{[ProtoMember(1)] public     int32Version  {get;set;} int = 0;
        [ProtoMember(2)] public     int32Seq  {get;set;} int = 0;
        [ProtoMember(3)] public     int32ReplyCode  {get;set;} int = 0;
        [ProtoMember(4)] public     result  {get;set;} string = "";
    }

    [ProtoContract] class Cell{[ProtoMember(1)] public     int32Mcc  {get;set;} int = -1;
        [ProtoMember(2)] public     int32Mnc  {get;set;} int = -1;
        [ProtoMember(3)] public     int32Lac  {get;set;} int = -1;
        [ProtoMember(4)] public     int32Cellid  {get;set;} int = -1;
        [ProtoMember(5)] public     int32Rssi  {get;set;} int = 0;
    }

    [ProtoContract] class ConnType{[ProtoMember(1)] public     type  {get;set;} int /* enum */ = 1;
        [ProtoMember(2)] public     desription  {get;set;} string = "";
    }

    [ProtoContract] class GPS{[ProtoMember(1)] public     int32Lat  {get;set;} int = 900000000;
        [ProtoMember(2)] public     int32Lon  {get;set;} int = 900000000;
        [ProtoMember(3)] public     int32Alt  {get;set;} int = -10000000;
        [ProtoMember(4)] public     eType  {get;set;} int /* enum */ = 0;
    }

    [ProtoContract] class IPAddrInfo{[ProtoMember(1)] public     int32Ip  {get;set;} int = 0;
        [ProtoMember(2)] public     int32Mask  {get;set;} int = 0;
        [ProtoMember(3)] public     int32Gateway  {get;set;} int = 0;
        [ProtoMember(4)] public     int32Port  {get;set;} int = 0;
    }

    [ProtoContract] class JudgeResult{[ProtoMember(1)] public     type  {get;set;} int /* enum */ = 0;
        [ProtoMember(2)] public     ssid  {get;set;} string = "";
        [ProtoMember(3)] public     tips  {get;set;} string = "";
        [ProtoMember(4)] public     int32IdleTimeout  {get;set;} int = 0;
        [ProtoMember(5)] public     idleWaiting  {get;set;} int = 0;
        [ProtoMember(6)] public     forceWifi  {get;set;} int = 0;
        [ProtoMember(7)] public     flagsWifipsw  {get;set;} int = 0;
        [ProtoMember(8)] public     flagsNetcheck  {get;set;} int = 0;
    }

    [ProtoContract] class LBSInfo{[ProtoMember(1)] public     msgGps  {get;set;} GPS? = null;
        [ProtoMember(2)] public     msgWifis  {get;set;} List<Wifi> = new();
        [ProtoMember(3)] public     msgCells  {get;set;} List<Cell> = new();
    }

    [ProtoContract] class MsgBody{[ProtoMember(1)] public     msgType  {get;set;} int /* enum */ = 1;
        [ProtoMember(2)] public     msgCcNotifylist  {get;set;} NotifyList? = null;
        [ProtoMember(3)] public     msgCcnfAbiQuery  {get;set;} NearFieldAbiQuery? = null;
        [ProtoMember(4)] public     msgCcPushJudgeResult  {get;set;} PushJudgeResult? = null;
        [ProtoMember(5)] public     msgCcnfFilesendReq  {get;set;} NearFieldFileSendReq? = null;
        [ProtoMember(6)] public     msgCcnfFilestateSync  {get;set;} NearFieldFileStateSync? = null;
    }

    [ProtoContract] class NearFieldAbiQuery{[ProtoMember(1)] public     toUin  {get;set;} long = 0L;
        [ProtoMember(2)] public     fromUin  {get;set;} long = 0L;
        [ProtoMember(3)] public     boolNeedTips  {get;set;} bool = false;
        [ProtoMember(4)] public     int32Timeout  {get;set;} int = 0;
        [ProtoMember(5)] public     cookie  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(6)] public     int32PeerIp  {get;set;} int = 0;
        [ProtoMember(7)] public     int32PeerPort  {get;set;} int = 0;
        [ProtoMember(8)] public     peerExtra  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class NearFieldFileInfo{[ProtoMember(1)] public     fileName  {get;set;} string = "";
        [ProtoMember(2)] public     fileSize  {get;set;} long = 0L;
        [ProtoMember(3)] public     fileMd5  {get;set;} string = "";
        [ProtoMember(4)] public     fileUrl  {get;set;} string = "";
        [ProtoMember(5)] public     fileThumbMd5  {get;set;} string = "";
        [ProtoMember(6)] public     fileThumbUrl  {get;set;} string = "";
        [ProtoMember(7)] public     sessionId  {get;set;} long = 0L;
        [ProtoMember(8)] public     int32Timeout  {get;set;} int = 0;
        [ProtoMember(9)] public     groupId  {get;set;} long = 0L;
    }

    [ProtoContract] class NearFieldFileSendReq{[ProtoMember(1)] public     toUin  {get;set;} long = 0L;
        [ProtoMember(2)] public     msgFileList  {get;set;} List<NearFieldFileInfo> = new();
        [ProtoMember(3)] public     int32Ip  {get;set;} int = 0;
        [ProtoMember(4)] public     int32UdpPort  {get;set;} int = 0;
        [ProtoMember(5)] public     ssid  {get;set;} string = "";
        [ProtoMember(6)] public     int32ConnWifiapTimeout  {get;set;} int = 0;
        [ProtoMember(7)] public     forceWifi  {get;set;} int = 0;
        [ProtoMember(8)] public     wifipsw  {get;set;} string = "";
    }

    [ProtoContract] class NearFieldFileStateSync{[ProtoMember(1)] public     eType  {get;set;} int /* enum */ = 1;
        [ProtoMember(2)] public     sessionId  {get;set;} long = 0L;
        [ProtoMember(3)] public     fromUin  {get;set;} long = 0L;
        [ProtoMember(4)] public     int32ErrorCode  {get;set;} int = 0;
    }

    [ProtoContract] class NearfieldInfo{[ProtoMember(1)] public     msgLbsInfo  {get;set;} LBSInfo? = null;
        [ProtoMember(2)] public     msgConnType  {get;set;} ConnType? = null;
        [ProtoMember(3)] public     msgIpInfo  {get;set;} IPAddrInfo? = null;
        [ProtoMember(4)] public     msgWifiDetail  {get;set;} WifiDetailInfo? = null;
        [ProtoMember(5)] public     msgWifiAbi  {get;set;} WifiAbility? = null;
        [ProtoMember(6)] public     extra  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class NotifyList{[ProtoMember(1)] public     notifyType  {get;set;} int /* enum */ = 0;
        [ProtoMember(2)] public     msgUpdateList  {get;set;} List<UpdateInfo> = new();
        [ProtoMember(3)] public     sessionId  {get;set;} int = 0;
    }

    [ProtoContract] class PushJudgeResult{[ProtoMember(1)] public     msgHead  {get;set;} BusiRespHead? = null;
        [ProtoMember(2)] public     toUin  {get;set;} long = 0L;
        [ProtoMember(3)] public     msgResult  {get;set;} JudgeResult? = null;
        [ProtoMember(4)] public     int32PeerIp  {get;set;} int = 0;
        [ProtoMember(5)] public     int32PeerPort  {get;set;} int = 0;
        [ProtoMember(6)] public     peerExtra  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class ReqAIOJudge{[ProtoMember(1)] public     msgHead  {get;set;} BusiReqHead? = null;
        [ProtoMember(2)] public     toUin  {get;set;} long = 0L;
        [ProtoMember(3)] public     msgNearfieldInfo  {get;set;} NearfieldInfo? = null;
    }

    [ProtoContract] class ReqExit{[ProtoMember(1)] public     msgHead  {get;set;} BusiReqHead? = null;
        [ProtoMember(2)] public     sessionId  {get;set;} int = 0;
        [ProtoMember(3)] public     msgNearfieldInfo  {get;set;} NearfieldInfo? = null;
    }

    [ProtoContract] class ReqGetList{[ProtoMember(1)] public     msgHead  {get;set;} BusiReqHead? = null;
        [ProtoMember(2)] public     msgNearfieldInfo  {get;set;} NearfieldInfo? = null;
        [ProtoMember(3)] public     sessionId  {get;set;} int = 0;
        [ProtoMember(4)] public     cookie  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class ReqReportNearFieldAbi{[ProtoMember(1)] public     msgHead  {get;set;} BusiReqHead? = null;
        [ProtoMember(2)] public     fromUin  {get;set;} long = 0L;
        [ProtoMember(3)] public     msgNearfieldInfo  {get;set;} NearfieldInfo? = null;
        [ProtoMember(4)] public     cookie  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class RespAIOJudge{[ProtoMember(1)] public     msgHead  {get;set;} BusiRespHead? = null;
        [ProtoMember(2)] public     msgResult  {get;set;} JudgeResult? = null;
        [ProtoMember(3)] public     timeout  {get;set;} int = 0;
        [ProtoMember(4)] public     toUin  {get;set;} long = 0L;
        [ProtoMember(5)] public     int32PeerIp  {get;set;} int = 0;
        [ProtoMember(6)] public     int32PeerPort  {get;set;} int = 0;
        [ProtoMember(7)] public     peerExtra  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class RespExit{[ProtoMember(1)] public     msgHead  {get;set;} BusiRespHead? = null;
    }

    [ProtoContract] class RespGetList{[ProtoMember(1)] public     msgHead  {get;set;} BusiRespHead? = null;
        [ProtoMember(2)] public     msgUserList  {get;set;} List<UserProfile> = new();
        [ProtoMember(3)] public     sessionId  {get;set;} int = 0;
        [ProtoMember(4)] public     int32UpdateInterval  {get;set;} int = 0;
        [ProtoMember(5)] public     cookie  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class UpdateInfo{[ProtoMember(1)] public     type  {get;set;} int /* enum */ = 1;
        [ProtoMember(2)] public     msgUser  {get;set;} UserProfile? = null;
    }

    [ProtoContract] class UserAbility{[ProtoMember(1)] public     int32SysQlver  {get;set;} int = 0;
        [ProtoMember(2)] public     int32SysTerm  {get;set;} int = 0;
        [ProtoMember(3)] public     int32SysApp  {get;set;} int = 0;
        [ProtoMember(10)] public     int32AbsWifiHost  {get;set;} int = 0;
        [ProtoMember(11)] public     int32AbsWifiClient  {get;set;} int = 0;
        [ProtoMember(12)] public     int32AbsWifiForcedcreate  {get;set;} int = 0;
        [ProtoMember(13)] public     int32AbsWifiForcedconnect  {get;set;} int = 0;
        [ProtoMember(14)] public     int32AbsWifiPassword  {get;set;} int = 0;
        [ProtoMember(20)] public     int32AbsNetReachablecheck  {get;set;} int = 0;
        [ProtoMember(21)] public     int32AbsNetSpeedTest  {get;set;} int = 0;
        [ProtoMember(30)] public     int32AbsUiPromptOnclick  {get;set;} int = 0;
        [ProtoMember(31)] public     int32AbsUiPromptPassive  {get;set;} int = 0;
    }

    [ProtoContract] class UserExtraInfo{[ProtoMember(1)] public     ability  {get;set;} UserAbility? = null;
    }

    [ProtoContract] class UserProfile{[ProtoMember(1)] public     uin  {get;set;} long = 0L;
        [ProtoMember(2)] public     int32FaceId  {get;set;} int = 0;
        [ProtoMember(3)] public     int32Sex  {get;set;} int = 0;
        [ProtoMember(4)] public     int32Age  {get;set;} int = 0;
        [ProtoMember(5)] public     nick  {get;set;} string = "";
        [ProtoMember(6)] public     tmpTalkSig  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(7)] public     msgResult  {get;set;} JudgeResult? = null;
        [ProtoMember(8)] public     int32Ip  {get;set;} int = 0;
        [ProtoMember(9)] public     int32Port  {get;set;} int = 0;
        [ProtoMember(10)] public     tip  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(11)] public     extra  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class Wifi{[ProtoMember(1)] public     mac  {get;set;} long = 0L;
        [ProtoMember(2)] public     int32Rssi  {get;set;} int = 0;
    }

    [ProtoContract] class WifiAbility{[ProtoMember(1)] public     boolEstablishAbi  {get;set;} bool = false;
        [ProtoMember(2)] public     boolAutoConnectAbi  {get;set;} bool = false;
    }

    [ProtoContract] class WifiDetailInfo{[ProtoMember(1)] public     boolSelfEstablish  {get;set;} bool = false;
        [ProtoMember(2)] public     ssid  {get;set;} string = "";
        [ProtoMember(3)] public     mac  {get;set;} string = "";
    }
}


[ProtoContract] class C2CType0x211SubC2CType0x9  {
    [ProtoContract] class MsgBody{[ProtoMember(1)] public     service  {get;set;} string = "";
        [ProtoMember(2)] public     cMD  {get;set;} int = 0;
        [ProtoMember(3)] public     msgPrinter  {get;set;} MsgPrinter? = null;
    } {
        [ProtoContract]
        internal class HPPrinterStateInfo(
            [ProtoMember(1)] public     printerDin  {get;set;} long = 0L;
            [ProtoMember(2)] public     printerQrPicUrl  {get;set;} string = "";
            [ProtoMember(3)] public     printerQrOpenUrl  {get;set;} string = "";
            [ProtoMember(4)] public     printerTipUrl  {get;set;} string = "";
        }

        [ProtoContract]
        internal class MsgPrinter(
            [ProtoMember(1)] public     stringPrinter  {get;set;} List<String> = new();
            [ProtoMember(2)] public     printSessionId  {get;set;} long = 0L;
            [ProtoMember(3)] public     printResult  {get;set;} int = 0;
            [ProtoMember(4)] public     resultMsg  {get;set;} string = "";
            [ProtoMember(5)] public     uint64SessionId  {get;set;} List<Long> = new();
            [ProtoMember(6)] public     msgSupportFileInfo  {get;set;} List<SupportFileInfo> = new();
            [ProtoMember(7)] public     hpPrinterStateInfo  {get;set;} HPPrinterStateInfo? = null;
        }

        [ProtoContract]
        internal class SupportFileInfo(
            [ProtoMember(1)] public     fileSuffix  {get;set;} string = "";
            [ProtoMember(2)] public     copies  {get;set;} int = 0;
            [ProtoMember(3)] public     duplex  {get;set;} int = 0;
        }
    }
}


[ProtoContract] class C2CType0x211SubC2CType0xb  {
    [ProtoContract] class MsgBody{[ProtoMember(1)] public     msgMsgHeader  {get;set;} MsgHeader? = null;
        [ProtoMember(2)] public     msgRejectMotify  {get;set;} RejectNotify? = null;
    } {
        [ProtoContract]
        internal class MsgHeader(
            [ProtoMember(1)] public     bodyType  {get;set;} int /* enum */ = 101;
            [ProtoMember(2)] public     sessionType  {get;set;} int = 0;
            [ProtoMember(3)] public     toUin  {get;set;} long = 0L;
            [ProtoMember(4)] public     toMobile  {get;set;} string = "";
            [ProtoMember(5)] public     roomId  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class RejectNotify(
            [ProtoMember(1)] public     enumRejectReason  {get;set;} int /* enum */ = 201;
            [ProtoMember(2)] public     msg  {get;set;} string = "";
            [ProtoMember(3)] public     ringFilename  {get;set;} string = "";
        }
    }
}
