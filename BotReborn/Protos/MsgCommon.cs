using ProtoBuf;

/**
 * msf.msgcomm.msg_comm
 */
[ProtoContract] class MsgComm  {
    [ProtoContract] class AppShareInfo(
       [ProtoMember(1)] public   appshareId  {get;set;} int = 0;
       [ProtoMember(2)] public   appshareCookie  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   appshareResource  {get;set;} PluginInfo? = null;
    }

    [ProtoContract] class C2CTmpMsgHead(
       [ProtoMember(1)] public   c2cType  {get;set;} int = 0;
       [ProtoMember(2)] public   serviceType  {get;set;} int = 0;
       [ProtoMember(3)] public   groupUin  {get;set;} long = 0L;
       [ProtoMember(4)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(5)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   sigType  {get;set;} int = 0;
       [ProtoMember(7)] public   fromPhone  {get;set;} string = "";
       [ProtoMember(8)] public   toPhone  {get;set;} string = "";
       [ProtoMember(9)] public   lockDisplay  {get;set;} int = 0;
       [ProtoMember(10)] public   directionFlag  {get;set;} int = 0;
       [ProtoMember(11)] public   reserved  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class ContentHead(
       [ProtoMember(1)] public   pkgNum  {get;set;} int = 0;
       [ProtoMember(2)] public   pkgIndex  {get;set;} int = 0;
       [ProtoMember(3)] public   divSeq  {get;set;} int = 0;
       [ProtoMember(4)] public   autoReply  {get;set;} int = 0;
    }

    [ProtoContract] class DiscussInfo(
       [ProtoMember(1)] public   discussUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   discussType  {get;set;} int = 0;
       [ProtoMember(3)] public   discussInfoSeq  {get;set;} long = 0L;
       [ProtoMember(4)] public   discussRemark  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   discussName  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class ExtGroupKeyInfo(
       [ProtoMember(1)] public   curMaxSeq  {get;set;} int = 0;
       [ProtoMember(2)] public   curTime  {get;set;} long = 0L;
    }

    [ProtoContract] class GroupInfo(
       [ProtoMember(1)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(2)] public   groupType  {get;set;} int = 0;
       [ProtoMember(3)] public   groupInfoSeq  {get;set;} long = 0L;
       [ProtoMember(4)] public   groupCard  {get;set;} string = "";
       [ProtoMember(5)] public   groupRank  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   groupLevel  {get;set;} int = 0;
       [ProtoMember(7)] public   groupCardType  {get;set;} int = 0;
       [ProtoMember(8)] public   groupName  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class Msg(
       [ProtoMember(1)] public   msgHead  {get;set;} MsgHead;
       [ProtoMember(2)] public   contentHead  {get;set;} ContentHead? = null;
       [ProtoMember(3)] public   msgBody  {get;set;} ImMsgBody.MsgBody;
       [ProtoMember(4)] public   appshareInfo  {get;set;} AppShareInfo? = null;
    }

    [ProtoContract] class MsgHead(
       [ProtoMember(1)] public   fromUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   msgType  {get;set;} int = 0;
       [ProtoMember(4)] public   c2cCmd  {get;set;} int = 0;
       [ProtoMember(5)] public   msgSeq  {get;set;} int = 0;
       [ProtoMember(6)] public   msgTime  {get;set;} int = 0;
       [ProtoMember(7) var msgUid  {get;set;} long = 0L;
       [ProtoMember(8)] public   c2cTmpMsgHead  {get;set;} C2CTmpMsgHead? = null;
       [ProtoMember(9)] public   groupInfo  {get;set;} GroupInfo? = null;
        /**
         * 1  {get;set;} 群消息 by pc tim
         * 1001  {get;set;} 群消息 sent by android phone
         *
         *
         * 3116  {get;set;} music share; ANDROID_PHONE 发送
         */
       [ProtoMember(10)] public   fromAppid  {get;set;} int = 0;
       [ProtoMember(11)] public   fromInstid  {get;set;} int = 0;
       [ProtoMember(12)] public   userActive  {get;set;} int = 0;
       [ProtoMember(13)] public   discussInfo  {get;set;} DiscussInfo? = null;
       [ProtoMember(14)] public   fromNick  {get;set;} string = "";
       [ProtoMember(15)] public   authUin  {get;set;} long = 0L;
       [ProtoMember(16)] public   authNick  {get;set;} string = "";
       [ProtoMember(17)] public   msgFlag  {get;set;} int = 0;
       [ProtoMember(18)] public   authRemark  {get;set;} string = "";
       [ProtoMember(19)] public   groupName  {get;set;} string = "";
       [ProtoMember(20)] public   mutiltransHead  {get;set;} MutilTransHead? = null;
       [ProtoMember(21)] public   msgInstCtrl  {get;set;} ImMsgHead.InstCtrl? = null;
       [ProtoMember(22)] public   publicAccountGroupSendFlag  {get;set;} int = 0;
       [ProtoMember(23)] public   wseqInC2cMsghead  {get;set;} int = 0;
       [ProtoMember(24)] public   cpid  {get;set;} long = 0L;
       [ProtoMember(25)] public   extGroupKeyInfo  {get;set;} ExtGroupKeyInfo? = null;
       [ProtoMember(26)] public   multiCompatibleText  {get;set;} string = "";
       [ProtoMember(27)] public   authSex  {get;set;} int = 0;
       [ProtoMember(28)] public   isSrcMsg  {get;set;} bool = false;
    }

    [ProtoContract] class MsgType0x210(
       [ProtoMember(1)] public   subMsgType  {get;set;} int = 0;
       [ProtoMember(2)] public   msgContent  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class MutilTransHead(
       [ProtoMember(1)] public   status  {get;set;} int = 0;
       [ProtoMember(2)] public   msgId  {get;set;} int = 0;
    }

    [ProtoContract] class PluginInfo(
       [ProtoMember(1)] public   resId  {get;set;} int = 0;
       [ProtoMember(2)] public   pkgName  {get;set;} string = "";
       [ProtoMember(3)] public   newVer  {get;set;} int = 0;
       [ProtoMember(4)] public   resType  {get;set;} int = 0;
       [ProtoMember(5)] public   lanType  {get;set;} int = 0;
       [ProtoMember(6)] public   priority  {get;set;} int = 0;
       [ProtoMember(7)] public   resName  {get;set;} string = "";
       [ProtoMember(8)] public   resDesc  {get;set;} string = "";
       [ProtoMember(9)] public   resUrlBig  {get;set;} string = "";
       [ProtoMember(10)] public   resUrlSmall  {get;set;} string = "";
       [ProtoMember(11)] public   resConf  {get;set;} string = "";
    }

    [ProtoContract] class Uin2Nick(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L;
       [ProtoMember(2)] public   nick  {get;set;} string = "";
    }

    [ProtoContract] class UinPairMsg(
       [ProtoMember(1)] public   lastReadTime  {get;set;} int = 0;
       [ProtoMember(2)] public   peerUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   msgCompleted  {get;set;} int = 0;
       [ProtoMember(4)] public   msg  {get;set;} List<Msg> = new();
       [ProtoMember(5)] public   unreadMsgNum  {get;set;} int = 0;
       [ProtoMember(8)] public   c2cType  {get;set;} int = 0;
       [ProtoMember(9)] public   serviceType  {get;set;} int = 0;
       [ProtoMember(10)] public   pbReserve  {get;set;} byte[] = Array.Empty<byte>();
    }
}
