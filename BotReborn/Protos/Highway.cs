






using ProtoBuf;

import kotlinx.serialization.protobuf.ProtoIntegerType

import kotlinx.serialization.protobuf.ProtoType




/**
 * v8.5.5
 */

[ProtoContract] class BdhExtinfo  {
    [ProtoContract] class CommFileExtReq{[ProtoMember(1)] public     actionType  {get;set;} int = 0;
        [ProtoMember(2)] public     uuid  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class CommFileExtRsp{[ProtoMember(1)] public     int32Retcode  {get;set;} int = 0;
        [ProtoMember(2)] public     downloadUrl  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class PicInfo{[ProtoMember(1)] public     idx  {get;set;} int = 0;
        [ProtoMember(2)] public     size  {get;set;} int = 0;
        [ProtoMember(3)] public     binMd5  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(4)] public     type  {get;set;} int = 0;
    }

    [ProtoContract] class QQVoiceExtReq{[ProtoMember(1)] public     qid  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(2)] public     fmt  {get;set;} int = 0;
        [ProtoMember(3)] public     rate  {get;set;} int = 0;
        [ProtoMember(4)] public     bits  {get;set;} int = 0;
        [ProtoMember(5)] public     channel  {get;set;} int = 0;
        [ProtoMember(6)] public     pinyin  {get;set;} int = 0;
    }

    [ProtoContract] class QQVoiceExtRsp{[ProtoMember(1)] public     qid  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(2)] public     int32Retcode  {get;set;} int = 0;
        [ProtoMember(3)] public     msgResult  {get;set;} List<QQVoiceResult> = new();
    }

    [ProtoContract] class QQVoiceResult{[ProtoMember(1)] public     text  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(2)] public     pinyin  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(3)] public     source  {get;set;} int = 0;
    }

    [ProtoContract] class ShortVideoReqExtInfo{[ProtoMember(1)] public     cmd  {get;set;} int = 0;
        [ProtoMember(2)] public     sessionId  {get;set;} long = 0L;
        [ProtoMember(3)] public     msgThumbinfo  {get;set;} PicInfo? = null;
        [ProtoMember(4)] public     msgVideoinfo  {get;set;} VideoInfo? = null;
        [ProtoMember(5)] public     msgShortvideoSureReq  {get;set;} ShortVideoSureReqInfo? = null;
        [ProtoMember(6)] public     boolIsMergeCmdBeforeData  {get;set;} bool = false;
    }

    [ProtoContract] class ShortVideoRspExtInfo{[ProtoMember(1)] public     cmd  {get;set;} int = 0;
        [ProtoMember(2)] public     sessionId  {get;set;} long = 0L;
        [ProtoMember(3)] public     int32Retcode  {get;set;} int = 0;
        [ProtoMember(4)] public     errinfo  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(5)] public     msgThumbinfo  {get;set;} PicInfo? = null;
        [ProtoMember(6)] public     msgVideoinfo  {get;set;} VideoInfo? = null;
        [ProtoMember(7)] public     msgShortvideoSureRsp  {get;set;} ShortVideoSureRspInfo? = null;
        [ProtoMember(8)] public     retryFlag  {get;set;} int = 0;
    }

    [ProtoContract] class ShortVideoSureReqInfo{[ProtoMember(1)] public     fromuin  {get;set;} long = 0L;
        [ProtoMember(2)] public     chatType  {get;set;} int = 0;
        [ProtoMember(3)] public     touin  {get;set;} long = 0L;
        [ProtoMember(4)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(5)] public     clientType  {get;set;} int = 0;
        [ProtoMember(6)] public     msgThumbinfo  {get;set;} PicInfo? = null;
        [ProtoMember(7)] public     msgMergeVideoinfo  {get;set;} List<VideoInfo> = new();
        [ProtoMember(8)] public     msgDropVideoinfo  {get;set;} List<VideoInfo> = new();
        [ProtoMember(9)] public     businessType  {get;set;} int = 0;
        [ProtoMember(10)] public     subBusinessType  {get;set;} int = 0;
    }

    [ProtoContract] class ShortVideoSureRspInfo{[ProtoMember(1)] public     fileid  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(2)] public     ukey  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(3)] public     msgVideoinfo  {get;set;} VideoInfo? = null;
        [ProtoMember(4)] public     mergeCost  {get;set;} int = 0;
    }

    [ProtoContract] class StoryVideoExtReq 

    [ProtoContract] class StoryVideoExtRsp{[ProtoMember(1)] public     int32Retcode  {get;set;} int = 0;
        [ProtoMember(2)] public     msg  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(3)] public     cdnUrl  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(4)] public     fileKey  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(5)] public     fileId  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class UploadPicExtInfo{[ProtoMember(1)] public     fileResid  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(2)] public     downloadUrl  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(3)] public     thumbDownloadUrl  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class VideoInfo{[ProtoMember(1)] public     idx  {get;set;} int = 0;
        [ProtoMember(2)] public     size  {get;set;} int = 0;
        [ProtoMember(3)] public     binMd5  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(4)] public     format  {get;set;} int = 0;
        [ProtoMember(5)] public     resLen  {get;set;} int = 0;
        [ProtoMember(6)] public     resWidth  {get;set;} int = 0;
        [ProtoMember(7)] public     time  {get;set;} int = 0;
        [ProtoMember(8)] public     starttime  {get;set;} long = 0L;
        [ProtoMember(9)] public     isAudio  {get;set;} int = 0;
    }
}

