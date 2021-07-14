






using ProtoBuf;

import kotlinx.serialization.protobuf.ProtoIntegerType

import kotlinx.serialization.protobuf.ProtoType



[ProtoContract] class SubMsgType0x43  {
    [ProtoContract] class UpdateTips(
       [ProtoMember(1)] public   desc  {get;set;} byte[] = Array.Empty<byte>();
    }
}

internal class Submsgtype0x101 {
    internal class SubMsgType0x27  {
        [ProtoContract]
        internal class ClientReport(
           [ProtoMember(1)] public   serviceId  {get;set;} int = 0;
           [ProtoMember(2)] public   contentId  {get;set;} string = "";
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgPushPlatform  {get;set;} PushPlatform? = null;
           [ProtoMember(2)] public   msgClientReport  {get;set;} ClientReport? = null;
        }

        [ProtoContract]
        internal class PushPlatform(
           [ProtoMember(1)] public   fromUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   title  {get;set;} string = "";
           [ProtoMember(3)] public   desc  {get;set;} string = "";
           [ProtoMember(4)] public   targetUrl  {get;set;} string = "";
           [ProtoMember(5)] public   forwardType  {get;set;} int = 0;
           [ProtoMember(6)] public   extDataString  {get;set;} string = "";
           [ProtoMember(7)] public   extData  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0x102 {
    internal class Submsgtype0x102  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   adId  {get;set;} string = "";
        }
    }
}


internal class Submsgtype0x103 {
    internal class Submsgtype0x103  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   from  {get;set;} long = 0L;
           [ProtoMember(2)] public   to  {get;set;} long = 0L;
           [ProtoMember(3)] public   topicId  {get;set;} int = 0;
           [ProtoMember(11)] public   curCount  {get;set;} int = 0;
           [ProtoMember(12)] public   totalCount  {get;set;} int = 0;
        }
    }
}


internal class Submsgtype0x104 {
    internal class Submsgtype0x104  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   from  {get;set;} long = 0L;
           [ProtoMember(2)] public   to  {get;set;} long = 0L;
           [ProtoMember(3)] public   topicId  {get;set;} int = 0;
           [ProtoMember(11)] public   wording  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0x108 {
    internal class SubMsgType0x108  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   type  {get;set;} int = 0;
           [ProtoMember(2)] public   pushUin  {get;set;} long = 0L;
           [ProtoMember(3)] public   likeCount  {get;set;} int = 0;
           [ProtoMember(4)] public   pushTime  {get;set;} int = 0;
        }
    }
}


internal class Submsgtype0x10f {
    internal class Submsgtype0x10f  {
        [ProtoContract]
        internal class KanDianCoinSettingWording(
           [ProtoMember(1)] public   wording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   pictureUrl  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   isOpenCoinEntry  {get;set;} int = 0;
           [ProtoMember(2)] public   canGetCoinCount  {get;set;} int = 0;
           [ProtoMember(3)] public   coinIconUrl  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   msgSettingWording  {get;set;} KanDianCoinSettingWording? = null;
           [ProtoMember(5)] public   lastCompletedTaskStamp  {get;set;} long = 0L;
           [ProtoMember(6)] public   dstUin  {get;set;} long = 0L;
        }
    }
}


internal class Submsgtype0x111 {
    internal class SubMsgType0x111  {
        [ProtoContract]
        internal class AddFriendSource(
           [ProtoMember(1)] public   source  {get;set;} int = 0;
           [ProtoMember(2)] public   subSource  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class MayKnowPerson(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   msgIosSource  {get;set;} AddFriendSource? = null;
           [ProtoMember(3)] public   msgAndroidSource  {get;set;} AddFriendSource? = null;
           [ProtoMember(4)] public   reason  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   additive  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(6)] public   nick  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(7)] public   remark  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(8)] public   country  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(9)] public   province  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(10)] public   city  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(11)] public   age  {get;set;} int = 0;
           [ProtoMember(12)] public   catelogue  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(13)] public   alghrithm  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(14)] public   richbuffer  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(15)] public   qzone  {get;set;} int = 0;
           [ProtoMember(16)] public   gender  {get;set;} int = 0;
           [ProtoMember(17)] public   mobileName  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(18)] public   token  {get;set;} string = "";
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   type  {get;set;} long = 0L;
           [ProtoMember(2)] public   msgAddRecommendPersons  {get;set;} List<MayKnowPerson> = new();
           [ProtoMember(3)] public   uint64DelUins  {get;set;} List<Long> = new();
        }
    }
}


internal class Submsgtype0x113 {
    internal class SubMsgType0x113  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   int32AppId  {get;set;} int = 0;
           [ProtoMember(2)] public   int32TaskId  {get;set;} int = 0;
           [ProtoMember(3)] public   enumTaskOp  {get;set;} int /* enum */ = 1;
        }
    }
}


internal class Submsgtype0x115 {
    internal class SubMsgType0x115  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   fromUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   toUin  {get;set;} long = 0L;
           [ProtoMember(3)] public   msgNotifyItem  {get;set;} NotifyItem? = null;
           [ProtoMember(4)] public   pbReserve  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class NotifyItem(
           [ProtoMember(1)] public   ime  {get;set;} int = 0;
           [ProtoMember(2)] public   timeout  {get;set;} int = 0;
           [ProtoMember(3)] public   timestamp  {get;set;} long = 0L;
           [ProtoMember(4)] public   eventType  {get;set;} int = 0;
           [ProtoMember(5)] public   interval  {get;set;} int = 0;
           [ProtoMember(6)] public   wording  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0x116 {
    internal class Submsgtype0x116  {
        [ProtoContract]
        internal class MemberInfo(
           [ProtoMember(1)] public   memberUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   inviteTimestamp  {get;set;} int = 0;
           [ProtoMember(3)] public   terminalType  {get;set;} int = 0;
           [ProtoMember(4)] public   clientVersion  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgMemberJoin  {get;set;} List<MemberInfo> = new();
           [ProtoMember(2)] public   msgMemberQuit  {get;set;} List<MemberInfo> = new();
           [ProtoMember(3)] public   groupId  {get;set;} int = 0;
           [ProtoMember(4)] public   roomId  {get;set;} int = 0;
           [ProtoMember(5)] public   inviteListTotalCount  {get;set;} int = 0;
           [ProtoMember(6)] public   enumEventType  {get;set;} int /* enum */ = 1;
        }
    }
}


internal class Submsgtype0x117 {
    internal class Submsgtype0x117  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   uint32MoudleId  {get;set;} List<int> = new();
        }
    }
}


internal class Submsgtype0x118 {
    internal class Submsgtype0x118  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   pushType  {get;set;} int = 0;
           [ProtoMember(2)] public   pushData  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   timestamp  {get;set;} int = 0;
           [ProtoMember(4)] public   msgSystemNotify  {get;set;} SystemNotify? = null;
        }

        [ProtoContract]
        internal class SystemNotify(
           [ProtoMember(1)] public   msgSummary  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   filterFlag  {get;set;} int = 0;
           [ProtoMember(3)] public   extendContent  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   ignorePcActive  {get;set;} int = 0;
           [ProtoMember(5)] public   filterVersion  {get;set;} int = 0;
           [ProtoMember(6)] public   countFlag  {get;set;} int = 0;
           [ProtoMember(7)] public   filterVersionUpperlimitFlag  {get;set;} int = 0;
           [ProtoMember(8)] public   filterVersionUpperlimit  {get;set;} int = 0;
           [ProtoMember(9)] public   customSound  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(10)] public   admnFlag  {get;set;} int = 0;
           [ProtoMember(11)] public   ignoreWithoutContent  {get;set;} int = 0;
           [ProtoMember(12)] public   msgTitle  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0x119 {
    internal class SubMsgType0x119  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   writerUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   creatorUin  {get;set;} long = 0L;
           [ProtoMember(3)] public   richContent  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   optBytesUrl  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   creatorNick  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0x11a {
    internal class Submsgtype0x11a  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   enumResult  {get;set;} int /* enum */ = 0;
           [ProtoMember(2)] public   token  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   encryptKey  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   msgUserData  {get;set;} UserData? = null;
           [ProtoMember(5)] public   enumBizType  {get;set;} int /* enum */ = 1;
        }

        [ProtoContract]
        internal class UserData(
           [ProtoMember(1)] public   ip  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   fixed32Port  {get;set;} List<int> = new();
           [ProtoMember(3)] public   ssid  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   bssid  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   enumPlatform  {get;set;} int /* enum */ = 1;
        }
    }
}


internal class Submsgtype0x11b {
    internal class Submsgtype0x11b  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   qrSig  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   enumBizType  {get;set;} int /* enum */ = 1;
        }
    }
}


internal class Submsgtype0x11c {
    [ProtoContract] class MsgBody(
       [ProtoMember(1)] public   cmd  {get;set;} int = 0;
       [ProtoMember(2)] public   timestamp  {get;set;} int = 0;
       [ProtoMember(3)] public   data  {get;set;} byte[] = Array.Empty<byte>();
    }
}


internal class Submsgtype0x11e {
    internal class SubMsgType0x11e  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   type  {get;set;} int = 0;
           [ProtoMember(2)] public   reason  {get;set;} string = "";
        }
    }
}


internal class Submsgtype0x11f {
    internal class SubMsgType0x11f  {
        [ProtoContract]
        internal class MediaUserInfo(
           [ProtoMember(1)] public   toUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   joinState  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgType  {get;set;} int = 0;
           [ProtoMember(2)] public   msgInfo  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   versionCtrl  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   aioType  {get;set;} int = 0;
           [ProtoMember(5)] public   operUin  {get;set;} long = 0L;
           [ProtoMember(6)] public   uint64ToUin  {get;set;} List<Long> = new();
           [ProtoMember(7)] public   grayTips  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(8)] public   msgSeq  {get;set;} long = 0L;
           [ProtoMember(9)] public   msgMediaUin  {get;set;} List<MediaUserInfo> = new();
           [ProtoMember(10)] public   msgPerSetting  {get;set;} PersonalSetting? = null;
           [ProtoMember(11)] public   playMode  {get;set;} int = 0;
           [ProtoMember(99)] public   mediaType  {get;set;} int = 0;
           [ProtoMember(100)] public   extInfo  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class PersonalSetting(
           [ProtoMember(1)] public   themeId  {get;set;} int = 0;
           [ProtoMember(2)] public   playerId  {get;set;} int = 0;
           [ProtoMember(3)] public   fontId  {get;set;} int = 0;
        }
    }
}


internal class Submsgtype0x120 {
    internal class SubMsgType0x120  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   srcAppId  {get;set;} int = 0;
           [ProtoMember(2)] public   noticeType  {get;set;} int = 0;
           [ProtoMember(3)] public   reserve1  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   reserve2  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   reserve3  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(6)] public   noticeTime  {get;set;} int = 0;
           [ProtoMember(7)] public   frdUin  {get;set;} long = 0L;
        }
    }
}


internal class Submsgtype0x122 {
    internal class GrayTipsResv  {
        [ProtoContract]
        internal class ResvAttr(
           [ProtoMember(1)] public   friendBannedFlag  {get;set;} int = 0;
        }
    }

    internal class Submsgtype0x122  {
        [ProtoContract]
        internal class MsgBody(
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

        [ProtoContract]
        internal class TemplParam(
           [ProtoMember(1)] public   name  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   value  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0x123 {
    internal class Submsgtype0x123  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   busiType  {get;set;} long = 0L;
           [ProtoMember(2)] public   busiId  {get;set;} long = 0L;
           [ProtoMember(3)] public   ctrlFlag  {get;set;} int = 0;
           [ProtoMember(4)] public   c2cType  {get;set;} int = 0;
           [ProtoMember(5)] public   serviceType  {get;set;} int = 0;
           [ProtoMember(6)] public   templId  {get;set;} long = 0L;
           [ProtoMember(7)] public   templParam  {get;set;} List<TemplParam> = new();
           [ProtoMember(8)] public   templContent  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class TemplParam(
           [ProtoMember(1)] public   name  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   value  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0x125 {
    internal class Submsgtype0x125  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgType  {get;set;} int = 0;
           [ProtoMember(2)] public   msgInfo  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   versionCtrl  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   operUin  {get;set;} long = 0L;
           [ProtoMember(5)] public   grayTips  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(6)] public   msgSeq  {get;set;} long = 0L;
           [ProtoMember(99)] public   pushType  {get;set;} int = 0;
           [ProtoMember(100)] public   extInfo  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0x126 {
    internal class Submsgtype0x126  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgSeq  {get;set;} long = 0L;
           [ProtoMember(2)] public   msgType  {get;set;} int = 0;
           [ProtoMember(3)] public   msgInfo  {get;set;} string = "";
           [ProtoMember(100)] public   extInfo  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0x127 {
    internal class Submsgtype0x127  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   seq  {get;set;} long = 0L;
           [ProtoMember(2)] public   actionType  {get;set;} int = 0;
           [ProtoMember(3)] public   friendUin  {get;set;} long = 0L;
           [ProtoMember(4)] public   operUin  {get;set;} long = 0L;
           [ProtoMember(5)] public   grayTips  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(6)] public   joinState  {get;set;} int /* enum */ = 1;
        }
    }
}


internal class Submsgtype0x128 {
    internal class Submsgtype0x128  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   matchUin  {get;set;} long = 0L;
           [ProtoMember(3)] public   tipsWording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   nick  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   timeStamp  {get;set;} long = 0L;
           [ProtoMember(6)] public   matchExpiredTime  {get;set;} int = 0;
           [ProtoMember(7)] public   reportId  {get;set;} string = "";
        }
    }
}


internal class Submsgtype0x129 {
    internal class Submsgtype0x129  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   seq  {get;set;} long = 0L;
           [ProtoMember(2)] public   actionType  {get;set;} int = 0;
           [ProtoMember(3)] public   friendUin  {get;set;} long = 0L;
           [ProtoMember(4)] public   operUin  {get;set;} long = 0L;
           [ProtoMember(5)] public   grayTips  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(6)] public   joinState  {get;set;} int /* enum */ = 1;
        }
    }
}


/*
internal class Submsgtype0x1a {
    internal class SubMsgType0x1a  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   fileKey  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   fromUinInt  {get;set;} int = 0;
           [ProtoMember(3)] public   toUinInt  {get;set;} int = 0;
           [ProtoMember(4)] public   status  {get;set;} int = 0;
           [ProtoMember(5)] public   ttl  {get;set;} int = 0;
           [ProtoMember(6)] public   desc  {get;set;} string = "";
           [ProtoMember(7)] public   type  {get;set;} int = 0;
           [ProtoMember(8)] public   captureTimes  {get;set;} int = 0;
           [ProtoMember(9)] public   fromUin  {get;set;} long = 0L;
           [ProtoMember(10)] public   toUin  {get;set;} long = 0L
        }
    }
}*/


