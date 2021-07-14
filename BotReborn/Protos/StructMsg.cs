using ProtoBuf;

internal class QPayReminderMsg  {
    [ProtoContract] class GetInfoReq(
       [ProtoMember(1)] public   scene  {get;set;} string = "";
       [ProtoMember(2)] public   subCmd  {get;set;} string = "";
       [ProtoMember(3)] public   infoDate  {get;set;} string = "";
    }

    [ProtoContract] class GetInfoRsp(
       [ProtoMember(1)] public   resultCode  {get;set;} int = 0;
       [ProtoMember(2)] public   resultInfo  {get;set;} string = "";
       [ProtoMember(3)] public   urgency  {get;set;} int = 0;
       [ProtoMember(4)] public   templateNo  {get;set;} int = 0;
       [ProtoMember(5)] public   content  {get;set;} string = "";
       [ProtoMember(6)] public   infoDate  {get;set;} string = "";
    }
}

internal class Structmsg  {
    [ProtoContract] class AddFrdSNInfo(
       [ProtoMember(1)] public   notSeeDynamic  {get;set;} int = 0;
       [ProtoMember(2)] public   setSn  {get;set;} int = 0;
    }

    [ProtoContract] class FlagInfo(
       [ProtoMember(1)] public   grpMsgKickAdmin  {get;set;} int = 0;
       [ProtoMember(2)] public   grpMsgHiddenGrp  {get;set;} int = 0;
       [ProtoMember(3)] public   grpMsgWordingDown  {get;set;} int = 0;
       [ProtoMember(4)] public   frdMsgGetBusiCard  {get;set;} int = 0;
       [ProtoMember(5)] public   grpMsgGetOfficialAccount  {get;set;} int = 0;
       [ProtoMember(6)] public   grpMsgGetPayInGroup  {get;set;} int = 0;
       [ProtoMember(7)] public   frdMsgDiscuss2ManyChat  {get;set;} int = 0;
       [ProtoMember(8)] public   grpMsgNotAllowJoinGrpInviteNotFrd  {get;set;} int = 0;
       [ProtoMember(9)] public   frdMsgNeedWaitingMsg  {get;set;} int = 0;
       [ProtoMember(10)] public   frdMsgUint32NeedAllUnreadMsg  {get;set;} int = 0;
       [ProtoMember(11)] public   grpMsgNeedAutoAdminWording  {get;set;} int = 0;
       [ProtoMember(12)] public   grpMsgGetTransferGroupMsgFlag  {get;set;} int = 0;
       [ProtoMember(13)] public   grpMsgGetQuitPayGroupMsgFlag  {get;set;} int = 0;
       [ProtoMember(14)] public   grpMsgSupportInviteAutoJoin  {get;set;} int = 0;
       [ProtoMember(15)] public   grpMsgMaskInviteAutoJoin  {get;set;} int = 0;
       [ProtoMember(16)] public   grpMsgGetDisbandedByAdmin  {get;set;} int = 0;
       [ProtoMember(17)] public   grpMsgGetC2cInviteJoinGroup  {get;set;} int = 0;
    }

    [ProtoContract] class FriendInfo(
       [ProtoMember(1)] public   msgJointFriend  {get;set;} string = "";
       [ProtoMember(2)] public   msgBlacklist  {get;set;} string = "";
    }

    [ProtoContract] class GroupInfo(
       [ProtoMember(1)] public   groupAuthType  {get;set;} int = 0;
       [ProtoMember(2)] public   displayAction  {get;set;} int = 0;
       [ProtoMember(3)] public   msgAlert  {get;set;} string = "";
       [ProtoMember(4)] public   msgDetailAlert  {get;set;} string = "";
       [ProtoMember(5)] public   msgOtherAdminDone  {get;set;} string = "";
       [ProtoMember(6)] public   appPrivilegeFlag  {get;set;} int = 0;
    }

    [ProtoContract] class MsgInviteExt(
       [ProtoMember(1)] public   srcType  {get;set;} int = 0;
       [ProtoMember(2)] public   srcCode  {get;set;} long = 0L;
       [ProtoMember(3)] public   waitState  {get;set;} int = 0;
    }

    [ProtoContract] class MsgPayGroupExt(
       [ProtoMember(1)] public   joinGrpTime  {get;set;} long = 0L;
       [ProtoMember(2)] public   quitGrpTime  {get;set;} long = 0L;
    }