[ProtoContract] class CSDataHighwayHead  {
    [ProtoContract] class C2CCommonExtendinfo{[ProtoMember(1)] public     infoId  {get;set;} int = 0;
        [ProtoMember(2)] public     msgFilterExtendinfo  {get;set;} FilterExtendinfo? = null;
    }

    [ProtoContract] class DataHighwayHead{[ProtoMember(1)] public     version  {get;set;} int = 0;
        [ProtoMember(2)] public     uin  {get;set;} string = "";
        [ProtoMember(3)] public     command  {get;set;} string = "";
        [ProtoMember(4)] public     seq  {get;set;} int = 0;
        [ProtoMember(5)] public     retryTimes  {get;set;} int? = null; // = 0;
        [ProtoMember(6)] public     appid  {get;set;} int? = null; // = 0;
        [ProtoMember(7)] public     dataflag  {get;set;} int? = null; // = 0;
        [ProtoMember(8)] public     commandId  {get;set;} int? = null; // = 0;
        [ProtoMember(9)] public     buildVer  {get;set;} string = "";
        [ProtoMember(10)] public     localeId  {get;set;} int = 0;
        [ProtoMember(11)] public     envId  {get;set;} int = 0;
    }

    [ProtoContract] class DataHole{[ProtoMember(1)] public     begin  {get;set;} long = 0L;
        [ProtoMember(2)] public     end  {get;set;} long = 0L;
    }

    [ProtoContract] class FilterExtendinfo{[ProtoMember(1)] public     filterFlag  {get;set;} int = 0;
        [ProtoMember(2)] public     msgImageFilterRequest  {get;set;} ImageFilterRequest? = null;
    }

    [ProtoContract] class FilterStyle{[ProtoMember(1)] public     styleId  {get;set;} int = 0;
        [ProtoMember(2)] public     styleName  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class ImageFilterRequest{[ProtoMember(1)] public     sessionId  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(2)] public     clientIp  {get;set;} int = 0;
        [ProtoMember(3)] public     uin  {get;set;} long = 0L;
        [ProtoMember(4)] public     style  {get;set;} FilterStyle? = null;
        [ProtoMember(5)] public     width  {get;set;} int = 0;
        [ProtoMember(6)] public     height  {get;set;} int = 0;
        [ProtoMember(7)] public     imageData  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class ImageFilterResponse{[ProtoMember(1)] public     retCode  {get;set;} int = 0;
        [ProtoMember(2)] public     imageData  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(3)] public     costTime  {get;set;} int = 0;
    }

    [ProtoContract] class LoginSigHead{[ProtoMember(1)] public     loginsigType  {get;set;} int = 0;
        [ProtoMember(2)] public     loginsig  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class NewServiceTicket{[ProtoMember(1)] public     signature  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(2)] public     ukey  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class PicInfoExt{[ProtoMember(1)] public     picWidth  {get;set;} int = 0;
        [ProtoMember(2)] public     picHeight  {get;set;} int = 0;
        [ProtoMember(3)] public     picFlag  {get;set;} int = 0;
        [ProtoMember(4)] public     busiType  {get;set;} int = 0;
        [ProtoMember(5)] public     srcTerm  {get;set;} int = 0;
        [ProtoMember(6)] public     platType  {get;set;} int = 0;
        [ProtoMember(7)] public     netType  {get;set;} int = 0;
        [ProtoMember(8)] public     imgType  {get;set;} int = 0;
        [ProtoMember(9)] public     appPicType  {get;set;} int = 0;
    }

    [ProtoContract] class PicRspExtInfo{[ProtoMember(1)] public     skey  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(2)] public     clientIp  {get;set;} int = 0;
        [ProtoMember(3)] public     upOffset  {get;set;} long = 0L;
        [ProtoMember(4)] public     blockSize  {get;set;} long = 0L;
    }

    [ProtoContract] class QueryHoleRsp{[ProtoMember(1)] public     result  {get;set;} int = 0;
        [ProtoMember(2)] public     dataHole  {get;set;} List<DataHole> = new();
        [ProtoMember(3)] public     boolCompFlag  {get;set;} bool = false;
    }

    [ProtoContract] class ReqDataHighwayHead{[ProtoMember(1)] public     msgBasehead  {get;set;} DataHighwayHead? = null;
        [ProtoMember(2)] public     msgSeghead  {get;set;} SegHead? = null;
        [ProtoMember(3)] public     reqExtendinfo  {get;set;} byte[]? = null; // = Array.Empty<byte>();
        [ProtoMember(4)] public     timestamp  {get;set;} long = 0L;
        [ProtoMember(5)] public     msgLoginSigHead  {get;set;} LoginSigHead? = null;
    }

    [ProtoContract] class RspBody{[ProtoMember(1)] public     msgQueryHoleRsp  {get;set;} QueryHoleRsp? = null;
    }

    [ProtoContract] class RspDataHighwayHead{[ProtoMember(1)] public     msgBasehead  {get;set;} DataHighwayHead? = null;
        [ProtoMember(2)] public     msgSeghead  {get;set;} SegHead? = null;
        [ProtoMember(3)] public     errorCode  {get;set;} int = 0;
        [ProtoMember(4)] public     allowRetry  {get;set;} int = 0;
        [ProtoMember(5)] public     cachecost  {get;set;} int = 0;
        [ProtoMember(6)] public     htcost  {get;set;} int = 0;
        [ProtoMember(7)] public     rspExtendinfo  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(8)] public     timestamp  {get;set;} long = 0L;
        [ProtoMember(9)] public     range  {get;set;} long = 0L;
        [ProtoMember(10)] public     isReset  {get;set;} int = 0;
    }

    [ProtoContract] class SegHead{[ProtoMember(1)] public     serviceid  {get;set;} int = 0;
        [ProtoMember(2)] public     filesize  {get;set;} long = 0L;
        [ProtoMember(3)] public     dataoffset  {get;set;} long = 0L;
        [ProtoMember(4)] public     datalength  {get;set;} int = 0;
        [ProtoMember(5)] public     rtcode  {get;set;} int? = null; // = 0;
        [ProtoMember(6)] public     serviceticket  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(7)] public     flag  {get;set;} int? = null; // = 0;
        [ProtoMember(8)] public     md5  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(9)] public     fileMd5  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(10)] public     cacheAddr  {get;set;} int = 0;
        [ProtoMember(11)] public     queryTimes  {get;set;} int = 0;
        [ProtoMember(12)] public     updateCacheip  {get;set;} int = 0;
    }
}