internal class Submsgtype0x26 {
    internal class Submsgtype0x26  {
        [ProtoContract]
        internal class AppID(
           [ProtoMember(1)] public   appId  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class AppNotifyContent(
           [ProtoMember(1)] public   text  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   optMsgAppNotifyUser  {get;set;} List<AppNotifyUser> = new();
        }

        [ProtoContract]
        internal class AppNotifyUser(
           [ProtoMember(1)] public   optUint64Uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   optUint32Flag  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class AppTip(
           [ProtoMember(1)] public   tipInfoSeq  {get;set;} int = 0;
           [ProtoMember(2)] public   icon  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   iconTimeStamp  {get;set;} int = 0;
           [ProtoMember(4)] public   tooltip  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   reportidClick  {get;set;} int = 0;
           [ProtoMember(6)] public   reportidShow  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class AppTipNotify(
           [ProtoMember(1)] public   msgAppTip  {get;set;} AppTip? = null;
           [ProtoMember(2)] public   action  {get;set;} int = 0;
           [ProtoMember(3)] public   text  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   notifySeq  {get;set;} int = 0;
           [ProtoMember(5)] public   neededTipInfoSeq  {get;set;} int = 0;
           [ProtoMember(6)] public   optMsgAppNotifyContent  {get;set;} AppNotifyContent? = null;
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   subCmd  {get;set;} int = 0;
           [ProtoMember(2)] public   msgSubcmd0x1PushBody  {get;set;} List<SubCmd0x1UpdateAppUnreadNum> = new();
           [ProtoMember(3)] public   msgSubcmd0x2PushBody  {get;set;} SubCmd0x2UpdateAppList? = null;
           [ProtoMember(4)] public   msgSubcmd0x3PushBody  {get;set;} SubCmd0x3UpdateDiscussAppInfo? = null;
           [ProtoMember(5)] public   msgSubcmd0x4PushBody  {get;set;} SubCmd0x4UpdateApp? = null;
        } {
            [ProtoContract]
            internal class SubCmd0x1UpdateAppUnreadNum(
               [ProtoMember(1)] public   msgAppId  {get;set;} AppID? = null;
               [ProtoMember(2)] public   groupCode  {get;set;} long = 0L;
                @ProtoType(ProtoIntegerType.SIGNED)[ProtoMember(3)] public   sint32UnreadNum  {get;set;} int = 0;
               [ProtoMember(4)] public   msgAppTipNotify  {get;set;} AppTipNotify? = null;
                @ProtoType(ProtoIntegerType.SIGNED)[ProtoMember(5)] public   sint32AlbumCnt  {get;set;} int = 0;
            }

            [ProtoContract]
            internal class SubCmd0x2UpdateAppList(
               [ProtoMember(1)] public   msgAppId  {get;set;} List<AppID> = new();
               [ProtoMember(2)] public   uint32TimeStamp  {get;set;} List<int> = new();
               [ProtoMember(3)] public   groupCode  {get;set;} long = 0L;
            }

            [ProtoContract]
            internal class SubCmd0x3UpdateDiscussAppInfo(
               [ProtoMember(1)] public   msgAppId  {get;set;} AppID? = null;
               [ProtoMember(2)] public   confUin  {get;set;} long = 0L;
               [ProtoMember(3)] public   msgAppTipNotify  {get;set;} AppTipNotify? = null;
            }

            [ProtoContract]
            internal class SubCmd0x4UpdateApp(
               [ProtoMember(1)] public   msgAppId  {get;set;} AppID? = null;
               [ProtoMember(2)] public   groupCode  {get;set;} long = 0L;
                @ProtoType(ProtoIntegerType.SIGNED)[ProtoMember(3)] public   sint32UnreadNum  {get;set;} int = 0;
            }
        }

        [ProtoContract]
        internal class TransferCnt(
           [ProtoMember(1)] public   chainId  {get;set;} long = 0L;
        }
    }
}

internal class Submsgtype0x27 {
    internal class SubMsgType0x27  {
        [ProtoContract]
        internal class AddGroup(
           [ProtoMember(1)] public   groupid  {get;set;} int = 0;
           [ProtoMember(2)] public   sortid  {get;set;} int = 0;
           [ProtoMember(3)] public   groupname  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class AppointmentNotify(
           [ProtoMember(1)] public   fromUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   appointId  {get;set;} string = "";
           [ProtoMember(3)] public   notifytype  {get;set;} int = 0;
           [ProtoMember(4)] public   tipsContent  {get;set;} string = "";
           [ProtoMember(5)] public   unreadCount  {get;set;} int = 0;
           [ProtoMember(6)] public   joinWording  {get;set;} string = "";
           [ProtoMember(7)] public   viewWording  {get;set;} string = "";
           [ProtoMember(8)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(9)] public   eventInfo  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(10)] public   nearbyEventInfo  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(11)] public   feedEventInfo  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class BinaryMsg(
           [ProtoMember(1)] public   opType  {get;set;} int = 0;
           [ProtoMember(2)] public   opValue  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class ChatMatchInfo(
           [ProtoMember(1)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   uin  {get;set;} long = 0L;
           [ProtoMember(3)] public   matchUin  {get;set;} long = 0L;
           [ProtoMember(4)] public   tipsWording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   leftChatTime  {get;set;} int = 0;
           [ProtoMember(6)] public   timeStamp  {get;set;} long = 0L;
           [ProtoMember(7)] public   matchExpiredTime  {get;set;} int = 0;
           [ProtoMember(8)] public   c2cExpiredTime  {get;set;} int = 0;
           [ProtoMember(9)] public   matchCount  {get;set;} int = 0;
           [ProtoMember(10)] public   nick  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class ConfMsgRoamFlag(
           [ProtoMember(1)] public   confid  {get;set;} long = 0L;
           [ProtoMember(2)] public   flag  {get;set;} int = 0;
           [ProtoMember(3)] public   timestamp  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class DaRenNotify(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   loginDays  {get;set;} int = 0;
           [ProtoMember(3)] public   days  {get;set;} int = 0;
           [ProtoMember(4)] public   isYestodayLogin  {get;set;} int = 0;
           [ProtoMember(5)] public   isTodayLogin  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class DelFriend(
           [ProtoMember(1)] public   uint64Uins  {get;set;} List<Long> = new();
        }

        [ProtoContract]
        internal class DelGroup(
           [ProtoMember(1)] public   groupid  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class FanpaiziNotify(
           [ProtoMember(1)] public   fromUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   fromNick  {get;set;} string = "";
           [ProtoMember(3)] public   tipsContent  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class ForwardBody(
           [ProtoMember(1)] public   notifyType  {get;set;} int = 0;
           [ProtoMember(2)] public   opType  {get;set;} int = 0;
           [ProtoMember(3)] public   msgAddGroup  {get;set;} AddGroup? = null;
           [ProtoMember(4)] public   msgDelGroup  {get;set;} DelGroup? = null;
           [ProtoMember(5)] public   msgModGroupName  {get;set;} ModGroupName? = null;
           [ProtoMember(6)] public   msgModGroupSort  {get;set;} ModGroupSort? = null;
           [ProtoMember(7)] public   msgModFriendGroup  {get;set;} ModFriendGroup? = null;
           [ProtoMember(8)] public   msgModProfile  {get;set;} ModProfile? = null;
           [ProtoMember(9)] public   msgModFriendRemark  {get;set;} ModFriendRemark? = null;
           [ProtoMember(10)] public   msgModLongNick  {get;set;} ModLongNick? = null;
           [ProtoMember(11)] public   msgModCustomFace  {get;set;} ModCustomFace? = null;
           [ProtoMember(12)] public   msgModGroupProfile  {get;set;} ModGroupProfile? = null;
           [ProtoMember(13)] public   msgModGroupMemberProfile  {get;set;} ModGroupMemberProfile? = null;
           [ProtoMember(14)] public   msgDelFriend  {get;set;} DelFriend? = null;
           [ProtoMember(15)] public   msgRoamPriv  {get;set;} ModFrdRoamPriv? = null;
           [ProtoMember(16)] public   msgGrpMsgRoamFlag  {get;set;} GrpMsgRoamFlag? = null;
           [ProtoMember(17)] public   msgConfMsgRoamFlag  {get;set;} ConfMsgRoamFlag? = null;
           [ProtoMember(18)] public   msgModRichLongNick  {get;set;} ModLongNick? = null;
           [ProtoMember(19)] public   msgBinPkg  {get;set;} BinaryMsg? = null;
           [ProtoMember(20)] public   msgModFriendRings  {get;set;} ModSnsGeneralInfo? = null;
           [ProtoMember(21)] public   msgModConfProfile  {get;set;} ModConfProfile? = null;
           [ProtoMember(22)] public   msgModFriendFlag  {get;set;} SnsUpdateFlag? = null;
           [ProtoMember(23)] public   msgAppointmentNotify  {get;set;} AppointmentNotify? = null;
           [ProtoMember(25)] public   msgDarenNotify  {get;set;} DaRenNotify? = null;
           [ProtoMember(26)] public   msgNewComeinUserNotify  {get;set;} NewComeinUserNotify? = null;
           [ProtoMember(200)] public   msgPushSearchDev  {get;set;} PushSearchDev? = null;
           [ProtoMember(201)] public   msgPushReportDev  {get;set;} PushReportDev? = null;
           [ProtoMember(202)] public   msgQqPayPush  {get;set;} QQPayPush? = null;
           [ProtoMember(203)] public   redpointInfo  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(204)] public   msgHotFriendNotify  {get;set;} HotFriendNotify? = null;
           [ProtoMember(205)] public   msgPraiseRankNotify  {get;set;} PraiseRankNotify? = null;
           [ProtoMember(210)] public   msgCampusNotify  {get;set;} MQQCampusNotify? = null;
           [ProtoMember(211)] public   msgModRichLongNickEx  {get;set;} ModLongNick? = null;
           [ProtoMember(212)] public   msgChatMatchInfo  {get;set;} ChatMatchInfo? = null;
           [ProtoMember(214)] public   msgFrdCustomOnlineStatusChange  {get;set;} FrdCustomOnlineStatusChange? = null;
           [ProtoMember(2000)] public   msgFanpanziNotify  {get;set;} FanpaiziNotify? = null;
        }

        [ProtoContract]
        internal class FrdCustomOnlineStatusChange(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class FriendGroup(
           [ProtoMember(1)] public   fuin  {get;set;} long = 0L;
           [ProtoMember(2)] public   uint32OldGroupId  {get;set;} List<int> = new();
           [ProtoMember(3)] public   uint32NewGroupId  {get;set;} List<int> = new();
        }

        [ProtoContract]
        internal class FriendRemark(
           [ProtoMember(1)] public   type  {get;set;} int = 0;
           [ProtoMember(2)] public   fuin  {get;set;} long = 0L;
           [ProtoMember(3)] public   rmkName  {get;set;} string = "";
           [ProtoMember(4)] public   groupCode  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class GPS(
           [ProtoMember(1)] public   int32Lat  {get;set;} int = 900000000;
           [ProtoMember(2)] public   int32Lon  {get;set;} int = 900000000;
           [ProtoMember(3)] public   int32Alt  {get;set;} int = -10000000;
           [ProtoMember(4)] public   int32Type  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class GroupMemberProfileInfo(
           [ProtoMember(1)] public   field  {get;set;} int = 0;
           [ProtoMember(2)] public   value  {get;set;} string = "";
        }

        [ProtoContract]
        internal class GroupProfileInfo(
           [ProtoMember(1)] public   field  {get;set;} int = 0;
           [ProtoMember(2)] public   value  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class GroupSort(
           [ProtoMember(1)] public   groupid  {get;set;} int = 0;
           [ProtoMember(2)] public   sortid  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class GrpMsgRoamFlag(
           [ProtoMember(1)] public   groupcode  {get;set;} long = 0L;
           [ProtoMember(2)] public   flag  {get;set;} int = 0;
           [ProtoMember(3)] public   timestamp  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class HotFriendNotify(
           [ProtoMember(1)] public   dstUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   praiseHotLevel  {get;set;} int = 0;
           [ProtoMember(3)] public   chatHotLevel  {get;set;} int = 0;
           [ProtoMember(4)] public   praiseHotDays  {get;set;} int = 0;
           [ProtoMember(5)] public   chatHotDays  {get;set;} int = 0;
           [ProtoMember(6)] public   closeLevel  {get;set;} int = 0;
           [ProtoMember(7)] public   closeDays  {get;set;} int = 0;
           [ProtoMember(8)] public   praiseFlag  {get;set;} int = 0;
           [ProtoMember(9)] public   chatFlag  {get;set;} int = 0;
           [ProtoMember(10)] public   closeFlag  {get;set;} int = 0;
           [ProtoMember(11)] public   notifyTime  {get;set;} long = 0L;
           [ProtoMember(12)] public   lastPraiseTime  {get;set;} long = 0L;
           [ProtoMember(13)] public   lastChatTime  {get;set;} long = 0L;
           [ProtoMember(14)] public   qzoneHotLevel  {get;set;} int = 0;
           [ProtoMember(15)] public   qzoneHotDays  {get;set;} int = 0;
           [ProtoMember(16)] public   qzoneFlag  {get;set;} int = 0;
           [ProtoMember(17)] public   lastQzoneTime  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class ModConfProfile(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   confUin  {get;set;} int = 0;
           [ProtoMember(3)] public   msgProfileInfos  {get;set;} List<ProfileInfo> = new();
        }

        [ProtoContract]
        internal class ModCustomFace(
           [ProtoMember(1)] public   type  {get;set;} int = 0;
           [ProtoMember(2)] public   uin  {get;set;} long = 0L;
           [ProtoMember(3)] public   groupCode  {get;set;} long = 0L;
           [ProtoMember(4)] public   cmdUin  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class ModFrdRoamPriv(
           [ProtoMember(1)] public   msgRoamPriv  {get;set;} List<OneRoamPriv> = new();
        }

        [ProtoContract]
        internal class ModFriendGroup(
           [ProtoMember(1)] public   msgFrdGroup  {get;set;} List<FriendGroup> = new();
        }

        [ProtoContract]
        internal class ModFriendRemark(
           [ProtoMember(1)] public   msgFrdRmk  {get;set;} List<FriendRemark> = new();
        }

        [ProtoContract]
        internal class ModGroupMemberProfile(
           [ProtoMember(1)] public   groupUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   uin  {get;set;} long = 0L;
           [ProtoMember(3)] public   msgGroupMemberProfileInfos  {get;set;} List<GroupMemberProfileInfo> = new();
           [ProtoMember(4)] public   groupCode  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class ModGroupName(
           [ProtoMember(1)] public   groupid  {get;set;} int = 0;
           [ProtoMember(2)] public   groupname  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class ModGroupProfile(
           [ProtoMember(1)] public   groupUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   msgGroupProfileInfos  {get;set;} List<GroupProfileInfo> = new();
           [ProtoMember(3)] public   groupCode  {get;set;} long = 0L;
           [ProtoMember(4)] public   cmdUin  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class ModGroupSort(
           [ProtoMember(1)] public   msgGroupsort  {get;set;} List<GroupSort> = new();
        }

        [ProtoContract]
        internal class ModLongNick(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   value  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class ModProfile(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   msgProfileInfos  {get;set;} List<ProfileInfo> = new();
        }

        [ProtoContract]
        internal class ModSnsGeneralInfo(
           [ProtoMember(1)] public   msgSnsGeneralInfos  {get;set;} List<SnsUpateBuffer> = new();
        }

        [ProtoContract]
        internal class MQQCampusNotify(
           [ProtoMember(1)] public   fromUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   wording  {get;set;} string = "";
           [ProtoMember(3)] public   target  {get;set;} string = "";
           [ProtoMember(4)] public   type  {get;set;} int = 0;
           [ProtoMember(5)] public   source  {get;set;} string = "";
        }

        [ProtoContract]
        internal class SubMsgType0x27MsgBody(
           [ProtoMember(1)] public   msgModInfos  {get;set;} List<ForwardBody> = new();
        }

        [ProtoContract]
        internal class NewComeinUser(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   isFrd  {get;set;} int = 0;
           [ProtoMember(3)] public   remark  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   nick  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class NewComeinUserNotify(
           [ProtoMember(1)] public   msgType  {get;set;} int = 0;
           [ProtoMember(2)] public   boolStrongNotify  {get;set;} bool = false;
           [ProtoMember(3)] public   pushTime  {get;set;} int = 0;
           [ProtoMember(4)] public   msgNewComeinUser  {get;set;} NewComeinUser? = null;
           [ProtoMember(5)] public   msgNewGroup  {get;set;} NewGroup? = null;
           [ProtoMember(6)] public   msgNewGroupUser  {get;set;} NewGroupUser? = null;
        }

        [ProtoContract]
        internal class NewGroup(
           [ProtoMember(1)] public   groupCode  {get;set;} long = 0L;
           [ProtoMember(2)] public   groupName  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   ownerUin  {get;set;} long = 0L;
           [ProtoMember(4)] public   ownerNick  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   distance  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class NewGroupUser(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   int32Sex  {get;set;} int = 0;
           [ProtoMember(3)] public   int32Age  {get;set;} int = 0;
           [ProtoMember(4)] public   nick  {get;set;} string = "";
           [ProtoMember(5)] public   distance  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class OneRoamPriv(
           [ProtoMember(1)] public   fuin  {get;set;} long = 0L;
           [ProtoMember(2)] public   privTag  {get;set;} int = 0;
           [ProtoMember(3)] public   privValue  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class PraiseRankNotify(
           [ProtoMember(11)] public   isChampion  {get;set;} int = 0;
           [ProtoMember(12)] public   rankNum  {get;set;} int = 0;
           [ProtoMember(13)] public   msg  {get;set;} string = "";
        }

        [ProtoContract]
        internal class ProfileInfo(
           [ProtoMember(1)] public   field  {get;set;} int = 0;
           [ProtoMember(2)] public   value  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class PushReportDev(
           [ProtoMember(1)] public   msgType  {get;set;} int = 0;
           [ProtoMember(4)] public   cookie  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   reportMaxNum  {get;set;} int = 200;
           [ProtoMember(6)] public   sn  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class PushSearchDev(
           [ProtoMember(1)] public   msgType  {get;set;} int = 0;
           [ProtoMember(2)] public   msgGpsInfo  {get;set;} GPS? = null;
           [ProtoMember(3)] public   devTime  {get;set;} int = 0;
           [ProtoMember(4)] public   pushTime  {get;set;} int = 0;
           [ProtoMember(5)] public   din  {get;set;} long = 0L;
           [ProtoMember(6)] public   data  {get;set;} string = "";
        }

        [ProtoContract]
        internal class QQPayPush(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   boolPayOk  {get;set;} bool = false;
        }

        [ProtoContract]
        internal class SnsUpateBuffer(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   code  {get;set;} long = 0L;
           [ProtoMember(3)] public   result  {get;set;} int = 0;
           [ProtoMember(400)] public   msgSnsUpdateItem  {get;set;} List<SnsUpdateItem> = new();
           [ProtoMember(401)] public   uint32Idlist  {get;set;} List<int> = new();
        }

        [ProtoContract]
        internal class SnsUpdateFlag(
           [ProtoMember(1)] public   msgUpdateSnsFlag  {get;set;} List<SnsUpdateOneFlag> = new();
        }

        [ProtoContract]
        internal class SnsUpdateItem(
           [ProtoMember(1)] public   updateSnsType  {get;set;} int = 0;
           [ProtoMember(2)] public   value  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class SnsUpdateOneFlag(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   id  {get;set;} long = 0L;
           [ProtoMember(3)] public   flag  {get;set;} int = 0;
        }
    }
}


internal class Submsgtype0x28 {
    internal class SubMsgType0x28  {
        [ProtoContract]
        internal class FollowList(
           [ProtoMember(1)] public   puin  {get;set;} long = 0L;
           [ProtoMember(2)] public   uin  {get;set;} long = 0L;
           [ProtoMember(3)] public   type  {get;set;} int = 0;
           [ProtoMember(4)] public   seqno  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   subCmd  {get;set;} int = 0;
           [ProtoMember(2)] public   msgRspFollowlist  {get;set;} RspFollowList? = null;
           [ProtoMember(3)] public   msgRspTypelist  {get;set;} RspTypeList? = null;
        }

        [ProtoContract]
        internal class RspFollowList(
           [ProtoMember(1)] public   msgFollowlist  {get;set;} List<FollowList> = new();
        }

        [ProtoContract]
        internal class RspTypeList(
           [ProtoMember(1)] public   msgTypelist  {get;set;} List<TypeList> = new();
        }

        [ProtoContract]
        internal class TypeList(
           [ProtoMember(1)] public   puin  {get;set;} long = 0L;
           [ProtoMember(2)] public   flag  {get;set;} int = 0;
           [ProtoMember(3)] public   type  {get;set;} int = 0;
        }
    }
}


internal class Submsgtype0x30 {
    internal class SubMsgType0x30  {
        [ProtoContract]
        internal class BlockListNotify(
           [ProtoMember(1)] public   msgBlockUinInfo  {get;set;} List<BlockUinInfo> = new();
           [ProtoMember(2)] public   uint64DelUin  {get;set;} List<Long> = new();
        }

        [ProtoContract]
        internal class BlockUinInfo(
           [ProtoMember(1)] public   blockUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   sourceId  {get;set;} int = 0;
           [ProtoMember(3)] public   sourceSubId  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   subCmd  {get;set;} int = 0;
           [ProtoMember(2)] public   msgS2cBlocklistNotify  {get;set;} BlockListNotify? = null;
        }
    }
}


internal class Submsgtype0x31 {
    internal class Submsgtype0x31  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   flag  {get;set;} int = 0;
           [ProtoMember(2)] public   uin  {get;set;} long = 0L;
           [ProtoMember(3)] public   bindUin  {get;set;} long = 0L;
            @ProtoType(ProtoIntegerType.FIXED)[ProtoMember(4)] public   time  {get;set;} int = 0;
        }
    }
}


internal class Submsgtype0x35 {
    internal class Submsgtype0x35  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   bubbleTimestamp  {get;set;} int = 0;
        }
    }
}


internal class Submsgtype0x3b {
    internal class Submsgtype0x3b  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   subCmd  {get;set;} int = 0;
           [ProtoMember(2)] public   groupCode  {get;set;} long = 0L;
           [ProtoMember(3)] public   userShowFlag  {get;set;} int = 0;
           [ProtoMember(4)] public   memberLevelChanged  {get;set;} int = 0;
           [ProtoMember(5)] public   officemode  {get;set;} int = 0;
        }
    }
}


internal class Submsgtype0x3d {
    internal class SttResultPush  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   subCmd  {get;set;} int = 0;
           [ProtoMember(2)] public   msgPttResp  {get;set;} TransPttResp? = null;
        }

        [ProtoContract]
        internal class TransPttResp(
           [ProtoMember(1)] public   sessionid  {get;set;} long = 0L;
           [ProtoMember(2)] public   pttType  {get;set;} int = 0;
           [ProtoMember(3)] public   errorCode  {get;set;} int = 0;
           [ProtoMember(4)] public   totalLen  {get;set;} int = 0;
           [ProtoMember(5)] public   seq  {get;set;} int = 0;
           [ProtoMember(6)] public   pos  {get;set;} int = 0;
           [ProtoMember(7)] public   len  {get;set;} int = 0;
           [ProtoMember(8)] public   text  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(9)] public   senderUin  {get;set;} long = 0L;
           [ProtoMember(10)] public   receiverUin  {get;set;} long = 0L;
           [ProtoMember(11)] public   fileID  {get;set;} int = 0;
           [ProtoMember(12)] public   filemd5  {get;set;} string = "";
           [ProtoMember(13)] public   filePath  {get;set;} string = "";
        }
    }
}


internal class Submsgtype0x3e {
    internal class Submsgtype0x3e  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   subcmd  {get;set;} int = 0;
           [ProtoMember(2)] public   random  {get;set;} int = 0;
           [ProtoMember(3)] public   result  {get;set;} int = 0;
           [ProtoMember(4)] public   device  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   sid  {get;set;} int = 0;
        }
    }
}


internal class Submsgtype0x3f {
    internal class SubMsgType0x3f  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgPubunikey  {get;set;} List<PubUniKey> = new();
        }

        [ProtoContract]
        internal class PubUniKey(
           [ProtoMember(1)] public   fromPubUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   qwMsgId  {get;set;} long = 0L;
        }
    }
}


internal class Submsgtype0x40 {
    internal class SubMsgType0x40  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   vUuid  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   fromUin  {get;set;} long = 0L;
           [ProtoMember(3)] public   toUin  {get;set;} long = 0L;
           [ProtoMember(4)] public   state  {get;set;} int = 0;
           [ProtoMember(11)] public   opertype  {get;set;} int = 0;
           [ProtoMember(12)] public   fromphonenum  {get;set;} string = "";
        }
    }
}


internal class Submsgtype0x41 {
    internal class MsgType0x210SubMsgType0x41  {
        [ProtoContract]
        internal class GameRsultMsg(
           [ProtoMember(1)] public   gameName  {get;set;} string = "";
           [ProtoMember(2)] public   gamePic  {get;set;} string = "";
           [ProtoMember(3)] public   moreInfo  {get;set;} string = "";
           [ProtoMember(4)] public   msgGameRsts  {get;set;} List<UinResult> = new();
           [ProtoMember(5)] public   gameSubheading  {get;set;} string = "";
           [ProtoMember(6)] public   uin  {get;set;} long = 0L;
           [ProtoMember(7)] public   nickname  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class UinResult(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   nickname  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   grade  {get;set;} int = 0;
           [ProtoMember(4)] public   score  {get;set;} string = "";
        }
    }
}


internal class Submsgtype0x42 {
    internal class Submsgtype0x42  {
        [ProtoContract]
        internal class GameStatusSync(
           [ProtoMember(1)] public   gameAppid  {get;set;} int = 0;
           [ProtoMember(2)] public   data  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0x44 {
    internal class Submsgtype0x44  {
        [ProtoContract]
        internal class ClearCountMsg(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   time  {get;set;} int = 0;
           [ProtoMember(3)] public   processflag  {get;set;} int = 0;
           [ProtoMember(4)] public   updateflag  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class FriendSyncMsg(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   fuin  {get;set;} long = 0L;
           [ProtoMember(3)] public   processtype  {get;set;} int = 0;
           [ProtoMember(4)] public   time  {get;set;} int = 0;
           [ProtoMember(5)] public   processflag  {get;set;} int = 0;
           [ProtoMember(6)] public   sourceid  {get;set;} int = 0;
           [ProtoMember(7)] public   sourcesubid  {get;set;} int = 0;
           [ProtoMember(8)] public   strWording  {get;set;} List<String> = new();
        }

        [ProtoContract]
        internal class GroupSyncMsg(
           [ProtoMember(1)] public   msgType  {get;set;} int = 0;
           [ProtoMember(2)] public   msgSeq  {get;set;} long = 0L;
           [ProtoMember(3)] public   grpCode  {get;set;} long = 0L;
           [ProtoMember(4)] public   gaCode  {get;set;} long = 0L;
           [ProtoMember(5)] public   optUin1  {get;set;} long = 0L;
           [ProtoMember(6)] public   optUin2  {get;set;} long = 0L;
           [ProtoMember(7)] public   msgBuf  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(8)] public   authKey  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(9)] public   msgStatus  {get;set;} int = 0;
           [ProtoMember(10)] public   actionUin  {get;set;} long = 0L;
           [ProtoMember(11)] public   actionTime  {get;set;} long = 0L;
           [ProtoMember(12)] public   curMaxMemCount  {get;set;} int = 0;
           [ProtoMember(13)] public   nextMaxMemCount  {get;set;} int = 0;
           [ProtoMember(14)] public   curMemCount  {get;set;} int = 0;
           [ProtoMember(15)] public   reqSrcId  {get;set;} int = 0;
           [ProtoMember(16)] public   reqSrcSubId  {get;set;} int = 0;
           [ProtoMember(17)] public   inviterRole  {get;set;} int = 0;
           [ProtoMember(18)] public   extAdminNum  {get;set;} int = 0;
           [ProtoMember(19)] public   processflag  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class ModifySyncMsg(
           [ProtoMember(1)] public   time  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgFriendMsgSync  {get;set;} FriendSyncMsg? = null;
           [ProtoMember(2)] public   msgGroupMsgSync  {get;set;} GroupSyncMsg? = null;
           [ProtoMember(3)] public   msgCleanCountMsg  {get;set;} ClearCountMsg? = null;
           [ProtoMember(4)] public   msgModifyMsgSync  {get;set;} ModifySyncMsg? = null;
           [ProtoMember(5)] public   msgWaitingMsgSync  {get;set;} WaitingSyncMsg? = null;
        }

        [ProtoContract]
        internal class WaitingSyncMsg(
           [ProtoMember(1)] public   time  {get;set;} int = 0;
        }
    }
}


internal class Submsgtype0x48 {
    [ProtoContract] class RecommendDeviceLock(
       [ProtoMember(1)] public   canCancel  {get;set;} bool = false;
       [ProtoMember(2)] public   wording  {get;set;} string = "";
       [ProtoMember(3)] public   title  {get;set;} string = "";
       [ProtoMember(4)] public   secondTitle  {get;set;} string = "";
       [ProtoMember(5)] public   thirdTitle  {get;set;} string = "";
       [ProtoMember(6)] public   wordingList  {get;set;} List<String> = new();
    }
}


internal class Submsgtype0x4a {
    [ProtoContract] class MsgBody(
       [ProtoMember(1)] public   secCmd  {get;set;} int = 0;
       [ProtoMember(2)] public   data  {get;set;} byte[] = Array.Empty<byte>();
    }
}


internal class Submsgtype0x4b {
    [ProtoContract] class MsgBody(
       [ProtoMember(1)] public   albumid  {get;set;} string = "";
       [ProtoMember(2)] public   coverUrl  {get;set;} string = "";
       [ProtoMember(3)] public   albumName  {get;set;} string = "";
       [ProtoMember(4)] public   opuin  {get;set;} long = 0L;
        @ProtoType(ProtoIntegerType.FIXED)[ProtoMember(5)] public   time  {get;set;} int = 0;
       [ProtoMember(6)] public   picCnt  {get;set;} int = 0;
       [ProtoMember(7)] public   pushMsgHelper  {get;set;} string = "";
       [ProtoMember(8)] public   pushMsgAlbum  {get;set;} string = "";
       [ProtoMember(9)] public   usrTotal  {get;set;} int = 0;
       [ProtoMember(10)] public   uint64User  {get;set;} List<Long> = new();
    }

    internal class Submsgtype0x4b  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   albumid  {get;set;} string = "";
           [ProtoMember(2)] public   coverUrl  {get;set;} string = "";
           [ProtoMember(3)] public   albumName  {get;set;} string = "";
           [ProtoMember(4)] public   opuin  {get;set;} long = 0L;
            @ProtoType(ProtoIntegerType.FIXED)[ProtoMember(5)] public   time  {get;set;} int = 0;
           [ProtoMember(6)] public   picCnt  {get;set;} int = 0;
           [ProtoMember(7)] public   pushMsgHelper  {get;set;} string = "";
           [ProtoMember(8)] public   pushMsgAlbum  {get;set;} string = "";
           [ProtoMember(9)] public   usrTotal  {get;set;} int = 0;
           [ProtoMember(10)] public   uint64User  {get;set;} List<Long> = new();
        }
    }
}


internal class Submsgtype0x4e {
    internal class Submsgtype0x4e  {
        [ProtoContract]
        internal class GroupBulletin(
           [ProtoMember(1)] public   msgContent  {get;set;} List<Content> = new();
        } {
            [ProtoContract]
            internal class Content(
               [ProtoMember(1)] public   feedid  {get;set;} byte[] = Array.Empty<byte>();
               [ProtoMember(2)] public   uin  {get;set;} long = 0L;
                @ProtoType(ProtoIntegerType.FIXED)[ProtoMember(3)] public   time  {get;set;} int = 0;
            }
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   groupId  {get;set;} long = 0L;
           [ProtoMember(2)] public   groupCode  {get;set;} long = 0L;
           [ProtoMember(3)] public   appid  {get;set;} int = 0;
           [ProtoMember(4)] public   msgGroupBulletin  {get;set;} GroupBulletin? = null;
        }
    }
}


internal class Submsgtype0x54 {
    internal class Submsgtype0x54  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   peerType  {get;set;} int /* enum */ = 1;
           [ProtoMember(2)] public   peerUin  {get;set;} long = 0L;
           [ProtoMember(3)] public   taskList  {get;set;} List<TaskInfo> = new();
        } {
            [ProtoContract]
            internal class TaskInfo(
               [ProtoMember(1)] public   taskId  {get;set;} int = 0;
            }
        }
    }
}


internal class Submsgtype0x60 {
    internal class SubMsgType0x60  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   pushcmd  {get;set;} int = 0;
           [ProtoMember(2)] public   int64Ts  {get;set;} long = 0L;
           [ProtoMember(3)] public   ssid  {get;set;} string = "";
           [ProtoMember(4)] public   content  {get;set;} string = "";
        }
    }
}


internal class Submsgtype0x63 {
    internal class Submsgtype0x63  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   roomid  {get;set;} long = 0L;
           [ProtoMember(2)] public   seq  {get;set;} int = 0;
           [ProtoMember(3)] public   url  {get;set;} string = "";
           [ProtoMember(4)] public   data  {get;set;} string = "";
        }
    }
}


internal class Submsgtype0x65 {
    internal class SubMsgType0x65  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   cmd  {get;set;} int = 0;
           [ProtoMember(2)] public   msgExpiredPkg  {get;set;} MsgExpiredPkg? = null;
        }

        [ProtoContract]
        internal class MsgExpiredPkg(
           [ProtoMember(1)] public   platform  {get;set;} int = 0;
           [ProtoMember(2)] public   expirePkg  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   predownPkg  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0x66 {
    internal class Submsgtype0x66  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   type  {get;set;} int = 0;
           [ProtoMember(2)] public   pushData  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   timestamp  {get;set;} int = 0;
           [ProtoMember(4)] public   notifyText  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   pushFlag  {get;set;} int = 0;
        }
    }
}


internal class Submsgtype0x67 {
    internal class Submsgtype0x67  {
        [ProtoContract]
        internal class GroupInfo(
           [ProtoMember(1)] public   groupCode  {get;set;} long = 0L;
           [ProtoMember(2)] public   groupName  {get;set;} string = "";
           [ProtoMember(3)] public   groupMemo  {get;set;} string = "";
           [ProtoMember(4)] public   memberNum  {get;set;} int = 0;
           [ProtoMember(5)] public   groupType  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgGrpinfo  {get;set;} List<GroupInfo> = new();
        }
    }
}


internal class Submsgtype0x69 {
    [ProtoContract] class Submsgtype0x69(
       [ProtoMember(1)] public   appid  {get;set;} int = 0;
       [ProtoMember(2)] public   boolDisplayReddot  {get;set;} bool = false;
       [ProtoMember(3)] public   number  {get;set;} int = 0;
       [ProtoMember(4)] public   reason  {get;set;} int = 0;
       [ProtoMember(5)] public   lastTime  {get;set;} int = 0;
       [ProtoMember(6)] public   cmdUin  {get;set;} long = 0L;
       [ProtoMember(7)] public   faceUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(8)] public   customBuffer  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(9)] public   expireTime  {get;set;} int = 0;
       [ProtoMember(10)] public   cmdUinType  {get;set;} int = 0;
       [ProtoMember(11)] public   reportType  {get;set;} int = 0;
       [ProtoMember(12)] public   boolTestEnv  {get;set;} bool = false;
    }
}


internal class Submsgtype0x6b {
    internal class SubMsgType0x6b  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   toUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   tipsContent  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   yesText  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   noText  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0x6f {
    internal class SubMsgType0x6f  {
        [ProtoContract]
        internal class AddFriendSource(
           [ProtoMember(1)] public   source  {get;set;} int = 0;
           [ProtoMember(2)] public   subSource  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class AddQimFriendNotifyToQQ(
           [ProtoMember(1)] public   opType  {get;set;} int = 0;
           [ProtoMember(2)] public   uin  {get;set;} long = 0L;
           [ProtoMember(3)] public   gender  {get;set;} int = 0;
           [ProtoMember(4)] public   smartRemark  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   longnick  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(6)] public   storysTotalNum  {get;set;} long = 0L;
           [ProtoMember(7)] public   caresCount  {get;set;} long = 0L;
           [ProtoMember(8)] public   fansCount  {get;set;} long = 0L;
           [ProtoMember(9)] public   wording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(10)] public   srcWording  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class AddQimNotLoginFrdNotifyToQQ(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   nick  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   gender  {get;set;} int = 0;
           [ProtoMember(4)] public   age  {get;set;} int = 0;
           [ProtoMember(5)] public   coverstory  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(6)] public   storysTotalNum  {get;set;} long = 0L;
           [ProtoMember(7)] public   msgVideoInfo  {get;set;} List<VideoInfo> = new();
           [ProtoMember(8)] public   wording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(9)] public   qqUin  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class BirthdayReminderPush(
           [ProtoMember(2004)] public   reminderWording  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class FanpaiziNotify(
           [ProtoMember(1)] public   fromUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   fromNick  {get;set;} string = "";
           [ProtoMember(3)] public   tipsContent  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class ForwardBody(
           [ProtoMember(1)] public   notifyType  {get;set;} int = 0;
           [ProtoMember(2)] public   opType  {get;set;} int = 0;
           [ProtoMember(2000)] public   msgFanpanziNotify  {get;set;} FanpaiziNotify? = null;
           [ProtoMember(2001)] public   msgMcardNotificationLike  {get;set;} MCardNotificationLike? = null;
           [ProtoMember(2002)] public   msgVipInfoNotify  {get;set;} VipInfoNotify? = null;
           [ProtoMember(2003)] public   msgPushLostDevFound  {get;set;} PushLostDevFound? = null;
           [ProtoMember(2004)] public   msgBirthdayReminderPush  {get;set;} BirthdayReminderPush? = null;
           [ProtoMember(2005)] public   msgPushLostDev  {get;set;} PushLostDevFound? = null;
           [ProtoMember(2007)] public   msgBabyqRewardInfo  {get;set;} RewardInfo? = null;
           [ProtoMember(2008)] public   msgHotFriendNotify  {get;set;} HotFriendNotify? = null;
           [ProtoMember(2009)] public   msgPushQimRecommend  {get;set;} QimRecomendMsg? = null;
           [ProtoMember(2010)] public   msgModQimFriend  {get;set;} QimFriendNotify? = null;
           [ProtoMember(2011)] public   msgModQimFriendToQq  {get;set;} QimFriendNotifyToQQ? = null;
        }

        [ProtoContract]
        internal class GPS(
           [ProtoMember(1)] public   int32Lat  {get;set;} int = 900000000;
           [ProtoMember(2)] public   int32Lon  {get;set;} int = 900000000;
           [ProtoMember(3)] public   int32Alt  {get;set;} int = -10000000;
           [ProtoMember(4)] public   int32Type  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class HotFriendNotify(
           [ProtoMember(1)] public   dstUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   praiseHotLevel  {get;set;} int = 0;
           [ProtoMember(3)] public   chatHotLevel  {get;set;} int = 0;
           [ProtoMember(4)] public   praiseHotDays  {get;set;} int = 0;
           [ProtoMember(5)] public   chatHotDays  {get;set;} int = 0;
           [ProtoMember(6)] public   closeLevel  {get;set;} int = 0;
           [ProtoMember(7)] public   closeDays  {get;set;} int = 0;
           [ProtoMember(8)] public   praiseFlag  {get;set;} int = 0;
           [ProtoMember(9)] public   chatFlag  {get;set;} int = 0;
           [ProtoMember(10)] public   closeFlag  {get;set;} int = 0;
           [ProtoMember(11)] public   notifyTime  {get;set;} long = 0L;
           [ProtoMember(12)] public   lastPraiseTime  {get;set;} long = 0L;
           [ProtoMember(13)] public   lastChatTime  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class MCardNotificationLike(
           [ProtoMember(1)] public   fromUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   counterTotal  {get;set;} int = 0;
           [ProtoMember(3)] public   counterNew  {get;set;} int = 0;
           [ProtoMember(4)] public   wording  {get;set;} string = "";
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgModInfos  {get;set;} List<ForwardBody> = new();
        }

        [ProtoContract]
        internal class PushLostDevFound(
           [ProtoMember(1)] public   msgType  {get;set;} int = 0;
           [ProtoMember(3)] public   devTime  {get;set;} int = 0;
           [ProtoMember(6)] public   din  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class QimFriendNotify(
           [ProtoMember(1)] public   opType  {get;set;} int = 0;
           [ProtoMember(2)] public   uint64Uins  {get;set;} List<Long> = new();
           [ProtoMember(3)] public   fansUnreadCount  {get;set;} long = 0L;
           [ProtoMember(4)] public   fansTotalCount  {get;set;} long = 0L;
           [ProtoMember(5)] public   pushTime  {get;set;} long = 0L;
           [ProtoMember(6)] public   bytesMobiles  {get;set;} List<byte[]> = new();
        }

        [ProtoContract]
        internal class QimFriendNotifyToQQ(
           [ProtoMember(1)] public   notifyType  {get;set;} int = 0;
           [ProtoMember(2)] public   msgAddNotifyToQq  {get;set;} AddQimFriendNotifyToQQ? = null;
           [ProtoMember(3)] public   msgUpgradeNotify  {get;set;} UpgradeQimFriendNotify? = null;
           [ProtoMember(4)] public   msgAddNotLoginFrdNotifyToQq  {get;set;} AddQimNotLoginFrdNotifyToQQ? = null;
        }

        [ProtoContract]
        internal class QimRecomendInfo(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   name  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   reason  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   gender  {get;set;} int = 0;
           [ProtoMember(5)] public   longnick  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(6)] public   alghbuff  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(7)] public   age  {get;set;} int = 0;
           [ProtoMember(8)] public   source  {get;set;} int = 0;
           [ProtoMember(9)] public   sourceReason  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(10)] public   msgIosSource  {get;set;} AddFriendSource? = null;
           [ProtoMember(11)] public   msgAndroidSource  {get;set;} AddFriendSource? = null;
        }

        [ProtoContract]
        internal class QimRecomendMsg(
           [ProtoMember(1)] public   msgRecomendList  {get;set;} List<QimRecomendInfo> = new();
           [ProtoMember(2)] public   timestamp  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class RewardInfo(
           [ProtoMember(1)] public   type  {get;set;} int = 0;
           [ProtoMember(2)] public   name  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   jmpUrl  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   cookies  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   jmpWording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(6)] public   optWording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(7)] public   optUrl  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(8)] public   faceAddonId  {get;set;} long = 0L;
           [ProtoMember(9)] public   iconUrl  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(10)] public   toastWording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(11)] public   reportType  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class UpgradeQimFriendNotify(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   wording  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class VideoInfo(
           [ProtoMember(1)] public   vid  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   videoCoverUrl  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class VipInfoNotify(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   vipLevel  {get;set;} int = 0;
           [ProtoMember(3)] public   vipIdentify  {get;set;} int = 0;
           [ProtoMember(4)] public   ext  {get;set;} int = 0;
           [ProtoMember(5)] public   extString  {get;set;} string = "";
           [ProtoMember(6)] public   redFlag  {get;set;} int = 0;
           [ProtoMember(7)] public   disableRedEnvelope  {get;set;} int = 0;
           [ProtoMember(8)] public   redpackId  {get;set;} int = 0;
           [ProtoMember(9)] public   redpackName  {get;set;} string = "";
        }
    }
}


internal class Submsgtype0x71 {
    internal class Submsgtype0x71  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgAppInfo  {get;set;} List<ReportAppInfo> = new();
           [ProtoMember(2)] public   uiUin  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class RedDisplayInfo(
           [ProtoMember(1)] public   msgRedTypeInfo  {get;set;} List<RedTypeInfo> = new();
           [ProtoMember(2)] public   msgTabDisplayInfo  {get;set;} RedTypeInfo? = null;
        }

        [ProtoContract]
        internal class RedTypeInfo(
           [ProtoMember(1)] public   redType  {get;set;} int = 0;
           [ProtoMember(2)] public   redContent  {get;set;} string = "";
           [ProtoMember(3)] public   redDesc  {get;set;} string = "";
           [ProtoMember(4)] public   redPriority  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class ReportAppInfo(
           [ProtoMember(1)] public   appId  {get;set;} int = 0;
           [ProtoMember(2)] public   int32NewFlag  {get;set;} int = 0;
           [ProtoMember(3)] public   type  {get;set;} int = 0;
           [ProtoMember(4)] public   buffer  {get;set;} string = "";
           [ProtoMember(5)] public   path  {get;set;} string = "";
           [ProtoMember(6)] public   pushRedTs  {get;set;} int = 0;
           [ProtoMember(7)] public   mission  {get;set;} string = "";
           [ProtoMember(8)] public   int32Appset  {get;set;} int = 0;
           [ProtoMember(9)] public   int32Num  {get;set;} int = 0;
           [ProtoMember(10)] public   iconUrl  {get;set;} string = "";
           [ProtoMember(11)] public   int32IconFlag  {get;set;} int = 0;
           [ProtoMember(12)] public   int32IconType  {get;set;} int = 0;
           [ProtoMember(13)] public   duration  {get;set;} int = 0;
           [ProtoMember(14)] public   msgVersionInfo  {get;set;} ReportVersion? = null;
           [ProtoMember(15)] public   androidAppId  {get;set;} int = 0;
           [ProtoMember(16)] public   iosAppId  {get;set;} int = 0;
           [ProtoMember(17)] public   androidPath  {get;set;} string = "";
           [ProtoMember(18)] public   iosPath  {get;set;} string = "";
           [ProtoMember(19)] public   int32MissionLevel  {get;set;} int = 0;
           [ProtoMember(20)] public   msgDisplayDesc  {get;set;} RedDisplayInfo? = null;
        }

        [ProtoContract]
        internal class ReportVersion(
           [ProtoMember(1)] public   int32PlantId  {get;set;} int = 0;
           [ProtoMember(2)] public   boolAllver  {get;set;} bool = false;
           [ProtoMember(3)] public   strVersion  {get;set;} List<String> = new();
        }
    }
}


internal class Submsgtype0x72 {
    internal class SubMsgType0x72  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   subCmd  {get;set;} int = 0;
           [ProtoMember(2)] public   urgency  {get;set;} int = 0;
           [ProtoMember(3)] public   templateNo  {get;set;} int = 0;
           [ProtoMember(4)] public   content  {get;set;} string = "";
           [ProtoMember(5)] public   infoDate  {get;set;} string = "";
        }
    }
}


internal class Submsgtype0x76 {
    internal class SubMsgType0x76  {
        [ProtoContract]
        internal class BirthdayNotify(
           [ProtoMember(1)] public   msgOneFriend  {get;set;} List<OneBirthdayFriend> = new();
           [ProtoMember(2)] public   reserved  {get;set;} int = 0;
           [ProtoMember(3)] public   giftMsg  {get;set;} List<OneGiftMessage> = new();
           [ProtoMember(4)] public   topPicUrl  {get;set;} string = "";
           [ProtoMember(5)] public   extend  {get;set;} string = "";
        }

        [ProtoContract]
        internal class GeoGraphicNotify(
           [ProtoMember(1)] public   localCity  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   msgOneFriend  {get;set;} List<OneGeoGraphicFriend> = new();
        }

        [ProtoContract]
        internal class MemorialDayNotify(
           [ProtoMember(1)] public   anniversaryInfo  {get;set;} List<OneMemorialDayInfo> = new();
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgType  {get;set;} int = 0;
           [ProtoMember(2)] public   boolStrongNotify  {get;set;} bool = false;
           [ProtoMember(3)] public   pushTime  {get;set;} int = 0;
           [ProtoMember(4)] public   msgGeographicNotify  {get;set;} GeoGraphicNotify? = null;
           [ProtoMember(5)] public   msgBirthdayNotify  {get;set;} BirthdayNotify? = null;
           [ProtoMember(6)] public   notifyWording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(7)] public   msgMemorialdayNotify  {get;set;} MemorialDayNotify? = null;
        }

        [ProtoContract]
        internal class OneBirthdayFriend(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   boolLunarBirth  {get;set;} bool = false;
           [ProtoMember(3)] public   birthMonth  {get;set;} int = 0;
           [ProtoMember(4)] public   birthDate  {get;set;} int = 0;
           [ProtoMember(5)] public   msgSendTime  {get;set;} long = 0L;
           [ProtoMember(6)] public   birthYear  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class OneGeoGraphicFriend(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class OneGiftMessage(
           [ProtoMember(1)] public   giftId  {get;set;} int = 0;
           [ProtoMember(2)] public   giftName  {get;set;} string = "";
           [ProtoMember(3)] public   type  {get;set;} int = 0;
           [ProtoMember(4)] public   giftUrl  {get;set;} string = "";
           [ProtoMember(5)] public   price  {get;set;} int = 0;
           [ProtoMember(6)] public   playCnt  {get;set;} int = 0;
           [ProtoMember(7)] public   backgroundColor  {get;set;} string = "";
        }

        [ProtoContract]
        internal class OneMemorialDayInfo(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   type  {get;set;} long = 0;
           [ProtoMember(3)] public   memorialTime  {get;set;} int = 0;
           [ProtoMember(11)] public   mainWordingNick  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(12)] public   mainWordingEvent  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(13)] public   subWording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(14)] public   greetings  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(15)] public   friendGender  {get;set;} int = 0;
        }
    }
}


internal class Submsgtype0x78 {
    internal class Submsgtype0x78  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   type  {get;set;} int = 0;
           [ProtoMember(2)] public   version  {get;set;} int = 0;
        }
    }
}


