
using System;
using System.Collections.Generic;
using ProtoBuf;

[ProtoContract] class Cmd0x346  {
    [ProtoContract] class AddrList{[ProtoMember(2)] public List<string> strIp  {get;set;}  = new();
        [ProtoMember(3)] public string strDomain  {get;set;}  = "";
        [ProtoMember(4)] public int port  {get;set;} = 0;
    }

    [ProtoContract] class ApplyCleanTrafficRsp{
        [ProtoMember(10)] public int int32RetCode  {get;set;} = 0;
        [ProtoMember(20)] public string retMsg  {get;set;}  = "";
    }

    [ProtoContract] class ApplyCopyFromReq{[ProtoMember(10)] public     srcUin  {get;set;} long = 0L;
        [ProtoMember(20)] public     srcGroup  {get;set;} long = 0L;
        [ProtoMember(30)] public     srcSvcid  {get;set;} int = 0;
        [ProtoMember(40)] public     srcParentfolder  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(50)] public     srcUuid  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(60)] public     fileMd5  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(70)] public     dstUin  {get;set;} long = 0L;
        [ProtoMember(80)] public     fileSize  {get;set;} long = 0L;
        [ProtoMember(90)] public     fileName  {get;set;} string = "";
        [ProtoMember(100)] public     dangerLevel  {get;set;} int = 0;
        [ProtoMember(110)] public     totalSpace  {get;set;} long = 0L;
    }

    [ProtoContract] class ApplyCopyFromRsp{[ProtoMember(10)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(20)] public     retMsg  {get;set;} string = "";
        [ProtoMember(30)] public     uuid  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(40)] public     totalSpace  {get;set;} long = 0L;
    }

    [ProtoContract] class ApplyCopyToReq{[ProtoMember(10)] public     dstId  {get;set;} long = 0L;
        [ProtoMember(20)] public     dstUin  {get;set;} long = 0L;
        [ProtoMember(30)] public     dstSvcid  {get;set;} int = 0;
        [ProtoMember(40)] public     srcUin  {get;set;} long = 0L;
        [ProtoMember(50)] public     fileSize  {get;set;} long = 0L;
        [ProtoMember(60)] public     fileName  {get;set;} string = "";
        [ProtoMember(70)] public     localFilepath  {get;set;} string = "";
        [ProtoMember(80)] public     uuid  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class ApplyCopyToRsp{[ProtoMember(10)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(20)] public     retMsg  {get;set;} string = "";
        [ProtoMember(30)] public     fileKey  {get;set;} string = "";
    }

    [ProtoContract] class ApplyDownloadAbsReq{[ProtoMember(10)] public     uin  {get;set;} long = 0L;
        [ProtoMember(20)] public     uuid  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class ApplyDownloadAbsRsp{[ProtoMember(10)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(20)] public     retMsg  {get;set;} string = "";
        [ProtoMember(30)] public     msgDownloadInfo  {get;set;} Cmd0x346.DownloadInfo? = null;
    }

    [ProtoContract] class ApplyDownloadReq{[ProtoMember(10)] public     uin  {get;set;} long = 0L;
        [ProtoMember(20)] public     uuid  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(30)] public     ownerType  {get;set;} int = 0;
        [ProtoMember(500)] public     extUintype  {get;set;} int = 0;
        [ProtoMember(501)] public     needHttpsUrl  {get;set;} int = 0;
    }

    [ProtoContract] class ApplyDownloadRsp{[ProtoMember(10)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(20)] public     retMsg  {get;set;} string = "";
        [ProtoMember(30)] public     msgDownloadInfo  {get;set;} Cmd0x346.DownloadInfo? = null;
        [ProtoMember(40)] public     msgFileInfo  {get;set;} Cmd0x346.FileInfo? = null;
    }

    [ProtoContract] class ApplyForwardFileReq{[ProtoMember(10)] public     senderUin  {get;set;} long = 0L;
        [ProtoMember(20)] public     recverUin  {get;set;} long = 0L;
        [ProtoMember(30)] public     uuid  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(40)] public     dangerLevel  {get;set;} int = 0;
        [ProtoMember(50)] public     totalSpace  {get;set;} long = 0L;
    }

    [ProtoContract] class ApplyForwardFileRsp{[ProtoMember(10)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(20)] public     retMsg  {get;set;} string = "";
        [ProtoMember(30)] public     totalSpace  {get;set;} long = 0L;
        [ProtoMember(40)] public     usedSpace  {get;set;} long = 0L;
        [ProtoMember(50)] public     uuid  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class ApplyGetTrafficReq 

    [ProtoContract] class ApplyGetTrafficRsp{[ProtoMember(10)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(20)] public     retMsg  {get;set;} string = "";
        [ProtoMember(30)] public     useFileSize  {get;set;} long = 0L;
        [ProtoMember(40)] public     useFileNum  {get;set;} int = 0;
        [ProtoMember(50)] public     allFileSize  {get;set;} long = 0L;
        [ProtoMember(60)] public     allFileNum  {get;set;} int = 0;
    }

    [ProtoContract] class ApplyListDownloadReq{[ProtoMember(10)] public     uin  {get;set;} long = 0L;
        [ProtoMember(20)] public     beginIndex  {get;set;} int = 0;
        [ProtoMember(30)] public     reqCount  {get;set;} int = 0;
    }

    [ProtoContract] class ApplyListDownloadRsp{[ProtoMember(10)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(20)] public     retMsg  {get;set;} string = "";
        [ProtoMember(30)] public     totalCount  {get;set;} int = 0;
        [ProtoMember(40)] public     beginIndex  {get;set;} int = 0;
        [ProtoMember(50)] public     rspCount  {get;set;} int = 0;
        [ProtoMember(60)] public     isEnd  {get;set;} int = 0;
        [ProtoMember(70)] public     msgFileList  {get;set;} List<Cmd0x346.FileInfo> = new();
    }

    [ProtoContract] class ApplyUploadHitReq{[ProtoMember(10)] public     senderUin  {get;set;} long = 0L;
        [ProtoMember(20)] public     recverUin  {get;set;} long = 0L;
        [ProtoMember(30)] public     fileSize  {get;set;} long = 0L;
        [ProtoMember(40)] public     fileName  {get;set;} string = "";
        [ProtoMember(50)] public     _10mMd5  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(60)] public     localFilepath  {get;set;} string = "";
        [ProtoMember(70)] public     dangerLevel  {get;set;} int = 0;
        [ProtoMember(80)] public     totalSpace  {get;set;} long = 0L;
    }

    [ProtoContract] class ApplyUploadHitReqV2{[ProtoMember(10)] public     senderUin  {get;set;} long = 0L;
        [ProtoMember(20)] public     recverUin  {get;set;} long = 0L;
        [ProtoMember(30)] public     fileSize  {get;set;} long = 0L;
        [ProtoMember(40)] public     fileName  {get;set;} string = "";
        [ProtoMember(50)] public     _10mMd5  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(60)] public     _3sha  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(70)] public     sha  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(80)] public     localFilepath  {get;set;} string = "";
        [ProtoMember(90)] public     dangerLevel  {get;set;} int = 0;
        [ProtoMember(100)] public     totalSpace  {get;set;} long = 0L;
    }

    [ProtoContract] class ApplyUploadHitReqV3{[ProtoMember(10)] public     senderUin  {get;set;} long = 0L;
        [ProtoMember(20)] public     recverUin  {get;set;} long = 0L;
        [ProtoMember(30)] public     fileSize  {get;set;} long = 0L;
        [ProtoMember(40)] public     fileName  {get;set;} string = "";
        [ProtoMember(50)] public     _10mMd5  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(60)] public     sha  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(70)] public     localFilepath  {get;set;} string = "";
        [ProtoMember(80)] public     dangerLevel  {get;set;} int = 0;
        [ProtoMember(90)] public     totalSpace  {get;set;} long = 0L;
    }

    [ProtoContract] class ApplyUploadHitRsp{[ProtoMember(10)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(20)] public     retMsg  {get;set;} string = "";
        [ProtoMember(30)] public     uploadIp  {get;set;} string = "";
        [ProtoMember(40)] public     uploadPort  {get;set;} int = 0;
        [ProtoMember(50)] public     uploadDomain  {get;set;} string = "";
        [ProtoMember(60)] public     uuid  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(70)] public     uploadKey  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(80)] public     totalSpace  {get;set;} long = 0L;
        [ProtoMember(90)] public     usedSpace  {get;set;} long = 0L;
        [ProtoMember(100)] public     uploadDns  {get;set;} string = "";
    }

    [ProtoContract] class ApplyUploadHitRspV2{[ProtoMember(10)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(20)] public     retMsg  {get;set;} string = "";
        [ProtoMember(30)] public     uploadIp  {get;set;} string = "";
        [ProtoMember(40)] public     uploadPort  {get;set;} int = 0;
        [ProtoMember(50)] public     uploadDomain  {get;set;} string = "";
        [ProtoMember(60)] public     uuid  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(70)] public     uploadKey  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(80)] public     totalSpace  {get;set;} long = 0L;
        [ProtoMember(90)] public     usedSpace  {get;set;} long = 0L;
        [ProtoMember(100)] public     uploadHttpsPort  {get;set;} int = 443;
        [ProtoMember(110)] public     uploadHttpsDomain  {get;set;} string = "";
        [ProtoMember(120)] public     uploadDns  {get;set;} string = "";
    }

    [ProtoContract] class ApplyUploadHitRspV3{[ProtoMember(10)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(20)] public     retMsg  {get;set;} string = "";
        [ProtoMember(30)] public     uploadIp  {get;set;} string = "";
        [ProtoMember(40)] public     uploadPort  {get;set;} int = 0;
        [ProtoMember(50)] public     uploadDomain  {get;set;} string = "";
        [ProtoMember(60)] public     uuid  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(70)] public     uploadKey  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(80)] public     totalSpace  {get;set;} long = 0L;
        [ProtoMember(90)] public     usedSpace  {get;set;} long = 0L;
        [ProtoMember(100)] public     uploadDns  {get;set;} string = "";
    }

    [ProtoContract] class ApplyUploadReq{[ProtoMember(10)] public     senderUin  {get;set;} long = 0L;
        [ProtoMember(20)] public     recverUin  {get;set;} long = 0L;
        [ProtoMember(30)] public     fileType  {get;set;} int = 0;
        [ProtoMember(40)] public     fileSize  {get;set;} long = 0L;
        [ProtoMember(50)] public     fileName  {get;set;} byte[] = Array.Empty<byte>(); //String = "";
        [ProtoMember(60)] public     _10mMd5  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(70)] public     localFilepath  {get;set;} string = "";
        [ProtoMember(80)] public     dangerLevel  {get;set;} int = 0;
        [ProtoMember(90)] public     totalSpace  {get;set;} long = 0L;
    }

    [ProtoContract] class ApplyUploadReqV2{[ProtoMember(10)] public     senderUin  {get;set;} long = 0L;
        [ProtoMember(20)] public     recverUin  {get;set;} long = 0L;
        [ProtoMember(30)] public     fileSize  {get;set;} long = 0L;
        [ProtoMember(40)] public     fileName  {get;set;} string = "";
        [ProtoMember(50)] public     _10mMd5  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(60)] public     _3sha  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(70)] public     localFilepath  {get;set;} string = "";
        [ProtoMember(80)] public     dangerLevel  {get;set;} int = 0;
        [ProtoMember(90)] public     totalSpace  {get;set;} long = 0L;
    }

    [ProtoContract] class ApplyUploadReqV3{[ProtoMember(10)] public     senderUin  {get;set;} long = 0L;
        [ProtoMember(20)] public     recverUin  {get;set;} long = 0L;
        [ProtoMember(30)] public     fileSize  {get;set;} long = 0L;
        [ProtoMember(40)] public     fileName  {get;set;} string = "";
        [ProtoMember(50)] public     _10mMd5  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(60)] public     sha  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(70)] public     localFilepath  {get;set;} string = "";
        [ProtoMember(80)] public     dangerLevel  {get;set;} int = 0;
        [ProtoMember(90)] public     totalSpace  {get;set;} long = 0L;
    }

    [ProtoContract] class ApplyUploadRsp{[ProtoMember(10)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(20)] public     retMsg  {get;set;} string = "";
        [ProtoMember(30)] public     totalSpace  {get;set;} long = 0L;
        [ProtoMember(40)] public     usedSpace  {get;set;} long = 0L;
        [ProtoMember(50)] public     uploadedSize  {get;set;} long = 0L;
        [ProtoMember(60)] public     uploadIp  {get;set;} string = "";
        [ProtoMember(70)] public     uploadDomain  {get;set;} string = "";
        [ProtoMember(80)] public     uploadPort  {get;set;} int = 0;
        [ProtoMember(90)] public     uuid  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(100)] public     uploadKey  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(110)] public     boolFileExist  {get;set;} bool = false;
        [ProtoMember(120)] public     packSize  {get;set;} int = 0;
        [ProtoMember(130)] public     strUploadipList  {get;set;} List<String> = new();
        [ProtoMember(140)] public     uploadDns  {get;set;} string = "";
    }

    [ProtoContract] class ApplyUploadRspV2{[ProtoMember(10)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(20)] public     retMsg  {get;set;} string = "";
        [ProtoMember(30)] public     totalSpace  {get;set;} long = 0L;
        [ProtoMember(40)] public     usedSpace  {get;set;} long = 0L;
        [ProtoMember(50)] public     uploadedSize  {get;set;} long = 0L;
        [ProtoMember(60)] public     uploadIp  {get;set;} string = "";
        [ProtoMember(70)] public     uploadDomain  {get;set;} string = "";
        [ProtoMember(80)] public     uploadPort  {get;set;} int = 0;
        [ProtoMember(90)] public     uuid  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(100)] public     uploadKey  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(110)] public     boolFileExist  {get;set;} bool = false;
        [ProtoMember(120)] public     packSize  {get;set;} int = 0;
        [ProtoMember(130)] public     strUploadipList  {get;set;} List<String> = new();
        [ProtoMember(140)] public     httpsvrApiVer  {get;set;} int = 0;
        [ProtoMember(141)] public     sha  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(142)] public     uploadHttpsPort  {get;set;} int = 443;
        [ProtoMember(143)] public     uploadHttpsDomain  {get;set;} string = "";
        [ProtoMember(150)] public     uploadDns  {get;set;} string = "";
        [ProtoMember(160)] public     uploadLanip  {get;set;} string = "";
    }

    [ProtoContract] class ApplyUploadRspV3{[ProtoMember(10)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(20)] public     retMsg  {get;set;} string = "";
        [ProtoMember(30)] public     totalSpace  {get;set;} long = 0L;
        [ProtoMember(40)] public     usedSpace  {get;set;} long = 0L;
        [ProtoMember(50)] public     uploadedSize  {get;set;} long = 0L;
        [ProtoMember(60)] public     uploadIp  {get;set;} string = "";
        [ProtoMember(70)] public     uploadDomain  {get;set;} string = "";
        [ProtoMember(80)] public     uploadPort  {get;set;} int = 0;
        [ProtoMember(90)] public     uuid  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(100)] public     uploadKey  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(110)] public     boolFileExist  {get;set;} bool = false;
        [ProtoMember(120)] public     packSize  {get;set;} int = 0;
        [ProtoMember(130)] public     strUploadipList  {get;set;} List<String> = new();
        [ProtoMember(140)] public     uploadHttpsPort  {get;set;} int = 443;
        [ProtoMember(150)] public     uploadHttpsDomain  {get;set;} string = "";
        [ProtoMember(160)] public     uploadDns  {get;set;} string = "";
        [ProtoMember(170)] public     uploadLanip  {get;set;} string = "";
    }

    [ProtoContract] class DeleteFileReq{[ProtoMember(10)] public     uin  {get;set;} long = 0L;
        [ProtoMember(20)] public     peerUin  {get;set;} long = 0L;
        [ProtoMember(30)] public     deleteType  {get;set;} int = 0;
        [ProtoMember(40)] public     uuid  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class DeleteFileRsp{[ProtoMember(10)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(20)] public     retMsg  {get;set;} string = "";
    }

    [ProtoContract] class DelMessageReq{[ProtoMember(1)] public     uinSender  {get;set;} long = 0L;
        [ProtoMember(2)] public     uinReceiver  {get;set;} long = 0L;
        [ProtoMember(10)] public     msgTime  {get;set;} int = 0;
        [ProtoMember(20)] public     msgRandom  {get;set;} int = 0;
        [ProtoMember(30)] public     msgSeqNo  {get;set;} int = 0;
    }

    [ProtoContract] class DownloadInfo{[ProtoMember(10)] public     downloadKey  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(20)] public     downloadIp  {get;set;} string = "";
        [ProtoMember(30)] public     downloadDomain  {get;set;} string = "";
        [ProtoMember(40)] public     port  {get;set;} int = 0;
        [ProtoMember(50)] public     downloadUrl  {get;set;} string = "";
        [ProtoMember(60)] public     strDownloadipList  {get;set;} List<String> = new();
        [ProtoMember(70)] public     cookie  {get;set;} string = "";
        [ProtoMember(80)] public     httpsPort  {get;set;} int = 443;
        [ProtoMember(90)] public     httpsDownloadDomain  {get;set;} string = "";
        [ProtoMember(110)] public     downloadDns  {get;set;} string = "";
    }

    [ProtoContract] class DownloadSuccReq{[ProtoMember(10)] public     uin  {get;set;} long = 0L;
        [ProtoMember(20)] public     uuid  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class DownloadSuccRsp{[ProtoMember(10)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(20)] public     retMsg  {get;set;} string = "";
        [ProtoMember(30)] public     int32DownStat  {get;set;} int = 0;
    }

    [ProtoContract] class ExtensionReq{[ProtoMember(1)] public     id  {get;set;} long = 0L;
        [ProtoMember(2)] public     type  {get;set;} long = 0L;
        [ProtoMember(3)] public     dstPhonenum  {get;set;} string = "";
        [ProtoMember(4)] public     int32PhoneConvertType  {get;set;} int = 0;
        [ProtoMember(20)] public     sig  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(100)] public     routeId  {get;set;} long = 0L;
        [ProtoMember(90100)] public     msgDelMessageReq  {get;set;} Cmd0x346.DelMessageReq? = null;
        [ProtoMember(90200)] public     downloadUrlType  {get;set;} int = 0;
        [ProtoMember(90300)] public     pttFormat  {get;set;} int = 0;
        [ProtoMember(90400)] public     isNeedInnerIp  {get;set;} int = 0;
        [ProtoMember(90500)] public     netType  {get;set;} int = 255;
        [ProtoMember(90600)] public     voiceType  {get;set;} int = 0;
        [ProtoMember(90700)] public     fileType  {get;set;} int = 0;
        [ProtoMember(90800)] public     pttTime  {get;set;} int = 0;
        [ProtoMember(90900)] public     bdhCmdid  {get;set;} int = 0;
        [ProtoMember(91000)] public     reqTransferType  {get;set;} int = 0;
        [ProtoMember(91100)] public     isAuto  {get;set;} int = 0;
    }

    [ProtoContract] class ExtensionRsp{[ProtoMember(1)] public     transferType  {get;set;} int = 0;
        [ProtoMember(2)] public     channelType  {get;set;} int = 0;
        [ProtoMember(3)] public     allowRetry  {get;set;} int = 0;
        [ProtoMember(4)] public     serverAddrIpv6List  {get;set;} Cmd0x346.AddrList? = null;
    }

    [ProtoContract] class FileInfo{[ProtoMember(1)] public     uin  {get;set;} long = 0L;
        [ProtoMember(2)] public     dangerEvel  {get;set;} int = 0;
        [ProtoMember(3)] public     fileSize  {get;set;} long = 0L;
        [ProtoMember(4)] public     lifeTime  {get;set;} int = 0;
        [ProtoMember(5)] public     uploadTime  {get;set;} int = 0;
        [ProtoMember(6)] public     uuid  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(7)] public     fileName  {get;set;} string = "";
        [ProtoMember(90)] public     absFileType  {get;set;} int = 0;
        [ProtoMember(100)] public     _10mMd5  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(101)] public     sha  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(110)] public     clientType  {get;set;} int = 0;
        [ProtoMember(120)] public     ownerUin  {get;set;} long = 0L;
        [ProtoMember(121)] public     peerUin  {get;set;} long = 0L;
        [ProtoMember(130)] public     expireTime  {get;set;} int = 0;
    }

    [ProtoContract] class FileQueryReq{[ProtoMember(10)] public     uin  {get;set;} long = 0L;
        [ProtoMember(20)] public     uuid  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class FileQueryRsp{[ProtoMember(10)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(20)] public     retMsg  {get;set;} string = "";
        [ProtoMember(30)] public     msgFileInfo  {get;set;} Cmd0x346.FileInfo? = null;
    }

    [ProtoContract] class RecallFileReq{[ProtoMember(1)] public     uin  {get;set;} long = 0L;
        [ProtoMember(2)] public     uuid  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class RecallFileRsp{[ProtoMember(1)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(2)] public     retMsg  {get;set;} string = "";
    }

    [ProtoContract] class RecvListQueryReq{[ProtoMember(1)] public     uin  {get;set;} long = 0L;
        [ProtoMember(2)] public     beginIndex  {get;set;} int = 0;
        [ProtoMember(3)] public     reqCount  {get;set;} int = 0;
    }

    [ProtoContract] class RecvListQueryRsp{[ProtoMember(1)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(2)] public     retMsg  {get;set;} string = "";
        [ProtoMember(3)] public     fileTotCount  {get;set;} int = 0;
        [ProtoMember(4)] public     beginIndex  {get;set;} int = 0;
        [ProtoMember(5)] public     rspFileCount  {get;set;} int = 0;
        [ProtoMember(6)] public     isEnd  {get;set;} int = 0;
        [ProtoMember(7)] public     msgFileList  {get;set;} List<Cmd0x346.FileInfo> = new();
    }

    [ProtoContract] class RenewFileReq{[ProtoMember(1)] public     uin  {get;set;} long = 0L;
        [ProtoMember(2)] public     uuid  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(3)] public     addTtl  {get;set;} int = 0;
    }

    [ProtoContract] class RenewFileRsp{[ProtoMember(1)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(2)] public     retMsg  {get;set;} string = "";
    }

    [ProtoContract] class ReqBody{[ProtoMember(1)] public     cmd  {get;set;} int = 0;
        [ProtoMember(2)] public     seq  {get;set;} int = 0;
        [ProtoMember(3)] public     msgRecvListQueryReq  {get;set;} Cmd0x346.RecvListQueryReq? = null;
        [ProtoMember(4)] public     msgSendListQueryReq  {get;set;} Cmd0x346.SendListQueryReq? = null;
        [ProtoMember(5)] public     msgRenewFileReq  {get;set;} Cmd0x346.RenewFileReq? = null;
        [ProtoMember(6)] public     msgRecallFileReq  {get;set;} Cmd0x346.RecallFileReq? = null;
        [ProtoMember(7)] public     msgApplyUploadReq  {get;set;} Cmd0x346.ApplyUploadReq? = null;
        [ProtoMember(8)] public     msgApplyUploadHitReq  {get;set;} Cmd0x346.ApplyUploadHitReq? = null;
        [ProtoMember(9)] public     msgApplyForwardFileReq  {get;set;} Cmd0x346.ApplyForwardFileReq? = null;
        [ProtoMember(10)] public     msgUploadSuccReq  {get;set;} Cmd0x346.UploadSuccReq? = null;
        [ProtoMember(11)] public     msgDeleteFileReq  {get;set;} Cmd0x346.DeleteFileReq? = null;
        [ProtoMember(12)] public     msgDownloadSuccReq  {get;set;} Cmd0x346.DownloadSuccReq? = null;
        [ProtoMember(13)] public     msgApplyDownloadAbsReq  {get;set;} Cmd0x346.ApplyDownloadAbsReq? = null;
        [ProtoMember(14)] public     msgApplyDownloadReq  {get;set;} Cmd0x346.ApplyDownloadReq? = null;
        [ProtoMember(15)] public     msgApplyListDownloadReq  {get;set;} Cmd0x346.ApplyListDownloadReq? = null;
        [ProtoMember(16)] public     msgFileQueryReq  {get;set;} Cmd0x346.FileQueryReq? = null;
        [ProtoMember(17)] public     msgApplyCopyFromReq  {get;set;} Cmd0x346.ApplyCopyFromReq? = null;
        [ProtoMember(18)] public     msgApplyUploadReqV2  {get;set;} Cmd0x346.ApplyUploadReqV2? = null;
        [ProtoMember(19)] public     msgApplyUploadReqV3  {get;set;} Cmd0x346.ApplyUploadReqV3? = null;
        [ProtoMember(20)] public     msgApplyUploadHitReqV2  {get;set;} Cmd0x346.ApplyUploadHitReqV2? = null;
        [ProtoMember(21)] public     msgApplyUploadHitReqV3  {get;set;} Cmd0x346.ApplyUploadHitReqV3? = null;
        [ProtoMember(101)] public     businessId  {get;set;} int = 0;
        [ProtoMember(102)] public     clientType  {get;set;} int = 0;
        [ProtoMember(90000)] public     msgApplyCopyToReq  {get;set;} Cmd0x346.ApplyCopyToReq? = null;
        [ProtoMember(90001)] public     msgApplyCleanTrafficReq  {get;set;} Cmd0x346.ApplyCleanTrafficReq? = null;
        [ProtoMember(90002)] public     msgApplyGetTrafficReq  {get;set;} Cmd0x346.ApplyGetTrafficReq? = null;
        [ProtoMember(99999)] public     msgExtensionReq  {get;set;} Cmd0x346.ExtensionReq? = null;
    }

    [ProtoContract] class RspBody{[ProtoMember(1)] public     cmd  {get;set;} int = 0;
        [ProtoMember(2)] public     seq  {get;set;} int = 0;
        [ProtoMember(3)] public     msgRecvListQueryRsp  {get;set;} Cmd0x346.RecvListQueryRsp? = null;
        [ProtoMember(4)] public     msgSendListQueryRsp  {get;set;} Cmd0x346.SendListQueryRsp? = null;
        [ProtoMember(5)] public     msgRenewFileRsp  {get;set;} Cmd0x346.RenewFileRsp? = null;
        [ProtoMember(6)] public     msgRecallFileRsp  {get;set;} Cmd0x346.RecallFileRsp? = null;
        [ProtoMember(7)] public     msgApplyUploadRsp  {get;set;} Cmd0x346.ApplyUploadRsp? = null;
        [ProtoMember(8)] public     msgApplyUploadHitRsp  {get;set;} Cmd0x346.ApplyUploadHitRsp? = null;
        [ProtoMember(9)] public     msgApplyForwardFileRsp  {get;set;} Cmd0x346.ApplyForwardFileRsp? = null;
        [ProtoMember(10)] public     msgUploadSuccRsp  {get;set;} Cmd0x346.UploadSuccRsp? = null;
        [ProtoMember(11)] public     msgDeleteFileRsp  {get;set;} Cmd0x346.DeleteFileRsp? = null;
        [ProtoMember(12)] public     msgDownloadSuccRsp  {get;set;} Cmd0x346.DownloadSuccRsp? = null;
        [ProtoMember(13)] public     msgApplyDownloadAbsRsp  {get;set;} Cmd0x346.ApplyDownloadAbsRsp? = null;
        [ProtoMember(14)] public     msgApplyDownloadRsp  {get;set;} Cmd0x346.ApplyDownloadRsp? = null;
        [ProtoMember(15)] public     msgApplyListDownloadRsp  {get;set;} Cmd0x346.ApplyListDownloadRsp? = null;
        [ProtoMember(16)] public     msgFileQueryRsp  {get;set;} Cmd0x346.FileQueryRsp? = null;
        [ProtoMember(17)] public     msgApplyCopyFromRsp  {get;set;} Cmd0x346.ApplyCopyFromRsp? = null;
        [ProtoMember(18)] public     msgApplyUploadRspV2  {get;set;} Cmd0x346.ApplyUploadRspV2? = null;
        [ProtoMember(19)] public     msgApplyUploadRspV3  {get;set;} Cmd0x346.ApplyUploadRspV3? = null;
        [ProtoMember(20)] public     msgApplyUploadHitRspV2  {get;set;} Cmd0x346.ApplyUploadHitRspV2? = null;
        [ProtoMember(21)] public     msgApplyUploadHitRspV3  {get;set;} Cmd0x346.ApplyUploadHitRspV3? = null;
        [ProtoMember(90000)] public     msgApplyCopyToRsp  {get;set;} Cmd0x346.ApplyCopyToRsp? = null;
        [ProtoMember(90001)] public     msgApplyCleanTrafficRsp  {get;set;} Cmd0x346.ApplyCleanTrafficRsp? = null;
        [ProtoMember(90002)] public     msgApplyGetTrafficRsp  {get;set;} Cmd0x346.ApplyGetTrafficRsp? = null;
        [ProtoMember(99999)] public     msgExtensionRsp  {get;set;} Cmd0x346.ExtensionRsp? = null;
    }

    [ProtoContract] class SendListQueryReq{[ProtoMember(1)] public     uin  {get;set;} long = 0L;
        [ProtoMember(2)] public     beginIndex  {get;set;} int = 0;
        [ProtoMember(3)] public     reqCount  {get;set;} int = 0;
    }

    [ProtoContract] class SendListQueryRsp{[ProtoMember(1)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(2)] public     retMsg  {get;set;} string = "";
        [ProtoMember(3)] public     fileTotCount  {get;set;} int = 0;
        [ProtoMember(4)] public     beginIndex  {get;set;} int = 0;
        [ProtoMember(5)] public     rspFileCount  {get;set;} int = 0;
        [ProtoMember(6)] public     isEnd  {get;set;} int = 0;
        [ProtoMember(7)] public     totLimit  {get;set;} long = 0L;
        [ProtoMember(8)] public     usedLimit  {get;set;} long = 0L;
        [ProtoMember(9)] public     msgFileList  {get;set;} List<Cmd0x346.FileInfo> = new();
    }

    [ProtoContract] class UploadSuccReq{[ProtoMember(10)] public     senderUin  {get;set;} long = 0L;
        [ProtoMember(20)] public     recverUin  {get;set;} long = 0L;
        [ProtoMember(30)] public     uuid  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class UploadSuccRsp{[ProtoMember(10)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(20)] public     retMsg  {get;set;} string = "";
        [ProtoMember(30)] public     msgFileInfo  {get;set;} Cmd0x346.FileInfo? = null;
    }
}