[ProtoContract] class HwConfigPersistentPB  {
    [ProtoContract] class HwConfigItemPB{[ProtoMember(1)] public     key  {get;set;} string = "";
        [ProtoMember(2)] public     endPointList  {get;set;} List<HwEndPointPB> = new();
    }

    [ProtoContract] class HwConfigPB{[ProtoMember(1)] public     configItemList  {get;set;} List<HwConfigItemPB> = new();
        [ProtoMember(2)] public     netSegConfList  {get;set;} List<HwNetSegConfPB> = new();
        [ProtoMember(3)] public     shortVideoNetConf  {get;set;} List<HwNetSegConfPB> = new();
        [ProtoMember(4)] public     configItemListIp6  {get;set;} List<HwConfigItemPB> = new();
    }

    [ProtoContract] class HwEndPointPB{[ProtoMember(1)] public     host  {get;set;} string = "";
        [ProtoMember(2)] public     int32Port  {get;set;} int = 0;
        [ProtoMember(3)] public     int64Timestampe  {get;set;} long = 0L;
    }

    [ProtoContract] class HwNetSegConfPB{[ProtoMember(1)] public     int64NetType  {get;set;} long = 0L;
        [ProtoMember(2)] public     int64SegSize  {get;set;} long = 0L;
        [ProtoMember(3)] public     int64SegNum  {get;set;} long = 0L;
        [ProtoMember(4)] public     int64CurConnNum  {get;set;} long = 0L;
    }
}