internal class Submsgtype0x7a {
    internal class Submsgtype0x7a  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   content  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   fromUin  {get;set;} long = 0L;
           [ProtoMember(3)] public   nick  {get;set;} string = "";
           [ProtoMember(4)] public   discussUin  {get;set;} long = 0L;
           [ProtoMember(5)] public   discussNick  {get;set;} string = "";
           [ProtoMember(6)] public   seq  {get;set;} long = 0L;
           [ProtoMember(7)] public   atTime  {get;set;} long = 0L;
        }
    }
}


internal class Submsgtype0x7c {
    internal class Submsgtype0x7c  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   int32Cmd  {get;set;} int = 0;
           [ProtoMember(3)] public   stringCmdExt  {get;set;} List<String> = new();
           [ProtoMember(4)] public   seq  {get;set;} long = 0L;
           [ProtoMember(5)] public   stringSeqExt  {get;set;} List<String> = new();
        }
    }
}


internal class Submsgtype0x7e {
    internal class Submsgtype0x7e  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   notice  {get;set;} string = "";
           [ProtoMember(2)] public   msgOnlinePush  {get;set;} WalletMsgPush? = null;
        }

        [ProtoContract]
        internal class WalletMsgPush(
           [ProtoMember(1)] public   action  {get;set;} int = 0;
           [ProtoMember(2)] public   timestamp  {get;set;} int = 0;
           [ProtoMember(3)] public   extend  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   serialno  {get;set;} string = "";
           [ProtoMember(5)] public   billno  {get;set;} string = "";
           [ProtoMember(6)] public   appinfo  {get;set;} string = "";
           [ProtoMember(7)] public   amount  {get;set;} int = 0;
           [ProtoMember(8)] public   jumpurl  {get;set;} string = "";
        }
    }
}


