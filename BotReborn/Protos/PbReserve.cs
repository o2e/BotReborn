using ProtoBuf;

internal class NotOnlineImage {
    [ProtoContract] class ResvAttr{[ProtoMember(1)] public     imageBizType  {get;set;} int = 0;
        [ProtoMember(2)] public     customfaceType  {get;set;} int = 0;
        [ProtoMember(3)] public     emojiPackageid  {get;set;} int = 0;
        [ProtoMember(4)] public     emojiId  {get;set;} int = 0;
        [ProtoMember(5)] public     text  {get;set;} string = "";
        [ProtoMember(6)] public     doutuSuppliers  {get;set;} string = "";
        [ProtoMember(8)] public     textSummary  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(10)] public     emojiFrom  {get;set;} int = 0;
        [ProtoMember(11)] public     emojiSource  {get;set;} string = "";
        [ProtoMember(12)] public     emojiWebUrl  {get;set;} string = "";
        [ProtoMember(13)] public     emojiIconUrl  {get;set;} string = "";
        [ProtoMember(14)] public     emojiMarketFaceName  {get;set;} string = "";
        [ProtoMember(15)] public     source  {get;set;} int = 0;
        [ProtoMember(16)] public     cameraCaptureTemplateinfo  {get;set;} string = "";
        [ProtoMember(17)] public     cameraCaptureMaterialname  {get;set;} string = "";
        [ProtoMember(18)] public     adEmoJumpUrl  {get;set;} string = "";
        [ProtoMember(19)] public     adEmoDescStr  {get;set;} string = "";
    }
}

internal class CustomFace {
    [ProtoContract] class AnimationImageShow{[ProtoMember(1)] public     int32EffectId  {get;set;} int = 0;
        [ProtoMember(2)] public     animationParam  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class ResvAttr{[ProtoMember(1)] public     imageBizType  {get;set;} int = 0;
        [ProtoMember(2)] public     customfaceType  {get;set;} int = 0;
        [ProtoMember(3)] public     emojiPackageid  {get;set;} int = 0;
        [ProtoMember(4)] public     emojiId  {get;set;} int = 0;
        [ProtoMember(5)] public     text  {get;set;} string = "";
        [ProtoMember(6)] public     doutuSuppliers  {get;set;} string = "";
        [ProtoMember(7)] public     msgImageShow  {get;set;} AnimationImageShow? = null;
        [ProtoMember(9)] public     textSummary  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(10)] public     emojiFrom  {get;set;} int = 0;
        [ProtoMember(11)] public     emojiSource  {get;set;} string = "";
        [ProtoMember(12)] public     emojiWebUrl  {get;set;} string = "";
        [ProtoMember(13)] public     emojiIconUrl  {get;set;} string = "";
        [ProtoMember(14)] public     emojiMarketFaceName  {get;set;} string = "";
        [ProtoMember(15)] public     source  {get;set;} int = 0;
        [ProtoMember(16)] public     cameraCaptureTemplateinfo  {get;set;} string = "";
        [ProtoMember(17)] public     cameraCaptureMaterialname  {get;set;} string = "";
        [ProtoMember(18)] public     adEmoJumpUrl  {get;set;} string = "";
        [ProtoMember(19)] public     adEmoDescStr  {get;set;} string = "";
    }
}

