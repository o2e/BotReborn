

using ProtoBuf;

internal class HummerResv21  {
    [ProtoContract] class FileImgInfo{[ProtoMember(1)] public     fileWidth  {get;set;} int = 0;
        [ProtoMember(2)] public     fileHeight  {get;set;} int = 0;
    }

    [ProtoContract] class ForwardExtFileInfo{[ProtoMember(1)] public     fileType  {get;set;} int = 0;
        [ProtoMember(2)] public     senderUin  {get;set;} long = 0L;
        [ProtoMember(3)] public     receiverUin  {get;set;} long = 0L;
        [ProtoMember(4)] public     fileUuid  {get;set;} string = "";
        [ProtoMember(5)] public     fileName  {get;set;} string = "";
        [ProtoMember(6)] public     fileSize  {get;set;} long = 0L;
        [ProtoMember(7)] public     fileSha1  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(8)] public     fileMd5  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(9)] public     int64DeadTime  {get;set;} long = 0L;
        [ProtoMember(10)] public     imgWidth  {get;set;} int = 0;
        [ProtoMember(11)] public     imgHeight  {get;set;} int = 0;
        [ProtoMember(12)] public     videoDuration  {get;set;} long = 0L;
        [ProtoMember(13)] public     busId  {get;set;} int = 0;
    }

    [ProtoContract] class ResvAttr{[ProtoMember(1)] public     fileImageInfo  {get;set;} FileImgInfo? = null;
        [ProtoMember(2)] public     forwardExtFileInfo  {get;set;} ForwardExtFileInfo? = null;
    }

    [ProtoContract] class XtfSenderInfo{[ProtoMember(1)] public     lanIp  {get;set;} int = 0;
        [ProtoMember(2)] public     lanPort  {get;set;} int = 0;
        [ProtoMember(3)] public     lanSrkey  {get;set;} long = 0L;
    }
}