internal class Submsgtype0x83 {
    internal class SubMsgType0x83  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgParams  {get;set;} List<MsgParams> = new();
           [ProtoMember(2)] public   seq  {get;set;} long = 0L;
           [ProtoMember(3)] public   groupId  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class MsgParams(
           [ProtoMember(1)] public   type  {get;set;} int = 0;
           [ProtoMember(2)] public   fromUin  {get;set;} long = 0L;
           [ProtoMember(3)] public   toUin  {get;set;} long = 0L;
           [ProtoMember(4)] public   dataString  {get;set;} string = "";
           [ProtoMember(5)] public   data  {get;set;} byte[] = Array.Empty<byte>();
        }

        internal class MsgRep 
    }
}


internal class Submsgtype0x85 {
    internal class SubMsgType0x85  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   showLastest  {get;set;} int = 0;
           [ProtoMember(2)] public   senderUin  {get;set;} long = 0L;
           [ProtoMember(3)] public   receiverUin  {get;set;} long = 0L;
           [ProtoMember(4)] public   senderRichContent  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   receiverRichContent  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(6)] public   authkey  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(7)] public   pcBody  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(8)] public   icon  {get;set;} int = 0;
           [ProtoMember(9)] public   random  {get;set;} int = 0;
           [ProtoMember(10)] public   redSenderUin  {get;set;} long = 0L;
           [ProtoMember(11)] public   type  {get;set;} int = 0;
           [ProtoMember(12)] public   subType  {get;set;} int = 0;
           [ProtoMember(13)] public   jumpurl  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0x86 {
    internal class SubMsgType0x86  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   notifyFlag  {get;set;} int = 0;
           [ProtoMember(2)] public   notifyWording  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0x87 {
    internal class SubMsgType0x87  {
        [ProtoContract]
        internal class CloneInfo(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   remark  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   originNick  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   showInAio  {get;set;} int = 0;
           [ProtoMember(5)] public   toUin  {get;set;} long = 0L;
           [ProtoMember(6)] public   toNick  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(7)] public   srcGender  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   friendMsgTypeFlag  {get;set;} long = 0L;
           [ProtoMember(2)] public   msgMsgNotify  {get;set;} List<MsgNotify> = new();
           [ProtoMember(3)] public   msgMsgNotifyUnread  {get;set;} MsgNotifyUnread? = null;
        }

        [ProtoContract]
        internal class MsgNotify(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   fuin  {get;set;} long = 0L;
           [ProtoMember(3)] public   time  {get;set;} int = 0;
           [ProtoMember(4)] public   reqsubtype  {get;set;} int = 0;
           [ProtoMember(5)] public   maxCount  {get;set;} int = 0;
           [ProtoMember(6)] public   msgCloneInfo  {get;set;} CloneInfo? = null;
        }

        [ProtoContract]
        internal class MsgNotifyUnread(
           [ProtoMember(1)] public   unreadcount  {get;set;} int = 0;
        }
    }
}


