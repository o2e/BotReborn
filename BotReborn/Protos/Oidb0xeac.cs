

using ProtoBuf;

[ProtoContract] class Oidb0xeac  {
    [ProtoContract] class ArkMsg{[ProtoMember(1)] public     appName  {get;set;} string = "";
        [ProtoMember(2)] public     json  {get;set;} string = "";
    }

    [ProtoContract] class BatchReqBody{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     msgs  {get;set;} List<Oidb0xeac.MsgInfo> = new();
    }

    [ProtoContract] class BatchRspBody{[ProtoMember(1)] public     wording  {get;set;} string = "";
        [ProtoMember(2)] public     errorCode  {get;set;} int = 0;
        [ProtoMember(3)] public     succCnt  {get;set;} int = 0;
        [ProtoMember(4)] public     msgProcInfos  {get;set;} List<Oidb0xeac.MsgProcessInfo> = new();
        [ProtoMember(5)] public     digestTime  {get;set;} int = 0;
    }

    [ProtoContract] class DigestMsg{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     msgSeq  {get;set;} int = 0;
        [ProtoMember(3)] public     msgRandom  {get;set;} int = 0;
        [ProtoMember(4)] public     msgContent  {get;set;} List<Oidb0xeac.MsgElem> = new();
        [ProtoMember(5)] public     textSize  {get;set;} long = 0L;
        [ProtoMember(6)] public     picSize  {get;set;} long = 0L;
        [ProtoMember(7)] public     videoSize  {get;set;} long = 0L;
        [ProtoMember(8)] public     senderUin  {get;set;} long = 0L;
        [ProtoMember(9)] public     senderTime  {get;set;} int = 0;
        [ProtoMember(10)] public     addDigestUin  {get;set;} long = 0L;
        [ProtoMember(11)] public     addDigestTime  {get;set;} int = 0;
        [ProtoMember(12)] public     startTime  {get;set;} int = 0;
        [ProtoMember(13)] public     latestMsgSeq  {get;set;} int = 0;
        [ProtoMember(14)] public     opType  {get;set;} int = 0;
    }

    [ProtoContract] class FaceMsg{[ProtoMember(1)] public     index  {get;set;} int = 0;
        [ProtoMember(2)] public     text  {get;set;} string = "";
    }

    [ProtoContract] class GroupFileMsg{[ProtoMember(1)] public     fileName  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(2)] public     busId  {get;set;} int = 0;
        [ProtoMember(3)] public     fileId  {get;set;} string = "";
        [ProtoMember(4)] public     fileSize  {get;set;} long = 0L;
        [ProtoMember(5)] public     deadTime  {get;set;} long = 0L;
        [ProtoMember(6)] public     fileSha1  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(7)] public     ext  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(8)] public     fileMd5  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class ImageMsg{[ProtoMember(1)] public     md5  {get;set;} string = "";
        [ProtoMember(2)] public     uuid  {get;set;} string = "";
        [ProtoMember(3)] public     imgType  {get;set;} int = 0;
        [ProtoMember(4)] public     fileSize  {get;set;} int = 0;
        [ProtoMember(5)] public     width  {get;set;} int = 0;
        [ProtoMember(6)] public     height  {get;set;} int = 0;
        [ProtoMember(101)] public     fileId  {get;set;} int = 0;
        [ProtoMember(102)] public     serverIp  {get;set;} int = 0;
        [ProtoMember(103)] public     serverPort  {get;set;} int = 0;
        [ProtoMember(104)] public     filePath  {get;set;} string = "";
        [ProtoMember(201)] public     thumbUrl  {get;set;} string = "";
        [ProtoMember(202)] public     originalUrl  {get;set;} string = "";
        [ProtoMember(203)] public     resaveUrl  {get;set;} string = "";
    }

    [ProtoContract] class MsgElem{[ProtoMember(1)] public     msgType  {get;set;} int = 0;
        [ProtoMember(11)] public     textMsg  {get;set;} Oidb0xeac.TextMsg? = null;
        [ProtoMember(12)] public     faceMsg  {get;set;} Oidb0xeac.FaceMsg? = null;
        [ProtoMember(13)] public     imageMsg  {get;set;} Oidb0xeac.ImageMsg? = null;
        [ProtoMember(14)] public     groupFileMsg  {get;set;} Oidb0xeac.GroupFileMsg? = null;
        [ProtoMember(15)] public     shareMsg  {get;set;} Oidb0xeac.ShareMsg? = null;
        [ProtoMember(16)] public     richMsg  {get;set;} Oidb0xeac.RichMsg? = null;
        [ProtoMember(17)] public     arkMsg  {get;set;} Oidb0xeac.ArkMsg? = null;
    }

    [ProtoContract] class MsgInfo{[ProtoMember(1)] public     msgSeq  {get;set;} int = 0;
        [ProtoMember(2)] public     msgRandom  {get;set;} int = 0;
    }

    [ProtoContract] class MsgProcessInfo{[ProtoMember(1)] public     msg  {get;set;} Oidb0xeac.MsgInfo? = null;
        [ProtoMember(2)] public     errorCode  {get;set;} int = 0;
        [ProtoMember(3)] public     digestUin  {get;set;} long = 0L;
        [ProtoMember(4)] public     digestTime  {get;set;} int = 0;
    }

    [ProtoContract] class ReqBody{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     msgSeq  {get;set;} int = 0;
        [ProtoMember(3)] public     msgRandom  {get;set;} int = 0;
    }

    [ProtoContract] class RichMsg{[ProtoMember(1)] public     serviceId  {get;set;} int = 0;
        [ProtoMember(2)] public     xml  {get;set;} string = "";
        [ProtoMember(3)] public     longMsgResid  {get;set;} string = "";
    }

    [ProtoContract] class RspBody{[ProtoMember(1)] public     wording  {get;set;} string = "";
        [ProtoMember(2)] public     digestUin  {get;set;} long = 0L;
        [ProtoMember(3)] public     digestTime  {get;set;} int = 0;
        [ProtoMember(4)] public     msg  {get;set;} Oidb0xeac.DigestMsg? = null;
        [ProtoMember(10)] public     errorCode  {get;set;} int = 0;
    }

    [ProtoContract] class ShareMsg{[ProtoMember(1)] public     type  {get;set;} string = "";
        [ProtoMember(2)] public     title  {get;set;} string = "";
        [ProtoMember(3)] public     summary  {get;set;} string = "";
        [ProtoMember(4)] public     brief  {get;set;} string = "";
        [ProtoMember(5)] public     url  {get;set;} string = "";
        [ProtoMember(6)] public     pictureUrl  {get;set;} string = "";
        [ProtoMember(7)] public     action  {get;set;} string = "";
        [ProtoMember(8)] public     source  {get;set;} string = "";
        [ProtoMember(9)] public     sourceUrl  {get;set;} string = "";
    }

    [ProtoContract] class TextMsg{[ProtoMember(1)] public     str  {get;set;} byte[] = Array.Empty<byte>();
    }
}
