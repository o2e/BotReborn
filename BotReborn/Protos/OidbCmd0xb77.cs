







using ProtoBuf;

import net.mamoe.mirai.internal.network.Packet


[ProtoContract] class OidbCmd0xb77  {
    [ProtoContract] class ArkJsonBody{[ProtoMember(10)] public     jsonStr  {get;set;} string = "";
    }

    [ProtoContract] class ArkMsgBody{[ProtoMember(1)] public     app  {get;set;} string = "";
        [ProtoMember(2)] public     view  {get;set;} string = "";
        [ProtoMember(3)] public     prompt  {get;set;} string = "";
        [ProtoMember(4)] public     ver  {get;set;} string = "";
        [ProtoMember(5)] public     desc  {get;set;} string = "";
        [ProtoMember(6)] public     featureId  {get;set;} int = 0;
        [ProtoMember(10)] public     meta  {get;set;} string = "";
        [ProtoMember(11)] public     metaUrl1  {get;set;} string = "";
        [ProtoMember(12)] public     metaUrl2  {get;set;} string = "";
        [ProtoMember(13)] public     metaUrl3  {get;set;} string = "";
        [ProtoMember(14)] public     metaText1  {get;set;} string = "";
        [ProtoMember(15)] public     metaText2  {get;set;} string = "";
        [ProtoMember(16)] public     metaText3  {get;set;} string = "";
        [ProtoMember(20)] public     config  {get;set;} string = "";
    }

    [ProtoContract] class ArkV1MsgBody{[ProtoMember(1)] public     app  {get;set;} string = "";
        [ProtoMember(2)] public     view  {get;set;} string = "";
        [ProtoMember(3)] public     prompt  {get;set;} string = "";
        [ProtoMember(4)] public     ver  {get;set;} string = "";
        [ProtoMember(5)] public     desc  {get;set;} string = "";
        [ProtoMember(6)] public     featureId  {get;set;} int = 0;
        [ProtoMember(10)] public     meta  {get;set;} string = "";
        [ProtoMember(11)] public     items  {get;set;} List<TemplateItem> = new();
        [ProtoMember(20)] public     config  {get;set;} string = "";
    }

    [ProtoContract] class ClientInfo{[ProtoMember(1)] public     platform  {get;set;} int = 0;
        [ProtoMember(2)] public     sdkVersion  {get;set;} string = "";
        [ProtoMember(3)] public     androidPackageName  {get;set;} string = "";
        [ProtoMember(4)] public     androidSignature  {get;set;} string = "";
        [ProtoMember(5)] public     iosBundleId  {get;set;} string = "";
        [ProtoMember(6)] public     pcSign  {get;set;} string = "";
    }

    [ProtoContract] class ImageInfo{[ProtoMember(1)] public     md5  {get;set;} string = "";
        [ProtoMember(2)] public     uuid  {get;set;} string = "";
        [ProtoMember(3)] public     imgType  {get;set;} int = 0;
        [ProtoMember(4)] public     fileSize  {get;set;} int = 0;
        [ProtoMember(5)] public     width  {get;set;} int = 0;
        [ProtoMember(6)] public     height  {get;set;} int = 0;
        [ProtoMember(7)] public     original  {get;set;} int = 0;
        [ProtoMember(101)] public     fileId  {get;set;} int = 0;
        [ProtoMember(102)] public     serverIp  {get;set;} int = 0;
        [ProtoMember(103)] public     serverPort  {get;set;} int = 0;
    }

    [ProtoContract] class MiniAppMsgBody{[ProtoMember(1)] public     miniAppAppid  {get;set;} long = 0L;
        [ProtoMember(2)] public     miniAppPath  {get;set;} string = "";
        [ProtoMember(3)] public     webPageUrl  {get;set;} string = "";
        [ProtoMember(4)] public     miniAppType  {get;set;} int = 0;
        [ProtoMember(5)] public     title  {get;set;} string = "";
        [ProtoMember(6)] public     desc  {get;set;} string = "";
        [ProtoMember(10)] public     jsonStr  {get;set;} string = "";
    }

    [ProtoContract] class ReqBody{[ProtoMember(1)] public     appid  {get;set;} long = 0L;
        [ProtoMember(2)] public     appType  {get;set;} int = 0;
        [ProtoMember(3)] public     msgStyle  {get;set;} int = 0;
        [ProtoMember(4)] public     senderUin  {get;set;} long = 0L;
        [ProtoMember(5)] public     clientInfo  {get;set;} ClientInfo? = null;
        // [ProtoMember(6)] public     textMsg  {get;set;} string? = null;
        [ProtoMember(7)] public     extInfo  {get;set;} ExtInfo? = null;
        [ProtoMember(10)] public     sendType  {get;set;} int = 0;
        [ProtoMember(11)] public     recvUin  {get;set;} long = 0L;
        [ProtoMember(12)] public     richMsgBody  {get;set;} RichMsgBody? = null;
        [ProtoMember(13)] public     arkMsgBody  {get;set;} ArkMsgBody? = null;
        // [ProtoMember(14)] public     recvOpenid  {get;set;} string? = null; // don't be ""
        [ProtoMember(15)] public     arkv1MsgBody  {get;set;} ArkV1MsgBody? = null;
        [ProtoMember(16)] public     arkJsonBody  {get;set;} ArkJsonBody? = null;
        [ProtoMember(17)] public     xmlMsgBody  {get;set;} XmlMsgBody? = null;
        [ProtoMember(18)] public     miniAppMsgBody  {get;set;} MiniAppMsgBody? = null;
    }

    [ProtoContract] class ExtInfo(
       [ProtoMember(1)] public   customFeatureId  {get;set;} List<int> = new();
       [ProtoMember(2)] public   apnsWording  {get;set;} string = "";
       [ProtoMember(3)] public   groupSaveDbFlag  {get;set;} int = 0;
       [ProtoMember(4)] public   receiverAppId  {get;set;} int = 0;
       [ProtoMember(5)] public   msgSeq  {get;set;} long = 0L;
    }

    [ProtoContract] class RichMsgBody{[ProtoMember(1)] public     usingArk  {get;set;} bool = false;
        [ProtoMember(10)] public     title  {get;set;} string = "";
        [ProtoMember(11)] public     summary  {get;set;} string = "";
        [ProtoMember(12)] public     brief  {get;set;} string = "";
        [ProtoMember(13)] public     url  {get;set;} string = "";
        [ProtoMember(14)] public     pictureUrl  {get;set;} string = "";
        [ProtoMember(15)] public     action  {get;set;} string = "";
        [ProtoMember(16)] public     musicUrl  {get;set;} string = "";
        [ProtoMember(21)] public     imageInfo  {get;set;} ImageInfo? = null;
    }

    [ProtoContract] class RspBody{[ProtoMember(1)] public     wording  {get;set;} string = "";
        [ProtoMember(2)] public     jumpResult  {get;set;} int = 0;
        [ProtoMember(3)] public     jumpUrl  {get;set;} string = "";
        [ProtoMember(4)] public     level  {get;set;} int = 0;
        [ProtoMember(5)] public     subLevel  {get;set;} int = 0;
        [ProtoMember(6)] public     developMsg  {get;set;} string = "";
    }; Packet

    [ProtoContract] class TemplateItem{[ProtoMember(1)] public     key  {get;set;} string = "";
        [ProtoMember(2)] public     type  {get;set;} int = 0;
        [ProtoMember(3)] public     value  {get;set;} string = "";
    }

    [ProtoContract] class XmlMsgBody{[ProtoMember(11)] public     serviceId  {get;set;} int = 0;
        [ProtoMember(12)] public     xml  {get;set;} string = "";
    }
}