internal class Submsgtype0x89 {
    internal class Submsgtype0x89  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   uiUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   pushRedTs  {get;set;} int = 0;
           [ProtoMember(3)] public   msgNumRed  {get;set;} List<NumRedBusiInfo> = new();
        }

        [ProtoContract]
        internal class NumRedBusiInfo(
           [ProtoMember(1)] public   clientVerBegin  {get;set;} string = "";
           [ProtoMember(2)] public   clientVerEnd  {get;set;} string = "";
           [ProtoMember(3)] public   platId  {get;set;} int = 0;
           [ProtoMember(4)] public   appId  {get;set;} int = 0;
           [ProtoMember(5)] public   androidAppId  {get;set;} int = 0;
           [ProtoMember(6)] public   iosAppId  {get;set;} int = 0;
           [ProtoMember(7)] public   path  {get;set;} string = "";
           [ProtoMember(8)] public   androidPath  {get;set;} string = "";
           [ProtoMember(9)] public   iosPath  {get;set;} string = "";
           [ProtoMember(10)] public   missionid  {get;set;} string = "";
           [ProtoMember(11)] public   msgid  {get;set;} long = 0L;
           [ProtoMember(12)] public   status  {get;set;} int = 0;
           [ProtoMember(13)] public   expireTime  {get;set;} int = 0;
           [ProtoMember(14)] public   int32Appset  {get;set;} int = 0;
        }
    }
}


internal class Submsgtype0x8d {
    internal class SubMsgType0x8d  {
        [ProtoContract]
        internal class ChannelNotify(
           [ProtoMember(1)] public   channelId  {get;set;} long = 0L;
           [ProtoMember(2)] public   channelName  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   wording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   topArticleIdList  {get;set;} List<Long> = new();
        }

        [ProtoContract]
        internal class CommentFeeds(
           [ProtoMember(1)] public   feedsOwner  {get;set;} long = 0L;
           [ProtoMember(2)] public   feedsId  {get;set;} long = 0L;
           [ProtoMember(3)] public   commentUin  {get;set;} long = 0L;
           [ProtoMember(4)] public   commentId  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   replyUin  {get;set;} long = 0L;
           [ProtoMember(6)] public   replyId  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(7)] public   commentInfo  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(8)] public   feedsSubject  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class DeleteComment(
           [ProtoMember(1)] public   feedsOwner  {get;set;} long = 0L;
           [ProtoMember(2)] public   feedsId  {get;set;} long = 0L;
           [ProtoMember(3)] public   commentUin  {get;set;} long = 0L;
           [ProtoMember(4)] public   commentId  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   replyUin  {get;set;} long = 0L;
           [ProtoMember(6)] public   replyId  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(7)] public   deleteUin  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class DeleteFeeds(
           [ProtoMember(1)] public   feedsOwner  {get;set;} long = 0L;
           [ProtoMember(2)] public   feedsId  {get;set;} long = 0L;
           [ProtoMember(3)] public   deleteUin  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class LikeFeeds(
           [ProtoMember(1)] public   feedsOwner  {get;set;} long = 0L;
           [ProtoMember(2)] public   feedsId  {get;set;} long = 0L;
           [ProtoMember(3)] public   likeUin  {get;set;} long = 0L;
           [ProtoMember(4)] public   feedsSubject  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgNotifyInfos  {get;set;} List<NotifyBody> = new();
           [ProtoMember(2)] public   redSpotNotifyBody  {get;set;} RedSpotNotifyBody? = null;
        }

        [ProtoContract]
        internal class NotifyBody(
           [ProtoMember(1)] public   notifyType  {get;set;} int = 0;
           [ProtoMember(2)] public   seq  {get;set;} int = 0;
           [ProtoMember(3)] public   pushTime  {get;set;} int = 0;
           [ProtoMember(10)] public   msgPublishFeeds  {get;set;} PublishFeeds? = null;
           [ProtoMember(11)] public   msgCommentFeeds  {get;set;} CommentFeeds? = null;
           [ProtoMember(12)] public   msgLikeFeeds  {get;set;} LikeFeeds? = null;
           [ProtoMember(13)] public   msgDeleteFeeds  {get;set;} DeleteFeeds? = null;
           [ProtoMember(14)] public   msgDeleteComment  {get;set;} DeleteComment? = null;
        }

        [ProtoContract]
        internal class PublishFeeds(
           [ProtoMember(1)] public   feedsOwner  {get;set;} long = 0L;
           [ProtoMember(2)] public   feedsId  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class RedSpotNotifyBody(
           [ProtoMember(1)] public   time  {get;set;} int = 0;
           [ProtoMember(2)] public   newChannelList  {get;set;} List<Long> = new();
           [ProtoMember(3)] public   guideWording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   msgChannelNotify  {get;set;} ChannelNotify? = null;
        }
    }
}


internal class Submsgtype0x8f {
    internal class Submsgtype0x8f  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgSourceId  {get;set;} SourceID? = null;
           [ProtoMember(2)] public   feedsId  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   enumMsgType  {get;set;} int /* enum */ = 1;
           [ProtoMember(4)] public   extMsg  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   authorUin  {get;set;} long = 0L;
           [ProtoMember(6)] public   confirmUin  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class SourceID(
           [ProtoMember(1)] public   sourceType  {get;set;} int = 0;
           [ProtoMember(2)] public   sourceCode  {get;set;} long = 0L;
        }
    }
}


internal class Submsgtype0x90 {
    internal class SubMsgType0x90  {
        [ProtoContract]
        internal class DpNotifyMsgBdoy(
           [ProtoMember(1)] public   pid  {get;set;} int = 0;
           [ProtoMember(2)] public   din  {get;set;} long = 0L;
           [ProtoMember(3)] public   msgNotifyInfo  {get;set;} List<NotifyItem> = new();
           [ProtoMember(4)] public   extendInfo  {get;set;} string = "";
        }

        [ProtoContract]
        internal class Head(
           [ProtoMember(1)] public   cmd  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgHead  {get;set;} Head? = null;
           [ProtoMember(2)] public   msgBody  {get;set;} PushBody? = null;
        }

        [ProtoContract]
        internal class NotifyItem(
           [ProtoMember(1)] public   propertyid  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class OccupyMicrophoneNotifyMsgBody(
           [ProtoMember(1)] public   uin  {get;set;} int = 0;
           [ProtoMember(2)] public   din  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class PushBody(
           [ProtoMember(1)] public   msgDpNotifyBody  {get;set;} DpNotifyMsgBdoy? = null;
           [ProtoMember(2)] public   msgOccupyMicrophoneBody  {get;set;} OccupyMicrophoneNotifyMsgBody? = null;
        }
    }
}


internal class Submsgtype0x92 {
    internal class SubMsgType0x92  {
        [ProtoContract]
        internal class CrmS2CMsgHead(
           [ProtoMember(1)] public   crmSubCmd  {get;set;} int = 0;
           [ProtoMember(2)] public   headLen  {get;set;} int = 0;
           [ProtoMember(3)] public   verNo  {get;set;} int = 0;
           [ProtoMember(4)] public   kfUin  {get;set;} long = 0L;
           [ProtoMember(5)] public   seq  {get;set;} int = 0;
           [ProtoMember(6)] public   packNum  {get;set;} int = 0;
           [ProtoMember(7)] public   curPack  {get;set;} int = 0;
           [ProtoMember(8)] public   bufSig  {get;set;} string = "";
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   subCmd  {get;set;} int = 0;
           [ProtoMember(2)] public   msgCrmCommonHead  {get;set;} CrmS2CMsgHead? = null;
           [ProtoMember(100)] public   msgPushEmanMsg  {get;set;} S2CPushEmanMsgToC? = null;
        } {
            [ProtoContract]
            internal class S2CPushEmanMsgToC(
               [ProtoMember(1)] public   uin  {get;set;} long = 0L;
               [ProtoMember(2)] public   xml  {get;set;} string = "";
            }
        }
    }
}


internal class Submsgtype0x93 {
    internal class Submsgtype0x93  {
        [ProtoContract]
        internal class LiteMailIndexInfo(
           [ProtoMember(1)] public   feedsId  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   msgSourceId  {get;set;} SourceID? = null;
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgType  {get;set;} int = 0;
           [ProtoMember(2)] public   msgUmcChanged  {get;set;} UnreadMailCountChanged? = null;
           [ProtoMember(3)] public   msgStateChanged  {get;set;} StateChangeNotify? = null;
        }

        [ProtoContract]
        internal class SourceID(
           [ProtoMember(1)] public   sourceType  {get;set;} int = 0;
           [ProtoMember(2)] public   sourceCode  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class StateChangeNotify(
           [ProtoMember(1)] public   msgSourceId  {get;set;} SourceID? = null;
           [ProtoMember(2)] public   feedsId  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   enumMsgType  {get;set;} int /* enum */ = 1;
           [ProtoMember(4)] public   extMsg  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   reqUin  {get;set;} long = 0L;
           [ProtoMember(6)] public   msgLiteMailIndex  {get;set;} List<LiteMailIndexInfo> = new();
        }

        [ProtoContract]
        internal class UnreadMailCountChanged(
           [ProtoMember(1)] public   msgUmc  {get;set;} UnreadMailCountInfo? = null;
        }

        [ProtoContract]
        internal class UnreadMailCountInfo(
           [ProtoMember(1)] public   unreadCount  {get;set;} int = 0;
           [ProtoMember(2)] public   dataVersion  {get;set;} int = 0;
        }
    }
}


internal class Submsgtype0x94 {
    internal class Submsgtype0x94  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   taskId  {get;set;} int = 0;
           [ProtoMember(2)] public   folderReddotFlag  {get;set;} int = 0;
           [ProtoMember(3)] public   discoverReddotFlag  {get;set;} int = 0;
           [ProtoMember(4)] public   startTs  {get;set;} int = 0;
           [ProtoMember(5)] public   endTs  {get;set;} int = 0;
           [ProtoMember(6)] public   periodOfValidity  {get;set;} int = 0;
           [ProtoMember(7)] public   folderMsg  {get;set;} string = "";
           [ProtoMember(8)] public   discountReddotFlag  {get;set;} int = 0;
           [ProtoMember(9)] public   nearbyReddotFlag  {get;set;} int = 0;
           [ProtoMember(10)] public   mineReddotFlag  {get;set;} int = 0;
           [ProtoMember(11)] public   onlyDiscoverReddotFlag  {get;set;} int = 0;
           [ProtoMember(12)] public   onlyDiscountReddotFlag  {get;set;} int = 0;
           [ProtoMember(13)] public   onlyNearbyReddotFlag  {get;set;} int = 0;
           [ProtoMember(14)] public   onlyMineReddotFlag  {get;set;} int = 0;
           [ProtoMember(15)] public   taskType  {get;set;} int = 0;
           [ProtoMember(16)] public   taskInfo  {get;set;} string = "";
           [ProtoMember(17)] public   typeName  {get;set;} string = "";
           [ProtoMember(18)] public   typeColor  {get;set;} string = "";
           [ProtoMember(19)] public   jumpUrl  {get;set;} string = "";
        }
    }
}


internal class Submsgtype0x96 {
    internal class Submsgtype0x96  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   pushMsg  {get;set;} string = "";
           [ProtoMember(2)] public   pushType  {get;set;} int = 0;
        }
    }
}


internal class Submsgtype0x97 {
    internal class Submsgtype0x97  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   businessUin  {get;set;} string = "";
           [ProtoMember(2)] public   jsonContext  {get;set;} string = "";
        }
    }
}


internal class Submsgtype0x98 {
    internal class Submsgtype0x98  {
        [ProtoContract]
        internal class ModBlock(
           [ProtoMember(1)] public   op  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   subCmd  {get;set;} int = 0;
           [ProtoMember(3)] public   msgModBlock  {get;set;} ModBlock? = null;
        }
    }
}


internal class Submsgtype0x9b {
    internal class SubMsgType0x9b  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   appId  {get;set;} long = 0L;
           [ProtoMember(2)] public   mainType  {get;set;} int = 0;
           [ProtoMember(3)] public   subType  {get;set;} int = 0;
           [ProtoMember(4)] public   extMsg  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   workflowId  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class PbOfficeNotify(
           [ProtoMember(1)] public   optUint32MyofficeFlag  {get;set;} int = 0;
           [ProtoMember(2)] public   uint64Appid  {get;set;} List<Long> = new();
        }
    }
}


internal class Submsgtype0x9d {
    internal class SubMsgType0x9d  {
        [ProtoContract]
        internal class ModuleUpdateNotify(
           [ProtoMember(1)] public   moduleId  {get;set;} int = 0;
           [ProtoMember(2)] public   moduleVersion  {get;set;} int = 0;
           [ProtoMember(3)] public   moduleState  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   subCmd  {get;set;} int = 0;
           [ProtoMember(2)] public   lolaModuleUpdate  {get;set;} List<ModuleUpdateNotify> = new();
        }
    }
}


internal class Submsgtype0x9e {
    internal class SubmsgType0x9e  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   type  {get;set;} int = 0;
           [ProtoMember(2)] public   wording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   url  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   authKey  {get;set;} int = 0;
        }
    }
}


internal class Submsgtype0x9f {
    [ProtoContract] class MsgBody(
       [ProtoMember(1)] public   showLastest  {get;set;} int = 0;
       [ProtoMember(2)] public   senderUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   receiverUin  {get;set;} long = 0L;
       [ProtoMember(4)] public   senderRichContent  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   receiverRichContent  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   authkey  {get;set;} byte[] = Array.Empty<byte>();
        @ProtoType(ProtoIntegerType.SIGNED)[ProtoMember(7)] public   sint32Sessiontype  {get;set;} int = 0;
       [ProtoMember(8)] public   groupUin  {get;set;} long = 0L;
    }
}


internal class Submsgtype0xa0 {
    internal class Submsgtype0xa0  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   isMassBlessOpen  {get;set;} int = 0;
        }
    }
}


internal class Submsgtype0xa1 {
    internal class Submsgtype0xa1  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   subCmd  {get;set;} int = 0;
           [ProtoMember(2)] public   qid  {get;set;} long = 0L;
            @ProtoType(ProtoIntegerType.FIXED)[ProtoMember(3)] public   fixed32UpdateTime  {get;set;} int = 0;
           [ProtoMember(4)] public   teamCreatedDestroied  {get;set;} int = 0;
           [ProtoMember(5)] public   uint64OfficeFaceChangedUins  {get;set;} List<Long> = new();
        }
    }
}


internal class Submsgtype0xa2 {
    [ProtoContract] class MsgBody(
       [ProtoMember(1)] public   showLastest  {get;set;} int = 0;
       [ProtoMember(2)] public   senderUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   receiverUin  {get;set;} long = 0L;
       [ProtoMember(4)] public   senderRichContent  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   receiverRichContent  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   authkey  {get;set;} byte[] = Array.Empty<byte>();
    }
}


