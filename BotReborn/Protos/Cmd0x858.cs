

using ProtoBuf;

@file  {get;set;}Suppress("SpellCheckingInspection")




import kotlinx.serialization.protobuf.ProtoIntegerType

import kotlinx.serialization.protobuf.ProtoType



[ProtoContract] class Oidb0x858  {
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

    [ProtoContract] class MessageRecallReminder(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L;
       [ProtoMember(2)] public   nickname  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   recalledMsgList  {get;set;} List<MessageMeta> = new();
       [ProtoMember(4)] public   reminderContent  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   userdef  {get;set;} byte[] = Array.Empty<byte>();
    } {
        [ProtoContract]
        internal class MessageMeta(
           [ProtoMember(1)] public   seq  {get;set;} int = 0;
           [ProtoMember(2)] public   time  {get;set;} int = 0;
           [ProtoMember(3)] public   msgRandom  {get;set;} int = 0;
        }
    }

    [ProtoContract] class NotifyMsgBody(
       [ProtoMember(1)] public   optEnumType  {get;set;} int /* enum */ = 5;
       [ProtoMember(2)] public   optUint64MsgTime  {get;set;} long = 0L;
       [ProtoMember(3)] public   optUint64MsgExpires  {get;set;} long = 0L;
       [ProtoMember(4)] public   optUint64ConfUin  {get;set;} long = 0L;
       [ProtoMember(5)] public   optMsgRedtips  {get;set;} RedGrayTipsInfo? = null;
       [ProtoMember(6)] public   optMsgRecallReminder  {get;set;} MessageRecallReminder? = null;
       [ProtoMember(7)] public   optMsgObjUpdate  {get;set;} NotifyObjmsgUpdate? = null;
        // @SerialId(8)] public   optStcmGameState  {get;set;} ApolloGameStatus.STCMGameMessage? = null;
        // @SerialId(9)] public   aplloMsgPush  {get;set;} ApolloPushMsgInfo.STPushMsgElem? = null;
       [ProtoMember(10)] public   optMsgGoldtips  {get;set;} GoldMsgTipsElem? = null;
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
}
