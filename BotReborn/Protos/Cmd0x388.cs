using ProtoBuf;

[ProtoContract] class Cmd0x388  {
    [ProtoContract] class DelImgReq(
       [ProtoMember(1)] public   srcUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   dstUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   reqTerm  {get;set;} int = 0;
       [ProtoMember(4)] public   reqPlatformType  {get;set;} int = 0;
       [ProtoMember(5)] public   buType  {get;set;} int = 0;
       [ProtoMember(6)] public   buildVer  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(7)] public   fileResid  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(8)] public   picWidth  {get;set;} int = 0;
       [ProtoMember(9)] public   picHeight  {get;set;} int = 0;
    }

    [ProtoContract] class DelImgRsp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   failMsg  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   fileResid  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class ExpRoamExtendInfo(
       [ProtoMember(1)] public   resid  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class ExpRoamPicInfo(
       [ProtoMember(1)] public   shopFlag  {get;set;} int = 0;
       [ProtoMember(2)] public   pkgId  {get;set;} int = 0;
       [ProtoMember(3)] public   picId  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class ExtensionCommPicTryUp(
       [ProtoMember(1)] public   bytesExtinfo  {get;set;} List<byte[]> = new();
    }

    [ProtoContract] class ExtensionExpRoamTryUp(
       [ProtoMember(1)] public   msgExproamPicInfo  {get;set;} List<ExpRoamPicInfo> = new();
    }

    [ProtoContract] class GetImgUrlReq(
       [ProtoMember(1)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(2)] public   dstUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   fileid  {get;set;} long = 0L;
       [ProtoMember(4)] public   fileMd5  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   urlFlag  {get;set;} int = 0;
       [ProtoMember(6)] public   urlType  {get;set;} int = 0;
       [ProtoMember(7)] public   reqTerm  {get;set;} int = 0;
       [ProtoMember(8)] public   reqPlatformType  {get;set;} int = 0;
       [ProtoMember(9)] public   innerIp  {get;set;} int = 0;
       [ProtoMember(10)] public   buType  {get;set;} int = 0;
       [ProtoMember(11)] public   buildVer  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(12)] public   fileId  {get;set;} long = 0L;
       [ProtoMember(13)] public   fileSize  {get;set;} long = 0L;
       [ProtoMember(14)] public   originalPic  {get;set;} int = 0;
       [ProtoMember(15)] public   retryReq  {get;set;} int = 0;
       [ProtoMember(16)] public   fileHeight  {get;set;} int = 0;
       [ProtoMember(17)] public   fileWidth  {get;set;} int = 0;
       [ProtoMember(18)] public   picType  {get;set;} int = 0;
       [ProtoMember(19)] public   picUpTimestamp  {get;set;} int = 0;
       [ProtoMember(20)] public   reqTransferType  {get;set;} int = 0;
    }

    [ProtoContract] class GetImgUrlRsp(
       [ProtoMember(1)] public   fileid  {get;set;} long = 0L;
       [ProtoMember(2)] public   fileMd5  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   result  {get;set;} int = 0;
       [ProtoMember(4)] public   failMsg  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   msgImgInfo  {get;set;} ImgInfo? = null;
       [ProtoMember(6)] public   bytesThumbDownUrl  {get;set;} List<byte[]> = new();
       [ProtoMember(7)] public   bytesOriginalDownUrl  {get;set;} List<byte[]> = new();
       [ProtoMember(8)] public   bytesBigDownUrl  {get;set;} List<byte[]> = new();
       [ProtoMember(9)] public   uint32DownIp  {get;set;} List<int> = new();
       [ProtoMember(10)] public   uint32DownPort  {get;set;} List<int> = new();
       [ProtoMember(11)] public   downDomain  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(12)] public   thumbDownPara  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(13)] public   originalDownPara  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(14)] public   bigDownPara  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(15)] public   fileId  {get;set;} long = 0L;
       [ProtoMember(16)] public   autoDownType  {get;set;} int = 0;
       [ProtoMember(17)] public   uint32OrderDownType  {get;set;} List<int> = new();
       [ProtoMember(19)] public   bigThumbDownPara  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(20)] public   httpsUrlFlag  {get;set;} int = 0;
       [ProtoMember(26)] public   msgDownIp6  {get;set;} List<IPv6Info> = new();
       [ProtoMember(27)] public   clientIp6  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class GetPttUrlReq(
       [ProtoMember(1)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(2)] public   dstUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   fileid  {get;set;} long = 0L;
       [ProtoMember(4)] public   fileMd5  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   reqTerm  {get;set;} int = 0;
       [ProtoMember(6)] public   reqPlatformType  {get;set;} int = 0;
       [ProtoMember(7)] public   innerIp  {get;set;} int = 0;
       [ProtoMember(8)] public   buType  {get;set;} int = 0;
       [ProtoMember(9)] public   buildVer  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(10)] public   fileId  {get;set;} long = 0L;
       [ProtoMember(11)] public   fileKey  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(12)] public   codec  {get;set;} int = 0;
       [ProtoMember(13)] public   buId  {get;set;} int = 0;
       [ProtoMember(14)] public   reqTransferType  {get;set;} int = 0;
       [ProtoMember(15)] public   isAuto  {get;set;} int = 0;
    }

    [ProtoContract] class GetPttUrlRsp(
       [ProtoMember(1)] public   fileid  {get;set;} long = 0L;
       [ProtoMember(2)] public   fileMd5  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   result  {get;set;} int = 0;
       [ProtoMember(4)] public   failMsg  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   bytesDownUrl  {get;set;} List<byte[]> = new();
       [ProtoMember(6)] public   uint32DownIp  {get;set;} List<int> = new();
       [ProtoMember(7)] public   uint32DownPort  {get;set;} List<int> = new();
       [ProtoMember(8)] public   downDomain  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(9)] public   downPara  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(10)] public   fileId  {get;set;} long = 0L;
       [ProtoMember(11)] public   transferType  {get;set;} int = 0;
       [ProtoMember(12)] public   allowRetry  {get;set;} int = 0;
       [ProtoMember(26)] public   msgDownIp6  {get;set;} List<IPv6Info> = new();
       [ProtoMember(27)] public   clientIp6  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(28)] public   strDomain  {get;set;} string = "";
    }

    
    [ProtoContract] class ImgInfo(
       [ProtoMember(1)] public   fileMd5  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   fileType  {get;set;} int = 0;
       [ProtoMember(3)] public   fileSize  {get;set;} long = 0L;
       [ProtoMember(4)] public   fileWidth  {get;set;} int = 0;
       [ProtoMember(5)] public   fileHeight  {get;set;} int = 0;
    } {
        override fun toString()  {get;set;} string {
            return "ImgInfo(fileMd5=${fileMd5.contentToString()}; fileType=$fileType; fileSize=$fileSize; fileWidth=$fileWidth; fileHeight=$fileHeight)"
        }
    }

    [ProtoContract] class IPv6Info(
       [ProtoMember(1)] public   ip6  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   port  {get;set;} int = 0;
    }

    [ProtoContract] class PicSize(
       [ProtoMember(1)] public   original  {get;set;} int = 0;
       [ProtoMember(2)] public   thumb  {get;set;} int = 0;
       [ProtoMember(3)] public   high  {get;set;} int = 0;
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   netType  {get;set;} int = 0;
       [ProtoMember(2)] public   subcmd  {get;set;} int = 0;
       [ProtoMember(3)] public   msgTryupImgReq  {get;set;} List<TryUpImgReq> = new();
       [ProtoMember(4)] public   msgGetimgUrlReq  {get;set;} List<GetImgUrlReq> = new();
       [ProtoMember(5)] public   msgTryupPttReq  {get;set;} List<TryUpPttReq> = new();
       [ProtoMember(6)] public   msgGetpttUrlReq  {get;set;} List<GetPttUrlReq> = new();
       [ProtoMember(7)] public   commandId  {get;set;} int = 0;
       [ProtoMember(8)] public   msgDelImgReq  {get;set;} List<DelImgReq> = new();
       [ProtoMember(1001)] public   extension  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   clientIp  {get;set;} int = 0;
       [ProtoMember(2)] public   subcmd  {get;set;} int = 0;
       [ProtoMember(3)] public   msgTryupImgRsp  {get;set;} List<TryUpImgRsp> = new();
       [ProtoMember(4)] public   msgGetimgUrlRsp  {get;set;} List<GetImgUrlRsp> = new();
       [ProtoMember(5)] public   msgTryupPttRsp  {get;set;} List<TryUpPttRsp> = new();
       [ProtoMember(6)] public   msgGetpttUrlRsp  {get;set;} List<GetPttUrlRsp> = new();
       [ProtoMember(7)] public   msgDelImgRsp  {get;set;} List<DelImgRsp> = new();
    }

    [ProtoContract] class TryUpImgReq(
       [ProtoMember(1)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(2)] public   srcUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   fileId  {get;set;} long = 0L;
       [ProtoMember(4)] public   fileMd5  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   fileSize  {get;set;} long = 0L;
       [ProtoMember(6)] public   fileName  {get;set;} string = "";
       [ProtoMember(7)] public   srcTerm  {get;set;} int = 0;
       [ProtoMember(8)] public   platformType  {get;set;} int = 0;
        /**
         * if uinType = 1 then 1 else2
         *
        UIN_QQ = new UINTYPE(0; 0; "UIN_QQ");
        UIN_EMAIL = new UINTYPE(1; 1; "UIN_EMAIL");
        UIN_MOBILE = new UINTYPE(2; 2; "UIN_MOBILE");
         */
       [ProtoMember(9)] public   buType  {get;set;} int = 0;
       [ProtoMember(10)] public   picWidth  {get;set;} int = 0;
       [ProtoMember(11)] public   picHeight  {get;set;} int = 0;
       [ProtoMember(12)] public   picType  {get;set;} int = 0;
       [ProtoMember(13)] public   buildVer  {get;set;} string = "";
       [ProtoMember(14)] public   innerIp  {get;set;} int = 0;
       [ProtoMember(15)] public   appPicType  {get;set;} int = 0;
       [ProtoMember(16)] public   originalPic  {get;set;} int = 0;
       [ProtoMember(17)] public   fileIndex  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(18)] public   dstUin  {get;set;} long = 0L;
       [ProtoMember(19)] public   srvUpload  {get;set;} int = 0;
       [ProtoMember(20)] public   transferUrl  {get;set;} byte[] = Array.Empty<byte>();
    )   {get;set;} ImgReq

    [ProtoContract] class TryUpImgRsp(
       [ProtoMember(1)] public   fileId  {get;set;} long = 0L;
       [ProtoMember(2)] public   result  {get;set;} int = 0;
       [ProtoMember(3)] public   failMsg  {get;set;} string = "";
       [ProtoMember(4)] public   boolFileExit  {get;set;} bool = false;
       [ProtoMember(5)] public   msgImgInfo  {get;set;} ImgInfo? = null;
       [ProtoMember(6)] public   uint32UpIp  {get;set;} List<int> = new();
       [ProtoMember(7)] public   uint32UpPort  {get;set;} List<int> = new();
       [ProtoMember(8)] public   upUkey  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(9)] public   fileid  {get;set;} long = 0L;
       [ProtoMember(10)] public   upOffset  {get;set;} long = 0L;
       [ProtoMember(11)] public   blockSize  {get;set;} long = 0L;
       [ProtoMember(12)] public   boolNewBigChan  {get;set;} bool = false;
       [ProtoMember(26)] public   msgUpIp6  {get;set;} List<IPv6Info> = new();
       [ProtoMember(27)] public   clientIp6  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(1001)] public   msgInfo4busi  {get;set;} TryUpInfo4Busi? = null;
    }

    [ProtoContract] class TryUpInfo4Busi(
       [ProtoMember(1)] public   downDomain  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   thumbDownUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   originalDownUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   bigDownUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   fileResid  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class TryUpPttReq(
       [ProtoMember(1)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(2)] public   srcUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   fileId  {get;set;} long = 0L;
       [ProtoMember(4)] public   fileMd5  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   fileSize  {get;set;} long = 0L;
       [ProtoMember(6)] public   fileName  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(7)] public   srcTerm  {get;set;} int = 0;
       [ProtoMember(8)] public   platformType  {get;set;} int = 0;
       [ProtoMember(9)] public   buType  {get;set;} int = 0;
       [ProtoMember(10)] public   buildVer  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(11)] public   innerIp  {get;set;} int = 0;
       [ProtoMember(12)] public   voiceLength  {get;set;} int = 0;
       [ProtoMember(13)] public   boolNewUpChan  {get;set;} bool = false;
       [ProtoMember(14)] public   codec  {get;set;} int = 0;
       [ProtoMember(15)] public   voiceType  {get;set;} int = 0;
       [ProtoMember(16)] public   buId  {get;set;} int = 0;
    }

    [ProtoContract] class TryUpPttRsp(
       [ProtoMember(1)] public   fileId  {get;set;} long = 0L;
       [ProtoMember(2)] public   result  {get;set;} int = 0;
       [ProtoMember(3)] public   failMsg  {get;set;} byte[]? = null;
       [ProtoMember(4)] public   boolFileExit  {get;set;} bool = false;
       [ProtoMember(5)] public   uint32UpIp  {get;set;} List<int> = new();
       [ProtoMember(6)] public   uint32UpPort  {get;set;} List<int> = new();
       [ProtoMember(7)] public   upUkey  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(8)] public   fileid  {get;set;} long = 0L;
       [ProtoMember(9)] public   upOffset  {get;set;} long = 0L;
       [ProtoMember(10)] public   blockSize  {get;set;} long = 0L;
       [ProtoMember(11)] public   fileKey  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(12)] public   channelType  {get;set;} int = 0;
       [ProtoMember(26)] public   msgUpIp6  {get;set;} List<IPv6Info> = new();
       [ProtoMember(27)] public   clientIp6  {get;set;} byte[] = Array.Empty<byte>();
    }
}