    [ProtoContract] class ReqNextSystemMsg(
       [ProtoMember(1)] public   msgNum  {get;set;} int = 0;
       [ProtoMember(2)] public   followingFriendSeq  {get;set;} long = 0L;
       [ProtoMember(3)] public   followingGroupSeq  {get;set;} long = 0L;
       [ProtoMember(4)] public   checktype  {get;set;} int /* enum */ = 1;
       [ProtoMember(5)] public   flag  {get;set;} FlagInfo? = null;
       [ProtoMember(6)] public   language  {get;set;} int = 0;
       [ProtoMember(7)] public   version  {get;set;} int = 0;
       [ProtoMember(8)] public   friendMsgTypeFlag  {get;set;} long = 0L;
    }

    [ProtoContract] class ReqSystemMsg(
       [ProtoMember(1)] public   msgNum  {get;set;} int = 0;
       [ProtoMember(2)] public   latestFriendSeq  {get;set;} long = 0L;
       [ProtoMember(3)] public   latestGroupSeq  {get;set;} long = 0L;
       [ProtoMember(4)] public   version  {get;set;} int = 0;
       [ProtoMember(5)] public   language  {get;set;} int = 0;
    }

    [ProtoContract] class ReqSystemMsgAction(
       [ProtoMember(1)] public   msgType  {get;set;} int /* enum */ = 1;
       [ProtoMember(2)] public   msgSeq  {get;set;} long = 0L;
       [ProtoMember(3)] public   reqUin  {get;set;} long = 0L;
       [ProtoMember(4)] public   subType  {get;set;} int = 0;
       [ProtoMember(5)] public   srcId  {get;set;} int = 0;
       [ProtoMember(6)] public   subSrcId  {get;set;} int = 0;
       [ProtoMember(7)] public   groupMsgType  {get;set;} int = 0;
       [ProtoMember(8)] public   actionInfo  {get;set;} SystemMsgActionInfo? = null;
       [ProtoMember(9)] public   language  {get;set;} int = 0;
    }

    [ProtoContract] class ReqSystemMsgNew(
       [ProtoMember(1)] public   msgNum  {get;set;} int = 0;
       [ProtoMember(2)] public   latestFriendSeq  {get;set;} long = 0L;
       [ProtoMember(3)] public   latestGroupSeq  {get;set;} long = 0L;
       [ProtoMember(4)] public   version  {get;set;} int = 0;
       [ProtoMember(5)] public   checktype  {get;set;} int /* enum */ = 1;
       [ProtoMember(6)] public   flag  {get;set;} FlagInfo? = null;
       [ProtoMember(7)] public   language  {get;set;} int = 0;
       [ProtoMember(8)] public   isGetFrdRibbon  {get;set;} bool = true;
       [ProtoMember(9)] public   isGetGrpRibbon  {get;set;} bool = true;
       [ProtoMember(10)] public   friendMsgTypeFlag  {get;set;} long = 0L;
    }

    [ProtoContract] class ReqSystemMsgRead(
       [ProtoMember(1)] public   latestFriendSeq  {get;set;} long = 0L;
       [ProtoMember(2)] public   latestGroupSeq  {get;set;} long = 0L;
       [ProtoMember(3)] public   type  {get;set;} int = 0;
       [ProtoMember(4)] public   checktype  {get;set;} int /* enum */ = 1;
    }

    [ProtoContract] class RspHead(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   msgFail  {get;set;} string = "";
    }

