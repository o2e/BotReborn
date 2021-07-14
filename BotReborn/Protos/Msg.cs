




using ProtoBuf;

import kotlinx.serialization.protobuf.ProtoIntegerType

import kotlinx.serialization.protobuf.ProtoType



[ProtoContract] class ImCommon  {
    [ProtoContract] class GroupInfo(
       [ProtoMember(1)] public   groupId  {get;set;} long = 0L;
       [ProtoMember(2)] public   groupType  {get;set;} int /* enum */ = 1;
    }

    [ProtoContract] class Signature(
       [ProtoMember(1)] public   keyType  {get;set;} int = 0;
       [ProtoMember(2)] public   sessionAppId  {get;set;} int = 0;
       [ProtoMember(3)] public   sessionKey  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class Token(
       [ProtoMember(1)] public   buf  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   c2cType  {get;set;} int = 0;
       [ProtoMember(3)] public   serviceType  {get;set;} int = 0;
    }

    [ProtoContract] class User(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L;
       [ProtoMember(2)] public   appId  {get;set;} int = 0;
       [ProtoMember(3)] public   instanceId  {get;set;} int = 0;
       [ProtoMember(4)] public   appType  {get;set;} int = 0;
        @ProtoType(ProtoIntegerType.FIXED)[ProtoMember(5)] public   clientIp  {get;set;} int = 0;
       [ProtoMember(6)] public   version  {get;set;} int = 0;
       [ProtoMember(7)] public   phoneNumber  {get;set;} string = "";
       [ProtoMember(8)] public   platformId  {get;set;} int = 0;
       [ProtoMember(9)] public   language  {get;set;} int = 0;
       [ProtoMember(10)] public   equipKey  {get;set;} byte[] = Array.Empty<byte>();
    }
}

[ProtoContract] class ImImagent  {
    [ProtoContract] class ImAgentHead(
       [ProtoMember(1)] public   command  {get;set;} int /* enum */ = 1;
       [ProtoMember(2)] public   seq  {get;set;} int = 0;
       [ProtoMember(3)] public   result  {get;set;} int = 0;
       [ProtoMember(4)] public   err  {get;set;} string = "";
       [ProtoMember(5)] public   echoBuf  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   reqUser  {get;set;} ImCommon.User? = null;
       [ProtoMember(7)] public   reqInfo  {get;set;} Requestinfo? = null;
       [ProtoMember(8)] public   signature  {get;set;} Signature? = null;
       [ProtoMember(9)] public   subCmd  {get;set;} int = 0;
       [ProtoMember(10)] public   serverIp  {get;set;} int = 0;
    }

    [ProtoContract] class ImAgentPackage(
       [ProtoMember(1)] public   head  {get;set;} ImAgentHead? = null;
       [ProtoMember(11)] public   msgSendReq  {get;set;} ImMsg.MsgSendReq? = null;
       [ProtoMember(12)] public   msgSendResp  {get;set;} ImMsg.MsgSendResp? = null;
    }

    [ProtoContract] class Requestinfo(
        @ProtoType(ProtoIntegerType.FIXED)[ProtoMember(1)] public   reqIp  {get;set;} int = 0;
       [ProtoMember(2)] public   reqPort  {get;set;} int = 0;
       [ProtoMember(3)] public   reqFlag  {get;set;} int = 0;
    }

    [ProtoContract] class Signature(
       [ProtoMember(1)] public   keyType  {get;set;} int = 0;
       [ProtoMember(2)] public   sessionAppId  {get;set;} int = 0;
       [ProtoMember(3)] public   sessionKey  {get;set;} byte[] = Array.Empty<byte>();
    }
}

[ProtoContract] class ImMsg  {
    [ProtoContract] class C2C(
       [ProtoMember(1)] public   sender  {get;set;} ImCommon.User? = null;
       [ProtoMember(2)] public   receiver  {get;set;} ImCommon.User? = null;
       [ProtoMember(3)] public   c2cRelation  {get;set;} C2CRelation? = null;
    }

    [ProtoContract] class C2CRelation(
       [ProtoMember(1)] public   c2cType  {get;set;} int /* enum */ = 0;
       [ProtoMember(2)] public   groupInfo  {get;set;} ImCommon.GroupInfo? = null;
       [ProtoMember(3)] public   token  {get;set;} ImCommon.Token? = null;
    }

    [ProtoContract] class ContentHead(
       [ProtoMember(1)] public   pkgNum  {get;set;} int = 1;
       [ProtoMember(2)] public   pkgIndex  {get;set;} int = 0;
       [ProtoMember(3)] public   seq  {get;set;} int = 0;
       [ProtoMember(4)] public   dateTime  {get;set;} int = 0;
       [ProtoMember(5)] public   msgType  {get;set;} int = 0;
       [ProtoMember(6)] public   divSeq  {get;set;} int = 0;
       [ProtoMember(7)] public   msgdbUin  {get;set;} long = 0L;
       [ProtoMember(8)] public   msgdbSeq  {get;set;} int = 0;
       [ProtoMember(9)] public   wordMsgSeq  {get;set;} int = 0;
       [ProtoMember(10)] public   msgRand  {get;set;} int = 0;
    }

    [ProtoContract] class Group(
       [ProtoMember(1)] public   sender  {get;set;} ImCommon.User? = null;
       [ProtoMember(2)] public   receiver  {get;set;} ImCommon.User? = null;
       [ProtoMember(3)] public   groupInfo  {get;set;} ImCommon.GroupInfo? = null;
    }

    [ProtoContract] class Msg(
       [ProtoMember(1)] public   head  {get;set;} MsgHead? = null;
       [ProtoMember(2)] public   body  {get;set;} ImMsgBody.MsgBody? = null;
    }

    [ProtoContract] class MsgHead(
       [ProtoMember(1)] public   routingHead  {get;set;} RoutingHead? = null;
       [ProtoMember(2)] public   contentHead  {get;set;} ContentHead? = null;
       [ProtoMember(3)] public   gbkTmpMsgBody  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class MsgSendReq(
       [ProtoMember(1)] public   msg  {get;set;} Msg? = null;
       [ProtoMember(2)] public   buMsg  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   msgTailId  {get;set;} int = 0;
       [ProtoMember(4)] public   connMsgFlag  {get;set;} int = 0;
       [ProtoMember(5)] public   cookie  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class MsgSendResp

    [ProtoContract] class RoutingHead(
       [ProtoMember(1)] public   c2c  {get;set;} C2C? = null;
       [ProtoMember(2)] public   group  {get;set;} Group? = null;
    }
}

[ProtoContract] class ImMsgBody  {
    [ProtoContract] class AnonymousGroupMsg(
       [ProtoMember(1)] public   flags  {get;set;} int = 0;
       [ProtoMember(2)] public   anonId  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   anonNick  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   headPortrait  {get;set;} int = 0;
       [ProtoMember(5)] public   expireTime  {get;set;} int = 0;
       [ProtoMember(6)] public   bubbleId  {get;set;} int = 0;
       [ProtoMember(7)] public   rankColor  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class ApolloActMsg(
       [ProtoMember(1)] public   actionId  {get;set;} int = 0;
       [ProtoMember(2)] public   actionName  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   actionText  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   flag  {get;set;} int = 0;
       [ProtoMember(5)] public   peerUin  {get;set;} int = 0;
       [ProtoMember(6)] public   senderTs  {get;set;} int = 0;
       [ProtoMember(7)] public   peerTs  {get;set;} int = 0;
       [ProtoMember(8)] public   int32SenderStatus  {get;set;} int = 0;
       [ProtoMember(9)] public   int32PeerStatus  {get;set;} int = 0;
       [ProtoMember(10)] public   diytextId  {get;set;} int = 0;
       [ProtoMember(11)] public   diytextContent  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(12)] public   inputText  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(13)] public   pbReserve  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class ArkAppElem(
       [ProtoMember(1)] public   appName  {get;set;} string = "";
       [ProtoMember(2)] public   minVersion  {get;set;} string = "";
       [ProtoMember(3)] public   xmlTemplate  {get;set;} string = "";
       [ProtoMember(4)] public   data  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class Attr(
        @ProtoType(ProtoIntegerType.SIGNED)[ProtoMember(1)] public   codePage  {get;set;} int = -1;
       [ProtoMember(2)] public   time  {get;set;} int = 1;
       [ProtoMember(3)] public   random  {get;set;} int = 0;
       [ProtoMember(4)] public   color  {get;set;} int = 0;
       [ProtoMember(5)] public   size  {get;set;} int = 10;
       [ProtoMember(6)] public   effect  {get;set;} int = 7;
       [ProtoMember(7)] public   charSet  {get;set;} int = 78;
       [ProtoMember(8)] public   pitchAndFamily  {get;set;} int = 90;
       [ProtoMember(9)] public   fontName  {get;set;} string = "Times New Roman";
       [ProtoMember(10)] public   reserveData  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class BitAppMsg(
       [ProtoMember(1)] public   buf  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class BlessingMessage(
       [ProtoMember(1)] public   msgType  {get;set;} int = 0;
       [ProtoMember(2)] public   exFlag  {get;set;} int = 0;
    }

    [ProtoContract] class CommonElem(
       [ProtoMember(1)] public   serviceType  {get;set;} int = 0;
       [ProtoMember(2)] public   pbElem  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   businessType  {get;set;} int = 0;
    }

    [ProtoContract] class ConferenceTipsInfo(
       [ProtoMember(1)] public   sessionType  {get;set;} int = 0;
       [ProtoMember(2)] public   sessionUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   text  {get;set;} string = "";
    }

    [ProtoContract] class CrmElem(
       [ProtoMember(1)] public   crmBuf  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   msgResid  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   qidianFlag  {get;set;} int = 0;
       [ProtoMember(4)] public   pushFlag  {get;set;} int = 0;
       [ProtoMember(5)] public   countFlag  {get;set;} int = 0;
    }

    [ProtoContract] class CustomElem(
       [ProtoMember(1)] public   desc  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   data  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   enumType  {get;set;} int /* enum */ = 1;
       [ProtoMember(4)] public   ext  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   sound  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class CustomFace(
       [ProtoMember(1)] public   guid  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   filePath  {get;set;} string = "";
       [ProtoMember(3)] public   shortcut  {get;set;} string = "";
       [ProtoMember(4)] public   buffer  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   flag  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   oldData  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(7)] public   fileId  {get;set;} int = 0;
       [ProtoMember(8)] public   serverIp  {get;set;} int = 0;
       [ProtoMember(9)] public   serverPort  {get;set;} int = 0;
       [ProtoMember(10)] public   fileType  {get;set;} int = 0;
       [ProtoMember(11)] public   signature  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(12)] public   useful  {get;set;} int = 0;
       [ProtoMember(13) override val picMd5  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(14) override val thumbUrl  {get;set;} string = "";
       [ProtoMember(15)] public   bigUrl  {get;set;} string = "";
       [ProtoMember(16) override val origUrl  {get;set;} string = "";
       [ProtoMember(17)] public   bizType  {get;set;} int = 0;
       [ProtoMember(18)] public   repeatIndex  {get;set;} int = 0;
       [ProtoMember(19)] public   repeatImage  {get;set;} int = 0;
       [ProtoMember(20)] public   imageType  {get;set;} int = 0;
       [ProtoMember(21)] public   index  {get;set;} int = 0;
       [ProtoMember(22)] public   width  {get;set;} int = 0;
       [ProtoMember(23)] public   height  {get;set;} int = 0;
       [ProtoMember(24)] public   source  {get;set;} int = 0;
       [ProtoMember(25)] public   size  {get;set;} int = 0;
       [ProtoMember(26)] public   origin  {get;set;} int = 0;
       [ProtoMember(27)] public   thumbWidth  {get;set;} int = 0;
       [ProtoMember(28)] public   thumbHeight  {get;set;} int = 0;
       [ProtoMember(29)] public   showLen  {get;set;} int = 0;
       [ProtoMember(30)] public   downloadLen  {get;set;} int = 0;
       [ProtoMember(31) override val _400Url  {get;set;} string = "";
       [ProtoMember(32)] public   _400Width  {get;set;} int = 0;
       [ProtoMember(33)] public   _400Height  {get;set;} int = 0;
       [ProtoMember(34)] public   pbReserve  {get;set;} byte[] = Array.Empty<byte>();
    }; NotOnlineImageOrCustomFace

    [ProtoContract] class DeliverGiftMsg(
       [ProtoMember(1)] public   grayTipContent  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   animationPackageId  {get;set;} int = 0;
       [ProtoMember(3)] public   animationPackageUrlA  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   animationPackageUrlI  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   remindBrief  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   giftId  {get;set;} int = 0;
       [ProtoMember(7)] public   giftCount  {get;set;} int = 0;
       [ProtoMember(8)] public   animationBrief  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(9)] public   senderUin  {get;set;} long = 0L;
       [ProtoMember(10)] public   receiverUin  {get;set;} long = 0L;
       [ProtoMember(11)] public   stmessageTitle  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(12)] public   stmessageSubtitle  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(13)] public   stmessageMessage  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(14)] public   stmessageGiftpicid  {get;set;} int = 0;
       [ProtoMember(15)] public   stmessageComefrom  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(16)] public   stmessageExflag  {get;set;} int = 0;
       [ProtoMember(17)] public   toAllGiftId  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(18)] public   comefromLink  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(19)] public   pbReserve  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(20)] public   receiverName  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(21)] public   receiverPic  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(22)] public   stmessageGifturl  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class EIMInfo(
       [ProtoMember(1)] public   rootId  {get;set;} long = 0L;
       [ProtoMember(2)] public   flag  {get;set;} int = 0;
    }

    [ProtoContract] class Elem(
       [ProtoMember(1)] public   text  {get;set;} Text? = null;
       [ProtoMember(2)] public   face  {get;set;} Face? = null;
       [ProtoMember(3)] public   onlineImage  {get;set;} OnlineImage? = null;
       [ProtoMember(4)] public   notOnlineImage  {get;set;} NotOnlineImage? = null;
       [ProtoMember(5)] public   transElemInfo  {get;set;} TransElem? = null;
       [ProtoMember(6)] public   marketFace  {get;set;} MarketFace? = null;
       [ProtoMember(7)] public   elemFlags  {get;set;} ElemFlags? = null;
       [ProtoMember(8)] public   customFace  {get;set;} CustomFace? = null;
       [ProtoMember(9)] public   elemFlags2  {get;set;} ElemFlags2? = null;
       [ProtoMember(10)] public   funFace  {get;set;} FunFace? = null;
       [ProtoMember(11)] public   secretFile  {get;set;} SecretFileMsg? = null;
       [ProtoMember(12)] public   richMsg  {get;set;} RichMsg? = null;
       [ProtoMember(13)] public   groupFile  {get;set;} GroupFile? = null;
       [ProtoMember(14)] public   pubGroup  {get;set;} PubGroup? = null;
       [ProtoMember(15)] public   marketTrans  {get;set;} MarketTrans? = null;
       [ProtoMember(16)] public   extraInfo  {get;set;} ExtraInfo? = null;
       [ProtoMember(17)] public   shakeWindow  {get;set;} ShakeWindow? = null;
       [ProtoMember(18)] public   pubAccount  {get;set;} PubAccount? = null;
       [ProtoMember(19)] public   videoFile  {get;set;} VideoFile? = null;
       [ProtoMember(20)] public   tipsInfo  {get;set;} TipsInfo? = null;
       [ProtoMember(21)] public   anonGroupMsg  {get;set;} AnonymousGroupMsg? = null;
       [ProtoMember(22)] public   qqLiveOld  {get;set;} QQLiveOld? = null;
       [ProtoMember(23)] public   lifeOnline  {get;set;} LifeOnlineAccount? = null;
       [ProtoMember(24)] public   qqwalletMsg  {get;set;} QQWalletMsg? = null;
       [ProtoMember(25)] public   crmElem  {get;set;} CrmElem? = null;
       [ProtoMember(26)] public   conferenceTipsInfo  {get;set;} ConferenceTipsInfo? = null;
       [ProtoMember(27)] public   redbagInfo  {get;set;} RedBagInfo? = null;
       [ProtoMember(28)] public   lowVersionTips  {get;set;} LowVersionTips? = null;
       [ProtoMember(29)] public   bankcodeCtrlInfo  {get;set;} byte[]? = null;
       [ProtoMember(30)] public   nearByMsg  {get;set;} NearByMessageType? = null;
       [ProtoMember(31)] public   customElem  {get;set;} CustomElem? = null;
       [ProtoMember(32)] public   locationInfo  {get;set;} LocationInfo? = null;
       [ProtoMember(33)] public   pubAccInfo  {get;set;} PubAccInfo? = null;
       [ProtoMember(34)] public   smallEmoji  {get;set;} SmallEmoji? = null;
       [ProtoMember(35)] public   fsjMsgElem  {get;set;} FSJMessageElem? = null;
       [ProtoMember(36)] public   arkApp  {get;set;} ArkAppElem? = null;
       [ProtoMember(37)] public   generalFlags  {get;set;} GeneralFlags? = null;
       [ProtoMember(38)] public   hcFlashPic  {get;set;} CustomFace? = null;
       [ProtoMember(39)] public   deliverGiftMsg  {get;set;} DeliverGiftMsg? = null;
       [ProtoMember(40)] public   bitappMsg  {get;set;} BitAppMsg? = null;
       [ProtoMember(41)] public   openQqData  {get;set;} OpenQQData? = null;
       [ProtoMember(42)] public   apolloMsg  {get;set;} ApolloActMsg? = null;
       [ProtoMember(43)] public   groupPubAccInfo  {get;set;} GroupPubAccountInfo? = null;
       [ProtoMember(44)] public   blessMsg  {get;set;} BlessingMessage? = null;
       [ProtoMember(45)] public   srcMsg  {get;set;} SourceMsg? = null;
       [ProtoMember(46)] public   lolaMsg  {get;set;} LolaMsg? = null;
       [ProtoMember(47)] public   groupBusinessMsg  {get;set;} GroupBusinessMsg? = null;
       [ProtoMember(48)] public   msgWorkflowNotify  {get;set;} WorkflowNotifyMsg? = null;
       [ProtoMember(49)] public   patElem  {get;set;} PatsElem? = null;
       [ProtoMember(50)] public   groupPostElem  {get;set;} GroupPostElem? = null;
       [ProtoMember(51)] public   lightApp  {get;set;} LightAppElem? = null;
       [ProtoMember(52)] public   eimInfo  {get;set;} EIMInfo? = null;
       [ProtoMember(53)] public   commonElem  {get;set;} CommonElem? = null;
    }

    [ProtoContract] class ElemFlags(
       [ProtoMember(1)] public   flags1  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   businessData  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class ElemFlags2(
       [ProtoMember(1)] public   colorTextId  {get;set;} int = 0;
       [ProtoMember(2)] public   msgId  {get;set;} long = 0L;
       [ProtoMember(3)] public   whisperSessionId  {get;set;} int = 0;
       [ProtoMember(4)] public   pttChangeBit  {get;set;} int = 0;
       [ProtoMember(5)] public   vipStatus  {get;set;} int = 0;
       [ProtoMember(6)] public   compatibleId  {get;set;} int = 0;
       [ProtoMember(7)] public   insts  {get;set;} List<Inst> = new();
       [ProtoMember(8)] public   msgRptCnt  {get;set;} int = 0;
       [ProtoMember(9)] public   srcInst  {get;set;} Inst? = null;
       [ProtoMember(10)] public   longtitude  {get;set;} int = 0;
       [ProtoMember(11)] public   latitude  {get;set;} int = 0;
       [ProtoMember(12)] public   customFont  {get;set;} int = 0;
       [ProtoMember(13)] public   pcSupportDef  {get;set;} PcSupportDef? = null;
       [ProtoMember(14)] public   crmFlags  {get;set;} int = 0;
    } {
        [ProtoContract]
        internal class Inst(
           [ProtoMember(1)] public   appId  {get;set;} int = 0;
           [ProtoMember(2)] public   instId  {get;set;} int = 0;
        )
    }

    [ProtoContract] class ExtraInfo(
       [ProtoMember(1)] public   nick  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   groupCard  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   level  {get;set;} int = 0;
       [ProtoMember(4)] public   flags  {get;set;} int = 0;
       [ProtoMember(5)] public   groupMask  {get;set;} int = 0;
       [ProtoMember(6)] public   msgTailId  {get;set;} int = 0;
       [ProtoMember(7)] public   senderTitle  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(8)] public   apnsTips  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(9)] public   uin  {get;set;} long = 0L;
       [ProtoMember(10)] public   msgStateFlag  {get;set;} int = 0;
       [ProtoMember(11)] public   apnsSoundType  {get;set;} int = 0;
       [ProtoMember(12)] public   newGroupFlag  {get;set;} int = 0;
    }

    [ProtoContract] class Face(
       [ProtoMember(1)] public   index  {get;set;} int = 0;
       [ProtoMember(2)] public   old  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(11)] public   buf  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class FSJMessageElem(
       [ProtoMember(1)] public   msgType  {get;set;} int = 0;
    }

    [ProtoContract] class FunFace(
       [ProtoMember(1)] public   msgTurntable  {get;set;} Turntable? = null;
       [ProtoMember(2)] public   msgBomb  {get;set;} Bomb? = null;
    ) {
        [ProtoContract]
        internal class Bomb(
           [ProtoMember(1)] public   boolBurst  {get;set;} bool = false;
        )

        [ProtoContract]
        internal class Turntable(
           [ProtoMember(1)] public   uint64UinList  {get;set;} List<Long> = new();
           [ProtoMember(2)] public   hitUin  {get;set;} long = 0L;
           [ProtoMember(3)] public   hitUinNick  {get;set;} string = "";
        )
    }

    [ProtoContract] class GeneralFlags(
       [ProtoMember(1)] public   bubbleDiyTextId  {get;set;} int = 0;
       [ProtoMember(2)] public   groupFlagNew  {get;set;} int = 0;
       [ProtoMember(3)] public   uin  {get;set;} long = 0L;
       [ProtoMember(4)] public   rpId  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   prpFold  {get;set;} int = 0;
       [ProtoMember(6)] public   longTextFlag  {get;set;} int = 0;
       [ProtoMember(7)] public   longTextResid  {get;set;} string = "";
       [ProtoMember(8)] public   groupType  {get;set;} int = 0;
       [ProtoMember(9)] public   toUinFlag  {get;set;} int = 0;
       [ProtoMember(10)] public   glamourLevel  {get;set;} int = 0;
       [ProtoMember(11)] public   memberLevel  {get;set;} int = 0;
       [ProtoMember(12)] public   groupRankSeq  {get;set;} long = 0L;
       [ProtoMember(13)] public   olympicTorch  {get;set;} int = 0;
       [ProtoMember(14)] public   babyqGuideMsgCookie  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(15)] public   uin32ExpertFlag  {get;set;} int = 0;
       [ProtoMember(16)] public   bubbleSubId  {get;set;} int = 0;
       [ProtoMember(17)] public   pendantId  {get;set;} long = 0L;
       [ProtoMember(18)] public   rpIndex  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(19)] public   pbReserve  {get;set;} byte[] = Array.Empty<byte>(); // 78 00 F8 01 00 C8 02 00
    }

    [ProtoContract] class GroupBusinessMsg(
       [ProtoMember(1)] public   flags  {get;set;} int = 0;
       [ProtoMember(2)] public   headUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   headClkUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   nick  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   nickColor  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   rank  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(7)] public   rankColor  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(8)] public   rankBgcolor  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class GroupFile(
       [ProtoMember(1)] public   filename  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   fileSize  {get;set;} long = 0L;
       [ProtoMember(3)] public   fileId  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   batchId  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   fileKey  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   mark  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(7)] public   sequence  {get;set;} long = 0L;
       [ProtoMember(8)] public   batchItemId  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(9)] public   feedMsgTime  {get;set;} int = 0;
       [ProtoMember(10)] public   pbReserve  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class GroupPostElem(
       [ProtoMember(1)] public   transType  {get;set;} int = 0;
       [ProtoMember(2)] public   transMsg  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class GroupPubAccountInfo(
       [ProtoMember(1)] public   pubAccount  {get;set;} long = 0L;
    }

    [ProtoContract] class LifeOnlineAccount(
       [ProtoMember(1)] public   uniqueId  {get;set;} long = 0L;
       [ProtoMember(2)] public   op  {get;set;} int = 0;
       [ProtoMember(3)] public   showTime  {get;set;} int = 0;
       [ProtoMember(4)] public   report  {get;set;} int = 0;
       [ProtoMember(5)] public   ack  {get;set;} int = 0;
       [ProtoMember(6)] public   bitmap  {get;set;} long = 0L;
       [ProtoMember(7)] public   gdtImpData  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(8)] public   gdtCliData  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(9)] public   viewId  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class LightAppElem(
       [ProtoMember(1)] public   data  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   msgResid  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class LocationInfo(
       [ProtoMember(1)] public   longitude  {get;set;} Double = 0.0;
       [ProtoMember(2)] public   latitude  {get;set;} Double = 0.0;
       [ProtoMember(3)] public   desc  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class LolaMsg(
       [ProtoMember(1)] public   msgResid  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   encodeContent  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   longMsgUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   downloadKey  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class LowVersionTips(
       [ProtoMember(1)] public   businessId  {get;set;} int = 0;
       [ProtoMember(2)] public   sessionType  {get;set;} int = 0;
       [ProtoMember(3)] public   sessionUin  {get;set;} long = 0L;
       [ProtoMember(4)] public   senderUin  {get;set;} long = 0L;
       [ProtoMember(5)] public   text  {get;set;} string = "";
    }

    [ProtoContract] data class MarketFace(
       [ProtoMember(1)  var faceName  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   itemType  {get;set;} int = 0;
       [ProtoMember(3)] public   faceInfo  {get;set;} int = 0;
       [ProtoMember(4)] public   faceId  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   tabId  {get;set;} int = 0;
       [ProtoMember(6)] public   subType  {get;set;} int = 0;
       [ProtoMember(7)] public   key  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(8)] public   param  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(9)] public   mediaType  {get;set;} int = 0;
       [ProtoMember(10)] public   imageWidth  {get;set;} int = 0;
       [ProtoMember(11)] public   imageHeight  {get;set;} int = 0;
       [ProtoMember(12)] public   mobileParam  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(13)] public   pbReserve  {get;set;} byte[] = Array.Empty<byte>();
    } {
        @Suppress("DuplicatedCode")
        override fun equals(other  {get;set;} Any?)  {get;set;} bool {
            if (this === other) return true
            if (javaClass != other?.javaClass) return false

            other as MarketFace

            if (!faceName.contentEquals(other.faceName)) return false
            if (itemType != other.itemType) return false
            if (faceInfo != other.faceInfo) return false
            if (!faceId.contentEquals(other.faceId)) return false
            if (tabId != other.tabId) return false
            if (subType != other.subType) return false
            if (!key.contentEquals(other.key)) return false
            if (!param.contentEquals(other.param)) return false
            if (mediaType != other.mediaType) return false
            if (imageWidth != other.imageWidth) return false
            if (imageHeight != other.imageHeight) return false
            if (!mobileParam.contentEquals(other.mobileParam)) return false
            if (!pbReserve.contentEquals(other.pbReserve)) return false

            return true
        }

        override fun hashCode()  {get;set;} int {
            var result = faceName.contentHashCode()
            result = 31 * result + itemType
            result = 31 * result + faceInfo
            result = 31 * result + faceId.contentHashCode()
            result = 31 * result + tabId
            result = 31 * result + subType
            result = 31 * result + key.contentHashCode()
            result = 31 * result + param.contentHashCode()
            result = 31 * result + mediaType
            result = 31 * result + imageWidth
            result = 31 * result + imageHeight
            result = 31 * result + mobileParam.contentHashCode()
            result = 31 * result + pbReserve.contentHashCode()
            return result
        }
    }

    [ProtoContract] class MarketTrans(
       [ProtoMember(1)] public   int32Flag  {get;set;} int = 0;
       [ProtoMember(2)] public   xml  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   msgResid  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   ability  {get;set;} int = 0;
       [ProtoMember(5)] public   minAbility  {get;set;} int = 0;
    }

    [ProtoContract] class MsgBody(
       [ProtoMember(1)] public   richText  {get;set;} RichText = RichText();
       [ProtoMember(2)] public   msgContent  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   msgEncryptContent  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class MsgBodySubtype4(
       [ProtoMember(1)] public   msgNotOnlineFile  {get;set;} NotOnlineFile? = null;
       [ProtoMember(2)] public   msgTime  {get;set;} int = 0;
    }

    [ProtoContract] class NearByMessageType(
       [ProtoMember(1)] public   type  {get;set;} int = 0;
       [ProtoMember(2)] public   identifyType  {get;set;} int = 0;
    }

    [ProtoContract] class NotOnlineFile(
       [ProtoMember(1)] public   fileType  {get;set;} int = 0;
       [ProtoMember(2)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   fileUuid  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   fileMd5  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   fileName  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   fileSize  {get;set;} long = 0L;
       [ProtoMember(7)] public   note  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(8)] public   reserved  {get;set;} int = 0;
       [ProtoMember(9)] public   subcmd  {get;set;} int = 0;
       [ProtoMember(10)] public   microCloud  {get;set;} int = 0;
       [ProtoMember(11)] public   bytesFileUrls  {get;set;} List<byte[]> = new();
       [ProtoMember(12)] public   downloadFlag  {get;set;} int = 0;
       [ProtoMember(50)] public   dangerEvel  {get;set;} int = 0;
       [ProtoMember(51)] public   lifeTime  {get;set;} int = 0;
       [ProtoMember(52)] public   uploadTime  {get;set;} int = 0;
       [ProtoMember(53)] public   absFileType  {get;set;} int = 0;
       [ProtoMember(54)] public   clientType  {get;set;} int = 0;
       [ProtoMember(55)] public   expireTime  {get;set;} int = 0;
       [ProtoMember(56)] public   pbReserve  {get;set;} byte[] = Array.Empty<byte>();
    }

    interface NotOnlineImageOrCustomFace {
        val thumbUrl  {get;set;} string
        val origUrl  {get;set;} string
        val _400Url  {get;set;} string
        val picMd5  {get;set;} byte[]
    }

    [ProtoContract] class NotOnlineImage(
       [ProtoMember(1)] public   filePath  {get;set;} string = "";
       [ProtoMember(2)] public   fileLen  {get;set;} long = 0L; // originally int
       [ProtoMember(3)] public   downloadPath  {get;set;} string = "";
       [ProtoMember(4)] public   oldVerSendFile  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   imgType  {get;set;} int = 0;
       [ProtoMember(6)] public   previewsImage  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(7) override val picMd5  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(8)] public   picHeight  {get;set;} int = 0;
       [ProtoMember(9)] public   picWidth  {get;set;} int = 0;
       [ProtoMember(10)] public   resId  {get;set;} string = "";
       [ProtoMember(11)] public   flag  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(12) override val thumbUrl  {get;set;} string = "";
       [ProtoMember(13)] public   original  {get;set;} int = 0;
       [ProtoMember(14)] public   bigUrl  {get;set;} string = "";
       [ProtoMember(15) override val origUrl  {get;set;} string = "";
       [ProtoMember(16)] public   bizType  {get;set;} int = 0;
       [ProtoMember(17)] public   result  {get;set;} int = 0;
       [ProtoMember(18)] public   index  {get;set;} int = 0;
       [ProtoMember(19)] public   opFaceBuf  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(20)] public   oldPicMd5  {get;set;} bool = false;
       [ProtoMember(21)] public   thumbWidth  {get;set;} int = 0;
       [ProtoMember(22)] public   thumbHeight  {get;set;} int = 0;
       [ProtoMember(23)] public   fileId  {get;set;} int = 0;
       [ProtoMember(24)] public   showLen  {get;set;} int = 0;
       [ProtoMember(25)] public   downloadLen  {get;set;} int = 0;
       [ProtoMember(26) override val _400Url  {get;set;} string = "";
       [ProtoMember(27)] public   _400Width  {get;set;} int = 0;
       [ProtoMember(28)] public   _400Height  {get;set;} int = 0;
       [ProtoMember(29)] public   pbReserve  {get;set;} byte[] = Array.Empty<byte>();
    }; NotOnlineImageOrCustomFace


    [ProtoContract] class OnlineImage(
       [ProtoMember(1)] public   guid  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   filePath  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   oldVerSendFile  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class OpenQQData(
       [ProtoMember(1)] public   carQqData  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class PatsElem(
       [ProtoMember(1)] public   patType  {get;set;} int = 0;
       [ProtoMember(2)] public   patCount  {get;set;} int = 0;
    }

    [ProtoContract] class PcSupportDef(
       [ProtoMember(1)] public   pcPtlBegin  {get;set;} int = 0;
       [ProtoMember(2)] public   pcPtlEnd  {get;set;} int = 0;
       [ProtoMember(3)] public   macPtlBegin  {get;set;} int = 0;
       [ProtoMember(4)] public   macPtlEnd  {get;set;} int = 0;
       [ProtoMember(5)] public   ptlsSupport  {get;set;} List<int> = new();
       [ProtoMember(6)] public   ptlsNotSupport  {get;set;} List<int> = new();
    }

    [ProtoContract] class Ptt(
       [ProtoMember(1)] public   fileType  {get;set;} int = 0;
       [ProtoMember(2)] public   srcUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   fileUuid  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   fileMd5  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   fileName  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   fileSize  {get;set;} int = 0;
       [ProtoMember(7)] public   reserve  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(8)] public   fileId  {get;set;} int = 0;
       [ProtoMember(9)] public   serverIp  {get;set;} int = 0;
       [ProtoMember(10)] public   serverPort  {get;set;} int = 0;
       [ProtoMember(11)] public   boolValid  {get;set;} bool = false;
       [ProtoMember(12)] public   signature  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(13)] public   shortcut  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(14)] public   fileKey  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(15)] public   magicPttIndex  {get;set;} int = 0;
       [ProtoMember(16)] public   voiceSwitch  {get;set;} int = 0;
       [ProtoMember(17)] public   pttUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(18)] public   groupFileKey  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(19)] public   time  {get;set;} int = 0;
       [ProtoMember(20)] public   downPara  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(29)] public   format  {get;set;} int = 0;
       [ProtoMember(30)] public   pbReserve  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(31)] public   bytesPttUrls  {get;set;} List<byte[]> = new();
       [ProtoMember(32)] public   downloadFlag  {get;set;} int = 0;
    }

    [ProtoContract] class PubAccInfo(
       [ProtoMember(1)] public   isInterNum  {get;set;} int = 0;
       [ProtoMember(2)] public   ingMsgTemplateId  {get;set;} string = "";
       [ProtoMember(3)] public   ingLongMsgUrl  {get;set;} string = "";
       [ProtoMember(4)] public   downloadKey  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class PubAccount(
       [ProtoMember(1)] public   buf  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   pubAccountUin  {get;set;} long = 0L;
    }

    [ProtoContract] class PubGroup(
       [ProtoMember(1)] public   nickname  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   gender  {get;set;} int = 0;
       [ProtoMember(3)] public   age  {get;set;} int = 0;
       [ProtoMember(4)] public   distance  {get;set;} int = 0;
    }

    [ProtoContract] class QQLiveOld(
       [ProtoMember(1)] public   subCmd  {get;set;} int = 0;
       [ProtoMember(2)] public   showText  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   param  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   introduce  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class QQWalletAioBody(
       [ProtoMember(1)] public   senduin  {get;set;} long = 0L;
       [ProtoMember(2)] public   sender  {get;set;} QQWalletAioElem? = null;
       [ProtoMember(3)] public   receiver  {get;set;} QQWalletAioElem? = null;
        @ProtoType(ProtoIntegerType.SIGNED)[ProtoMember(4)] public   sint32Channelid  {get;set;} int = 0;
        @ProtoType(ProtoIntegerType.SIGNED)[ProtoMember(5)] public   sint32Templateid  {get;set;} int = 0;
       [ProtoMember(6)] public   resend  {get;set;} int = 0;
       [ProtoMember(7)] public   msgPriority  {get;set;} int = 0;
        @ProtoType(ProtoIntegerType.SIGNED)[ProtoMember(8)] public   sint32Redtype  {get;set;} int = 0;
       [ProtoMember(9)] public   billno  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(10)] public   authkey  {get;set;} byte[] = Array.Empty<byte>();
        @ProtoType(ProtoIntegerType.SIGNED)[ProtoMember(11)] public   sint32Sessiontype  {get;set;} int = 0;
        @ProtoType(ProtoIntegerType.SIGNED)[ProtoMember(12)] public   sint32Msgtype  {get;set;} int = 0;
        @ProtoType(ProtoIntegerType.SIGNED)[ProtoMember(13)] public   sint32Envelopeid  {get;set;} int = 0;
       [ProtoMember(14)] public   name  {get;set;} byte[] = Array.Empty<byte>();
        @ProtoType(ProtoIntegerType.SIGNED)[ProtoMember(15)] public   sint32Conftype  {get;set;} int = 0;
        @ProtoType(ProtoIntegerType.SIGNED)[ProtoMember(16)] public   sint32MsgFrom  {get;set;} int = 0;
       [ProtoMember(17)] public   pcBody  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(18)] public   ingIndex  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(19)] public   redchannel  {get;set;} int = 0;
       [ProtoMember(20)] public   grapUin  {get;set;} List<Long> = new();
       [ProtoMember(21)] public   pbReserve  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class QQWalletAioElem(
       [ProtoMember(1)] public   background  {get;set;} int = 0;
       [ProtoMember(2)] public   icon  {get;set;} int = 0;
       [ProtoMember(3)] public   title  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   subtitle  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   content  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   linkurl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(7)] public   blackstripe  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(8)] public   notice  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(9)] public   titleColor  {get;set;} int = 0;
       [ProtoMember(10)] public   subtitleColor  {get;set;} int = 0;
       [ProtoMember(11)] public   actionsPriority  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(12)] public   jumpUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(13)] public   nativeIos  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(14)] public   nativeAndroid  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(15)] public   iconurl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(16)] public   contentColor  {get;set;} int = 0;
       [ProtoMember(17)] public   contentBgcolor  {get;set;} int = 0;
       [ProtoMember(18)] public   aioImageLeft  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(19)] public   aioImageRight  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(20)] public   cftImage  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(21)] public   pbReserve  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class QQWalletMsg(
       [ProtoMember(1)] public   aioBody  {get;set;} QQWalletAioBody? = null;
    }

    [ProtoContract] class RedBagInfo(
       [ProtoMember(1)] public   redbagType  {get;set;} int = 0;
    }

    [ProtoContract] class RichMsg(
       [ProtoMember(1)] public   template1  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   serviceId  {get;set;} int = 0;
       [ProtoMember(3)] public   msgResid  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   rand  {get;set;} int = 0;
       [ProtoMember(5)] public   seq  {get;set;} int = 0;
       [ProtoMember(6)] public   flags  {get;set;} int = 0;
    }

    [ProtoContract] class RichText(
       [ProtoMember(1)] public   attr  {get;set;} Attr? = null;
       [ProtoMember(2)] public   elems  {get;set;} MutableList<Elem> = mutableListOf();
       [ProtoMember(3)] public   notOnlineFile  {get;set;} NotOnlineFile? = null;
       [ProtoMember(4)] public   ptt  {get;set;} Ptt? = null;
       [ProtoMember(5)] public   tmpPtt  {get;set;} TmpPtt? = null;
       [ProtoMember(6)] public   trans211TmpMsg  {get;set;} Trans211TmpMsg? = null;
    }

    [ProtoContract] class SecretFileMsg(
       [ProtoMember(1)] public   fileKey  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   fromUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(4)] public   status  {get;set;} int = 0;
       [ProtoMember(5)] public   ttl  {get;set;} int = 0;
       [ProtoMember(6)] public   type  {get;set;} int = 0;
       [ProtoMember(7)] public   encryptPreheadLength  {get;set;} int = 0;
       [ProtoMember(8)] public   encryptType  {get;set;} int = 0;
       [ProtoMember(9)] public   encryptKey  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(10)] public   readTimes  {get;set;} int = 0;
       [ProtoMember(11)] public   leftTime  {get;set;} int = 0;
       [ProtoMember(12)] public   notOnlineImage  {get;set;} NotOnlineImage? = null;
       [ProtoMember(13)] public   elemFlags2  {get;set;} ElemFlags2? = null;
       [ProtoMember(14)] public   opertype  {get;set;} int = 0;
       [ProtoMember(15)] public   fromphonenum  {get;set;} string = "";
    }

    [ProtoContract] class ShakeWindow(
       [ProtoMember(1)] public   type  {get;set;} int = 0;
       [ProtoMember(2)] public   reserve  {get;set;} int = 0;
       [ProtoMember(3)] public   uin  {get;set;} long = 0L;
    }

    [ProtoContract] class SmallEmoji(
       [ProtoMember(1)] public   packIdSum  {get;set;} int = 0;
       [ProtoMember(2)] public   imageType  {get;set;} int = 0;
    }

    [ProtoContract] class SourceMsg(
       [ProtoMember(1)] public   origSeqs  {get;set;} intArray = intArrayOf();
       [ProtoMember(2)] public   senderUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   time  {get;set;} int = 0;
       [ProtoMember(4)] public   flag  {get;set;} int = 0;
       [ProtoMember(5)] public   elems  {get;set;} List<Elem> = new();
       [ProtoMember(6)] public   type  {get;set;} int = 0;
       [ProtoMember(7)] public   richMsg  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(8)] public   pbReserve  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(9)] public   srcMsg  {get;set;} byte[]? = null;
       [ProtoMember(10)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(11)] public   troopName  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class Text(
       [ProtoMember(1)] public   str  {get;set;} string = "";
       [ProtoMember(2)] public   link  {get;set;} string = "";
       [ProtoMember(3)] public   attr6Buf  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   attr7Buf  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(11)] public   buf  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(12)] public   pbReserve  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class TipsInfo(
       [ProtoMember(1)] public   text  {get;set;} string = "";
    }

    [ProtoContract] class TmpPtt(
       [ProtoMember(1)] public   fileType  {get;set;} int = 0;
       [ProtoMember(2)] public   fileUuid  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   fileMd5  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   fileName  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   fileSize  {get;set;} int = 0;
       [ProtoMember(6)] public   pttTimes  {get;set;} int = 0;
       [ProtoMember(7)] public   userType  {get;set;} int = 0;
       [ProtoMember(8)] public   ptttransFlag  {get;set;} int = 0;
       [ProtoMember(9)] public   busiType  {get;set;} int = 0;
       [ProtoMember(10)] public   msgId  {get;set;} long = 0L;
       [ProtoMember(30)] public   pbReserve  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(31)] public   pttEncodeData  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class Trans211TmpMsg(
       [ProtoMember(1)] public   msgBody  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   c2cCmd  {get;set;} int = 0;
    }

    [ProtoContract] class TransElem(
       [ProtoMember(1)] public   elemType  {get;set;} int = 0;
       [ProtoMember(2)] public   elemValue  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class VideoFile(
       [ProtoMember(1)] public   fileUuid  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   fileMd5  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   fileName  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   fileFormat  {get;set;} int = 0;
       [ProtoMember(5)] public   fileTime  {get;set;} int = 0;
       [ProtoMember(6)] public   fileSize  {get;set;} int = 0;
       [ProtoMember(7)] public   thumbWidth  {get;set;} int = 0;
       [ProtoMember(8)] public   thumbHeight  {get;set;} int = 0;
       [ProtoMember(9)] public   thumbFileMd5  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(10)] public   source  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(11)] public   thumbFileSize  {get;set;} int = 0;
       [ProtoMember(12)] public   busiType  {get;set;} int = 0;
       [ProtoMember(13)] public   fromChatType  {get;set;} int = 0;
       [ProtoMember(14)] public   toChatType  {get;set;} int = 0;
       [ProtoMember(15)] public   boolSupportProgressive  {get;set;} bool = false;
       [ProtoMember(16)] public   fileWidth  {get;set;} int = 0;
       [ProtoMember(17)] public   fileHeight  {get;set;} int = 0;
       [ProtoMember(18)] public   subBusiType  {get;set;} int = 0;
       [ProtoMember(19)] public   videoAttr  {get;set;} int = 0;
       [ProtoMember(20)] public   bytesThumbFileUrls  {get;set;} List<byte[]> = new();
       [ProtoMember(21)] public   bytesVideoFileUrls  {get;set;} List<byte[]> = new();
       [ProtoMember(22)] public   thumbDownloadFlag  {get;set;} int = 0;
       [ProtoMember(23)] public   videoDownloadFlag  {get;set;} int = 0;
       [ProtoMember(24)] public   pbReserve  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class WorkflowNotifyMsg(
       [ProtoMember(1)] public   extMsg  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   createUin  {get;set;} long = 0L;
    }
}

