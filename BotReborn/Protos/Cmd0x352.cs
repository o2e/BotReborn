using System;
using System.Collections.Generic;
using ProtoBuf;

[ProtoContract] class Cmd0x352  {
    [ProtoContract] class DelImgReq(
       [ProtoMember(1)] public long srcUin  {get;set;}  = 0L;
       [ProtoMember(2)] public long dstUin  {get;set;}  = 0L;
       [ProtoMember(3)] public int reqTerm  {get;set;}  = 0;
       [ProtoMember(4)] public int reqPlatformType  {get;set;}  = 0;
       [ProtoMember(5)] public int buType  {get;set;}  = 0;
       [ProtoMember(6)] public byte[] buildVer  {get;set;}  = Array.Empty<byte>();
       [ProtoMember(7)] public byte[] fileResid  {get;set;}  = Array.Empty<byte>();
       [ProtoMember(8)] public int picWidth  {get;set;}  = 0;
       [ProtoMember(9)] public int picHeight  {get;set;}  = 0;
    }

    [ProtoContract] class DelImgRsp(
       [ProtoMember(1)] public int result  {get;set;}  = 0;
       [ProtoMember(2)] public byte[] failMsg  {get;set;}  = Array.Empty<byte>();
       [ProtoMember(3)] public byte[] fileResid  {get;set;}  = Array.Empty<byte>();
    }

    [ProtoContract] class GetImgUrlReq(
       [ProtoMember(1)] public long srcUin  {get;set;}  = 0L;
       [ProtoMember(2)] public long dstUin  {get;set;}  = 0L;
       [ProtoMember(3)] public byte[] fileResid  {get;set;}  = Array.Empty<byte>();
       [ProtoMember(4)] public int urlFlag  {get;set;} = 0;
       [ProtoMember(6)] public int urlType  {get;set;}  = 0;
       [ProtoMember(7)] public int reqTerm  {get;set;}  = 0;
       [ProtoMember(8)] public int reqPlatformType  {get;set;}  = 0;
       [ProtoMember(9)] public int srcFileType  {get;set;}  = 0;
       [ProtoMember(10)] public int innerIp  {get;set;}  = 0;
       [ProtoMember(11)] public bool boolAddressBook  {get;set;}  = false;
       [ProtoMember(12)] public int buType  {get;set;}  = 0;
       [ProtoMember(13)] public byte[] buildVer  {get;set;}  = Array.Empty<byte>();
       [ProtoMember(14)] public int picUpTimestamp  {get;set;}  = 0;
       [ProtoMember(15)] public int reqTransferType  {get;set;}  = 0;
    }

    [ProtoContract] class GetImgUrlRsp(
       [ProtoMember(1)] public byte[] fileResid  {get;set;}  = Array.Empty<byte>();
       [ProtoMember(2)] public int clientIp  {get;set;}  = 0;
       [ProtoMember(3)] public int result  {get;set;}  = 0;
       [ProtoMember(4)] public byte[] failMsg  {get;set;}  = Array.Empty<byte>();
       [ProtoMember(5)] public   bytesThumbDownUrl  {get;set;} List< byte[]> = new();
       [ProtoMember(6)] public   bytesOriginalDownUrl  {get;set;} List<byte[]> = new();
       [ProtoMember(7)] public   msgImgInfo  {get;set;} ImgInfo? = null;
       [ProtoMember(8)] public   uint32DownIp  {get;set;} List<int> = new();
       [ProtoMember(9)] public   uint32DownPort  {get;set;} List<int> = new();
       [ProtoMember(10)] public   thumbDownPara  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(11)] public   originalDownPara  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(12)] public   downDomain  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(13)] public   bytesBigDownUrl  {get;set;} List<byte[]> = new();
       [ProtoMember(14)] public   bigDownPara  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(15)] public   bigThumbDownPara  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(16)] public   httpsUrlFlag  {get;set;} int = 0;
       [ProtoMember(26)] public   msgDownIp6  {get;set;} List<IPv6Info> = new();
       [ProtoMember(27)] public   clientIp6  {get;set;} byte[] = Array.Empty<byte>();
    }

    
    [ProtoContract] class ImgInfo(
       [ProtoMember(1)] public   fileMd5  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   fileType  {get;set;} int = 0;
       [ProtoMember(3)] public   fileSize  {get;set;} long = 0L;
       [ProtoMember(4)] public   fileWidth  {get;set;} int = 0;
       [ProtoMember(5)] public   fileHeight  {get;set;} int = 0;
       [ProtoMember(6)] public   fileFlag  {get;set;} long = 0L;
       [ProtoMember(7)] public   fileCutPos  {get;set;} int = 0;
    }

    [ProtoContract] class IPv6Info(
       [ProtoMember(1)] public   ip6  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   port  {get;set;} int = 0;
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   subcmd  {get;set;} int = 0; //2是GetImgUrlReq 1是UploadImgReq
       [ProtoMember(2)] public   msgTryupImgReq  {get;set;} List<TryUpImgReq> = new(); // optional
       [ProtoMember(3)] public   msgGetimgUrlReq  {get;set;} List<GetImgUrlReq> = new(); // optional
       [ProtoMember(4)] public   msgDelImgReq  {get;set;} List<DelImgReq> = new();
       [ProtoMember(10)] public   netType  {get;set;} int = 0; // 数据网络=5; wifi=3
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   subcmd  {get;set;} int = 0;
       [ProtoMember(2)] public   msgTryupImgRsp  {get;set;} List<TryUpImgRsp> = new();
       [ProtoMember(3)] public   msgGetimgUrlRsp  {get;set;} List<GetImgUrlRsp> = new();
       [ProtoMember(4)] public   boolNewBigchan  {get;set;} bool = false;
       [ProtoMember(5)] public   msgDelImgRsp  {get;set;} List<DelImgRsp> = new();
       [ProtoMember(10)] public   failMsg  {get;set;} string? = "";
    }

    [ProtoContract] class TryUpImgReq(
       [ProtoMember(1)] public   srcUin  {get;set;} long;
       [ProtoMember(2)] public   dstUin  {get;set;} long;
       [ProtoMember(3)] public   fileId  {get;set;} long = 0L; //从0开始的自增数？貌似有一个连接就要自增1; 但是又会重置回0
       [ProtoMember(4)] public   fileMd5  {get;set;} byte[];
       [ProtoMember(5)] public   fileSize  {get;set;} long; //默认为md5+".jpg"
       [ProtoMember(6)] public   fileName  {get;set;} string;
       [ProtoMember(7)] public   srcTerm  {get;set;} int = 5;
       [ProtoMember(8)] public   platformType  {get;set;} int = 9;
       [ProtoMember(9)] public   innerIP  {get;set;} int = 0;
       [ProtoMember(10)] public   addressBook  {get;set;} bool = false; //chatType == 1006为true 我觉得发false没问题
       [ProtoMember(11)] public   retry  {get;set;} int = 0; //default
       [ProtoMember(12)] public   buType  {get;set;} int = 1; //1或96 不确定
       [ProtoMember(13)] public   imgOriginal  {get;set;} bool = false; //是否为原图
       [ProtoMember(14)] public   imgWidth  {get;set;} int = 0;
       [ProtoMember(15)] public   imgHeight  {get;set;} int = 0;
        /**
         * ImgType  {get;set;}
         *  JPG  {get;set;}    1000
         *  PNG  {get;set;}    1001
         *  WEBP  {get;set;}   1002
         *  BMP  {get;set;}    1005
         *  GIG  {get;set;}    2000
         *  APNG  {get;set;}   2001
         *  SHARPP  {get;set;} 1004
         */
       [ProtoMember(16)] public   imgType  {get;set;} int = 1000;
       [ProtoMember(17)] public   buildVer  {get;set;} string = "8.2.7.4410"; //版本号
       [ProtoMember(18)] public   fileIndex  {get;set;} byte[] = Array.Empty<byte>(); //default
       [ProtoMember(19)] public   fileStoreDays  {get;set;} int = 0; //default
       [ProtoMember(20)] public   stepFlag  {get;set;} int = 0; //default
       [ProtoMember(21)] public   rejectTryFast  {get;set;} bool = false; //bool
       [ProtoMember(22)] public   srvUpload  {get;set;} int = 1; //typeHotPic[1/2/3]
       [ProtoMember(23)] public   transferUrl  {get;set;} byte[] = Array.Empty<byte>(); //rawDownloadUrl; 如果没有就是Array.Empty<byte>()
    )   {get;set;} ImgReq

    [ProtoContract] class TryUpImgRsp(
       [ProtoMember(1)] public   fileId  {get;set;} long = 0L;
       [ProtoMember(2)] public   clientIp  {get;set;} int = 0;
       [ProtoMember(3)] public   result  {get;set;} int = 0;
       [ProtoMember(4)] public   failMsg  {get;set;} string = "";
       [ProtoMember(5)] public   boolFileExit  {get;set;} bool = false;
       [ProtoMember(6)] public   msgImgInfo  {get;set;} ImgInfo? = null;
       [ProtoMember(7)] public   uint32UpIp  {get;set;} List<int> = new();
       [ProtoMember(8)] public   uint32UpPort  {get;set;} List<int> = new();
       [ProtoMember(9)] public   upUkey  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(10)] public   upResid  {get;set;} string = "";
       [ProtoMember(11)] public   upUuid  {get;set;} string = "";
       [ProtoMember(12)] public   upOffset  {get;set;} long = 0L;
       [ProtoMember(13)] public   blockSize  {get;set;} long = 0L;
       [ProtoMember(14)] public   encryptDstip  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(15)] public   roamdays  {get;set;} int = 0;
       [ProtoMember(26)] public   msgUpIp6  {get;set;} List<IPv6Info> = new();
       [ProtoMember(27)] public   clientIp6  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(60)] public   thumbDownPara  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(61)] public   originalDownPara  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(62)] public   downDomain  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(64)] public   bigDownPara  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(65)] public   bigThumbDownPara  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(66)] public   httpsUrlFlag  {get;set;} int = 0;
       [ProtoMember(1001)] public   msgInfo4busi  {get;set;} TryUpInfo4Busi? = null;
    }

    [ProtoContract] class TryUpInfo4Busi(
       [ProtoMember(1)] public   fileResid  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   downDomain  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   thumbDownUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   originalDownUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   bigDownUrl  {get;set;} byte[] = Array.Empty<byte>();
    }
}