[ProtoContract] class HwSessionInfoPersistentPB  {
    [ProtoContract] class HwSessionInfoPB{[ProtoMember(1)] public     httpconnSigSession  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(2)] public     sessionKey  {get;set;} byte[] = Array.Empty<byte>();
    }
}

[ProtoContract] class Subcmd0x501  {
    [ProtoContract] class ReqBody{[ProtoMember(1281)] public     msgSubcmd0x501ReqBody  {get;set;} SubCmd0x501ReqBody? = null;
    }

    [ProtoContract] class RspBody{[ProtoMember(1281)] public     msgSubcmd0x501RspBody  {get;set;} SubCmd0x501Rspbody? = null;
    }

    [ProtoContract] class SubCmd0x501ReqBody{[ProtoMember(1)] public     uin  {get;set;} long = 0L;
        [ProtoMember(2)] public     idcId  {get;set;} int = 0;
        [ProtoMember(3)] public     appid  {get;set;} int = 0;
        [ProtoMember(4)] public     loginSigType  {get;set;} int = 0;
        [ProtoMember(5)] public     loginSigTicket  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(6)] public     requestFlag  {get;set;} int = 0;
        [ProtoMember(7)] public     uint32ServiceTypes  {get;set;} List<int> = new();
        [ProtoMember(8)] public     bid  {get;set;} int = 0;
        [ProtoMember(9)] public     term  {get;set;} int = 0;
        [ProtoMember(10)] public     plat  {get;set;} int = 0;
        [ProtoMember(11)] public     net  {get;set;} int = 0;
        [ProtoMember(12)] public     caller  {get;set;} int = 0;
    }

    [ProtoContract] class SubCmd0x501Rspbody{[ProtoMember(1)] public     httpconnSigSession  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(2)] public     sessionKey  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(3)] public     msgHttpconnAddrs  {get;set;} List<SrvAddrs> = new();
        [ProtoMember(4)] public     preConnection  {get;set;} int = 0;
        [ProtoMember(5)] public     csConn  {get;set;} int = 0;
        [ProtoMember(6)] public     msgIpLearnConf  {get;set;} IpLearnConf? = null;
        [ProtoMember(7)] public     msgDynTimeoutConf  {get;set;} DynTimeOutConf? = null;
        [ProtoMember(8)] public     msgOpenUpConf  {get;set;} OpenUpConf? = null;
        [ProtoMember(9)] public     msgDownloadEncryptConf  {get;set;} DownloadEncryptConf? = null;
        [ProtoMember(10)] public     msgShortVideoConf  {get;set;} ShortVideoConf? = null;
        [ProtoMember(11)] public     msgPtvConf  {get;set;} PTVConf? = null;
        [ProtoMember(12)] public     shareType  {get;set;} int = 0;
        [ProtoMember(13)] public     shareChannel  {get;set;} int = 0;
        [ProtoMember(14)] public     fmtPolicy  {get;set;} int = 0;
        [ProtoMember(15)] public     bigdataPolicy  {get;set;} int = 0;
        [ProtoMember(16)] public     connAttemptDelay  {get;set;} int = 0;
    } {
        [ProtoContract]
        internal class DownloadEncryptConf(
            [ProtoMember(1)] public     boolEnableEncryptRequest  {get;set;} bool = false;
            [ProtoMember(2)] public     boolEnableEncryptedPic  {get;set;} bool = false;
            [ProtoMember(3)] public     ctrlFlag  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class DynTimeOutConf(
            [ProtoMember(1)] public     tbase2g  {get;set;} int = 0;
            [ProtoMember(2)] public     tbase3g  {get;set;} int = 0;
            [ProtoMember(3)] public     tbase4g  {get;set;} int = 0;
            [ProtoMember(4)] public     tbaseWifi  {get;set;} int = 0;
            [ProtoMember(5)] public     torg2g  {get;set;} int = 0;
            [ProtoMember(6)] public     torg3g  {get;set;} int = 0;
            [ProtoMember(7)] public     torg4g  {get;set;} int = 0;
            [ProtoMember(8)] public     torgWifi  {get;set;} int = 0;
            [ProtoMember(9)] public     maxTimeout  {get;set;} int = 0;
            [ProtoMember(10)] public     enableDynTimeout  {get;set;} int = 0;
            [ProtoMember(11)] public     maxTimeout2g  {get;set;} int = 0;
            [ProtoMember(12)] public     maxTimeout3g  {get;set;} int = 0;
            [ProtoMember(13)] public     maxTimeout4g  {get;set;} int = 0;
            [ProtoMember(14)] public     maxTimeoutWifi  {get;set;} int = 0;
            [ProtoMember(15)] public     hbTimeout2g  {get;set;} int = 0;
            [ProtoMember(16)] public     hbTimeout3g  {get;set;} int = 0;
            [ProtoMember(17)] public     hbTimeout4g  {get;set;} int = 0;
            [ProtoMember(18)] public     hbTimeoutWifi  {get;set;} int = 0;
            [ProtoMember(19)] public     hbTimeoutDefault  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class Ip6Addr(
            [ProtoMember(1)] public     type  {get;set;} int = 0;
            [ProtoMember(2)] public     ip6  {get;set;} byte[] = Array.Empty<byte>();
            [ProtoMember(3)] public     port  {get;set;} int = 0;
            [ProtoMember(4)] public     area  {get;set;} int = 0;
            [ProtoMember(5)] public     sameIsp  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class IpAddr(
            [ProtoMember(1)] public     type  {get;set;} int = 0;
            @ProtoType(ProtoIntegerType.FIXED) [ProtoMember(2)] public     ip  {get;set;} int = 0;
            [ProtoMember(3)] public     port  {get;set;} int = 0;
            [ProtoMember(4)] public     area  {get;set;} int = 0;
            [ProtoMember(5)] public     sameIsp  {get;set;} int = 0;
        } {
            fun decode()  {get;set;} Pair<Int; Int> = ip to port
        }

        [ProtoContract]
        internal class IpLearnConf(
            [ProtoMember(1)] public     refreshCachedIp  {get;set;} int = 0;
            [ProtoMember(2)] public     enableIpLearn  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class NetSegConf(
            [ProtoMember(1)] public     netType  {get;set;} int = 0;
            [ProtoMember(2)] public     segsize  {get;set;} int = 0;
            [ProtoMember(3)] public     segnum  {get;set;} int = 0;
            [ProtoMember(4)] public     curconnnum  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class OpenUpConf(
            [ProtoMember(1)] public     boolEnableOpenup  {get;set;} bool = false;
            [ProtoMember(2)] public     preSendSegnum  {get;set;} int = 0;
            [ProtoMember(3)] public     preSendSegnum3g  {get;set;} int = 0;
            [ProtoMember(4)] public     preSendSegnum4g  {get;set;} int = 0;
            [ProtoMember(5)] public     preSendSegnumWifi  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class PTVConf(
            [ProtoMember(1)] public     channelType  {get;set;} int = 0;
            [ProtoMember(2)] public     msgNetsegconf  {get;set;} List<NetSegConf> = new();
            [ProtoMember(3)] public     boolOpenHardwareCodec  {get;set;} bool = false;
        }

        [ProtoContract]
        internal class ShortVideoConf(
            [ProtoMember(1)] public     channelType  {get;set;} int = 0;
            [ProtoMember(2)] public     msgNetsegconf  {get;set;} List<NetSegConf> = new();
            [ProtoMember(3)] public     boolOpenHardwareCodec  {get;set;} bool = false;
            [ProtoMember(4)] public     boolSendAheadSignal  {get;set;} bool = false;
        }

        [ProtoContract]
        internal data class SrvAddrs(
            [ProtoMember(1)] public     serviceType  {get;set;} int = 0;
            [ProtoMember(2)] public     msgAddrs  {get;set;} List<IpAddr> = new();
            [ProtoMember(3)] public     fragmentSize  {get;set;} int = 0;
            [ProtoMember(4)] public     msgNetsegconf  {get;set;} List<NetSegConf> = new();
            [ProtoMember(5)] public     msgAddrsV6  {get;set;} List<Ip6Addr> = new();
        }
    }
}