internal class Submsgtype0xa4 {
    internal class Submsgtype0xa4  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   title  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   brief  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   url  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0xa8 {
    internal class SubMsgType0xa8  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   actionType  {get;set;} int = 0;
           [ProtoMember(2)] public   actionSubType  {get;set;} int = 0;
           [ProtoMember(3)] public   msgSummary  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   extendContent  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0xaa {
    internal class SubMsgType0xaa  {
        [ProtoContract]
        internal class GameTeamMsgBody(
           [ProtoMember(1)] public   gameTeamCmd  {get;set;} int = 0;
           [ProtoMember(2)] public   msgTurnOverMessage  {get;set;} GameTeamTurnOverMessage? = null;
           [ProtoMember(3)] public   msgStartGameMessage  {get;set;} GameTeamStartGameMessage? = null;
           [ProtoMember(4)] public   msgUpdateTeamMessage  {get;set;} GameTeamUpdateTeamMessage? = null;
        }

        [ProtoContract]
        internal class GameTeamStartGameMessage(
           [ProtoMember(1)] public   gamedata  {get;set;} string = "";
           [ProtoMember(2)] public   platformType  {get;set;} int = 0;
           [ProtoMember(3)] public   title  {get;set;} string = "";
           [ProtoMember(4)] public   summary  {get;set;} string = "";
           [ProtoMember(5)] public   picUrl  {get;set;} string = "";
           [ProtoMember(6)] public   appid  {get;set;} string = "";
           [ProtoMember(7)] public   appStoreId  {get;set;} string = "";
           [ProtoMember(8)] public   packageName  {get;set;} string = "";
           [ProtoMember(9)] public   createMsgTime  {get;set;} long = 0L;
           [ProtoMember(10)] public   expire  {get;set;} int = 0;
           [ProtoMember(11)] public   buildTeamTime  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class GameTeamTurnOverMessage(
           [ProtoMember(1)] public   teamId  {get;set;} string = "";
           [ProtoMember(2)] public   sessionType  {get;set;} int = 0;
           [ProtoMember(3)] public   sourceUin  {get;set;} string = "";
           [ProtoMember(4)] public   actionUin  {get;set;} string = "";
           [ProtoMember(5)] public   actionType  {get;set;} int = 0;
           [ProtoMember(6)] public   currentCount  {get;set;} int = 0;
           [ProtoMember(7)] public   totalCount  {get;set;} int = 0;
           [ProtoMember(8)] public   createMsgTime  {get;set;} long = 0L;
           [ProtoMember(9)] public   status  {get;set;} int = 0;
           [ProtoMember(10)] public   expire  {get;set;} int = 0;
           [ProtoMember(11)] public   buildTeamTime  {get;set;} long = 0L;
           [ProtoMember(12)] public   leaderUin  {get;set;} string = "";
           [ProtoMember(13)] public   uin32LeaderStatus  {get;set;} int = 0;
           [ProtoMember(14)] public   inviteSourceList  {get;set;} List<InviteSource> = new();
        }

        [ProtoContract]
        internal class GameTeamUpdateTeamMessage(
           [ProtoMember(1)] public   teamId  {get;set;} string = "";
           [ProtoMember(2)] public   gameId  {get;set;} string = "";
           [ProtoMember(3)] public   status  {get;set;} int = 0;
           [ProtoMember(4)] public   modeImg  {get;set;} string = "";
           [ProtoMember(5)] public   currentCount  {get;set;} int = 0;
           [ProtoMember(6)] public   createMsgTime  {get;set;} long = 0L;
           [ProtoMember(7)] public   expire  {get;set;} int = 0;
           [ProtoMember(8)] public   buildTeamTime  {get;set;} long = 0L;
           [ProtoMember(9)] public   leaderUin  {get;set;} string = "";
           [ProtoMember(10)] public   uin32LeaderStatus  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class InviteSource(
           [ProtoMember(1)] public   type  {get;set;} int = 0;
           [ProtoMember(2)] public   src  {get;set;} string = "";
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   cmd  {get;set;} int = 0;
           [ProtoMember(2)] public   msgGameTeamMsg  {get;set;} GameTeamMsgBody? = null;
           [ProtoMember(3)] public   msgOnlineDocMsg  {get;set;} OnlineDocMsgBody? = null;
        }

        [ProtoContract]
        internal class OnlineDocMsgBody(
           [ProtoMember(1)] public   onlineDocCmd  {get;set;} int = 0;
           [ProtoMember(2)] public   msgPushChangeTitleMessage  {get;set;} OnlineDocPushChangeTitleMessage? = null;
           [ProtoMember(3)] public   msgPushNewPadMessage  {get;set;} OnlineDocPushNewPadMessage? = null;
           [ProtoMember(4)] public   msgPushPreviewToEdit  {get;set;} OnlineDocPushPreviewToEditMessage? = null;
        }

        [ProtoContract]
        internal class OnlineDocPushChangeTitleMessage(
           [ProtoMember(1)] public   domainid  {get;set;} int = 0;
           [ProtoMember(2)] public   localpadid  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   title  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   lastEditorUin  {get;set;} long = 0L;
           [ProtoMember(5)] public   lastEditorNick  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(6)] public   lastEditTime  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class OnlineDocPushNewPadMessage(
           [ProtoMember(1)] public   padUrl  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   type  {get;set;} int = 0;
           [ProtoMember(3)] public   title  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   createTime  {get;set;} long = 0L;
           [ProtoMember(5)] public   creatorUin  {get;set;} long = 0L;
           [ProtoMember(6)] public   creatorNick  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(7)] public   lastEditorUin  {get;set;} long = 0L;
           [ProtoMember(8)] public   lastEditorNick  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(9)] public   lastEditTime  {get;set;} long = 0L;
           [ProtoMember(10)] public   boolPinnedFlag  {get;set;} bool = false;
           [ProtoMember(11)] public   lastViewerUin  {get;set;} long = 0L;
           [ProtoMember(12)] public   lastViewerNick  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(13)] public   lastViewTime  {get;set;} long = 0L;
           [ProtoMember(14)] public   lastPinnedTime  {get;set;} long = 0L;
           [ProtoMember(15)] public   currentUserBrowseTime  {get;set;} long = 0L;
           [ProtoMember(16)] public   hostuserUin  {get;set;} long = 0L;
           [ProtoMember(17)] public   hostuserNick  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(18)] public   lastAuthTime  {get;set;} long = 0L;
           [ProtoMember(19)] public   policy  {get;set;} int = 0;
           [ProtoMember(20)] public   rightFlag  {get;set;} int = 0;
           [ProtoMember(21)] public   domainid  {get;set;} int = 0;
           [ProtoMember(22)] public   localpadid  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(23)] public   lastUnpinnedTime  {get;set;} long = 0L;
           [ProtoMember(24)] public   boolDeleteFlag  {get;set;} bool = false;
           [ProtoMember(25)] public   lastDeleteTime  {get;set;} long = 0L;
           [ProtoMember(26)] public   thumbUrl  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(27)] public   pdid  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class OnlineDocPushPreviewToEditMessage(
           [ProtoMember(1)] public   version  {get;set;} int = 0;
           [ProtoMember(2)] public   title  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   padUrl  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   aioSession  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0xab {
    internal class SubMsgType0xab  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   gc  {get;set;} long = 0L;
           [ProtoMember(3)] public   rewardId  {get;set;} string = "";
           [ProtoMember(4)] public   rewardStatus  {get;set;} int = 0;
        }
    }
}


internal class Submsgtype0xae {
    internal class SubMsgType0xae  {
        [ProtoContract]
        internal class AddFriendSource(
           [ProtoMember(1)] public   source  {get;set;} int = 0;
           [ProtoMember(2)] public   subSource  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   type  {get;set;} int = 0;
           [ProtoMember(2)] public   msgPeopleMayKonw  {get;set;} PushPeopleMayKnow? = null;
           [ProtoMember(3)] public   msgPersonsMayKnow  {get;set;} PushPeopleMayKnowV2? = null;
        }

        [ProtoContract]
        internal class PersonMayKnow(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   name  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   age  {get;set;} int = 0;
           [ProtoMember(4)] public   sex  {get;set;} int = 0;
           [ProtoMember(5)] public   mainReason  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(6)] public   soureReason  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(7)] public   alghrithm  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(8)] public   source  {get;set;} int = 0;
           [ProtoMember(9)] public   msgIosSource  {get;set;} AddFriendSource? = null;
           [ProtoMember(10)] public   msgAndroidSource  {get;set;} AddFriendSource? = null;
           [ProtoMember(11)] public   msg  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(12)] public   gameSource  {get;set;} int = 0;
           [ProtoMember(13)] public   roleName  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class PushPeopleMayKnow(
            @ProtoType(ProtoIntegerType.FIXED)[ProtoMember(1)] public   fixed32Timestamp  {get;set;} int = 0;
           [ProtoMember(2)] public   wordingMsg  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class PushPeopleMayKnowV2(
            @ProtoType(ProtoIntegerType.FIXED)[ProtoMember(1)] public   fixed32Timestamp  {get;set;} int = 0;
           [ProtoMember(2)] public   msgFriendList  {get;set;} List<PersonMayKnow> = new();
           [ProtoMember(3)] public   roleName  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0xb1 {
    internal class Submsgtype0xb1  {
        [ProtoContract]
        internal class DealInviteInfo(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   groupCode  {get;set;} long = 0L;
           [ProtoMember(3)] public   id  {get;set;} string = "";
           [ProtoMember(4)] public   dealResult  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class InviteInfo(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   groupCode  {get;set;} long = 0L;
           [ProtoMember(3)] public   expireTime  {get;set;} int = 0;
           [ProtoMember(4)] public   id  {get;set;} string = "";
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   notifyType  {get;set;} int = 0;
           [ProtoMember(2)] public   inviteInfo  {get;set;} InviteInfo? = null;
           [ProtoMember(3)] public   univiteInfo  {get;set;} UninviteInfo? = null;
           [ProtoMember(4)] public   dealInfo  {get;set;} DealInviteInfo? = null;
        }

        [ProtoContract]
        internal class UninviteInfo(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   groupCode  {get;set;} long = 0L;
           [ProtoMember(3)] public   id  {get;set;} string = "";
        }
    }
}


internal class Submsgtype0xb3 {
    class SubMsgType0xb3 {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   type  {get;set;} int = 0;
           [ProtoMember(2)] public   msgAddFrdNotify  {get;set;} PushAddFrdNotify;
        }

        [ProtoContract]
        internal class PushAddFrdNotify(
           [ProtoMember(1)] public   fuin  {get;set;} long = 0L;
           [ProtoMember(2)] public   fuinBubbleId  {get;set;} long = 0L;
            @ProtoType(ProtoIntegerType.FIXED)[ProtoMember(3)] public   fixed32Timestamp  {get;set;} int = 0;
           [ProtoMember(4)] public   wording  {get;set;} string = ""; // 我们已经是好友啦，一起来聊天吧!
           [ProtoMember(5)] public   fuinNick  {get;set;} string = "";
           [ProtoMember(6)] public   sourceId  {get;set;} int = 0;
           [ProtoMember(7)] public   subsourceId  {get;set;} int = 0;
           [ProtoMember(8)] public   mobile  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(9)] public   reqUin  {get;set;} long = 0L;
        }
    }
}


internal class Submsgtype0xb5 {
    internal class SubMsgType0xb5  {
        [ProtoContract]
        internal class MsgBody(
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
           [ProtoMember(10000)] public   groupCode  {get;set;} long = 0L;
        }
    }
}


internal class Submsgtype0xbe {
    internal class SubMsgType0xbe  {
        [ProtoContract]
        internal class Medal(
           [ProtoMember(1)] public   id  {get;set;} int = 0;
           [ProtoMember(2)] public   level  {get;set;} int = 0;
           [ProtoMember(3)] public   type  {get;set;} int = 0;
           [ProtoMember(4)] public   iconUrl  {get;set;} string = "";
           [ProtoMember(5)] public   flashUrl  {get;set;} string = "";
           [ProtoMember(6)] public   name  {get;set;} string = "";
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   groupCode  {get;set;} long = 0L;
           [ProtoMember(3)] public   notifyType  {get;set;} int = 0;
           [ProtoMember(4)] public   onlineLevel  {get;set;} int = 0;
           [ProtoMember(5)] public   msgMedalList  {get;set;} List<Medal> = new();
        }
    }
}


/*
internal class Submsgtype0xc1 {
    internal class Submsgtype0xc1  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   groupid  {get;set;} long = 0L;
           [ProtoMember(2)] public   memberNum  {get;set;} int = 0;
           [ProtoMember(3)] public   data  {get;set;} string = ""
        }
    }
}
*/

internal class Submsgtype0xc3 {
    internal class Submsgtype0xc3  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   type  {get;set;} int = 0;
           [ProtoMember(2)] public   pushData  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   timestamp  {get;set;} long = 0L;
        }
    }
}


