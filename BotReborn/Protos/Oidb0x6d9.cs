

using ProtoBuf;

internal class Oidb0x6d9  {
    [ProtoContract] class CopyFromReqBody{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     appId  {get;set;} int = 0;
        [ProtoMember(3)] public     srcBusId  {get;set;} int = 0;
        [ProtoMember(4)] public     srcParentFolder  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(5)] public     srcFilePath  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(6)] public     dstBusId  {get;set;} int = 0;
        [ProtoMember(7)] public     dstFolderId  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(8)] public     fileSize  {get;set;} long = 0L;
        [ProtoMember(9)] public     localPath  {get;set;} string = "";
        [ProtoMember(10)] public     fileName  {get;set;} string = "";
        [ProtoMember(11)] public     srcUin  {get;set;} long = 0L;
        [ProtoMember(12)] public     md5  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class CopyFromRspBody{[ProtoMember(1)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(2)] public     retMsg  {get;set;} string = "";
        [ProtoMember(3)] public     clientWording  {get;set;} string = "";
        [ProtoMember(4)] public     saveFilePath  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(5)] public     busId  {get;set;} int = 0;
    }

    [ProtoContract] class CopyToReqBody{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     appId  {get;set;} int = 0;
        [ProtoMember(3)] public     srcBusId  {get;set;} int = 0;
        [ProtoMember(4)] public     srcFileId  {get;set;} string = "";
        [ProtoMember(5)] public     dstBusId  {get;set;} int = 0;
        [ProtoMember(6)] public     dstUin  {get;set;} long = 0L;
        [ProtoMember(40)] public     newFileName  {get;set;} string = "";
        [ProtoMember(100)] public     timCloudPdirKey  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(101)] public     timCloudPpdirKey  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(102)] public     timCloudExtensionInfo  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(103)] public     timFileExistOption  {get;set;} int = 0;
    }

    [ProtoContract] class CopyToRspBody{[ProtoMember(1)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(2)] public     retMsg  {get;set;} string = "";
        [ProtoMember(3)] public     clientWording  {get;set;} string = "";
        [ProtoMember(4)] public     saveFilePath  {get;set;} string = "";
        [ProtoMember(5)] public     busId  {get;set;} int = 0;
        [ProtoMember(40)] public     fileName  {get;set;} string = "";
    }

    [ProtoContract] class FeedsReqBody{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     appId  {get;set;} int = 0;
        [ProtoMember(3)] public     feedsInfoList  {get;set;} List<GroupFileCommon.FeedsInfo> = new();
        [ProtoMember(4)] public     multiSendSeq  {get;set;} int = 0;
    }

    [ProtoContract] class FeedsRspBody{[ProtoMember(1)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(2)] public     retMsg  {get;set;} string = "";
        [ProtoMember(3)] public     clientWording  {get;set;} string = "";
        [ProtoMember(4)] public     feedsResultList  {get;set;} List<GroupFileCommon.FeedsResult> = new();
        [ProtoMember(5)] public     svrbusyWaitTime  {get;set;} int = 0;
    }

    [ProtoContract] class ReqBody{[ProtoMember(1)] public     transFileReq  {get;set;} TransFileReqBody? = null;
        [ProtoMember(2)] public     copyFromReq  {get;set;} CopyFromReqBody? = null;
        [ProtoMember(3)] public     copyToReq  {get;set;} CopyToReqBody? = null;
        [ProtoMember(5)] public     feedsInfoReq  {get;set;} FeedsReqBody? = null;
    }

    [ProtoContract] class RspBody{[ProtoMember(1)] public     transFileRsp  {get;set;} TransFileRspBody? = null;
        [ProtoMember(2)] public     copyFromRsp  {get;set;} CopyFromRspBody? = null;
        [ProtoMember(3)] public     copyToRsp  {get;set;} CopyToRspBody? = null;
        [ProtoMember(5)] public     feedsInfoRsp  {get;set;} FeedsRspBody? = null;
    }

    [ProtoContract] class TransFileReqBody{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     appId  {get;set;} int = 0;
        [ProtoMember(3)] public     busId  {get;set;} int = 0;
        [ProtoMember(4)] public     fileId  {get;set;} string = "";
    }

    [ProtoContract] class TransFileRspBody{[ProtoMember(1)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(2)] public     retMsg  {get;set;} string = "";
        [ProtoMember(3)] public     clientWording  {get;set;} string = "";
        [ProtoMember(4)] public     saveBusId  {get;set;} int = 0;
        [ProtoMember(5)] public     saveFilePath  {get;set;} string = "";
    }
}