    [ProtoContract] class RspNextSystemMsg(
       [ProtoMember(1)] public   head  {get;set;} RspHead? = null;
       [ProtoMember(2)] public   msgs  {get;set;} List<StructMsg> = new();
       [ProtoMember(3)] public   followingFriendSeq  {get;set;} long = 0L;
       [ProtoMember(4)] public   followingGroupSeq  {get;set;} long = 0L;
       [ProtoMember(5)] public   checktype  {get;set;} int /* enum */ = 1;
       [ProtoMember(100)] public   gameNick  {get;set;} string = "";
       [ProtoMember(101)] public   undecidForQim  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(102)] public   unReadCount3  {get;set;} int = 0;
    }

    [ProtoContract] class RspSystemMsg(
       [ProtoMember(1)] public   head  {get;set;} RspHead? = null;
       [ProtoMember(2)] public   msgs  {get;set;} List<StructMsg> = new();
       [ProtoMember(3)] public   unreadCount  {get;set;} int = 0;
       [ProtoMember(4)] public   latestFriendSeq  {get;set;} long = 0L;
       [ProtoMember(5)] public   latestGroupSeq  {get;set;} long = 0L;
       [ProtoMember(6)] public   followingFriendSeq  {get;set;} long = 0L;
       [ProtoMember(7)] public   followingGroupSeq  {get;set;} long = 0L;
       [ProtoMember(8)] public   msgDisplay  {get;set;} string = "";
    }

    [ProtoContract] class RspSystemMsgAction(
       [ProtoMember(1)] public   head  {get;set;} RspHead? = null;
       [ProtoMember(2)] public   msgDetail  {get;set;} string = "";
       [ProtoMember(3)] public   type  {get;set;} int = 0;
       [ProtoMember(5)] public   msgInvalidDecided  {get;set;} string = "";
       [ProtoMember(6)] public   remarkResult  {get;set;} int = 0;
    }

    [ProtoContract] class RspSystemMsgNew(
       [ProtoMember(1)] public   head  {get;set;} RspHead? = null;
       [ProtoMember(2)] public   unreadFriendCount  {get;set;} int = 0;
       [ProtoMember(3)] public   unreadGroupCount  {get;set;} int = 0;
       [ProtoMember(4)] public   latestFriendSeq  {get;set;} long = 0L;
       [ProtoMember(5)] public   latestGroupSeq  {get;set;} long = 0L;
       [ProtoMember(6)] public   followingFriendSeq  {get;set;} long = 0L;
       [ProtoMember(7)] public   followingGroupSeq  {get;set;} long = 0L;
       [ProtoMember(9)] public   friendmsgs  {get;set;} List<StructMsg> = new();
       [ProtoMember(10)] public   groupmsgs  {get;set;} List<StructMsg> = new();
       [ProtoMember(11)] public   msgRibbonFriend  {get;set;} StructMsg? = null;
       [ProtoMember(12)] public   msgRibbonGroup  {get;set;} StructMsg? = null;
       [ProtoMember(13)] public   msgDisplay  {get;set;} string = "";
       [ProtoMember(14)] public   grpMsgDisplay  {get;set;} string = "";
       [ProtoMember(15)] public   over  {get;set;} int = 0;
       [ProtoMember(20)] public   checktype  {get;set;} int /* enum */ = 1;
       [ProtoMember(100)] public   gameNick  {get;set;} string = "";
       [ProtoMember(101)] public   undecidForQim  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(102)] public   unReadCount3  {get;set;} int = 0;
    }

    [ProtoContract] class RspSystemMsgRead(
       [ProtoMember(1)] public   head  {get;set;} RspHead? = null;
       [ProtoMember(2)] public   type  {get;set;} int = 0;
       [ProtoMember(3)] public   checktype  {get;set;} int /* enum */ = 1;
    }

    [ProtoContract] class StructMsg(
       [ProtoMember(1)] public   version  {get;set;} int = 0;
       [ProtoMember(2)] public   msgType  {get;set;} int /* enum */ = 1;
       [ProtoMember(3)] public   msgSeq  {get;set;} long = 0L;
       [ProtoMember(4)] public   msgTime  {get;set;} long = 0L;
       [ProtoMember(5)] public   reqUin  {get;set;} long = 0L;
       [ProtoMember(6)] public   unreadFlag  {get;set;} int = 0;
       [ProtoMember(50)] public   msg  {get;set;} SystemMsg? = null;
    }

    [ProtoContract] class SystemMsg(
       [ProtoMember(1)] public   subType  {get;set;} int = 0;
       [ProtoMember(2)] public   msgTitle  {get;set;} string = "";
       [ProtoMember(3)] public   msgDescribe  {get;set;} string = "";
       [ProtoMember(4)] public   msgAdditional  {get;set;} string = "";
       [ProtoMember(5)] public   msgSource  {get;set;} string = "";
       [ProtoMember(6)] public   msgDecided  {get;set;} string = "";
       [ProtoMember(7)] public   srcId  {get;set;} int = 0;
       [ProtoMember(8)] public   subSrcId  {get;set;} int = 0;
       [ProtoMember(9)] public   actions  {get;set;} List<SystemMsgAction> = new();
       [ProtoMember(10)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(11)] public   actionUin  {get;set;} long = 0L;
       [ProtoMember(12)] public   groupMsgType  {get;set;} int = 0;
       [ProtoMember(13)] public   groupInviterRole  {get;set;} int = 0;
       [ProtoMember(14)] public   friendInfo  {get;set;} FriendInfo? = null;
       [ProtoMember(15)] public   groupInfo  {get;set;} GroupInfo? = null;
       [ProtoMember(16)] public   actorUin  {get;set;} long = 0L;
       [ProtoMember(17)] public   msgActorDescribe  {get;set;} string = "";
       [ProtoMember(18)] public   msgAdditionalList  {get;set;} string = "";
       [ProtoMember(19)] public   relation  {get;set;} int = 0;
       [ProtoMember(20)] public   reqsubtype  {get;set;} int = 0;
       [ProtoMember(21)] public   cloneUin  {get;set;} long = 0L;
       [ProtoMember(22)] public   discussUin  {get;set;} long = 0L;
       [ProtoMember(23)] public   eimGroupId  {get;set;} long = 0L;
       [ProtoMember(24)] public   msgInviteExtinfo  {get;set;} MsgInviteExt? = null;
       [ProtoMember(25)] public   msgPayGroupExtinfo  {get;set;} MsgPayGroupExt? = null;
       [ProtoMember(26)] public   sourceFlag  {get;set;} int = 0;
       [ProtoMember(27)] public   gameNick  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(28)] public   gameMsg  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(29)] public   groupFlagext3  {get;set;} int = 0;
       [ProtoMember(30)] public   groupOwnerUin  {get;set;} long = 0L;
       [ProtoMember(31)] public   doubtFlag  {get;set;} int = 0;
       [ProtoMember(32)] public   warningTips  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(33)] public   nameMore  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(50)] public   reqUinFaceid  {get;set;} int = 0;
       [ProtoMember(51)] public   reqUinNick  {get;set;} string = "";
       [ProtoMember(52)] public   groupName  {get;set;} string = "";
       [ProtoMember(53)] public   actionUinNick  {get;set;} string = "";
       [ProtoMember(54)] public   msgQna  {get;set;} string = "";
       [ProtoMember(55)] public   msgDetail  {get;set;} string = "";
       [ProtoMember(57)] public   groupExtFlag  {get;set;} int = 0;
       [ProtoMember(58)] public   actorUinNick  {get;set;} string = "";
       [ProtoMember(59)] public   picUrl  {get;set;} string = "";
       [ProtoMember(60)] public   cloneUinNick  {get;set;} string = "";
       [ProtoMember(61)] public   reqUinBusinessCard  {get;set;} string = "";
       [ProtoMember(63)] public   eimGroupIdName  {get;set;} string = "";
       [ProtoMember(64)] public   reqUinPreRemark  {get;set;} string = "";
       [ProtoMember(65)] public   actionUinQqNick  {get;set;} string = "";
       [ProtoMember(66)] public   actionUinRemark  {get;set;} string = "";
       [ProtoMember(67)] public   reqUinGender  {get;set;} int = 0;
       [ProtoMember(68)] public   reqUinAge  {get;set;} int = 0;
       [ProtoMember(69)] public   c2cInviteJoinGroupFlag  {get;set;} int = 0;
       [ProtoMember(101)] public   cardSwitch  {get;set;} int = 0;
    }

    [ProtoContract] class SystemMsgAction(
       [ProtoMember(1)] public   name  {get;set;} string = "";
       [ProtoMember(2)] public   result  {get;set;} string = "";
       [ProtoMember(3)] public   action  {get;set;} int = 0;
       [ProtoMember(4)] public   actionInfo  {get;set;} SystemMsgActionInfo? = null;
       [ProtoMember(5)] public   detailName  {get;set;} string = "";
    }

    [ProtoContract] class SystemMsgActionInfo(
       [ProtoMember(1)] public   type  {get;set;} int /* enum */ = 1;
       [ProtoMember(2)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(3)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(50)] public   msg  {get;set;} string = "";
       [ProtoMember(51)] public   groupId  {get;set;} int = 0;
       [ProtoMember(52)] public   remark  {get;set;} string = "";
       [ProtoMember(53)] public   blacklist  {get;set;} bool = false;
       [ProtoMember(54)] public   addFrdSNInfo  {get;set;} AddFrdSNInfo? = null;
    }
}

[ProtoContract] class Youtu  {
    [ProtoContract] class NameCardOcrRsp(
       [ProtoMember(1)] public   errorcode  {get;set;} int = 0;
       [ProtoMember(2)] public   errormsg  {get;set;} string = "";
       [ProtoMember(3)] public   uin  {get;set;} string = "";
       [ProtoMember(4)] public   uinConfidence  {get;set;} Float = 0.0F;
       [ProtoMember(5)] public   phone  {get;set;} string = "";
       [ProtoMember(6)] public   phoneConfidence  {get;set;} Float = 0.0F;
       [ProtoMember(7)] public   name  {get;set;} string = "";
       [ProtoMember(8)] public   nameConfidence  {get;set;} Float = 0.0F;
       [ProtoMember(9)] public   image  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(10)] public   sessionId  {get;set;} string = "";
    }
}