internal class Submsgtype0xc5 {
    internal class Submsgtype0xc5  {
        [ProtoContract]
        internal class BBInfo(
           [ProtoMember(1)] public   bbUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   src  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class BiuBody(
           [ProtoMember(1)] public   biuUin  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class CommentInfo(
           [ProtoMember(2)] public   commentUin  {get;set;} long = 0L;
           [ProtoMember(3)] public   commentId  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   replyUin  {get;set;} long = 0L;
           [ProtoMember(5)] public   replyId  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(6)] public   commentContent  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class LikeInfo(
           [ProtoMember(2)] public   likeUin  {get;set;} long = 0L;
           [ProtoMember(3)] public   op  {get;set;} int = 0;
           [ProtoMember(4)] public   replyId  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   bid  {get;set;} int = 0;
           [ProtoMember(2)] public   source  {get;set;} int = 0;
           [ProtoMember(3)] public   operatorType  {get;set;} int /* enum */ = 1;
           [ProtoMember(4)] public   articleId  {get;set;} long = 0L;
           [ProtoMember(5)] public   pushTime  {get;set;} int = 0;
           [ProtoMember(6)] public   seq  {get;set;} long = 0L;
           [ProtoMember(10)] public   msgNotifyInfos  {get;set;} NotifyBody? = null;
           [ProtoMember(11)] public   diandianCookie  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class NotifyBody(
           [ProtoMember(1)] public   msgStyleSheet  {get;set;} StyleSheet? = null;
           [ProtoMember(10)] public   msgCommentArticle  {get;set;} CommentInfo? = null;
           [ProtoMember(11)] public   msgLikeArticle  {get;set;} LikeInfo? = null;
           [ProtoMember(12)] public   msgBbInfo  {get;set;} BBInfo? = null;
           [ProtoMember(13)] public   redPointInfo  {get;set;} List<RedPointInfo> = new();
        }

        [ProtoContract]
        internal class RedPointInfo(
           [ProtoMember(1)] public   itemId  {get;set;} int = 0;
           [ProtoMember(2)] public   redPointItemType  {get;set;} int /* enum */ = 0;
           [ProtoMember(3)] public   url  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   effectTime  {get;set;} long = 0L;
           [ProtoMember(5)] public   failureTime  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class StyleSheet(
           [ProtoMember(1)] public   showFolder  {get;set;} int = 0;
           [ProtoMember(2)] public   folderRedType  {get;set;} int /* enum */ = 0;
           [ProtoMember(3)] public   orangeWord  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   summary  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   msgTipBody  {get;set;} TipsBody? = null;
           [ProtoMember(6)] public   showLockScreen  {get;set;} int = 0;
           [ProtoMember(7)] public   msgType  {get;set;} int /* enum */ = 0;
           [ProtoMember(8)] public   msgBiuBody  {get;set;} BiuBody? = null;
           [ProtoMember(9)] public   isLow  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class TipsBody(
           [ProtoMember(1)] public   tipsUiType  {get;set;} int /* enum */ = 0;
           [ProtoMember(2)] public   uin  {get;set;} long = 0L;
           [ProtoMember(3)] public   iconUrl  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   content  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   schema  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(6)] public   businessInfo  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0xc6 {
    internal class SubMsgType0xc6  {
        [ProtoContract]
        internal class AccountExceptionAlertBody(
           [ProtoMember(1)] public   title  {get;set;} string = "";
           [ProtoMember(2)] public   content  {get;set;} string = "";
           [ProtoMember(3)] public   leftButtonText  {get;set;} string = "";
           [ProtoMember(4)] public   rightButtonText  {get;set;} string = "";
           [ProtoMember(5)] public   rightButtonLink  {get;set;} string = "";
           [ProtoMember(6)] public   leftButtonId  {get;set;} int = 0;
           [ProtoMember(7)] public   rightButtonId  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   secCmd  {get;set;} int = 0;
           [ProtoMember(2)] public   msgS2cAccountExceptionNotify  {get;set;} AccountExceptionAlertBody? = null;
        }
    }
}


internal class Submsgtype0xc7 {
    internal class Submsgtype0xc7  {
        [ProtoContract]
        internal class ForwardBody(
           [ProtoMember(1)] public   notifyType  {get;set;} int = 0;
           [ProtoMember(2)] public   opType  {get;set;} int = 0;
           [ProtoMember(3000)] public   msgHotFriendNotify  {get;set;} HotFriendNotify? = null;
           [ProtoMember(4000)] public   msgRelationalChainChange  {get;set;} RelationalChainChange? = null;
        }

        [ProtoContract]
        internal class FriendShipFlagNotify(
           [ProtoMember(1)] public   dstUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   level1  {get;set;} int = 0;
           [ProtoMember(3)] public   level2  {get;set;} int = 0;
           [ProtoMember(4)] public   continuityDays  {get;set;} int = 0;
           [ProtoMember(5)] public   chatFlag  {get;set;} int = 0;
           [ProtoMember(6)] public   lastChatTime  {get;set;} long = 0L;
           [ProtoMember(7)] public   notifyTime  {get;set;} long = 0L;
           [ProtoMember(8)] public   seq  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class HotFriendNotify(
           [ProtoMember(1)] public   dstUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   praiseHotLevel  {get;set;} int = 0;
           [ProtoMember(3)] public   chatHotLevel  {get;set;} int = 0;
           [ProtoMember(4)] public   praiseHotDays  {get;set;} int = 0;
           [ProtoMember(5)] public   chatHotDays  {get;set;} int = 0;
           [ProtoMember(6)] public   closeLevel  {get;set;} int = 0;
           [ProtoMember(7)] public   closeDays  {get;set;} int = 0;
           [ProtoMember(8)] public   praiseFlag  {get;set;} int = 0;
           [ProtoMember(9)] public   chatFlag  {get;set;} int = 0;
           [ProtoMember(10)] public   closeFlag  {get;set;} int = 0;
           [ProtoMember(11)] public   notifyTime  {get;set;} long = 0L;
           [ProtoMember(12)] public   lastPraiseTime  {get;set;} long = 0L;
           [ProtoMember(13)] public   lastChatTime  {get;set;} long = 0L;
           [ProtoMember(14)] public   qzoneHotLevel  {get;set;} int = 0;
           [ProtoMember(15)] public   qzoneHotDays  {get;set;} int = 0;
           [ProtoMember(16)] public   qzoneFlag  {get;set;} int = 0;
           [ProtoMember(17)] public   lastQzoneTime  {get;set;} long = 0L;
           [ProtoMember(51)] public   showRecheckEntry  {get;set;} int = 0;
           [ProtoMember(52)] public   wildcardWording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(100)] public   loverFlag  {get;set;} int = 0;
           [ProtoMember(200)] public   keyHotLevel  {get;set;} int = 0;
           [ProtoMember(201)] public   keyHotDays  {get;set;} int = 0;
           [ProtoMember(202)] public   keyFlag  {get;set;} int = 0;
           [ProtoMember(203)] public   lastKeyTime  {get;set;} long = 0L;
           [ProtoMember(204)] public   keyWording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(205)] public   keyTransFlag  {get;set;} int = 0;
           [ProtoMember(206)] public   loverKeyBusinessType  {get;set;} int = 0;
           [ProtoMember(207)] public   loverKeySubBusinessType  {get;set;} int = 0;
           [ProtoMember(208)] public   loverKeyMainWording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(209)] public   loverKeyLinkWording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(300)] public   boatLevel  {get;set;} int = 0;
           [ProtoMember(301)] public   boatDays  {get;set;} int = 0;
           [ProtoMember(302)] public   boatFlag  {get;set;} int = 0;
           [ProtoMember(303)] public   lastBoatTime  {get;set;} int = 0;
           [ProtoMember(304)] public   boatWording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(400)] public   notifyType  {get;set;} int = 0;
           [ProtoMember(401)] public   msgFriendshipFlagNotify  {get;set;} FriendShipFlagNotify? = null;
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgModInfos  {get;set;} List<ForwardBody> = new();
        }

        [ProtoContract]
        internal class RelationalChainChange(
           [ProtoMember(1)] public   appid  {get;set;} long = 0L;
           [ProtoMember(2)] public   srcUin  {get;set;} long = 0L;
           [ProtoMember(3)] public   dstUin  {get;set;} long = 0L;
           [ProtoMember(4)] public   changeType  {get;set;} int /* enum */ = 1;
           [ProtoMember(5)] public   msgRelationalChainInfoOld  {get;set;} RelationalChainInfo? = null;
           [ProtoMember(6)] public   msgRelationalChainInfoNew  {get;set;} RelationalChainInfo? = null;
           [ProtoMember(7)] public   msgToDegradeInfo  {get;set;} ToDegradeInfo? = null;
           [ProtoMember(20)] public   relationalChainInfos  {get;set;} List<RelationalChainInfos> = new();
           [ProtoMember(100)] public   uint32FeatureId  {get;set;} List<int> = new();
        }

        [ProtoContract]
        internal class RelationalChainInfo(
           [ProtoMember(1)] public   type  {get;set;} int /* enum */ = 1;
           [ProtoMember(2)] public   attr  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(1002)] public   intimateInfo  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(91001)] public   musicSwitch  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(101001)] public   mutualmarkAlienation  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class RelationalChainInfos(
           [ProtoMember(1)] public   msgRelationalChainInfoOld  {get;set;} RelationalChainInfo? = null;
           [ProtoMember(2)] public   msgRelationalChainInfoNew  {get;set;} RelationalChainInfo? = null;
        }

        [ProtoContract]
        internal class ToDegradeInfo(
           [ProtoMember(1)] public   toDegradeItem  {get;set;} List<ToDegradeItem> = new();
           [ProtoMember(2)] public   nick  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   notifyTime  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class ToDegradeItem(
           [ProtoMember(1)] public   type  {get;set;} int /* enum */ = 1;
           [ProtoMember(2)] public   oldLevel  {get;set;} int = 0;
           [ProtoMember(3)] public   newLevel  {get;set;} int = 0;
           [ProtoMember(11)] public   continuityDays  {get;set;} int = 0;
           [ProtoMember(12)] public   lastActionTime  {get;set;} long = 0L;
        }
    }
}

internal class Mutualmark {
    class Mutualmark  {
        [ProtoContract]
        internal class MutualmarkInfo(
           [ProtoMember(1)] public   lastActionTime  {get;set;} long = 0L;
           [ProtoMember(2)] public   level  {get;set;} int = 0;
           [ProtoMember(3)] public   lastChangeTime  {get;set;} long = 0L;
           [ProtoMember(4)] public   continueDays  {get;set;} int = 0;
           [ProtoMember(5)] public   wildcardWording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(6)] public   notifyTime  {get;set;} long = 0L;
           [ProtoMember(7)] public   iconStatus  {get;set;} long = 0L;
           [ProtoMember(8)] public   iconStatusEndTime  {get;set;} long = 0L;
           [ProtoMember(9)] public   closeFlag  {get;set;} int = 0;
           [ProtoMember(10)] public   resourceInfo  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class ResourceInfo17(
           [ProtoMember(1)] public   dynamicUrl  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   staticUrl  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   cartoonUrl  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   cartoonMd5  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   playCartoon  {get;set;} int = 0;
           [ProtoMember(6)] public   word  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0xc9 {
    class Submsgtype0xc9  {
        [ProtoContract]
        internal class BusinessMsg(
           [ProtoMember(1)] public   msgType  {get;set;} int /* enum */ = 0;
           [ProtoMember(2)] public   msgData  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   boolTabVisible  {get;set;} bool = false;
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   type  {get;set;} int = 0;
           [ProtoMember(2)] public   fromUin  {get;set;} long = 0L;
           [ProtoMember(3)] public   actionUin  {get;set;} long = 0L;
           [ProtoMember(4)] public   source  {get;set;} int /* enum */ = 0;
           [ProtoMember(5)] public   msgBusinessMsg  {get;set;} List<BusinessMsg> = new();
           [ProtoMember(6)] public   boolNewFriend  {get;set;} bool = false;
        }
    }
}


internal class Submsgtype0xca {
    class Submsgtype0xca  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   msgList  {get;set;} List<MsgContent> = new();
        }

        [ProtoContract]
        internal class MsgContent(
           [ProtoMember(1)] public   tag  {get;set;} long = 0L;
           [ProtoMember(2)] public   msgType  {get;set;} long = 0L;
           [ProtoMember(3)] public   seq  {get;set;} long = 0L;
           [ProtoMember(4)] public   content  {get;set;} string = "";
           [ProtoMember(5)] public   actionId  {get;set;} long = 0L;
           [ProtoMember(6)] public   ts  {get;set;} long = 0L;
           [ProtoMember(7)] public   expts  {get;set;} long = 0L;
           [ProtoMember(8)] public   errorMsg  {get;set;} string = "";
           [ProtoMember(9)] public   showSpace  {get;set;} long = 0L;
           [ProtoMember(10)] public   regionUrl  {get;set;} string = "";
        }
    }
}


internal class Submsgtype0xcb {
    internal class SubMsgType0xcb  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   anchorStatus  {get;set;} int = 0;
           [ProtoMember(2)] public   jumpSchema  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   anchorNickname  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   anchorHeadUrl  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   liveWording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(6)] public   liveEndWording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(7)] public   c2cMsgWording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(8)] public   liveWordingType  {get;set;} int = 0;
           [ProtoMember(9)] public   endWordingType  {get;set;} int = 0;
        }
    }
}


internal class Submsgtype0xcc {
    internal class SubMsgType0xcc  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgType  {get;set;} int = 0;
           [ProtoMember(2)] public   msgInfo  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   uin  {get;set;} long = 0L;
           [ProtoMember(4)] public   unionId  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   subType  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(6)] public   feedId  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(7)] public   vid  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(8)] public   coverUrl  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0xce {
    internal class Submsgtype0xce  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   int64StartTime  {get;set;} long = 0L;
           [ProtoMember(2)] public   int64EndTime  {get;set;} long = 0L;
           [ProtoMember(3)] public   params  {get;set;} string = "";
        }
    }
}


internal class Submsgtype0xcf {
    internal class Submsgtype0xcf  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   rsptype  {get;set;} int = 0;
           [ProtoMember(2)] public   rspbody  {get;set;} string = "";
        }
    }
}


internal class Submsgtype0xd0 {
    internal class SubMsgType0xd0  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgType  {get;set;} int = 0;
           [ProtoMember(2)] public   msgInfo  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   hotTopicId  {get;set;} long = 0L;
           [ProtoMember(4)] public   hotTopicName  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   bigVId  {get;set;} long = 0L;
           [ProtoMember(6)] public   bigVUnionId  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(7)] public   pgcType  {get;set;} int = 0;
           [ProtoMember(8)] public   pgcColumnUnionId  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(9)] public   link  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(10)] public   subType  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(11)] public   coverUrl  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0xd7 {
    internal class SubMsgType0xd7  {
        [ProtoContract]
        internal class Content(
           [ProtoMember(1)] public   fromUser  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   plainText  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   buluoWord  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   richFreshWord  {get;set;} AppointDefine.RichText? = null;
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   type  {get;set;} int = 0;
           [ProtoMember(2)] public   msgboxUnreadCount  {get;set;} int = 0;
           [ProtoMember(3)] public   unreadCount  {get;set;} int = 0;
           [ProtoMember(4)] public   msgContent  {get;set;} Content? = null;
           [ProtoMember(5)] public   timestamp  {get;set;} long = 0L;
        }
    }
}


internal class Submsgtype0xda {
    internal class SubMsgType0xda  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgType  {get;set;} int = 0;
           [ProtoMember(2)] public   msgInfo  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   subType  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   versionCtrl  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   feedId  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(6)] public   unionId  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(7)] public   commentId  {get;set;} int = 0;
           [ProtoMember(8)] public   iconUnionId  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(9)] public   coverUrl  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(10)] public   operType  {get;set;} int = 0;
           [ProtoMember(11)] public   groupUnionid  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(12)] public   vid  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(13)] public   doodleUrl  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(14)] public   fromNick  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(15)] public   vidUrl  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(16)] public   extInfo  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0xdb {
    internal class Submsgtype0xdb  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   rsptype  {get;set;} int = 0;
           [ProtoMember(2)] public   rspbody  {get;set;} string = "";
        }
    }
}


internal class Submsgtype0xdc {
    internal class Submsgtype0xdc  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgList  {get;set;} List<MsgContent> = new();
           [ProtoMember(2)] public   msgType  {get;set;} int = 0;
           [ProtoMember(3)] public   msgList0x02  {get;set;} List<MsgContent> = new();
           [ProtoMember(4)] public   minQqVer  {get;set;} string = "";
        }

        [ProtoContract]
        internal class MsgContent(
           [ProtoMember(1)] public   masterPri  {get;set;} long = 0L;
           [ProtoMember(2)] public   subPri  {get;set;} long = 0L;
           [ProtoMember(3)] public   showTimes  {get;set;} long = 0L;
           [ProtoMember(4)] public   showBegTs  {get;set;} long = 0L;
           [ProtoMember(5)] public   expTs  {get;set;} long = 0L;
           [ProtoMember(6)] public   msgSentTs  {get;set;} long = 0L;
           [ProtoMember(7)] public   actionId  {get;set;} long = 0L;
           [ProtoMember(8)] public   wording  {get;set;} string = "";
           [ProtoMember(9)] public   scheme  {get;set;} string = "";
           [ProtoMember(10)] public   regionUrl  {get;set;} string = "";
           [ProtoMember(11)] public   wordingColor  {get;set;} long = 0L;
           [ProtoMember(12)] public   msgId  {get;set;} long = 0L;
           [ProtoMember(13)] public   bubbleId  {get;set;} long = 0L;
           [ProtoMember(14)] public   tips  {get;set;} string = "";
           [ProtoMember(15)] public   gameId  {get;set;} long = 0L;
        }
    }
}


internal class Submsgtype0xdd {
    internal class Submsgtype0xdd  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgType  {get;set;} int = 0;
           [ProtoMember(2)] public   uint64InviteUin  {get;set;} List<Long> = new();
           [ProtoMember(3)] public   inviteLeader  {get;set;} long = 0L;
           [ProtoMember(4)] public   msgPoiInfo  {get;set;} WifiPOIInfo? = null;
           [ProtoMember(5)] public   msgPlayerState  {get;set;} List<PlayerState> = new();
        } {
            [ProtoContract]
            internal class PlayerState(
               [ProtoMember(1)] public   uin  {get;set;} long = 0L;
               [ProtoMember(2)] public   state  {get;set;} int = 0;
            }

            [ProtoContract]
            internal class SeatsInfo(
               [ProtoMember(1)] public   seatFlag  {get;set;} int = 0;
               [ProtoMember(2)] public   guestUin  {get;set;} long = 0L;
               [ProtoMember(3)] public   seatId  {get;set;} int = 0;
               [ProtoMember(4)] public   seatSeq  {get;set;} int = 0;
            }

            [ProtoContract]
            internal class WifiPOIInfo(
               [ProtoMember(1)] public   uid  {get;set;} byte[] = Array.Empty<byte>();
               [ProtoMember(2)] public   name  {get;set;} byte[] = Array.Empty<byte>();
               [ProtoMember(3)] public   faceId  {get;set;} int = 0;
               [ProtoMember(4)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
               [ProtoMember(5)] public   groupCode  {get;set;} int = 0;
               [ProtoMember(6)] public   groupUin  {get;set;} int = 0;
               [ProtoMember(7)] public   visitorNum  {get;set;} int = 0;
               [ProtoMember(8)] public   wifiPoiType  {get;set;} int = 0;
               [ProtoMember(9)] public   isMember  {get;set;} int = 0;
               [ProtoMember(10)] public   distance  {get;set;} int = 0;
               [ProtoMember(11)] public   msgTabSwitchOff  {get;set;} int = 0;
               [ProtoMember(12)] public   faceUrl  {get;set;} string = "";
               [ProtoMember(13)] public   hotThemeGroupFlag  {get;set;} int = 0;
               [ProtoMember(14)] public   bannerUrl  {get;set;} string = "";
               [ProtoMember(15)] public   specialFlag  {get;set;} int = 0;
               [ProtoMember(16)] public   totalNumLimit  {get;set;} int = 0;
               [ProtoMember(17)] public   isAdmin  {get;set;} int = 0;
               [ProtoMember(18)] public   joinGroupUrl  {get;set;} string = "";
               [ProtoMember(19)] public   groupTypeFlag  {get;set;} int = 0;
               [ProtoMember(20)] public   createrCityId  {get;set;} int = 0;
               [ProtoMember(21)] public   isUserCreate  {get;set;} int = 0;
               [ProtoMember(22)] public   ownerUin  {get;set;} long = 0L;
               [ProtoMember(23)] public   auditFlag  {get;set;} int = 0;
               [ProtoMember(24)] public   tvPkFlag  {get;set;} int = 0;
               [ProtoMember(25)] public   subType  {get;set;} int = 0;
               [ProtoMember(26)] public   lastMsgSeq  {get;set;} long = 0L;
               [ProtoMember(27)] public   msgSeatsInfo  {get;set;} List<SeatsInfo> = new();
               [ProtoMember(28)] public   flowerNum  {get;set;} long = 0L;
               [ProtoMember(29)] public   flowerPoint  {get;set;} long = 0L;
               [ProtoMember(31)] public   favoritesTime  {get;set;} long = 0L;
               [ProtoMember(32)] public   favoritesExpired  {get;set;} int = 0;
               [ProtoMember(33)] public   groupId  {get;set;} int = 0;
               [ProtoMember(34)] public   praiseNums  {get;set;} long = 0L;
               [ProtoMember(35)] public   reportPraiseGapTime  {get;set;} long = 0L;
               [ProtoMember(36)] public   reportPraiseGapFrequency  {get;set;} long = 0L;
               [ProtoMember(37)] public   getPraiseGapTime  {get;set;} long = 0L;
               [ProtoMember(38)] public   vistorJoinGroupTime  {get;set;} long = 0L;
               [ProtoMember(39)] public   groupIsNotExist  {get;set;} int = 0;
               [ProtoMember(40)] public   guestNum  {get;set;} int = 0;
               [ProtoMember(41)] public   highQualityFlag  {get;set;} int = 0;
               [ProtoMember(42)] public   exitGroupCode  {get;set;} long = 0L;
               [ProtoMember(43)] public   int32Latitude  {get;set;} int = 0;
               [ProtoMember(44)] public   int32Longitude  {get;set;} int = 0;
               [ProtoMember(45)] public   smemo  {get;set;} string = "";
               [ProtoMember(46)] public   isAllCountry  {get;set;} int = 0;
            }
        }
    }
}


internal class Submsgtype0xde {
    internal class Submsgtype0xde  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgType  {get;set;} int = 0;
           [ProtoMember(2)] public   unionId  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   uid  {get;set;} long = 0L;
           [ProtoMember(4)] public   vid  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   videoCover  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0xdf {
    internal class Submsgtype0xdf  {
        [ProtoContract]
        internal class MsgBody(
            //[ProtoMember(1)] public   msgGameState  {get;set;} ApolloGameStatus.STCMGameMessage? = null;
           [ProtoMember(2)] public   uint32UinList  {get;set;} List<int> = new();
        }
    }
}


internal class Submsgtype0xe0 {
    internal class Submsgtype0xe0  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   pushExt  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0xe1 {
    internal class Submsgtype0xe1  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   pushExt  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0xe4 {
    internal class Submsgtype0xe4  {
        [ProtoContract]
        internal class GeoInfo(
           [ProtoMember(1)] public   latitude  {get;set;} long = 0L;
           [ProtoMember(2)] public   longitude  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class GiftMsg(
           [ProtoMember(1)] public   fromUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   toUin  {get;set;} long = 0L;
           [ProtoMember(3)] public   productId  {get;set;} int = 0;
           [ProtoMember(4)] public   giftId  {get;set;} int = 0;
           [ProtoMember(5)] public   giftNum  {get;set;} long = 0L;
           [ProtoMember(6)] public   roomid  {get;set;} string = "";
           [ProtoMember(7)] public   giftWording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(8)] public   packageurl  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(50)] public   curAddDuration  {get;set;} int = 0;
           [ProtoMember(51)] public   allAddDuration  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class LikeMsg(
           [ProtoMember(1)] public   fromUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   toUin  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgMatchPlayer  {get;set;} Player? = null;
           [ProtoMember(2)] public   distance  {get;set;} int = 0;
           [ProtoMember(3)] public   hint  {get;set;} string = "";
           [ProtoMember(4)] public   countdown  {get;set;} int = 0;
           [ProtoMember(5)] public   key  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(6)] public   type  {get;set;} int = 0;
           [ProtoMember(7)] public   callType  {get;set;} int = 0;
           [ProtoMember(8)] public   displayDistance  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(9)] public   msgLike  {get;set;} LikeMsg? = null;
           [ProtoMember(10)] public   msgGift  {get;set;} GiftMsg? = null;
           [ProtoMember(11)] public   msgRoom  {get;set;} Room? = null;
        }

