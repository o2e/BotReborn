

using ProtoBuf;

@file  {get;set;}Suppress("SpellCheckingInspection")




import kotlinx.serialization.protobuf.ProtoIntegerType

import kotlinx.serialization.protobuf.ProtoType



internal class GroupOpenSysMsg  {
    [ProtoContract] class LightApp(
       [ProtoMember(1)] public   app  {get;set;} string = "";
       [ProtoMember(2)] public   view  {get;set;} string = "";
       [ProtoMember(3)] public   desc  {get;set;} string = "";
       [ProtoMember(4)] public   prompt  {get;set;} string = "";
       [ProtoMember(5)] public   ver  {get;set;} string = "";
       [ProtoMember(6)] public   meta  {get;set;} string = "";
       [ProtoMember(7)] public   config  {get;set;} string = "";
       [ProtoMember(8)] public   source  {get;set;} Source? = null;
    }

    [ProtoContract] class RichMsg(
       [ProtoMember(1)] public   title  {get;set;} string = "";
       [ProtoMember(2)] public   desc  {get;set;} string = "";
       [ProtoMember(3)] public   brief  {get;set;} string = "";
       [ProtoMember(4)] public   cover  {get;set;} string = "";
       [ProtoMember(5)] public   url  {get;set;} string = "";
       [ProtoMember(6)] public   source  {get;set;} Source? = null;
    }

    [ProtoContract] class Sender(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L;
       [ProtoMember(2)] public   nick  {get;set;} string = "";
       [ProtoMember(3)] public   avatar  {get;set;} string = "";
       [ProtoMember(4)] public   url  {get;set;} string = "";
    }

    [ProtoContract] class Source(
       [ProtoMember(1)] public   name  {get;set;} string = "";
       [ProtoMember(2)] public   icon  {get;set;} string = "";
       [ProtoMember(3)] public   url  {get;set;} string = "";
    }

    [ProtoContract] class SysMsgBody(
       [ProtoMember(1)] public   groupId  {get;set;} long = 0L;
       [ProtoMember(2)] public   appid  {get;set;} long = 0L;
       [ProtoMember(3)] public   sender  {get;set;} Sender? = null;
       [ProtoMember(4)] public   msgType  {get;set;} int = 0;
       [ProtoMember(5)] public   content  {get;set;} string = "";
       [ProtoMember(6)] public   richMsg  {get;set;} RichMsg? = null;
       [ProtoMember(7)] public   lightApp  {get;set;} LightApp? = null;
    }
}

