

using ProtoBuf;

internal class Oidb0x6d8  {
    [ProtoContract] class FileTimeStamp{[ProtoMember(1)] public     uploadTime  {get;set;} int = 0;
        [ProtoMember(2)] public     fileId  {get;set;} string = "";
    }

    [ProtoContract] class GetFileCountReqBody{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     appId  {get;set;} int = 0;
        [ProtoMember(3)] public     busId  {get;set;} int = 0;
    }

    [ProtoContract] class GetFileCountRspBody{[ProtoMember(1)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(2)] public     retMsg  {get;set;} string = "";
        [ProtoMember(3)] public     clientWording  {get;set;} string = "";
        [ProtoMember(4)] public     allFileCount  {get;set;} int = 0;
        [ProtoMember(5)] public     boolFileTooMany  {get;set;} bool = false;
        [ProtoMember(6)] public     limitCount  {get;set;} int = 0;
        [ProtoMember(7)] public     boolIsFull  {get;set;} bool = false;
    }

    [ProtoContract] class GetFileInfoReqBody{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     appId  {get;set;} int = 0;
        [ProtoMember(3)] public     busId  {get;set;} int = 0;
        [ProtoMember(4)] public     fileId  {get;set;} string = "";
        [ProtoMember(5)] public     fieldFlag  {get;set;} int = 16777215;
    }

    [ProtoContract] class GetFileInfoRspBody{[ProtoMember(1)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(2)] public     retMsg  {get;set;} string = "";
        [ProtoMember(3)] public     clientWording  {get;set;} string = "";
        [ProtoMember(4)] public     fileInfo  {get;set;} GroupFileCommon.FileInfo? = null;
    }

    [ProtoContract] class GetFileListReqBody{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     appId  {get;set;} int = 0;
        [ProtoMember(3)] public     folderId  {get;set;} string = "";
        [ProtoMember(4)] public     startTimestamp  {get;set;} FileTimeStamp? = null;
        [ProtoMember(5)] public     fileCount  {get;set;} int = 0;
        [ProtoMember(6)] public     maxTimestamp  {get;set;} FileTimeStamp? = null;
        [ProtoMember(7)] public     allFileCount  {get;set;} int = 0;
        [ProtoMember(8)] public     reqFrom  {get;set;} int = 0;
        [ProtoMember(9)] public     sortBy  {get;set;} int = 0;
        [ProtoMember(10)] public     filterCode  {get;set;} int = 0;
        [ProtoMember(11)] public     uin  {get;set;} long = 0L;
        [ProtoMember(12)] public     fieldFlag  {get;set;} int = 16777215;
        [ProtoMember(13)] public     startIndex  {get;set;} int = 0;
        [ProtoMember(14)] public     context  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(15)] public     clientVersion  {get;set;} int = 0;
        [ProtoMember(16)] public     whiteList  {get;set;} int = 0;
        [ProtoMember(17)] public     sortOrder  {get;set;} int = 0;
        [ProtoMember(18)] public     showOnlinedocFolder  {get;set;} int = 0;
    }

    [ProtoContract] class GetFileListRspBody{[ProtoMember(1)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(2)] public     retMsg  {get;set;} string = "";
        [ProtoMember(3)] public     clientWording  {get;set;} string = "";
        [ProtoMember(4)] public     boolIsEnd  {get;set;} bool = false;
        [ProtoMember(5)] public     itemList  {get;set;} List<Item> = new();
        [ProtoMember(6)] public     msgMaxTimestamp  {get;set;} FileTimeStamp? = null;
        [ProtoMember(7)] public     allFileCount  {get;set;} int = 0;
        [ProtoMember(8)] public     filterCode  {get;set;} int = 0;
        [ProtoMember(11)] public     boolSafeCheckFlag  {get;set;} bool = false;
        [ProtoMember(12)] public     safeCheckRes  {get;set;} int = 0;
        [ProtoMember(13)] public     nextIndex  {get;set;} int = 0;
        [ProtoMember(14)] public     context  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(15)] public     role  {get;set;} int = 0;
        [ProtoMember(16)] public     openFlag  {get;set;} int = 0;
    } {
        [ProtoContract]
        internal class Item(
            [ProtoMember(1)] public     type  {get;set;} int = 0; // folder=2;
            [ProtoMember(2)] public     folderInfo  {get;set;} GroupFileCommon.FolderInfo? = null;
            [ProtoMember(3)] public     fileInfo  {get;set;} GroupFileCommon.FileInfo? = null;
        } {
            val id get() = fileInfo?.fileId ?  {get;set;} folderInfo?.folderId
            val name get() = fileInfo?.fileName ?  {get;set;} folderInfo?.folderName
        }
    }

    [ProtoContract] class GetFilePreviewReqBody{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     appId  {get;set;} int = 0;
        [ProtoMember(3)] public     busId  {get;set;} int = 0;
        [ProtoMember(4)] public     fileId  {get;set;} string = "";
    }

    [ProtoContract] class GetFilePreviewRspBody{[ProtoMember(1)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(2)] public     retMsg  {get;set;} string = "";
        [ProtoMember(3)] public     clientWording  {get;set;} string = "";
        [ProtoMember(4)] public     int32ServerIp  {get;set;} int = 0;
        [ProtoMember(5)] public     int32ServerPort  {get;set;} int = 0;
        [ProtoMember(6)] public     downloadDns  {get;set;} string = "";
        [ProtoMember(7)] public     downloadUrl  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(8)] public     cookieVal  {get;set;} string = "";
        [ProtoMember(9)] public     reservedField  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(10)] public     downloadDnsHttps  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(11)] public     previewPortHttps  {get;set;} int = 0;
    }

    [ProtoContract] class GetSpaceReqBody{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     appId  {get;set;} int = 0;
    }

    [ProtoContract] class GetSpaceRspBody{[ProtoMember(1)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(2)] public     retMsg  {get;set;} string = "";
        [ProtoMember(3)] public     clientWording  {get;set;} string = "";
        [ProtoMember(4)] public     totalSpace  {get;set;} long = 0L;
        [ProtoMember(5)] public     usedSpace  {get;set;} long = 0L;
        [ProtoMember(6)] public     boolAllUpload  {get;set;} bool = false;
    }

    [ProtoContract] class ReqBody{[ProtoMember(1)] public     fileInfoReq  {get;set;} GetFileInfoReqBody? = null;
        [ProtoMember(2)] public     fileListInfoReq  {get;set;} GetFileListReqBody? = null;
        [ProtoMember(3)] public     groupFileCntReq  {get;set;} GetFileCountReqBody? = null;
        [ProtoMember(4)] public     groupSpaceReq  {get;set;} GetSpaceReqBody? = null;
        [ProtoMember(5)] public     filePreviewReq  {get;set;} GetFilePreviewReqBody? = null;
    }

    [ProtoContract] class RspBody{[ProtoMember(1)] public     fileInfoRsp  {get;set;} GetFileInfoRspBody? = null;
        [ProtoMember(2)] public     fileListInfoRsp  {get;set;} GetFileListRspBody? = null;
        [ProtoMember(3)] public     groupFileCntRsp  {get;set;} GetFileCountRspBody? = null;
        [ProtoMember(4)] public     groupSpaceRsp  {get;set;} GetSpaceRspBody? = null;
        [ProtoMember(5)] public     filePreviewRsp  {get;set;} GetFilePreviewRspBody? = null;
    }
}