        [ProtoContract]
        internal class Player(
           [ProtoMember(1)] public   uin  {get;set;} long = 0L;
           [ProtoMember(2)] public   nickname  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   logoUrl  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   gender  {get;set;} int = 0;
           [ProtoMember(5)] public   level  {get;set;} int = 0;
           [ProtoMember(6)] public   age  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class Room(
           [ProtoMember(1)] public   roomId  {get;set;} string = "";
        }
    }
}


internal class Submsgtype0xe5 {
    internal class Submsgtype0xe5  {
        [ProtoContract]
        internal class CrmS2CMsgHead(
           [ProtoMember(1)] public   crmSubCmd  {get;set;} int = 0;
           [ProtoMember(2)] public   headLen  {get;set;} int = 0;
           [ProtoMember(3)] public   verNo  {get;set;} int = 0;
           [ProtoMember(4)] public   kfUin  {get;set;} long = 0L;
           [ProtoMember(5)] public   seq  {get;set;} int = 0;
           [ProtoMember(6)] public   packNum  {get;set;} int = 0;
           [ProtoMember(7)] public   curPack  {get;set;} int = 0;
           [ProtoMember(8)] public   bufSig  {get;set;} string = "";
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   subCmd  {get;set;} int = 0;
           [ProtoMember(2)] public   msgCrmCommonHead  {get;set;} CrmS2CMsgHead? = null;
           [ProtoMember(3)] public   msgS2cCcAgentStatusChangePush  {get;set;} S2CCcAgentStatusChangePush? = null;
           [ProtoMember(4)] public   msgS2cCcConfigChangePush  {get;set;} S2CCcConfigChangePush? = null;
           [ProtoMember(5)] public   msgS2cCcExceptionOccurPush  {get;set;} S2CCcExceptionOccurPush? = null;
           [ProtoMember(6)] public   msgS2cCcTalkingStatusChangePush  {get;set;} S2CCcTalkingStatusChangePush? = null;
           [ProtoMember(7)] public   msgS2cCcAgentActionResultPush  {get;set;} S2CCcAgentActionResultPush? = null;
           [ProtoMember(8)] public   msgS2cCallRecordChangePush  {get;set;} S2CCallRecordChangePush? = null;
           [ProtoMember(9)] public   msgS2cSmsEventPush  {get;set;} S2CSMSEventPush? = null;
           [ProtoMember(10)] public   msgS2cAgentCallStatusEventPush  {get;set;} S2CAgentCallStatusEventPush? = null;
           [ProtoMember(11)] public   msgS2cUserGetCouponForKfextEventPush  {get;set;} S2CUserGetCouponForKFExtEventPush? = null;
           [ProtoMember(12)] public   msgS2cUserGetCouponForCEventPush  {get;set;} S2CUserGetCouponForCEventPush? = null;
        } {
            [ProtoContract]
            internal class S2CAgentCallStatusEventPush(
               [ProtoMember(1)] public   type  {get;set;} int = 0;
               [ProtoMember(2)] public   callStatus  {get;set;} int = 0;
               [ProtoMember(3)] public   ringAsr  {get;set;} int = 0;
               [ProtoMember(4)] public   callid  {get;set;} string = "";
               [ProtoMember(5)] public   fromKfext  {get;set;} long = 0L;
               [ProtoMember(6)] public   timestamp  {get;set;} int = 0;
            }

            [ProtoContract]
            internal class S2CCallRecordChangePush(
               [ProtoMember(1)] public   kfext  {get;set;} long = 0L;
                @ProtoType(ProtoIntegerType.FIXED)[ProtoMember(2)] public   fixed64Timestamp  {get;set;} long = 0L;
            }

            [ProtoContract]
            internal class S2CCcAgentActionResultPush(
               [ProtoMember(1)] public   type  {get;set;} int = 0;
               [ProtoMember(2)] public   callid  {get;set;} string = "";
               [ProtoMember(3)] public   result  {get;set;} int = 0;
               [ProtoMember(4)] public   timestamp  {get;set;} int = 0;
               [ProtoMember(5)] public   status  {get;set;} int = 0;
               [ProtoMember(6)] public   targetName  {get;set;} byte[] = Array.Empty<byte>();
               [ProtoMember(7)] public   targetKfext  {get;set;} long = 0L;
            }

            [ProtoContract]
            internal class S2CCcAgentStatusChangePush(
               [ProtoMember(1)] public   readyDevice  {get;set;} int = 0;
               [ProtoMember(2)] public   updateTime  {get;set;} long = 0L;
               [ProtoMember(3)] public   deviceSubState  {get;set;} int = 0;
            }

            [ProtoContract]
            internal class S2CCcConfigChangePush(
               [ProtoMember(1)] public   optype  {get;set;} int = 0;
            }

            [ProtoContract]
            internal class S2CCcExceptionOccurPush(
               [ProtoMember(1)] public   optype  {get;set;} int = 0;
            }

            [ProtoContract]
            internal class S2CCcTalkingStatusChangePush(
               [ProtoMember(1)] public   talkingStatus  {get;set;} int = 0;
               [ProtoMember(2)] public   callid  {get;set;} string = "";
            }

            [ProtoContract]
            internal class S2CSMSEventPush(
               [ProtoMember(1)] public   type  {get;set;} int = 0;
               [ProtoMember(2)] public   phoneNum  {get;set;} string = "";
               [ProtoMember(3)] public   timestamp  {get;set;} long = 0L;
               [ProtoMember(4)] public   smsId  {get;set;} string = "";
               [ProtoMember(5)] public   eventMsg  {get;set;} string = "";
            }

            [ProtoContract]
            internal class S2CUserGetCouponForCEventPush(
               [ProtoMember(1)] public   qquin  {get;set;} long = 0L;
               [ProtoMember(2)] public   kfuin  {get;set;} long = 0L;
               [ProtoMember(3)] public   couponId  {get;set;} long = 0L;
               [ProtoMember(4)] public   timestamp  {get;set;} int = 0;
               [ProtoMember(5)] public   kfext  {get;set;} long = 0L;
               [ProtoMember(6)] public   tipsContent  {get;set;} string = "";
            }

            [ProtoContract]
            internal class S2CUserGetCouponForKFExtEventPush(
               [ProtoMember(1)] public   channelType  {get;set;} int = 0;
               [ProtoMember(2)] public   fakeuin  {get;set;} long = 0L;
               [ProtoMember(3)] public   qquin  {get;set;} long = 0L;
               [ProtoMember(4)] public   openid  {get;set;} string = "";
               [ProtoMember(5)] public   visitorid  {get;set;} string = "";
               [ProtoMember(6)] public   appid  {get;set;} string = "";
               [ProtoMember(7)] public   qqPubUin  {get;set;} long = 0L;
               [ProtoMember(8)] public   kfuin  {get;set;} long = 0L;
               [ProtoMember(9)] public   couponId  {get;set;} long = 0L;
               [ProtoMember(10)] public   notifyTips  {get;set;} string = "";
               [ProtoMember(11)] public   timestamp  {get;set;} int = 0;
               [ProtoMember(12)] public   kfext  {get;set;} long = 0L;
            }
        }
    }
}


internal class Submsgtype0xe8 {
    internal class Submsgtype0xe8  {
        [ProtoContract]
        internal class MsgBody/*(
            [ProtoMember(1)] public   msgItem  {get;set;} ApolloPushMsgInfo.STPushMsgElem? = null
        )*/ 
    }
}


internal class Submsgtype0xe9 {
    internal class SubMsgType0xe9  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   businessType  {get;set;} int = 0;
           [ProtoMember(2)] public   business  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0xea {
    internal class Submsgtype0xea  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   title  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   content  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0xee {
    internal class Submsgtype0xee  {
        [ProtoContract]
        internal class AccountInfo(
           [ProtoMember(1)] public   id  {get;set;} long = 0L;
           [ProtoMember(2)] public   name  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   iconUrl  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class ContextInfo(
           [ProtoMember(1)] public   id  {get;set;} long = 0L;
           [ProtoMember(2)] public   title  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   msgPicList  {get;set;} List<PictureInfo> = new();
           [ProtoMember(4)] public   jumpUrl  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   orangeWord  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(6)] public   brief  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(7)] public   enumContextType  {get;set;} int /* enum */ = 0;
           [ProtoMember(8)] public   videoBrief  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class ControlInfo(
           [ProtoMember(1)] public   commentLength  {get;set;} int = 0;
           [ProtoMember(2)] public   showLine  {get;set;} int = 0;
           [ProtoMember(3)] public   fontSize  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class ExtraInfo(
           [ProtoMember(1)] public   ext  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   cookie  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   id  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   seq  {get;set;} long = 0L;
           [ProtoMember(3)] public   bid  {get;set;} int = 0;
           [ProtoMember(11)] public   msgNotifyList  {get;set;} List<NotifyInfo> = new();
        }

        [ProtoContract]
        internal class NotifyInfo(
           [ProtoMember(1)] public   msgStyleSheet  {get;set;} StyleSheet? = null;
           [ProtoMember(2)] public   enumApppushType  {get;set;} int /* enum */ = 0;
           [ProtoMember(3)] public   msgOrdinaryPushInfo  {get;set;} OrdinaryPushInfo? = null;
           [ProtoMember(4)] public   msgSocialPushInfo  {get;set;} SocialPushInfo? = null;
           [ProtoMember(5)] public   msgUgcPushInfo  {get;set;} UGCPushInfo? = null;
           [ProtoMember(11)] public   msgContextInfo  {get;set;} ContextInfo? = null;
           [ProtoMember(12)] public   msgAccountInfo  {get;set;} AccountInfo? = null;
           [ProtoMember(13)] public   msgStatisticsInfo  {get;set;} StatisticsInfo? = null;
           [ProtoMember(14)] public   msgControlInfo  {get;set;} ControlInfo? = null;
           [ProtoMember(21)] public   msgExtraInfo  {get;set;} ExtraInfo? = null;
        }

        [ProtoContract]
        internal class OrangeControlInfo(
           [ProtoMember(1)] public   color  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   fontSize  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class OrdinaryPushInfo(
           [ProtoMember(1)] public   msgLabelControlInfo  {get;set;} OrangeControlInfo? = null;
        }

        [ProtoContract]
        internal class PictureInfo(
           [ProtoMember(1)] public   url  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class SocialPushInfo(
           [ProtoMember(1)] public   feedsId  {get;set;} long = 0L;
           [ProtoMember(2)] public   biuReason  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   biuComment  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class StatisticsInfo(
           [ProtoMember(1)] public   algorithmId  {get;set;} long = 0L;
           [ProtoMember(2)] public   strategyId  {get;set;} long = 0L;
           [ProtoMember(3)] public   folderStatus  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class StyleSheet(
           [ProtoMember(1)] public   enumStyleType  {get;set;} int /* enum */ = 0;
           [ProtoMember(2)] public   arkEnable  {get;set;} int = 0;
           [ProtoMember(3)] public   scene  {get;set;} long = 0L;
           [ProtoMember(11)] public   duration  {get;set;} int = 0;
           [ProtoMember(12)] public   endTime  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class UGCPushInfo(
           [ProtoMember(1)] public   feedsId  {get;set;} long = 0L;
           [ProtoMember(2)] public   ugcReason  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}


internal class Submsgtype0xf9 {
    internal class Submsgtype0xf9  {
        [ProtoContract]
        internal class AdInfo(
           [ProtoMember(1)] public   fromUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   nick  {get;set;} string = "";
           [ProtoMember(3)] public   headUrl  {get;set;} string = "";
           [ProtoMember(4)] public   brief  {get;set;} string = "";
           [ProtoMember(5)] public   action  {get;set;} string = "";
           [ProtoMember(6)] public   flag  {get;set;} int = 0;
           [ProtoMember(7)] public   serviceID  {get;set;} int = 0;
           [ProtoMember(8)] public   templateID  {get;set;} int = 0;
           [ProtoMember(9)] public   url  {get;set;} string = "";
           [ProtoMember(10)] public   msgMsgCommonData  {get;set;} MsgCommonData? = null;
           [ProtoMember(11)] public   msgVideo  {get;set;} List<Video> = new();
           [ProtoMember(12)] public   pushTime  {get;set;} int = 0;
           [ProtoMember(13)] public   invalidTime  {get;set;} int = 0;
           [ProtoMember(14)] public   maxExposureTime  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   zipAdInfo  {get;set;} byte[] = Array.Empty<byte>();
        }

        [ProtoContract]
        internal class MsgCommonData(
           [ProtoMember(1)] public   adId  {get;set;} string = "";
           [ProtoMember(2)] public   adPosId  {get;set;} string = "";
           [ProtoMember(3)] public   boolBannerShow  {get;set;} bool = false;
           [ProtoMember(4)] public   bannertype  {get;set;} int = 0;
           [ProtoMember(5)] public   jumpType  {get;set;} int = 0;
           [ProtoMember(6)] public   jumpUrl  {get;set;} string = "";
           [ProtoMember(7)] public   appId  {get;set;} string = "";
           [ProtoMember(8)] public   appName  {get;set;} string = "";
           [ProtoMember(9)] public   packagename  {get;set;} string = "";
           [ProtoMember(10)] public   androidDownloadUrl  {get;set;} string = "";
           [ProtoMember(11)] public   scheme  {get;set;} string = "";
           [ProtoMember(12)] public   iosDownloadUrl  {get;set;} string = "";
           [ProtoMember(13)] public   bannerImgUrl  {get;set;} string = "";
           [ProtoMember(14)] public   bannerText  {get;set;} string = "";
           [ProtoMember(15)] public   bannerButtonText  {get;set;} string = "";
           [ProtoMember(16)] public   boolSilentDownload  {get;set;} bool = false;
           [ProtoMember(17)] public   audioSwitchType  {get;set;} int = 0;
           [ProtoMember(18)] public   preDownloadType  {get;set;} int = 0;
           [ProtoMember(19)] public   reportLink  {get;set;} string = "";
           [ProtoMember(20)] public   boolHorizontalVideo  {get;set;} bool = false;
           [ProtoMember(21)] public   audioFadeinDuration  {get;set;} int = 0;
           [ProtoMember(22)] public   openJumpUrlGuide  {get;set;} string = "";
           [ProtoMember(23)] public   myappDownloadUrl  {get;set;} string = "";
           [ProtoMember(24)] public   jumpTypeParams  {get;set;} string = "";
           [ProtoMember(25)] public   scrollUpToJump  {get;set;} int = 0;
           [ProtoMember(26)] public   controlVariable  {get;set;} int = 0;
           [ProtoMember(27)] public   autoJump  {get;set;} int = 0;
           [ProtoMember(28)] public   clickLink  {get;set;} string = "";
           [ProtoMember(29)] public   monitorType  {get;set;} int = 0;
           [ProtoMember(30)] public   shareNick  {get;set;} string = "";
           [ProtoMember(31)] public   shareAdHeadUrl  {get;set;} string = "";
           [ProtoMember(32)] public   shareAdBrief  {get;set;} string = "";
           [ProtoMember(33)] public   shareAdTxt  {get;set;} string = "";
           [ProtoMember(34)] public   shareAdIconUrl  {get;set;} string = "";
           [ProtoMember(35)] public   shareJumpUrl  {get;set;} string = "";
           [ProtoMember(36)] public   controlPluginTime  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class Video(
           [ProtoMember(1)] public   layout  {get;set;} int = 0;
           [ProtoMember(2)] public   cover  {get;set;} string = "";
           [ProtoMember(3)] public   src  {get;set;} string = "";
        }
    }
}


internal class Submsgtype0xfd {
    internal class Submsgtype0xfd  {
        [ProtoContract]
        internal class AdInfo(
           [ProtoMember(1)] public   fromUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   adId  {get;set;} string = "";
           [ProtoMember(3)] public   adSeq  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   msgAdInfo  {get;set;} AdInfo? = null;
        }
    }
}


internal class Submsgtype0xfe {
    internal class Submsgtype0xfe  {
        [ProtoContract]
        internal class MsgBody(
           [ProtoMember(1)] public   wording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   innerUnreadNum  {get;set;} int = 0;
           [ProtoMember(3)] public   boxUnreadNum  {get;set;} int = 0;
           [ProtoMember(4)] public   updateTime  {get;set;} int = 0;
        }
    }
}