[ProtoContract] class TroopTips0x857  {
    [ProtoContract] class AIOGrayTipsInfo(
       [ProtoMember(1)] public   optUint32ShowLastest  {get;set;} int = 0;
       [ProtoMember(2)] public   optBytesContent  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   optUint32Remind  {get;set;} int = 0;
       [ProtoMember(4)] public   optBytesBrief  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   receiverUin  {get;set;} long = 0L;
       [ProtoMember(6)] public   reliaoAdminOpt  {get;set;} int = 0;
       [ProtoMember(7)] public   robotGroupOpt  {get;set;} int = 0;
    }

    [ProtoContract] class AIOTopTipsInfo(
       [ProtoMember(1)] public   optBytesContent  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   optUint32Icon  {get;set;} int = 0;
       [ProtoMember(3)] public   optEnumAction  {get;set;} int /* enum */ = 1;
       [ProtoMember(4)] public   optBytesUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   optBytesData  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   optBytesDataI  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(7)] public   optBytesDataA  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(8)] public   optBytesDataP  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class FloatedTipsInfo(
       [ProtoMember(1)] public   optBytesContent  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class GeneralGrayTipInfo(
       [ProtoMember(1)] public   busiType  {get;set;} long = 0L;
       [ProtoMember(2)] public   busiId  {get;set;} long = 0L;
       [ProtoMember(3)] public   ctrlFlag  {get;set;} int = 0;
       [ProtoMember(4)] public   c2cType  {get;set;} int = 0;
       [ProtoMember(5)] public   serviceType  {get;set;} int = 0;
       [ProtoMember(6)] public   templId  {get;set;} long = 0L;
       [ProtoMember(7)] public   msgTemplParam  {get;set;} List<TemplParam> = new();
       [ProtoMember(8)] public   content  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(10)] public   tipsSeqId  {get;set;} long = 0L;
       [ProtoMember(100)] public   pbReserv  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class GoldMsgTipsElem(
       [ProtoMember(1)] public   type  {get;set;} int = 0;
       [ProtoMember(2)] public   billno  {get;set;} string = "";
       [ProtoMember(3)] public   result  {get;set;} int = 0;
       [ProtoMember(4)] public   amount  {get;set;} int = 0;
       [ProtoMember(5)] public   total  {get;set;} int = 0;
       [ProtoMember(6)] public   interval  {get;set;} int = 0;
       [ProtoMember(7)] public   finish  {get;set;} int = 0;
       [ProtoMember(8)] public   uin  {get;set;} List<Long> = new();
       [ProtoMember(9)] public   action  {get;set;} int = 0;
    }

    [ProtoContract] class GroupInfoChange(
       [ProtoMember(1)] public   groupHonorSwitch  {get;set;} int = 0;
    }

    [ProtoContract] class GroupNotifyInfo(
       [ProtoMember(1)] public   optUint32AutoPullFlag  {get;set;} int = 0;
       [ProtoMember(2)] public   optBytesFeedsId  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class InstCtrl(
       [ProtoMember(1)] public   msgSendToInst  {get;set;} List<InstInfo> = new();
       [ProtoMember(2)] public   msgExcludeInst  {get;set;} List<InstInfo> = new();
       [ProtoMember(3)] public   msgFromInst  {get;set;} InstInfo? = null;
    }

    [ProtoContract] class InstInfo(
       [ProtoMember(1)] public   apppid  {get;set;} int = 0;
       [ProtoMember(2)] public   instid  {get;set;} int = 0;
       [ProtoMember(3)] public   platform  {get;set;} int = 0;
       [ProtoMember(4)] public   openAppid  {get;set;} int = 0;
       [ProtoMember(5)] public   productid  {get;set;} int = 0;
       [ProtoMember(6)] public   ssoBid  {get;set;} int = 0;
       [ProtoMember(7)] public   guid  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(8)] public   verMin  {get;set;} int = 0;
       [ProtoMember(9)] public   verMax  {get;set;} int = 0;
    }

    [ProtoContract] class LbsShareChangePushInfo(
       [ProtoMember(1)] public   msgType  {get;set;} int = 0;
       [ProtoMember(2)] public   msgInfo  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   versionCtrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   groupId  {get;set;} long = 0L;
       [ProtoMember(5)] public   operUin  {get;set;} long = 0L;
       [ProtoMember(6)] public   grayTips  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(7)] public   msgSeq  {get;set;} long = 0L;
       [ProtoMember(8)] public   joinNums  {get;set;} int = 0;
       [ProtoMember(99)] public   pushType  {get;set;} int = 0;
       [ProtoMember(100)] public   extInfo  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class LuckyBagNotify(
       [ProtoMember(1)] public   msgTips  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class MediaChangePushInfo(
       [ProtoMember(1)] public   msgType  {get;set;} int = 0;
       [ProtoMember(2)] public   msgInfo  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   versionCtrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   groupId  {get;set;} long = 0L;
       [ProtoMember(5)] public   operUin  {get;set;} long = 0L;
       [ProtoMember(6)] public   grayTips  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(7)] public   msgSeq  {get;set;} long = 0L;
       [ProtoMember(8)] public   joinNums  {get;set;} int = 0;
       [ProtoMember(9)] public   msgPerSetting  {get;set;} PersonalSetting? = null;
       [ProtoMember(10)] public   playMode  {get;set;} int = 0;
       [ProtoMember(99)] public   mediaType  {get;set;} int = 0;
       [ProtoMember(100)] public   extInfo  {get;set;} byte[] = Array.Empty<byte>();
    } {
        [ProtoContract]
        internal class PersonalSetting(
           [ProtoMember(1)] public   themeId  {get;set;} int = 0;
           [ProtoMember(2)] public   playerId  {get;set;} int = 0;
           [ProtoMember(3)] public   fontId  {get;set;} int = 0;
        }
    }

    [ProtoContract] class MessageBoxInfo(
       [ProtoMember(1)] public   optBytesContent  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   optBytesTitle  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   optBytesButton  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class MessageRecallReminder(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L;
       [ProtoMember(2)] public   nickname  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   recalledMsgList  {get;set;} List<MessageMeta> = new();
       [ProtoMember(4)] public   reminderContent  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   userdef  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   groupType  {get;set;} int = 0;
       [ProtoMember(7)] public   opType  {get;set;} int = 0;
    } {
        [ProtoContract]
        internal class MessageMeta(
           [ProtoMember(1)] public   seq  {get;set;} int = 0;
           [ProtoMember(2)] public   time  {get;set;} int = 0;
           [ProtoMember(3)] public   msgRandom  {get;set;} int = 0;
           [ProtoMember(4)] public   msgType  {get;set;} int = 0;
           [ProtoMember(5)] public   msgFlag  {get;set;} int = 0;
           [ProtoMember(6)] public   authorUin  {get;set;} long = 0L;
        }
    }

    [ProtoContract] class MiniAppNotify(
       [ProtoMember(1)] public   msg  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class NotifyMsgBody(
       [ProtoMember(1)] public   optEnumType  {get;set;} int /* enum */ = 1;
       [ProtoMember(2)] public   optUint64MsgTime  {get;set;} long = 0L;
       [ProtoMember(3)] public   optUint64MsgExpires  {get;set;} long = 0L;
       [ProtoMember(4)] public   optUint64GroupCode  {get;set;} long = 0L;
       [ProtoMember(5)] public   optMsgGraytips  {get;set;} AIOGrayTipsInfo? = null;
       [ProtoMember(6)] public   optMsgMessagebox  {get;set;} MessageBoxInfo? = null;
       [ProtoMember(7)] public   optMsgFloatedtips  {get;set;} FloatedTipsInfo? = null;
       [ProtoMember(8)] public   optMsgToptips  {get;set;} AIOTopTipsInfo? = null;
       [ProtoMember(9)] public   optMsgRedtips  {get;set;} RedGrayTipsInfo? = null;
       [ProtoMember(10)] public   optMsgGroupNotify  {get;set;} GroupNotifyInfo? = null;
       [ProtoMember(11)] public   optMsgRecall  {get;set;} MessageRecallReminder? = null;
       [ProtoMember(12)] public   optMsgThemeNotify  {get;set;} ThemeStateNotify? = null;
       [ProtoMember(13)] public   serviceType  {get;set;} int = 0;
       [ProtoMember(14)] public   optMsgObjmsgUpdate  {get;set;} NotifyObjmsgUpdate? = null;
       [ProtoMember(15)] public   optMsgWerewolfPush  {get;set;} WereWolfPush? = null;
        // @SerialId(16)] public   optStcmGameState  {get;set;} ApolloGameStatus.STCMGameMessage? = null;
        // @SerialId(17)] public   aplloMsgPush  {get;set;} ApolloPushMsgInfo.STPushMsgElem? = null;
       [ProtoMember(18)] public   optMsgGoldtips  {get;set;} GoldMsgTipsElem? = null;
       [ProtoMember(20)] public   optMsgMiniappNotify  {get;set;} MiniAppNotify? = null;
       [ProtoMember(21)] public   optUint64SenderUin  {get;set;} long = 0L;
       [ProtoMember(22)] public   optMsgLuckybagNotify  {get;set;} LuckyBagNotify? = null;
       [ProtoMember(23)] public   optMsgTroopformtipsPush  {get;set;} TroopFormGrayTipsInfo? = null;
       [ProtoMember(24)] public   optMsgMediaPush  {get;set;} MediaChangePushInfo? = null;
       [ProtoMember(26)] public   optGeneralGrayTip  {get;set;} GeneralGrayTipInfo? = null;
       [ProtoMember(27)] public   optMsgVideoPush  {get;set;} VideoChangePushInfo? = null;
       [ProtoMember(28)] public   optLbsShareChangePlusInfo  {get;set;} LbsShareChangePushInfo? = null;
       [ProtoMember(29)] public   optMsgSingPush  {get;set;} SingChangePushInfo? = null;
       [ProtoMember(30)] public   optMsgGroupInfoChange  {get;set;} GroupInfoChange? = null;
    }

    [ProtoContract] class NotifyObjmsgUpdate(
       [ProtoMember(1)] public   objmsgId  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   updateType  {get;set;} int = 0;
       [ProtoMember(3)] public   extMsg  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class RedGrayTipsInfo(
       [ProtoMember(1)] public   optUint32ShowLastest  {get;set;} int = 0;
       [ProtoMember(2)] public   senderUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   receiverUin  {get;set;} long = 0L;
       [ProtoMember(4)] public   senderRichContent  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   receiverRichContent  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   authkey  {get;set;} byte[] = Array.Empty<byte>();
        @ProtoType(ProtoIntegerType.SIGNED)[ProtoMember(7)] public   sint32Msgtype  {get;set;} int = 0;
       [ProtoMember(8)] public   luckyFlag  {get;set;} int = 0;
       [ProtoMember(9)] public   hideFlag  {get;set;} int = 0;
       [ProtoMember(10)] public   pcBody  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(11)] public   icon  {get;set;} int = 0;
       [ProtoMember(12)] public   luckyUin  {get;set;} long = 0L;
       [ProtoMember(13)] public   time  {get;set;} int = 0;
       [ProtoMember(14)] public   random  {get;set;} int = 0;
       [ProtoMember(15)] public   broadcastRichContent  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(16)] public   idiom  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(17)] public   idiomSeq  {get;set;} int = 0;
       [ProtoMember(18)] public   idiomAlpha  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(19)] public   jumpurl  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   optUint64GroupCode  {get;set;} long = 0L;
       [ProtoMember(2)] public   uint64Memberuins  {get;set;} List<Long> = new();
       [ProtoMember(3)] public   optUint32Offline  {get;set;} int = 0;
       [ProtoMember(4)] public   msgInstCtrl  {get;set;} InstCtrl? = null;
       [ProtoMember(5)] public   optBytesMsg  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   optUint32BusiType  {get;set;} int = 0;
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   optUint64GroupCode  {get;set;} long = 0L;
    }

    [ProtoContract] class SingChangePushInfo(
       [ProtoMember(1)] public   seq  {get;set;} long = 0L;
       [ProtoMember(2)] public   actionType  {get;set;} int = 0;
       [ProtoMember(3)] public   groupId  {get;set;} long = 0L;
       [ProtoMember(4)] public   operUin  {get;set;} long = 0L;
       [ProtoMember(5)] public   grayTips  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   joinNums  {get;set;} int = 0;
    }

    [ProtoContract] class TemplParam(
       [ProtoMember(1)] public   name  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   value  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class ThemeStateNotify(
       [ProtoMember(1)] public   state  {get;set;} int = 0;
       [ProtoMember(2)] public   feedsId  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   themeName  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   actionUin  {get;set;} long = 0L;
       [ProtoMember(5)] public   createUin  {get;set;} long = 0L;
    }

    [ProtoContract] class TroopFormGrayTipsInfo(
       [ProtoMember(1)] public   writerUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   creatorUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   richContent  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   optBytesUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   creatorNick  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class VideoChangePushInfo(
       [ProtoMember(1)] public   seq  {get;set;} long = 0L;
       [ProtoMember(2)] public   actionType  {get;set;} int = 0;
       [ProtoMember(3)] public   groupId  {get;set;} long = 0L;
       [ProtoMember(4)] public   operUin  {get;set;} long = 0L;
       [ProtoMember(5)] public   grayTips  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   joinNums  {get;set;} int = 0;
       [ProtoMember(100)] public   extInfo  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class WereWolfPush(
       [ProtoMember(1)] public   pushType  {get;set;} int = 0;
       [ProtoMember(2)] public   gameRoom  {get;set;} long = 0L;
       [ProtoMember(3)] public   enumGameState  {get;set;} int = 0;
       [ProtoMember(4)] public   gameRound  {get;set;} int = 0;
       [ProtoMember(5)] public   roles  {get;set;} List<Role> = new();
       [ProtoMember(6)] public   speaker  {get;set;} long = 0L;
       [ProtoMember(7)] public   judgeUin  {get;set;} long = 0L;
       [ProtoMember(8)] public   judgeWords  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(9)] public   enumOperation  {get;set;} int = 0;
       [ProtoMember(10)] public   srcUser  {get;set;} long = 0L;
       [ProtoMember(11)] public   dstUser  {get;set;} long = 0L;
       [ProtoMember(12)] public   deadUsers  {get;set;} List<Long> = new();
       [ProtoMember(13)] public   gameResult  {get;set;} int = 0;
       [ProtoMember(14)] public   timeoutSec  {get;set;} int = 0;
       [ProtoMember(15)] public   killConfirmed  {get;set;} int = 0;
       [ProtoMember(16)] public   judgeNickname  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(17)] public   votedTieUsers  {get;set;} List<Long> = new();
    } {
        [ProtoContract]
        internal class GameRecord(
           [ProtoMember(1)] public   total  {get;set;} int = 0;
           [ProtoMember(2)] public   win  {get;set;} int = 0;
           [ProtoMember(3)] public   lose  {get;set;} int = 0;
           [ProtoMember(4)] public   draw  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class Role(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   enumType  {get;set;} int = 0;
           [ProtoMember(3)] public   enumState  {get;set;} int = 0;
           [ProtoMember(4)] public   canSpeak  {get;set;} int = 0;
           [ProtoMember(5)] public   canListen  {get;set;} int = 0;
           [ProtoMember(6)] public   position  {get;set;} int = 0;
           [ProtoMember(7)] public   canVote  {get;set;} int = 0;
           [ProtoMember(8)] public   canVoted  {get;set;} int = 0;
           [ProtoMember(9)] public   alreadyChecked  {get;set;} int = 0;
           [ProtoMember(10)] public   alreadySaved  {get;set;} int = 0;
           [ProtoMember(11)] public   alreadyPoisoned  {get;set;} int = 0;
           [ProtoMember(12)] public   playerState  {get;set;} int = 0;
           [ProtoMember(13)] public   enumDeadOp  {get;set;} int = 0;
           [ProtoMember(14)] public   enumOperation  {get;set;} int = 0;
           [ProtoMember(15)] public   dstUser  {get;set;} long = 0L;
           [ProtoMember(16)] public   operationRound  {get;set;} int = 0;
           [ProtoMember(17)] public   msgGameRecord  {get;set;} GameRecord? = null;
           [ProtoMember(18)] public   isWerewolf  {get;set;} int = 0;
           [ProtoMember(19)] public   defendedUser  {get;set;} long = 0L;
           [ProtoMember(20)] public   isSheriff  {get;set;} int = 0;
        }
    }
}