internal class Generalflags  {
    [ProtoContract] class ResvAttr(
       [ProtoMember(1)] public   globalGroupLevel  {get;set;} int = 0;
       [ProtoMember(2)] public   nearbyCharmLevel  {get;set;} int = 0;
       [ProtoMember(3)] public   redbagMsgSenderUin  {get;set;} long = 0L;
       [ProtoMember(4)] public   titleId  {get;set;} int = 0;
       [ProtoMember(5)] public   robotMsgFlag  {get;set;} int = 0;
       [ProtoMember(6)] public   wantGiftSenderUin  {get;set;} long = 0L;
       [ProtoMember(7)] public   stickerX  {get;set;} Float = 0.0f;
       [ProtoMember(8)] public   stickerY  {get;set;} Float = 0.0f;
       [ProtoMember(9)] public   stickerWidth  {get;set;} Float = 0.0f;
       [ProtoMember(10)] public   stickerHeight  {get;set;} Float = 0.0f;
       [ProtoMember(11)] public   stickerRotate  {get;set;} int = 0;
       [ProtoMember(12)] public   stickerHostMsgseq  {get;set;} long = 0L;
       [ProtoMember(13)] public   stickerHostMsguid  {get;set;} long = 0L;
       [ProtoMember(14)] public   stickerHostTime  {get;set;} long = 0L;
       [ProtoMember(15)] public   mobileCustomFont  {get;set;} int = 0;
       [ProtoMember(16)] public   tailKey  {get;set;} int = 0;
       [ProtoMember(17)] public   showTailFlag  {get;set;} int = 0;
       [ProtoMember(18)] public   doutuMsgType  {get;set;} int = 0;
       [ProtoMember(19)] public   doutuCombo  {get;set;} int = 0;
       [ProtoMember(20)] public   customFeatureid  {get;set;} int = 0;
       [ProtoMember(21)] public   goldenMsgType  {get;set;} int = 0;
       [ProtoMember(22)] public   goldenMsgInfo  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(23)] public   botMessageClassId  {get;set;} int = 0;
       [ProtoMember(24)] public   subscriptionUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(25)] public   pendantDiyId  {get;set;} int = 0;
       [ProtoMember(26)] public   timedMessage  {get;set;} int = 0;
       [ProtoMember(27)] public   holidayFlag  {get;set;} int = 0;
       [ProtoMember(29)] public   kplInfo  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(30)] public   faceId  {get;set;} int = 0;
       [ProtoMember(31)] public   diyFontTimestamp  {get;set;} int = 0;
       [ProtoMember(32)] public   redEnvelopeType  {get;set;} int = 0;
       [ProtoMember(33)] public   shortVideoId  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(34)] public   reqFontEffectId  {get;set;} int = 0;
       [ProtoMember(35)] public   loveLanguageFlag  {get;set;} int = 0;
       [ProtoMember(36)] public   aioSyncToStoryFlag  {get;set;} int = 0;
       [ProtoMember(37)] public   uploadImageToQzoneFlag  {get;set;} int = 0;
       [ProtoMember(39)] public   uploadImageToQzoneParam  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(40)] public   groupConfessSig  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(41)] public   subfontId  {get;set;} long = 0L;
       [ProtoMember(42)] public   msgFlagType  {get;set;} int = 0;
       [ProtoMember(43)] public   uint32CustomFeatureid  {get;set;} List<int> = new();
       [ProtoMember(44)] public   richCardNameVer  {get;set;} int = 0;
       [ProtoMember(47)] public   msgInfoFlag  {get;set;} int = 0;
       [ProtoMember(48)] public   serviceMsgType  {get;set;} int = 0;
       [ProtoMember(49)] public   serviceMsgRemindType  {get;set;} int = 0;
       [ProtoMember(50)] public   serviceMsgName  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(51)] public   vipType  {get;set;} int = 0;
       [ProtoMember(52)] public   vipLevel  {get;set;} int = 0;
       [ProtoMember(53)] public   pbPttWaveform  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(54)] public   userBigclubLevel  {get;set;} int = 0;
       [ProtoMember(55)] public   userBigclubFlag  {get;set;} int = 0;
       [ProtoMember(56)] public   nameplate  {get;set;} int = 0;
       [ProtoMember(57)] public   autoReply  {get;set;} int = 0;
       [ProtoMember(58)] public   reqIsBigclubHidden  {get;set;} int = 0;
       [ProtoMember(59)] public   showInMsgList  {get;set;} int = 0;
       [ProtoMember(60)] public   oacMsgExtend  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(61)] public   groupMemberFlagEx2  {get;set;} int = 0;
       [ProtoMember(62)] public   groupRingtoneId  {get;set;} int = 0;
       [ProtoMember(63)] public   robotGeneralTrans  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(64)] public   troopPobingTemplate  {get;set;} int = 0;
       [ProtoMember(65)] public   hudongMark  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(66)] public   groupInfoFlagEx3  {get;set;} int = 0;
    }
}

[ProtoContract] class ResvAttrForGiftMsg  {
    [ProtoContract] class ActivityGiftInfo(
       [ProtoMember(1)] public   isActivityGift  {get;set;} int = 0;
       [ProtoMember(2)] public   textColor  {get;set;} string = "";
       [ProtoMember(3)] public   text  {get;set;} string = "";
       [ProtoMember(4)] public   url  {get;set;} string = "";
    }

    [ProtoContract] class InteractGift(
       [ProtoMember(1)] public   interactId  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class ResvAttr(
       [ProtoMember(1)] public   int32SendScore  {get;set;} int = 0;
       [ProtoMember(2)] public   int32RecvScore  {get;set;} int = 0;
       [ProtoMember(3)] public   charmHeroism  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   buttonFlag  {get;set;} int = 0;
       [ProtoMember(5)] public   objColor  {get;set;} int = 0;
       [ProtoMember(6)] public   animationType  {get;set;} int = 0;
       [ProtoMember(7)] public   msgInteractGift  {get;set;} interactGift? = null;
       [ProtoMember(8)] public   activityGiftInfo  {get;set;} ActivityGiftInfo? = null;
    }
}

[ProtoContract] class SourceMsg  {
    [ProtoContract] class ResvAttr(
       [ProtoMember(1)] public   richMsg2  {get;set;} byte[]? = null;
       [ProtoMember(2)] public   oriMsgtype  {get;set;} int? = null;
       [ProtoMember(3)] public   origUids  {get;set;} List<Long>? = null;
    }
}

[ProtoContract] class VideoFile  {
    [ProtoContract] class ResvAttr(
       [ProtoMember(1)] public   hotvideoIcon  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   hotvideoTitle  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   hotvideoUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   hotvideoIconSub  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   specialVideoType  {get;set;} int = 0;
       [ProtoMember(6)] public   dynamicText  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(7)] public   msgTailType  {get;set;} int = 0;
       [ProtoMember(8)] public   redEnvelopeType  {get;set;} int = 0;
       [ProtoMember(9)] public   shortVideoId  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(10)] public   animojiModelId  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(11)] public   longVideoKandianType  {get;set;} int = 0;
       [ProtoMember(12)] public   source  {get;set;} int = 0;
    }
}
