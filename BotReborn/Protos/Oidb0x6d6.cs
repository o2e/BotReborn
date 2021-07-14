







using ProtoBuf;

import net.mamoe.mirai.internal.network.protocol.packet.chat.CheckableStruct



internal class Oidb0x6d6  {
    [ProtoContract] class DeleteFileReqBody{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     appId  {get;set;} int = 0;
        [ProtoMember(3)] public     busId  {get;set;} int = 0;
        [ProtoMember(4)] public     parentFolderId  {get;set;} string = "";
        [ProtoMember(5)] public     fileId  {get;set;} string = "";
        [ProtoMember(6)] public     msgdbSeq  {get;set;} int = 0;
        [ProtoMember(7)] public     msgRand  {get;set;} int = 0;
    }

    [ProtoContract] class DeleteFileRspBody(
        /**
         * -103  {get;set;} file not exist
         */
       [ProtoMember(1) override val int32RetCode  {get;set;} int = 0;
       [ProtoMember(2) override val retMsg  {get;set;} string = "";
        [ProtoMember(3)] public     clientWording  {get;set;} string = "";
    }; CheckableStruct

    [ProtoContract] class DownloadFileReqBody{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     appId  {get;set;} int = 0;
        [ProtoMember(3)] public     busId  {get;set;} int = 0;
        [ProtoMember(4)] public     fileId  {get;set;} string = "";
        [ProtoMember(5)] public     boolThumbnailReq  {get;set;} bool = false;
        [ProtoMember(6)] public     urlType  {get;set;} int = 0;
        [ProtoMember(7)] public     boolPreviewReq  {get;set;} bool = false;
        [ProtoMember(8)] public     src  {get;set;} int = 0;
    }

    [ProtoContract] class DownloadFileRspBody(
       [ProtoMember(1) override val int32RetCode  {get;set;} int = 0;
       [ProtoMember(2) override val retMsg  {get;set;} string = "";
        [ProtoMember(3)] public     clientWording  {get;set;} string = "";
        [ProtoMember(4)] public     downloadIp  {get;set;} string = "";
        [ProtoMember(5)] public     downloadDns  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(6)] public     downloadUrl  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(7)] public     sha  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(8)] public     sha3  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(9)] public     md5  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(10)] public     cookieVal  {get;set;} string = "";
        [ProtoMember(11)] public     saveFileName  {get;set;} string = "";
        [ProtoMember(12)] public     previewPort  {get;set;} int = 0;
        [ProtoMember(13)] public     downloadDnsHttps  {get;set;} string = "";
        [ProtoMember(14)] public     previewPortHttps  {get;set;} int = 0;
    }; CheckableStruct

    [ProtoContract] class MoveFileReqBody{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     appId  {get;set;} int = 0;
        [ProtoMember(3)] public     busId  {get;set;} int = 0;
        [ProtoMember(4)] public     fileId  {get;set;} string = "";
        [ProtoMember(5)] public     parentFolderId  {get;set;} string = "";
        [ProtoMember(6)] public     destFolderId  {get;set;} string = "";
    }

    [ProtoContract] class MoveFileRspBody(
       [ProtoMember(1) override val int32RetCode  {get;set;} int = 0;
       [ProtoMember(2) override val retMsg  {get;set;} string = "";
        [ProtoMember(3)] public     clientWording  {get;set;} string = "";
        [ProtoMember(4)] public     parentFolderId  {get;set;} string = "";
    }; CheckableStruct

    [ProtoContract] class RenameFileReqBody{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     appId  {get;set;} int = 0;
        [ProtoMember(3)] public     busId  {get;set;} int = 0;
        [ProtoMember(4)] public     fileId  {get;set;} string = "";
        [ProtoMember(5)] public     parentFolderId  {get;set;} string = "";
        [ProtoMember(6)] public     newFileName  {get;set;} string = "";
    }

    [ProtoContract] class RenameFileRspBody(
       [ProtoMember(1) override val int32RetCode  {get;set;} int = 0;
       [ProtoMember(2) override val retMsg  {get;set;} string = "";
        [ProtoMember(3)] public     clientWording  {get;set;} string = "";
    }; CheckableStruct

    [ProtoContract] class ReqBody{[ProtoMember(1)] public     uploadFileReq  {get;set;} UploadFileReqBody? = null;
        [ProtoMember(2)] public     resendFileReq  {get;set;} ResendReqBody? = null;
        [ProtoMember(3)] public     downloadFileReq  {get;set;} DownloadFileReqBody? = null;
        [ProtoMember(4)] public     deleteFileReq  {get;set;} DeleteFileReqBody? = null;
        [ProtoMember(5)] public     renameFileReq  {get;set;} RenameFileReqBody? = null;
        [ProtoMember(6)] public     moveFileReq  {get;set;} MoveFileReqBody? = null;
    }

    [ProtoContract] class ResendReqBody{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     appId  {get;set;} int = 0;
        [ProtoMember(3)] public     busId  {get;set;} int = 0;
        [ProtoMember(4)] public     fileId  {get;set;} string = "";
        [ProtoMember(5)] public     sha  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class ResendRspBody(
       [ProtoMember(1) override val int32RetCode  {get;set;} int = 0;
       [ProtoMember(2) override val retMsg  {get;set;} string = "";
        [ProtoMember(3)] public     clientWording  {get;set;} string = "";
        [ProtoMember(4)] public     uploadIp  {get;set;} string = "";
        [ProtoMember(5)] public     fileKey  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(6)] public     checkKey  {get;set;} byte[] = Array.Empty<byte>();
    }; CheckableStruct

    [ProtoContract] class RspBody{[ProtoMember(1)] public     uploadFileRsp  {get;set;} UploadFileRspBody? = null;
        [ProtoMember(2)] public     resendFileRsp  {get;set;} ResendRspBody? = null;
        [ProtoMember(3)] public     downloadFileRsp  {get;set;} DownloadFileRspBody? = null;
        [ProtoMember(4)] public     deleteFileRsp  {get;set;} DeleteFileRspBody? = null;
        [ProtoMember(5)] public     renameFileRsp  {get;set;} RenameFileRspBody? = null;
        [ProtoMember(6)] public     moveFileRsp  {get;set;} MoveFileRspBody? = null;
    }

    [ProtoContract] class UploadFileReqBody{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     appId  {get;set;} int = 0;
        [ProtoMember(3)] public     busId  {get;set;} int = 0;
        [ProtoMember(4)] public     entrance  {get;set;} int = 0;
        [ProtoMember(5)] public     parentFolderId  {get;set;} string = "";
        [ProtoMember(6)] public     fileName  {get;set;} string = "";
        [ProtoMember(7)] public     localPath  {get;set;} string = "";
        [ProtoMember(8)] public     fileSize  {get;set;} long = 0L;
        [ProtoMember(9)] public     sha  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(10)] public     sha3  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(11)] public     md5  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(15)] public     boolSupportMultiUpload  {get;set;} bool = false;
    }

    [ProtoContract] class UploadFileRspBody(
       [ProtoMember(1) override val int32RetCode  {get;set;} int = 0;
       [ProtoMember(2) override val retMsg  {get;set;} string = "";
        [ProtoMember(3)] public     clientWording  {get;set;} string = "";
        [ProtoMember(4)] public     uploadIp  {get;set;} string = "";
        [ProtoMember(5)] public     serverDns  {get;set;} string = "";
        [ProtoMember(6)] public     busId  {get;set;} int = 0;
        [ProtoMember(7)] public     fileId  {get;set;} string = "";
        [ProtoMember(8)] public     fileKey  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(9)] public     checkKey  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(10)] public     boolFileExist  {get;set;} bool = false;
        [ProtoMember(12)] public     uploadIpLanV4  {get;set;} List<String> = new();
        [ProtoMember(13)] public     uploadIpLanV6  {get;set;} List<String> = new();
        [ProtoMember(14)] public     uploadPort  {get;set;} int = 0;
    }; CheckableStruct
}
