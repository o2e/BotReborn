using ProtoBuf;

internal class HummerCommelem  {
    [ProtoContract] class MsgElemInfoServtype1(
       [ProtoMember(1)] public   rewardId  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   senderUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   picType  {get;set;} int = 0;
       [ProtoMember(4)] public   rewardMoney  {get;set;} int = 0;
       [ProtoMember(5)] public   url  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   content  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(7)] public   createTimestamp  {get;set;} int = 0;
       [ProtoMember(8)] public   status  {get;set;} int = 0;
       [ProtoMember(9)] public   size  {get;set;} int = 0;
       [ProtoMember(10)] public   videoDuration  {get;set;} int = 0;
       [ProtoMember(11)] public   seq  {get;set;} long = 0L;
       [ProtoMember(12)] public   rewardTypeExt  {get;set;} int = 0
    }

    [ProtoContract] class MsgElemInfoServtype11(
       [ProtoMember(1)] public   resID  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   resMD5  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   reserveInfo1  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   reserveInfo2  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   doodleDataOffset  {get;set;} int = 0;
       [ProtoMember(6)] public   doodleGifId  {get;set;} int = 0;
       [ProtoMember(7)] public   doodleUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(8)] public   doodleMd5  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class MsgElemInfoServtype13(
       [ProtoMember(1)] public   sysHeadId  {get;set;} int = 0;
       [ProtoMember(2)] public   headFlag  {get;set;} int = 0
    }

    [ProtoContract] class MsgElemInfoServtype14(
       [ProtoMember(1)] public   id  {get;set;} int = 0;
       [ProtoMember(2)] public   reserveInfo  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class MsgElemInfoServtype15(
       [ProtoMember(1)] public   vid  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   cover  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   title  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   summary  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   createTime  {get;set;} long = 0L;
       [ProtoMember(6)] public   commentContent  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(7)] public   author  {get;set;} long = 0L;
       [ProtoMember(8)] public   ctrVersion  {get;set;} int = 0
    }

    [ProtoContract] class MsgElemInfoServtype16(
       [ProtoMember(1)] public   uid  {get;set;} long = 0L;
       [ProtoMember(2)] public   unionID  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   storyID  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   md5  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   thumbUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   doodleUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(7)] public   videoWidth  {get;set;} int = 0;
       [ProtoMember(8)] public   videoHeight  {get;set;} int = 0;
       [ProtoMember(9)] public   sourceName  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(10)] public   sourceActionType  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(11)] public   sourceActionData  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(12)] public   ctrVersion  {get;set;} int = 0
    }

    [ProtoContract] class MsgElemInfoServtype18(
       [ProtoMember(1)] public   currentAmount  {get;set;} long = 0L;
       [ProtoMember(2)] public   totalAmount  {get;set;} long = 0L;
       [ProtoMember(3)] public   listid  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   authKey  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   number  {get;set;} int = 0
    }

    [ProtoContract] class MsgElemInfoServtype19(
       [ProtoMember(1)] public   data  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class MsgElemInfoServtype2(
       [ProtoMember(1)] public   pokeType  {get;set;} int = 0;
       [ProtoMember(2)] public   pokeSummary  {get;set;} string = "";
       [ProtoMember(3)] public   doubleHit  {get;set;} int = 0;
       [ProtoMember(4)] public   vaspokeId  {get;set;} int = 0;
       [ProtoMember(5)] public   vaspokeName  {get;set;} string = "";
       [ProtoMember(6)] public   vaspokeMinver  {get;set;} string = "";
       [ProtoMember(7)] public   pokeStrength  {get;set;} int = 0;
       [ProtoMember(8)] public   msgType  {get;set;} int = 0;
       [ProtoMember(9)] public   faceBubbleCount  {get;set;} int = 0;
       [ProtoMember(10)] public   pokeFlag  {get;set;} int = 0
    }

    [ProtoContract] class MsgElemInfoServtype20(
       [ProtoMember(1)] public   data  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class MsgElemInfoServtype21(
       [ProtoMember(1)] public   topicId  {get;set;} int = 0;
       [ProtoMember(2)] public   confessorUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   confessorNick  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   confessorSex  {get;set;} int = 0;
       [ProtoMember(5)] public   sysmsgFlag  {get;set;} int = 0;
       [ProtoMember(6)] public   c2cConfessCtx  {get;set;} C2CConfessContext? = null;
       [ProtoMember(7)] public   topic  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(8)] public   confessTime  {get;set;} long = 0L;
       [ProtoMember(9)] public   groupConfessMsg  {get;set;} GroupConfessMsg? = null;
       [ProtoMember(10)] public   groupConfessCtx  {get;set;} GroupConfessContext? = null
    } {
        [ProtoContract]
        internal class C2CConfessContext(
           [ProtoMember(1)] public   confessorUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   confessToUin  {get;set;} long = 0L;
           [ProtoMember(3)] public   sendUin  {get;set;} long = 0L;
           [ProtoMember(4)] public   confessorNick  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   confess  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(6)] public   bgType  {get;set;} int = 0;
           [ProtoMember(7)] public   topicId  {get;set;} int = 0;
           [ProtoMember(8)] public   confessTime  {get;set;} long = 0L;
           [ProtoMember(9)] public   confessorSex  {get;set;} int = 0;
           [ProtoMember(10)] public   bizType  {get;set;} int = 0;
           [ProtoMember(11)] public   confessNum  {get;set;} int = 0;
           [ProtoMember(12)] public   confessToSex  {get;set;} int = 0
        }

        [ProtoContract]
        internal class GroupConfessContext(
           [ProtoMember(1)] public   confessorUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   confessToUin  {get;set;} long = 0L;
           [ProtoMember(3)] public   sendUin  {get;set;} long = 0L;
           [ProtoMember(4)] public   confessorSex  {get;set;} int = 0;
           [ProtoMember(5)] public   confessToNick  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(6)] public   topic  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(7)] public   topicId  {get;set;} int = 0;
           [ProtoMember(8)] public   confessTime  {get;set;} long = 0L;
           [ProtoMember(9)] public   confessToNickType  {get;set;} int = 0;
           [ProtoMember(10)] public   confessorNick  {get;set;} byte[] = Array.Empty<byte>()
        }

        [ProtoContract]
        internal class GroupConfessItem(
           [ProtoMember(1)] public   topicId  {get;set;} int = 0;
           [ProtoMember(2)] public   confessToUin  {get;set;} long = 0L;
           [ProtoMember(3)] public   confessToNick  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(4)] public   topic  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(5)] public   confessToNickType  {get;set;} int = 0
        }

        [ProtoContract]
        internal class GroupConfessMsg(
           [ProtoMember(1)] public   confessTime  {get;set;} long = 0L;
           [ProtoMember(2)] public   confessorUin  {get;set;} long = 0L;
           [ProtoMember(3)] public   confessorSex  {get;set;} int = 0;
           [ProtoMember(4)] public   sysmsgFlag  {get;set;} int = 0;
           [ProtoMember(5)] public   confessItems  {get;set;} List<GroupConfessItem> = new();
           [ProtoMember(6)] public   totalTopicCount  {get;set;} int = 0
        }
    }

    [ProtoContract] class MsgElemInfoServtype23(
       [ProtoMember(1)] public   faceType  {get;set;} int = 0;
       [ProtoMember(2)] public   faceBubbleCount  {get;set;} int = 0;
       [ProtoMember(3)] public   faceSummary  {get;set;} string = "";
       [ProtoMember(4)] public   flag  {get;set;} int = 0;
       [ProtoMember(5)] public   others  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class MsgElemInfoServtype24(
       [ProtoMember(1)] public   limitChatEnter  {get;set;} LimitChatEnter? = null;
       [ProtoMember(2)] public   limitChatExit  {get;set;} LimitChatExit? = null
    } {
        [ProtoContract]
        internal class LimitChatEnter(
           [ProtoMember(1)] public   tipsWording  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(2)] public   leftChatTime  {get;set;} int = 0;
           [ProtoMember(3)] public   matchTs  {get;set;} long = 0L;
           [ProtoMember(4)] public   matchExpiredTime  {get;set;} int = 0;
           [ProtoMember(5)] public   c2cExpiredTime  {get;set;} int = 0;
           [ProtoMember(6)] public   readyTs  {get;set;} long = 0L;
           [ProtoMember(7)] public   matchNick  {get;set;} byte[] = Array.Empty<byte>()
        }

        [ProtoContract]
        internal class LimitChatExit(
           [ProtoMember(1)] public   exitMethod  {get;set;} int = 0;
           [ProtoMember(2)] public   matchTs  {get;set;} long = 0L
        }
    }

    [ProtoContract] class MsgElemInfoServtype27(
       [ProtoMember(1)] public   videoFile  {get;set;} ImMsgBody.VideoFile? = null
    }

    [ProtoContract] class MsgElemInfoServtype29(
       [ProtoMember(1)] public   luckybagMsg  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class MsgElemInfoServtype3(
       [ProtoMember(1)] public   flashTroopPic  {get;set;} ImMsgBody.CustomFace? = null;
       [ProtoMember(2)] public   flashC2cPic  {get;set;} ImMsgBody.NotOnlineImage? = null
    }

    [ProtoContract] class MsgElemInfoServtype31(
       [ProtoMember(1)] public   text  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   ext  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class MsgElemInfoServtype33(
       [ProtoMember(1)] public   index  {get;set;} int = 0;
       [ProtoMember(2)] public   name  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   compat  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   buf  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class MsgElemInfoServtype4(
       [ProtoMember(1)] public   imsgType  {get;set;} int = 0;
       [ProtoMember(4)] public   stStoryAioObjMsg  {get;set;} StoryAioObjMsg? = null
    }

    [ProtoContract] class MsgElemInfoServtype5(
       [ProtoMember(1)] public   vid  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   cover  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   title  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   summary  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   createTime  {get;set;} long = 0L;
       [ProtoMember(6)] public   commentContent  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(7)] public   author  {get;set;} long = 0L
    }

    [ProtoContract] class MsgElemInfoServtype8(
       [ProtoMember(1)] public   wifiDeliverGiftMsg  {get;set;} ImMsgBody.DeliverGiftMsg? = null
    }

    [ProtoContract] class MsgElemInfoServtype9(
       [ProtoMember(1)] public   anchorStatus  {get;set;} int = 0;
       [ProtoMember(2)] public   jumpSchema  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   anchorNickname  {get;set;} string = "";
       [ProtoMember(4)] public   anchorHeadUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   liveTitle  {get;set;} string = ""
    }

    [ProtoContract] class StoryAioObjMsg(
       [ProtoMember(1)] public   uiUrl  {get;set;} string = "";
       [ProtoMember(2)] public   jmpUrl  {get;set;} string = ""
    }
}