[ProtoContract] class ImMsgHead  {
    [ProtoContract] class C2CHead(
       [ProtoMember(1)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   fromUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   ccType  {get;set;} int = 0;
       [ProtoMember(4)] public   ccCmd  {get;set;} int = 0;
       [ProtoMember(5)] public   authPicSig  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   authSig  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(7)] public   authBuf  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(8)] public   serverTime  {get;set;} int = 0;
       [ProtoMember(9)] public   clientTime  {get;set;} int = 0;
       [ProtoMember(10)] public   rand  {get;set;} int = 0;
       [ProtoMember(11)] public   ingPhoneNumber  {get;set;} string = "";
    }

    [ProtoContract] class CSHead(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L;
       [ProtoMember(2)] public   command  {get;set;} int = 0;
       [ProtoMember(3)] public   seq  {get;set;} int = 0;
       [ProtoMember(4)] public   version  {get;set;} int = 0;
       [ProtoMember(5)] public   retryTimes  {get;set;} int = 0;
       [ProtoMember(6)] public   clientType  {get;set;} int = 0;
       [ProtoMember(7)] public   pubno  {get;set;} int = 0;
       [ProtoMember(8)] public   localid  {get;set;} int = 0;
       [ProtoMember(9)] public   timezone  {get;set;} int = 0;
        @ProtoType(ProtoIntegerType.FIXED)[ProtoMember(10)] public   clientIp  {get;set;} int = 0;
       [ProtoMember(11)] public   clientPort  {get;set;} int = 0;
        @ProtoType(ProtoIntegerType.FIXED)[ProtoMember(12)] public   connIp  {get;set;} int = 0;
       [ProtoMember(13)] public   connPort  {get;set;} int = 0;
        @ProtoType(ProtoIntegerType.FIXED)[ProtoMember(14)] public   interfaceIp  {get;set;} int = 0;
       [ProtoMember(15)] public   interfacePort  {get;set;} int = 0;
        @ProtoType(ProtoIntegerType.FIXED)[ProtoMember(16)] public   actualIp  {get;set;} int = 0;
       [ProtoMember(17)] public   flag  {get;set;} int = 0;
        @ProtoType(ProtoIntegerType.FIXED)[ProtoMember(18)] public   timestamp  {get;set;} int = 0;
       [ProtoMember(19)] public   subcmd  {get;set;} int = 0;
       [ProtoMember(20)] public   result  {get;set;} int = 0;
       [ProtoMember(21)] public   appId  {get;set;} int = 0;
       [ProtoMember(22)] public   instanceId  {get;set;} int = 0;
       [ProtoMember(23)] public   sessionId  {get;set;} long = 0L;
       [ProtoMember(24)] public   idcId  {get;set;} int = 0;
    }

    [ProtoContract] class DeltaHead(
       [ProtoMember(1)] public   totalLen  {get;set;} long = 0L;
       [ProtoMember(2)] public   offset  {get;set;} long = 0L;
       [ProtoMember(3)] public   ackOffset  {get;set;} long = 0L;
       [ProtoMember(4)] public   cookie  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   ackCookie  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   result  {get;set;} int = 0;
       [ProtoMember(7)] public   flags  {get;set;} int = 0;
    }

    [ProtoContract] class Head(
       [ProtoMember(1)] public   headType  {get;set;} int = 0;
       [ProtoMember(2)] public   msgCsHead  {get;set;} CSHead? = null;
       [ProtoMember(3)] public   msgS2cHead  {get;set;} S2CHead? = null;
       [ProtoMember(4)] public   msgHttpconnHead  {get;set;} HttpConnHead? = null;
       [ProtoMember(5)] public   paintFlag  {get;set;} int = 0;
       [ProtoMember(6)] public   msgLoginSig  {get;set;} LoginSig? = null;
       [ProtoMember(7)] public   msgDeltaHead  {get;set;} DeltaHead? = null;
       [ProtoMember(8)] public   msgC2cHead  {get;set;} C2CHead? = null;
       [ProtoMember(9)] public   msgSconnHead  {get;set;} SConnHead? = null;
       [ProtoMember(10)] public   msgInstCtrl  {get;set;} InstCtrl? = null;
    }

    [ProtoContract] class HttpConnHead(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L;
       [ProtoMember(2)] public   command  {get;set;} int = 0;
       [ProtoMember(3)] public   subCommand  {get;set;} int = 0;
       [ProtoMember(4)] public   seq  {get;set;} int = 0;
       [ProtoMember(5)] public   version  {get;set;} int = 0;
       [ProtoMember(6)] public   retryTimes  {get;set;} int = 0;
       [ProtoMember(7)] public   clientType  {get;set;} int = 0;
       [ProtoMember(8)] public   pubNo  {get;set;} int = 0;
       [ProtoMember(9)] public   localId  {get;set;} int = 0;
       [ProtoMember(10)] public   timeZone  {get;set;} int = 0;
        @ProtoType(ProtoIntegerType.FIXED)[ProtoMember(11)] public   clientIp  {get;set;} int = 0;
       [ProtoMember(12)] public   clientPort  {get;set;} int = 0;
        @ProtoType(ProtoIntegerType.FIXED)[ProtoMember(13)] public   qzhttpIp  {get;set;} int = 0;
       [ProtoMember(14)] public   qzhttpPort  {get;set;} int = 0;
        @ProtoType(ProtoIntegerType.FIXED)[ProtoMember(15)] public   sppIp  {get;set;} int = 0;
       [ProtoMember(16)] public   sppPort  {get;set;} int = 0;
       [ProtoMember(17)] public   flag  {get;set;} int = 0;
       [ProtoMember(18)] public   key  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(19)] public   compressType  {get;set;} int = 0;
       [ProtoMember(20)] public   originSize  {get;set;} int = 0;
       [ProtoMember(21)] public   errorCode  {get;set;} int = 0;
       [ProtoMember(22)] public   msgRedirect  {get;set;} RedirectMsg? = null;
       [ProtoMember(23)] public   commandId  {get;set;} int = 0;
       [ProtoMember(24)] public   serviceCmdid  {get;set;} int = 0;
       [ProtoMember(25)] public   msgOidbhead  {get;set;} TransOidbHead? = null;
    }

    [ProtoContract] class InstCtrl(
       [ProtoMember(1)] public   msgSendToInst  {get;set;} List<InstInfo> = new();
       [ProtoMember(2)] public   msgExcludeInst  {get;set;} List<InstInfo> = new();
       [ProtoMember(3)] public   msgFromInst  {get;set;} InstInfo? = InstInfo();
    }

    [ProtoContract] class InstInfo(
       [ProtoMember(1)] public   apppid  {get;set;} int = 0;
       [ProtoMember(2)] public   instid  {get;set;} int = 0;
       [ProtoMember(3)] public   platform  {get;set;} int = 0;
       [ProtoMember(10)] public   enumDeviceType  {get;set;} int /* enum */ = 0;
    }

    [ProtoContract] class LoginSig(
       [ProtoMember(1)] public   type  {get;set;} int = 0;
       [ProtoMember(2)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class RedirectMsg(
        @ProtoType(ProtoIntegerType.FIXED)[ProtoMember(1)] public   lastRedirectIp  {get;set;} int = 0;
       [ProtoMember(2)] public   lastRedirectPort  {get;set;} int = 0;
        @ProtoType(ProtoIntegerType.FIXED)[ProtoMember(3)] public   redirectIp  {get;set;} int = 0;
       [ProtoMember(4)] public   redirectPort  {get;set;} int = 0;
       [ProtoMember(5)] public   redirectCount  {get;set;} int = 0;
    }

    [ProtoContract] class S2CHead(
       [ProtoMember(1)] public   subMsgtype  {get;set;} int = 0;
       [ProtoMember(2)] public   msgType  {get;set;} int = 0;
       [ProtoMember(3)] public   fromUin  {get;set;} long = 0L;
       [ProtoMember(4)] public   msgId  {get;set;} int = 0;
        @ProtoType(ProtoIntegerType.FIXED)[ProtoMember(5)] public   relayIp  {get;set;} int = 0;
       [ProtoMember(6)] public   relayPort  {get;set;} int = 0;
       [ProtoMember(7)] public   toUin  {get;set;} long = 0L;
    }

    [ProtoContract] class SConnHead 

    [ProtoContract] class TransOidbHead(
       [ProtoMember(1)] public   command  {get;set;} int = 0;
       [ProtoMember(2)] public   serviceType  {get;set;} int = 0;
       [ProtoMember(3)] public   result  {get;set;} int = 0;
       [ProtoMember(4)] public   errorMsg  {get;set;} string = "";
    }
}

[ProtoContract] class ImReceipt  {
    [ProtoContract] class MsgInfo(
       [ProtoMember(1)] public   fromUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   msgSeq  {get;set;} int = 0;
       [ProtoMember(4)] public   msgRandom  {get;set;} int = 0;
    }

    [ProtoContract] data class ReceiptInfo(
       [ProtoMember(1)] public   readTime  {get;set;} long = 0L;
    }

    [ProtoContract] class ReceiptReq(
       [ProtoMember(1)] public   command  {get;set;} int /* enum */ = 1;
       [ProtoMember(2)] public   msgInfo  {get;set;} MsgInfo? = null;
    }

    [ProtoContract] class ReceiptResp(
       [ProtoMember(1)] public   command  {get;set;} int /* enum */ = 1;
       [ProtoMember(2)] public   receiptInfo  {get;set;} ReceiptInfo? = null;
    }
}

[ProtoContract] class ObjMsg  {
    [ProtoContract] class MsgContentInfo(
       [ProtoMember(1)] public   contentInfoId  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   msgFile  {get;set;} MsgFile? = null;
    } {
        [ProtoContract]
        internal class MsgFile(
           [ProtoMember(1)] public   busId  {get;set;} int = 0;
           [ProtoMember(2)] public   filePath  {get;set;} string = ""; // actually uuid
           [ProtoMember(3)] public   fileSize  {get;set;} long = 0L;
           [ProtoMember(4)] public   fileName  {get;set;} string = "";
           [ProtoMember(5)] public   int64DeadTime  {get;set;} long = 0L;
           [ProtoMember(6)] public   fileSha1  {get;set;} byte[] = Array.Empty<byte>(); // empty
           [ProtoMember(7)] public   ext  {get;set;} string = ""; // originally bytes
        }
    }

    [ProtoContract] class MsgPic(
       [ProtoMember(1)] public   smallPicUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   originalPicUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   localPicId  {get;set;} int = 0;
    }

    [ProtoContract] class ObjMsg(
       [ProtoMember(1)] public   msgType  {get;set;} int = 0;
       [ProtoMember(2)] public   title  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   bytesAbstact  {get;set;} List<byte[]> = new();
       [ProtoMember(5)] public   titleExt  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   msgPic  {get;set;} List<MsgPic> = new();
       [ProtoMember(7)] public   msgContentInfo  {get;set;} List<MsgContentInfo> = new();
       [ProtoMember(8)] public   reportIdShow  {get;set;} int = 0;
    }
}
