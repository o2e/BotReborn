





using ProtoBuf;

import net.mamoe.mirai.internal.network.Packet


import net.mamoe.mirai.utils.capitalize

internal class Oidb0x5d4  {
    [ProtoContract] class DelResult{[ProtoMember(1)] public     uin  {get;set;} long = 0L;
        [ProtoMember(2)] public     res  {get;set;} int = 0
    }

    [ProtoContract] class ReqBody{[ProtoMember(1)] public     uinList  {get;set;} List<Long> = new()
    }

    [ProtoContract] class RspBody{[ProtoMember(1)] public     seq  {get;set;} int = 0;
        [ProtoMember(2)] public     result  {get;set;} List<DelResult> = new()
    }
}

internal class Oidb0x5d2  {
    [ProtoContract] class FriendInfo{[ProtoMember(1)] public     uin  {get;set;} long = 0L;
        [ProtoMember(2)] public     gender  {get;set;} int = 0;
        [ProtoMember(3)] public     age  {get;set;} int = 0;
        [ProtoMember(4)] public     group  {get;set;} int = 0;
        [ProtoMember(5)] public     login  {get;set;} int = 0;
        [ProtoMember(6)] public     remark  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class FriendEntry{[ProtoMember(1)] public     uin  {get;set;} long = 0L;
        [ProtoMember(2)] public     nick  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class GroupInfo{[ProtoMember(1)] public     id  {get;set;} int = 0;
        [ProtoMember(2)] public     name  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class LoginInfo{[ProtoMember(1)] public     id  {get;set;} int = 0;
        [ProtoMember(2)] public     name  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class ReqBody{[ProtoMember(1)] public     subCmd  {get;set;} int = 0;
        [ProtoMember(2)] public     reqGetList  {get;set;} ReqGetList? = null;
        [ProtoMember(3)] public     reqGetInfo  {get;set;} ReqGetInfo? = null
    }

    [ProtoContract] class ReqGetInfo{[ProtoMember(1)] public     uinList  {get;set;} List<Long> = new()
    }

    [ProtoContract] class ReqGetList{[ProtoMember(1)] public     seq  {get;set;} int = 0
    }

    [ProtoContract] class RspBody{[ProtoMember(1)] public     subCmd  {get;set;} int = 0;
        [ProtoMember(2)] public     rspGetList  {get;set;} RspGetList? = null;
        [ProtoMember(3)] public     rspGetInfo  {get;set;} RspGetInfo? = null
    }

    [ProtoContract] class RspGetInfo{[ProtoMember(1)] public     groupInfo  {get;set;} List<GroupInfo> = new();
        [ProtoMember(2)] public     loginInfo  {get;set;} List<LoginInfo> = new();
        [ProtoMember(3)] public     time  {get;set;} int = 0;
        [ProtoMember(4)] public     frdInfo  {get;set;} List<FriendInfo> = new();
        [ProtoMember(5)] public     frdDelete  {get;set;} List<Long> = new()
    }

    [ProtoContract] class RspGetList{[ProtoMember(1)] public     seq  {get;set;} int = 0;
        [ProtoMember(2)] public     list  {get;set;} List<FriendEntry> = new()
    }
}

internal class Oidb0x496 {
    [ProtoContract] class AioKeyword{[ProtoMember(1)] public     keywords  {get;set;} List<AioKeywordInfo> = new();
        [ProtoMember(2)] public     rules  {get;set;} List<AioKeywordRuleInfo> = new();
        [ProtoMember(3)] public     version  {get;set;} int = 0
    }

    [ProtoContract] class AioKeywordInfo{[ProtoMember(1)] public     word  {get;set;} string = "";
        [ProtoMember(2)] public     ruleId  {get;set;} int = 0
    }

    [ProtoContract] class AioKeywordRuleInfo{[ProtoMember(1)] public     ruleId  {get;set;} int = 0;
        [ProtoMember(2)] public     startTime  {get;set;} int = 0;
        [ProtoMember(3)] public     endTime  {get;set;} int = 0;
        [ProtoMember(4)] public     postionFlag  {get;set;} int = 0;
        [ProtoMember(5)] public     matchGroupClass  {get;set;} List<int> = new();
        [ProtoMember(6)] public     version  {get;set;} int = 0
    }

    [ProtoContract] class GroupMsgConfig{[ProtoMember(1)] public     boolUinEnable  {get;set;} bool = false;
        [ProtoMember(2)] public     maxAioMsg  {get;set;} int = 0;
        [ProtoMember(3)] public     enableHelper  {get;set;} int = 0;
        [ProtoMember(4)] public     groupMaxNumber  {get;set;} int = 0;
        [ProtoMember(5)] public     nextUpdateTime  {get;set;} int = 0
    }

    [ProtoContract] class MsgSeqInfo{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     managerUinList  {get;set;} List<Long> = new();
        [ProtoMember(3)] public     updateTime  {get;set;} long = 0L;
        [ProtoMember(4)] public     firstUnreadManagerMsgSeq  {get;set;} long = 0L;
        [ProtoMember(5)] public     uint64ManagerMsgSeq  {get;set;} List<Long> = new()
    }

    [ProtoContract] class ReqBody{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     updateTime  {get;set;} long = 0L;
        [ProtoMember(3)] public     managerUinList  {get;set;} long = 0L;
        [ProtoMember(4)] public     firstUnreadManagerMsgSeq  {get;set;} long = 0L;
        [ProtoMember(5)] public     justFetchMsgConfig  {get;set;} int = 0;
        [ProtoMember(6)] public     type  {get;set;} int = 0;
        [ProtoMember(7)] public     version  {get;set;} int = 0;
        [ProtoMember(8)] public     aioKeywordVersion  {get;set;} int = 0
    }

    [ProtoContract] class Robot{[ProtoMember(1)] public     version  {get;set;} int = 0;
        [ProtoMember(2)] public     uinRange  {get;set;} List<UinRange> = new();
        [ProtoMember(3)] public     fireKeywords  {get;set;} List<String> = new();
        [ProtoMember(4)] public     startKeywords  {get;set;} List<String> = new();
        [ProtoMember(5)] public     endKeywords  {get;set;} List<String> = new();
        [ProtoMember(6)] public     sessionTimeout  {get;set;} int = 0;
        [ProtoMember(7)] public     subscribeCategories  {get;set;} List<RobotSubscribeCategory> = new()
    }

    [ProtoContract] class RobotSubscribeCategory{[ProtoMember(1)] public     id  {get;set;} int = 0;
        [ProtoMember(2)] public     name  {get;set;} string = "";
        [ProtoMember(3)] public     type  {get;set;} int = 0;
        [ProtoMember(4)] public     nextWording  {get;set;} string = "";
        [ProtoMember(5)] public     nextContent  {get;set;} string = ""
    }

    [ProtoContract] class RspBody{[ProtoMember(1)] public     msgSeqInfo  {get;set;} List<MsgSeqInfo> = new();
        [ProtoMember(2)] public     maxAioMsg  {get;set;} long = 0L;
        [ProtoMember(3)] public     maxPositionMsg  {get;set;} long = 0L;
        [ProtoMember(4)] public     msgGroupMsgConfig  {get;set;} GroupMsgConfig? = null;
        [ProtoMember(5)] public     robotConfig  {get;set;} Robot? = null;
        [ProtoMember(6)] public     aioKeywordConfig  {get;set;} AioKeyword? = null
    }

    [ProtoContract] class UinRange{[ProtoMember(1)] public     startUin  {get;set;} long = 0L;
        [ProtoMember(2)] public     endUin  {get;set;} long = 0L
    }
}


[ProtoContract] class Oidb0x8a0  {
    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   optUint64GroupCode  {get;set;} long = 0L;
       [ProtoMember(2)] public   msgKickResult  {get;set;} List<KickResult> = new()
    }

    [ProtoContract] class KickResult(
       [ProtoMember(1)] public   optUint32Result  {get;set;} int = 0;
       [ProtoMember(2)] public   optUint64MemberUin  {get;set;} long = 0L
    }

    [ProtoContract] class KickMemberInfo(
       [ProtoMember(1)] public   optUint32Operate  {get;set;} int = 0;
       [ProtoMember(2)] public   optUint64MemberUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   optUint32Flag  {get;set;} int = 0;
       [ProtoMember(4)] public   optBytesMsg  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   optUint64GroupCode  {get;set;} long = 0L;
       [ProtoMember(2)] public   msgKickList  {get;set;} List<KickMemberInfo> = new();
       [ProtoMember(3)] public   kickList  {get;set;} List<Long> = new();
       [ProtoMember(4)] public   kickFlag  {get;set;} int = 0;
       [ProtoMember(5)] public   kickMsg  {get;set;} byte[] = Array.Empty<byte>()
    }
}


[ProtoContract] class Oidb0x8fc  {
    [ProtoContract] class CardNameElem(
       [ProtoMember(1)] public   enumCardType  {get;set;} int /* enum */ = 1;
       [ProtoMember(2)] public   value  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class CommCardNameBuf(
       [ProtoMember(1)] public   richCardName  {get;set;} List<RichCardNameElem> = new()
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(2)] public   showFlag  {get;set;} int = 0;
       [ProtoMember(3)] public   memLevelInfo  {get;set;} List<MemberInfo> = new();
       [ProtoMember(4)] public   levelName  {get;set;} List<LevelName> = new();
       [ProtoMember(5)] public   updateTime  {get;set;} int = 0;
       [ProtoMember(6)] public   officeMode  {get;set;} int = 0;
       [ProtoMember(7)] public   groupOpenAppid  {get;set;} int = 0;
       [ProtoMember(8)] public   msgClientInfo  {get;set;} ClientInfo? = null;
       [ProtoMember(9)] public   authKey  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class MemberInfo(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L;
       [ProtoMember(2)] public   point  {get;set;} int = 0;
       [ProtoMember(3)] public   activeDay  {get;set;} int = 0;
       [ProtoMember(4)] public   level  {get;set;} int = 0;
       [ProtoMember(5)] public   specialTitle  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   specialTitleExpireTime  {get;set;} int = 0;
       [ProtoMember(7)] public   uinName  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(8)] public   memberCardName  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(9)] public   phone  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(10)] public   email  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(11)] public   remark  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(12)] public   gender  {get;set;} int = 0;
       [ProtoMember(13)] public   job  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(14)] public   tribeLevel  {get;set;} int = 0;
       [ProtoMember(15)] public   tribePoint  {get;set;} int = 0;
       [ProtoMember(16)] public   richCardName  {get;set;} List<CardNameElem> = new();
       [ProtoMember(17)] public   commRichCardName  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class RichCardNameElem(
       [ProtoMember(1)] public   ctrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   text  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(2)] public   errInfo  {get;set;} string = ""
    }

    [ProtoContract] class ClientInfo(
       [ProtoMember(1)] public   implat  {get;set;} int = 0;
       [ProtoMember(2)] public   ingClientver  {get;set;} string = ""
    }

    [ProtoContract] class LevelName(
       [ProtoMember(1)] public   level  {get;set;} int = 0;
       [ProtoMember(2)] public   name  {get;set;} string = ""
    }
}

[ProtoContract] class Oidb0x88d  {
    [ProtoContract] class GroupExInfoOnly(
       [ProtoMember(1)] public   tribeId  {get;set;} int = 0;
       [ProtoMember(2)] public   moneyForAddGroup  {get;set;} int = 0
    }

    [ProtoContract] class ReqGroupInfo(
       [ProtoMember(1)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(2)] public   stgroupinfo  {get;set;} GroupInfo? = null;
       [ProtoMember(3)] public   lastGetGroupNameTime  {get;set;} int = 0
    }

    [ProtoContract] class RspGroupInfo(
       [ProtoMember(1)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(2)] public   result  {get;set;} int = 0;
       [ProtoMember(3)] public   stgroupinfo  {get;set;} GroupInfo? = null
    }

    [ProtoContract] class GroupGeoInfo(
       [ProtoMember(1)] public   owneruin  {get;set;} long = 0L;
       [ProtoMember(2)] public   settime  {get;set;} int = 0;
       [ProtoMember(3)] public   cityid  {get;set;} int = 0;
       [ProtoMember(4)] public   int64Longitude  {get;set;} long = 0L;
       [ProtoMember(5)] public   int64Latitude  {get;set;} long = 0L;
       [ProtoMember(6)] public   geocontent  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(7)] public   poiId  {get;set;} long = 0L
    }

    [ProtoContract] class TagRecord(
       [ProtoMember(1)] public   fromUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(3)] public   tagId  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   setTime  {get;set;} long = 0L;
       [ProtoMember(5)] public   goodNum  {get;set;} int = 0;
       [ProtoMember(6)] public   badNum  {get;set;} int = 0;
       [ProtoMember(7)] public   tagLen  {get;set;} int = 0;
       [ProtoMember(8)] public   tagValue  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class GroupInfo(
       [ProtoMember(1)] public   groupOwner  {get;set;} long? = null;
       [ProtoMember(2)] public   groupCreateTime  {get;set;} int? = null;
       [ProtoMember(3)] public   groupFlag  {get;set;} int? = null;
       [ProtoMember(4)] public   groupFlagExt  {get;set;} int? = null;
       [ProtoMember(5)] public   groupMemberMaxNum  {get;set;} int? = null;
       [ProtoMember(6)] public   groupMemberNum  {get;set;} int? = null;
       [ProtoMember(7)] public   groupOption  {get;set;} int? = null;
       [ProtoMember(8)] public   groupClassExt  {get;set;} int? = null;
       [ProtoMember(9)] public   groupSpecialClass  {get;set;} int? = null;
       [ProtoMember(10)] public   groupLevel  {get;set;} int? = null;
       [ProtoMember(11)] public   groupFace  {get;set;} int? = null;
       [ProtoMember(12)] public   groupDefaultPage  {get;set;} int? = null;
       [ProtoMember(13)] public   groupInfoSeq  {get;set;} int? = null;
       [ProtoMember(14)] public   groupRoamingTime  {get;set;} int? = null;
       [ProtoMember(15)] public   groupName  {get;set;} string? = null;
       [ProtoMember(16)] public   groupMemo  {get;set;} string? = null;
       [ProtoMember(17)] public   ingGroupFingerMemo  {get;set;} string? = null;
       [ProtoMember(18)] public   ingGroupClassText  {get;set;} string? = null;
       [ProtoMember(19)] public   groupAllianceCode  {get;set;} List<int> = new();
       [ProtoMember(20)] public   groupExtraAdmNum  {get;set;} int? = null;
       [ProtoMember(21)] public   groupUin  {get;set;} long? = null;
       [ProtoMember(22)] public   groupCurMsgSeq  {get;set;} int? = null;
       [ProtoMember(23)] public   groupLastMsgTime  {get;set;} int? = null;
       [ProtoMember(24)] public   ingGroupQuestion  {get;set;} string? = null;
       [ProtoMember(25)] public   ingGroupAnswer  {get;set;} string? = null;
       [ProtoMember(26)] public   groupVisitorMaxNum  {get;set;} int? = null;
       [ProtoMember(27)] public   groupVisitorCurNum  {get;set;} int? = null;
       [ProtoMember(28)] public   levelNameSeq  {get;set;} int? = null;
       [ProtoMember(29)] public   groupAdminMaxNum  {get;set;} int? = null;
       [ProtoMember(30)] public   groupAioSkinTimestamp  {get;set;} int? = null;
       [ProtoMember(31)] public   groupBoardSkinTimestamp  {get;set;} int? = null;
       [ProtoMember(32)] public   ingGroupAioSkinUrl  {get;set;} string? = null;
       [ProtoMember(33)] public   ingGroupBoardSkinUrl  {get;set;} string? = null;
       [ProtoMember(34)] public   groupCoverSkinTimestamp  {get;set;} int? = null;
       [ProtoMember(35)] public   ingGroupCoverSkinUrl  {get;set;} string? = null;
       [ProtoMember(36)] public   groupGrade  {get;set;} int? = null;
       [ProtoMember(37)] public   activeMemberNum  {get;set;} int? = null;
       [ProtoMember(38)] public   certificationType  {get;set;} int? = null;
       [ProtoMember(39)] public   ingCertificationText  {get;set;} string? = null;
       [ProtoMember(40)] public   ingGroupRichFingerMemo  {get;set;} string? = null;
       [ProtoMember(41)] public   tagRecord  {get;set;} List<TagRecord> = new();
       [ProtoMember(42)] public   groupGeoInfo  {get;set;} GroupGeoInfo? = null;
       [ProtoMember(43)] public   headPortraitSeq  {get;set;} int? = null;
       [ProtoMember(44)] public   msgHeadPortrait  {get;set;} GroupHeadPortrait? = null;
       [ProtoMember(45)] public   shutupTimestamp  {get;set;} int? = null;
       [ProtoMember(46)] public   shutupTimestampMe  {get;set;} int? = null;
       [ProtoMember(47)] public   createSourceFlag  {get;set;} int? = null;
       [ProtoMember(48)] public   cmduinMsgSeq  {get;set;} int? = null;
       [ProtoMember(49)] public   cmduinJoinTime  {get;set;} int? = null;
       [ProtoMember(50)] public   cmduinUinFlag  {get;set;} int? = null;
       [ProtoMember(51)] public   cmduinFlagEx  {get;set;} int? = null;
       [ProtoMember(52)] public   cmduinNewMobileFlag  {get;set;} int? = null;
       [ProtoMember(53)] public   cmduinReadMsgSeq  {get;set;} int? = null;
       [ProtoMember(54)] public   cmduinLastMsgTime  {get;set;} int? = null;
       [ProtoMember(55)] public   groupTypeFlag  {get;set;} int? = null;
       [ProtoMember(56)] public   appPrivilegeFlag  {get;set;} int? = null;
       [ProtoMember(57)] public   stGroupExInfo  {get;set;} GroupExInfoOnly? = null;
       [ProtoMember(58)] public   groupSecLevel  {get;set;} int? = null;
       [ProtoMember(59)] public   groupSecLevelInfo  {get;set;} int? = null;
       [ProtoMember(60)] public   cmduinPrivilege  {get;set;} int? = null;
       [ProtoMember(61)] public   ingPoidInfo  {get;set;} byte[]? = null;
       [ProtoMember(62)] public   cmduinFlagEx2  {get;set;} int? = null;
       [ProtoMember(63)] public   confUin  {get;set;} long? = null;
       [ProtoMember(64)] public   confMaxMsgSeq  {get;set;} int? = null;
       [ProtoMember(65)] public   confToGroupTime  {get;set;} int? = null;
       [ProtoMember(66)] public   passwordRedbagTime  {get;set;} int? = null;
       [ProtoMember(67)] public   subscriptionUin  {get;set;} long? = null;
       [ProtoMember(68)] public   memberListChangeSeq  {get;set;} int? = null;
       [ProtoMember(69)] public   membercardSeq  {get;set;} int? = null;
       [ProtoMember(70)] public   rootId  {get;set;} long? = null;
       [ProtoMember(71)] public   parentId  {get;set;} long? = null;
       [ProtoMember(72)] public   teamSeq  {get;set;} int? = null;
       [ProtoMember(73)] public   historyMsgBeginTime  {get;set;} long? = null;
       [ProtoMember(74)] public   inviteNoAuthNumLimit  {get;set;} long? = null;
       [ProtoMember(75)] public   cmduinHistoryMsgSeq  {get;set;} int? = null;
       [ProtoMember(76)] public   cmduinJoinMsgSeq  {get;set;} int? = null;
       [ProtoMember(77)] public   groupFlagext3  {get;set;} int? = null;
       [ProtoMember(78)] public   groupOpenAppid  {get;set;} int? = null;
       [ProtoMember(79)] public   isConfGroup  {get;set;} int? = null;
       [ProtoMember(80)] public   isModifyConfGroupFace  {get;set;} int? = null;
       [ProtoMember(81)] public   isModifyConfGroupName  {get;set;} int? = null;
       [ProtoMember(82)] public   noFingerOpenFlag  {get;set;} int? = null;
       [ProtoMember(83)] public   noCodeFingerOpenFlag  {get;set;} int? = null;
       [ProtoMember(84)] public   autoAgreeJoinGroupUserNumForNormalGroup  {get;set;} int? = null;
       [ProtoMember(85)] public   autoAgreeJoinGroupUserNumForConfGroup  {get;set;} int? = null;
       [ProtoMember(86)] public   isAllowConfGroupMemberNick  {get;set;} int? = null;
       [ProtoMember(87)] public   isAllowConfGroupMemberAtAll  {get;set;} int? = null;
       [ProtoMember(88)] public   isAllowConfGroupMemberModifyGroupName  {get;set;} int? = null;
       [ProtoMember(89)] public   longGroupName  {get;set;} string? = null;
       [ProtoMember(90)] public   cmduinJoinRealMsgSeq  {get;set;} int? = null;
       [ProtoMember(91)] public   isGroupFreeze  {get;set;} int? = null;
       [ProtoMember(92)] public   msgLimitFrequency  {get;set;} int? = null;
       [ProtoMember(93)] public   joinGroupAuth  {get;set;} byte[]? = null;
       [ProtoMember(94)] public   hlGuildAppid  {get;set;} int? = null;
       [ProtoMember(95)] public   hlGuildSubType  {get;set;} int? = null;
       [ProtoMember(96)] public   hlGuildOrgid  {get;set;} int? = null;
       [ProtoMember(97)] public   isAllowHlGuildBinary  {get;set;} int? = null;
       [ProtoMember(98)] public   cmduinRingtoneId  {get;set;} int? = null;
       [ProtoMember(99)] public   groupFlagext4  {get;set;} int? = null;
       [ProtoMember(100)] public   groupFreezeReason  {get;set;} int? = null;
    }

    [ProtoContract] class GroupHeadPortraitInfo(
       [ProtoMember(1)] public   uint32PicId  {get;set;} int = 0;
       [ProtoMember(2)] public   leftX  {get;set;} int = 0;
       [ProtoMember(3)] public   leftY  {get;set;} int = 0;
       [ProtoMember(4)] public   rightX  {get;set;} int = 0;
       [ProtoMember(5)] public   rightY  {get;set;} int = 0
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   stzrspgroupinfo  {get;set;} List<RspGroupInfo> = new();
       [ProtoMember(2)] public   errorinfo  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   appid  {get;set;} int = 0;
       [ProtoMember(2)] public   stzreqgroupinfo  {get;set;} List<ReqGroupInfo> = new();
       [ProtoMember(3)] public   pcClientVersion  {get;set;} int = 0
    }

    [ProtoContract] class GroupHeadPortrait(
       [ProtoMember(1)] public   picCnt  {get;set;} int = 0;
       [ProtoMember(2)] public   msgInfo  {get;set;} List<GroupHeadPortraitInfo> = new();
       [ProtoMember(3)] public   defaultId  {get;set;} int = 0;
       [ProtoMember(4)] public   verifyingPicCnt  {get;set;} int = 0;
       [ProtoMember(5)] public   msgVerifyingpicInfo  {get;set;} List<GroupHeadPortraitInfo> = new()
    }
}

[ProtoContract] class Oidb0x89a  {
    [ProtoContract] class GroupNewGuidelinesInfo(
       [ProtoMember(1)] public   boolEnabled  {get;set;} bool = false;
       [ProtoMember(2)] public   ingContent  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class Groupinfo(
       [ProtoMember(1)  var groupExtAdmNum  {get;set;} int? = null;
       [ProtoMember(2)  var flag  {get;set;} int? = null;
       [ProtoMember(3)  var ingGroupName  {get;set;} byte[]? = null;
       [ProtoMember(4)  var ingGroupMemo  {get;set;} byte[]? = null;
       [ProtoMember(5)  var ingGroupFingerMemo  {get;set;} byte[]? = null;
       [ProtoMember(6)  var ingGroupAioSkinUrl  {get;set;} byte[]? = null;
       [ProtoMember(7)  var ingGroupBoardSkinUrl  {get;set;} byte[]? = null;
       [ProtoMember(8)  var ingGroupCoverSkinUrl  {get;set;} byte[]? = null;
       [ProtoMember(9)  var groupGrade  {get;set;} int? = null;
       [ProtoMember(10)  var activeMemberNum  {get;set;} int? = null;
       [ProtoMember(11)  var certificationType  {get;set;} int? = null;
       [ProtoMember(12)  var ingCertificationText  {get;set;} byte[]? = null;
       [ProtoMember(13)  var ingGroupRichFingerMemo  {get;set;} byte[]? = null;
       [ProtoMember(14)  var stGroupNewguidelines  {get;set;} GroupNewGuidelinesInfo? = null;
       [ProtoMember(15)  var groupFace  {get;set;} int? = null;
       [ProtoMember(16)  var addOption  {get;set;} int? = null;
       [ProtoMember(17)  var shutupTime  {get;set;} int? = null;
       [ProtoMember(18)  var groupTypeFlag  {get;set;} int? = null;
       [ProtoMember(19)  var stringGroupTag  {get;set;} List<byte[]> = new();
       [ProtoMember(20)  var msgGroupGeoInfo  {get;set;} GroupGeoInfo? = null;
       [ProtoMember(21)  var groupClassExt  {get;set;} int? = null;
       [ProtoMember(22)  var ingGroupClassText  {get;set;} byte[]? = null;
       [ProtoMember(23)  var appPrivilegeFlag  {get;set;} int? = null;
       [ProtoMember(24)  var appPrivilegeMask  {get;set;} int? = null;
       [ProtoMember(25)  var stGroupExInfo  {get;set;} GroupExInfoOnly? = null;
       [ProtoMember(26)  var groupSecLevel  {get;set;} int? = null;
       [ProtoMember(27)  var groupSecLevelInfo  {get;set;} int? = null;
       [ProtoMember(28)  var subscriptionUin  {get;set;} long? = null;
       [ProtoMember(29)  var allowMemberInvite  {get;set;} int? = null;
       [ProtoMember(30)  var ingGroupQuestion  {get;set;} byte[]? = null;
       [ProtoMember(31)  var ingGroupAnswer  {get;set;} byte[]? = null;
       [ProtoMember(32)  var groupFlagext3  {get;set;} int? = null;
       [ProtoMember(33)  var groupFlagext3Mask  {get;set;} int? = null;
       [ProtoMember(34)  var groupOpenAppid  {get;set;} int? = null;
       [ProtoMember(35)  var noFingerOpenFlag  {get;set;} int? = null;
       [ProtoMember(36)  var noCodeFingerOpenFlag  {get;set;} int? = null;
       [ProtoMember(37)  var rootId  {get;set;} long? = null;
       [ProtoMember(38)  var msgLimitFrequency  {get;set;} int? = null
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(2)] public   errorinfo  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class GroupExInfoOnly(
       [ProtoMember(1)] public   tribeId  {get;set;} int = 0;
       [ProtoMember(2)] public   moneyForAddGroup  {get;set;} int = 0
    }

    [ProtoContract] class GroupGeoInfo(
       [ProtoMember(1)] public   cityId  {get;set;} int = 0;
       [ProtoMember(2)] public   longtitude  {get;set;} long = 0L;
       [ProtoMember(3)] public   latitude  {get;set;} long = 0L;
       [ProtoMember(4)] public   ingGeoContent  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   poiId  {get;set;} long = 0L
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(2)] public   stGroupInfo  {get;set;} Groupinfo? = null;
       [ProtoMember(3)] public   originalOperatorUin  {get;set;} long = 0L;
       [ProtoMember(4)] public   reqGroupOpenAppid  {get;set;} int = 0
    }
}

[ProtoContract] class Cmd0x7cb  {
    [ProtoContract] class ConfigItem(
       [ProtoMember(1)] public   id  {get;set;} int = 0;
       [ProtoMember(2)] public   config  {get;set;} string = ""
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   timeStamp  {get;set;} int = 0;
       [ProtoMember(2)] public   timeGap  {get;set;} int = 0;
       [ProtoMember(3)] public   commentConfigs  {get;set;} List<CommentConfig> = new();
       [ProtoMember(4)] public   attendTipsToA  {get;set;} string = "";
       [ProtoMember(5)] public   firstMsgTips  {get;set;} string = "";
       [ProtoMember(6)] public   cancleConfig  {get;set;} List<ConfigItem> = new();
       [ProtoMember(7)] public   msgDateRequest  {get;set;} DateRequest? = null;
       [ProtoMember(8)] public   msgHotLocale  {get;set;} List<byte[]> = new();//List<AppointDefine.LocaleInfo>
       [ProtoMember(9)] public   msgTopicList  {get;set;} List<TopicConfig> = new();
       [ProtoMember(10)] public   travelMsgTips  {get;set;} string = "";
       [ProtoMember(11)] public   travelProfileTips  {get;set;} string = "";
       [ProtoMember(12)] public   travelAttenTips  {get;set;} string = "";
       [ProtoMember(13)] public   topicDefault  {get;set;} int = 0
    }

    [ProtoContract] class CommentConfig(
       [ProtoMember(1)] public   appointSubject  {get;set;} int = 0;
       [ProtoMember(2)] public   msgConfigs  {get;set;} List<ConfigItem> = new()
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   timeStamp  {get;set;} int = 0
    }

    [ProtoContract] class DateRequest(
       [ProtoMember(1)] public   time  {get;set;} int = 0;
       [ProtoMember(2)] public   errMsg  {get;set;} string = ""
    }

    [ProtoContract] class TopicConfig(
       [ProtoMember(1)] public   topicId  {get;set;} int = 0;
       [ProtoMember(2)] public   topicName  {get;set;} string = "";
       [ProtoMember(3)] public   deadline  {get;set;} int = 0;
       [ProtoMember(4)] public   errDeadline  {get;set;} string = ""
    }
}

[ProtoContract] class Oidb0x87a  {
    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   country  {get;set;} string = "";
       [ProtoMember(2)] public   telephone  {get;set;} string = "";
       [ProtoMember(3)] public   resendInterval  {get;set;} int = 0;
       [ProtoMember(4)] public   guid  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   country  {get;set;} string = "";
       [ProtoMember(2)] public   telephone  {get;set;} string = "";
       [ProtoMember(3)] public   guid  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   enumButype  {get;set;} int /* enum */ = 0
    }
}

[ProtoContract] class GroupAppPb  {
    [ProtoContract] class ClientInfo(
       [ProtoMember(1)] public   platform  {get;set;} int = 0;
       [ProtoMember(2)] public   version  {get;set;} string = ""
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   fullList  {get;set;} AppList? = null;
       [ProtoMember(2)] public   groupGrayList  {get;set;} AppList? = null;
       [ProtoMember(3)] public   redPointList  {get;set;} AppList? = null;
       [ProtoMember(4)] public   cacheInterval  {get;set;} int = 0
    }

    [ProtoContract] class AppList(
       [ProtoMember(1)] public   hash  {get;set;} string = "";
       [ProtoMember(2)] public   infos  {get;set;} List<AppInfo> = new()
    }

    [ProtoContract] class AppInfo(
       [ProtoMember(1)] public   appid  {get;set;} int = 0;
       [ProtoMember(2)] public   icon  {get;set;} string = "";
       [ProtoMember(3)] public   name  {get;set;} string = "";
       [ProtoMember(4)] public   url  {get;set;} string = "";
       [ProtoMember(5)] public   isGray  {get;set;} int = 0;
       [ProtoMember(6)] public   iconSimpleDay  {get;set;} string = "";
       [ProtoMember(7)] public   iconSimpleNight  {get;set;} string = ""
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   client  {get;set;} ClientInfo? = null;
       [ProtoMember(2)] public   groupId  {get;set;} long = 0L;
       [ProtoMember(3)] public   groupType  {get;set;} int = 0;
       [ProtoMember(4)] public   fullListHash  {get;set;} string = "";
       [ProtoMember(5)] public   groupGrayListHash  {get;set;} string = ""
    }
}

[ProtoContract] class Oidb0xc34  {
    [ProtoContract] class RspBody 

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L
    }
}

[ProtoContract] class Cmd0x5fd  {
    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   msgComment  {get;set;} AppointDefine.DateComment? = null;
       [ProtoMember(2)] public   maxFetchCount  {get;set;} int = 0;
       [ProtoMember(3)] public   lastCommentId  {get;set;} string = ""
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   msgComment  {get;set;} List<AppointDefine.DateComment> = new();
       [ProtoMember(2)] public   errorTips  {get;set;} string = "";
       [ProtoMember(3)] public   clearCacheFlag  {get;set;} int = 0;
       [ProtoMember(4)] public   commentWording  {get;set;} string = "";
       [ProtoMember(5)] public   commentNum  {get;set;} int = 0
    }
}

[ProtoContract] class Oidb0xbcb  {
    [ProtoContract] class CheckUrlReqItem(
       [ProtoMember(1)] public   url  {get;set;} string = "";
       [ProtoMember(2)] public   refer  {get;set;} string = "";
       [ProtoMember(3)] public   plateform  {get;set;} string = "";
       [ProtoMember(4)] public   qqPfTo  {get;set;} string = "";
       [ProtoMember(5)] public   msgType  {get;set;} int = 0;
       [ProtoMember(6)] public   msgFrom  {get;set;} int = 0;
       [ProtoMember(7)] public   msgChatid  {get;set;} long = 0L;
       [ProtoMember(8)] public   serviceType  {get;set;} long = 0L;
       [ProtoMember(9)] public   sendUin  {get;set;} long = 0L;
       [ProtoMember(10)] public   reqType  {get;set;} string = ""
    }

    [ProtoContract] class CheckUrlRsp(
       [ProtoMember(1)] public   results  {get;set;} List<UrlCheckResult> = new();
       [ProtoMember(2)] public   nextReqDuration  {get;set;} int = 0
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(9)] public   notUseCache  {get;set;} int = 0;
       [ProtoMember(10)] public   checkUrlReq  {get;set;} CheckUrlReq? = null
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   wording  {get;set;} string = "";
       [ProtoMember(10)] public   checkUrlRsp  {get;set;} CheckUrlRsp? = null
    }

    [ProtoContract] class CheckUrlReq(
       [ProtoMember(1)] public   url  {get;set;} List<String> = new();
       [ProtoMember(2)] public   refer  {get;set;} string = "";
       [ProtoMember(3)] public   plateform  {get;set;} string = "";
       [ProtoMember(4)] public   qqPfTo  {get;set;} string = "";
       [ProtoMember(5)] public   msgType  {get;set;} int = 0;
       [ProtoMember(6)] public   msgFrom  {get;set;} int = 0;
       [ProtoMember(7)] public   msgChatid  {get;set;} long = 0L;
       [ProtoMember(8)] public   serviceType  {get;set;} long = 0L;
       [ProtoMember(9)] public   sendUin  {get;set;} long = 0L;
       [ProtoMember(10)] public   reqType  {get;set;} string = "";
       [ProtoMember(11)] public   originalUrl  {get;set;} string = ""
    }

    [ProtoContract] class UrlCheckResult(
       [ProtoMember(1)] public   url  {get;set;} string = "";
       [ProtoMember(2)] public   result  {get;set;} int = 0;
       [ProtoMember(3)] public   jumpResult  {get;set;} int = 0;
       [ProtoMember(4)] public   jumpUrl  {get;set;} string = "";
       [ProtoMember(5)] public   level  {get;set;} int = 0;
       [ProtoMember(6)] public   subLevel  {get;set;} int = 0;
       [ProtoMember(7)] public   umrtype  {get;set;} int = 0;
       [ProtoMember(8)] public   retFrom  {get;set;} int = 0;
       [ProtoMember(9)] public   operationBit  {get;set;} long = 0L
    }
}

[ProtoContract] class Oidb0xbfe  {
    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   receiveStatus  {get;set;} int = 0;
       [ProtoMember(2)] public   jumpUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   flag  {get;set;} int = 0
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L
    }
}

[ProtoContract] class Oidb0xbe8  {
    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L;
       [ProtoMember(2)] public   enumOpCode  {get;set;} int /* enum */ = 1;
       [ProtoMember(3)] public   rspOfPopupFlag  {get;set;} int = 0;
       [ProtoMember(4)] public   popupCountNow  {get;set;} int = 0
    }

    [ProtoContract] class PopupResult(
       [ProtoMember(1)] public   popupResult  {get;set;} int = 0;
       [ProtoMember(2)] public   popupFieldid  {get;set;} int = 0
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L;
       [ProtoMember(2)] public   enumOpCode  {get;set;} int /* enum */ = 1;
       [ProtoMember(3)] public   reqOfPopupFlag  {get;set;} int = 0;
       [ProtoMember(4)] public   rstOfPopupFlag  {get;set;} int = 0;
       [ProtoMember(5)] public   mqq808WelcomepageFlag  {get;set;} int = 0;
       [ProtoMember(6)] public   msgPopupResult  {get;set;} List<PopupResult> = new()
    }
}

[ProtoContract] class Cmd0x7de  {
    [ProtoContract] class UserProfile(
       [ProtoMember(1)] public   msgPublisherInfo  {get;set;} AppointDefine.PublisherInfo? = null;
       [ProtoMember(2)] public   msgAppointsInfo  {get;set;} AppointDefine.AppointInfo? = null;
       [ProtoMember(3)] public   msgVistorInfo  {get;set;} List<AppointDefine.StrangerInfo> = new()
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   msgHead  {get;set;} BusiRespHead? = null;
       [ProtoMember(2)] public   msgUserList  {get;set;} List<UserProfile> = new();
       [ProtoMember(3)] public   ended  {get;set;} int = 0;
       [ProtoMember(4)] public   cookie  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class BusiRespHead(
       [ProtoMember(1)] public   int32Version  {get;set;} int = 1;
       [ProtoMember(2)] public   int32Seq  {get;set;} int = 0;
       [ProtoMember(3)] public   int32ReplyCode  {get;set;} int = 0;
       [ProtoMember(4)] public   result  {get;set;} string = ""
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   msgHead  {get;set;} BusiReqHead? = null;
       [ProtoMember(2)] public   msgLbsInfo  {get;set;} AppointDefine.LBSInfo? = null;
       [ProtoMember(3)] public   time  {get;set;} int = 0;
       [ProtoMember(4)] public   subject  {get;set;} int = 0;
       [ProtoMember(5)] public   gender  {get;set;} int = 0;
       [ProtoMember(6)] public   ageLow  {get;set;} int = 0;
       [ProtoMember(7)] public   ageUp  {get;set;} int = 0;
       [ProtoMember(8)] public   profession  {get;set;} int = 0;
       [ProtoMember(9)] public   cookie  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(10)] public   msgDestination  {get;set;} AppointDefine.LocaleInfo? = null
    }

    [ProtoContract] class BusiReqHead(
       [ProtoMember(1)] public   int32Version  {get;set;} int = 1;
       [ProtoMember(2)] public   int32Seq  {get;set;} int = 0
    }
}

[ProtoContract] class Cmd0x7a8  {
    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   reqUin  {get;set;} long = 0L;
       [ProtoMember(11)] public   onlyObtained  {get;set;} int = 0;
       [ProtoMember(12)] public   readReport  {get;set;} int = 0;
       [ProtoMember(13)] public   sortType  {get;set;} int = 0;
       [ProtoMember(14)] public   onlyNew  {get;set;} int = 0;
       [ProtoMember(15)] public   filterMedalIds  {get;set;} List<int> = new();
       [ProtoMember(16)] public   onlySummary  {get;set;} int = 0;
       [ProtoMember(17)] public   doScan  {get;set;} int = 0;
       [ProtoMember(18)] public   startTimestamp  {get;set;} int = 0
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   nick  {get;set;} string = "";
       [ProtoMember(2)] public   metalRank  {get;set;} int = 0;
       [ProtoMember(3)] public   friCount  {get;set;} int = 0;
       [ProtoMember(4)] public   metalCount  {get;set;} int = 0;
       [ProtoMember(5)] public   metalTotal  {get;set;} int = 0;
       [ProtoMember(6)] public   msgMedal  {get;set;} List<Common.MedalInfo> = new();
       [ProtoMember(8)] public   totalPoint  {get;set;} int = 0;
       [ProtoMember(9)] public   int32NewCount  {get;set;} int = 0;
       [ProtoMember(10)] public   int32UpgradeCount  {get;set;} int = 0;
       [ProtoMember(11)] public   promptParams  {get;set;} string = "";
       [ProtoMember(12)] public   now  {get;set;} int = 0
    }

    [ProtoContract] class MedalNews(
       [ProtoMember(1)] public   friUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   friNick  {get;set;} string = "";
       [ProtoMember(3)] public   msgMedal  {get;set;} Common.MedalInfo? = null
    }
}


[ProtoContract] class Cmd0x5fe  {
    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   msgAppointId  {get;set;} AppointDefine.AppointID? = null;
       [ProtoMember(2)] public   commentId  {get;set;} string = "";
       [ProtoMember(3)] public   fetchOldCount  {get;set;} int = 0;
       [ProtoMember(4)] public   fetchNewCount  {get;set;} int = 0
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   msgComment  {get;set;} List<AppointDefine.DateComment> = new();
       [ProtoMember(2)] public   errorTips  {get;set;} string = "";
       [ProtoMember(3)] public   fetchOldOver  {get;set;} int = 0;
       [ProtoMember(4)] public   fetchNewOver  {get;set;} int = 0
    }
}

[ProtoContract] class Oidb0xc35  {
    [ProtoContract] class RspBody 

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L;
       [ProtoMember(2)] public   msgExposeInfo  {get;set;} List<ExposeItem> = new()
    }

    [ProtoContract] class ExposeItem(
       [ProtoMember(1)] public   friend  {get;set;} long = 0L;
       [ProtoMember(2)] public   pageId  {get;set;} int = 0;
       [ProtoMember(3)] public   entranceId  {get;set;} int = 0;
       [ProtoMember(4)] public   actionId  {get;set;} int = 0;
       [ProtoMember(5)] public   exposeCount  {get;set;} int = 0;
       [ProtoMember(6)] public   exposeTime  {get;set;} int = 0;
       [ProtoMember(7)] public   algoBuffer  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(8)] public   addition  {get;set;} byte[] = Array.Empty<byte>()
    }
}

[ProtoContract] class Oidb0xc0d  {
    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   completedTaskStamp  {get;set;} long = 0L;
       [ProtoMember(2)] public   errMsg  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L;
       [ProtoMember(2)] public   taskType  {get;set;} int = 0;
       [ProtoMember(3)] public   taskPoint  {get;set;} int = 0
    }
}

[ProtoContract] class OidbSso  {
    [ProtoContract] class OIDBSSOPkg(
       [ProtoMember(1)] public   command  {get;set;} int = 0;
       [ProtoMember(2)] public   serviceType  {get;set;} int;
       [ProtoMember(3)] public   result  {get;set;} int = 0;
       [ProtoMember(4)] public   bodybuffer  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   errorMsg  {get;set;} string = "";
       [ProtoMember(6)] public   clientVersion  {get;set;} string = ""
    }; Packet {
        fun checkSuccess(actionName  {get;set;} string) {
            check(result == 0) {
                "${actionName.capitalize()} failed. result=$result; errorMsg=$errorMsg"
            }
        }
    }
}

[ProtoContract] class Cmd0xc83  {
    [ProtoContract] class ReqBody(
       [ProtoMember(101)] public   fromUin  {get;set;} long = 0L;
       [ProtoMember(102)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(103)] public   op  {get;set;} int = 0
    }

    [ProtoContract] class RspBody(
       [ProtoMember(101)] public   result  {get;set;} int = 0;
       [ProtoMember(102)] public   retryInterval  {get;set;} int = 0
    }
}

[ProtoContract] class Cmd0xccb  {
    [ProtoContract] class GroupMsgInfo(
       [ProtoMember(1)] public   msgSeq  {get;set;} int = 0;
       [ProtoMember(2)] public   roamFlag  {get;set;} int = 0
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   type  {get;set;} int = 0;
       [ProtoMember(2)] public   destUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(4)] public   c2cMsg  {get;set;} List<C2cMsgInfo> = new();
       [ProtoMember(5)] public   groupMsg  {get;set;} List<GroupMsgInfo> = new()
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   type  {get;set;} int = 0;
       [ProtoMember(2)] public   destUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(4)] public   c2cMsg  {get;set;} List<C2cMsgInfo> = new();
       [ProtoMember(5)] public   groupMsg  {get;set;} List<GroupMsgInfo> = new();
       [ProtoMember(6)] public   resId  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class C2cMsgInfo(
       [ProtoMember(1)] public   msgSeq  {get;set;} int = 0;
       [ProtoMember(2)] public   msgTime  {get;set;} int = 0;
       [ProtoMember(3)] public   msgRandom  {get;set;} int = 0;
       [ProtoMember(4)] public   roamFlag  {get;set;} int = 0
    }
}

[ProtoContract] class Oidb0xd84  {
    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   xmitinfo  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   xmitinfo  {get;set;} byte[] = Array.Empty<byte>()
    }
}

[ProtoContract] class Oidb0x5e1  {
    [ProtoContract] class UdcUinData(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L;
       [ProtoMember(4)] public   openid  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(20002)] public   nick  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(20003)] public   country  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(20004)] public   province  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(20009)] public   gender  {get;set;} int = 0;
       [ProtoMember(20014)] public   allow  {get;set;} int = 0;
       [ProtoMember(20015)] public   faceId  {get;set;} int = 0;
       [ProtoMember(20020)] public   city  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(20027)] public   commonPlace1  {get;set;} int = 0;
       [ProtoMember(20030)] public   mss3Bitmapextra  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(20031)] public   birthday  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(20032)] public   cityId  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(20033)] public   lang1  {get;set;} int = 0;
       [ProtoMember(20034)] public   lang2  {get;set;} int = 0;
       [ProtoMember(20035)] public   lang3  {get;set;} int = 0;
       [ProtoMember(20041)] public   cityZoneId  {get;set;} int = 0;
       [ProtoMember(20056)] public   oin  {get;set;} int = 0;
       [ProtoMember(20059)] public   bubbleId  {get;set;} int = 0;
       [ProtoMember(21001)] public   mss2Identity  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(21002)] public   mss1Service  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(21003)] public   lflag  {get;set;} int = 0;
       [ProtoMember(21004)] public   extFlag  {get;set;} int = 0;
       [ProtoMember(21006)] public   basicSvrFlag  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(21007)] public   basicCliFlag  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(24101)] public   pengyouRealname  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(24103)] public   pengyouGender  {get;set;} int = 0;
       [ProtoMember(24118)] public   pengyouFlag  {get;set;} int = 0;
       [ProtoMember(26004)] public   fullBirthday  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(26005)] public   fullAge  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(26010)] public   simpleUpdateTime  {get;set;} int = 0;
       [ProtoMember(26011)] public   mssUpdateTime  {get;set;} int = 0;
       [ProtoMember(27022)] public   groupMemCreditFlag  {get;set;} int = 0;
       [ProtoMember(27025)] public   faceAddonId  {get;set;} long = 0L;
       [ProtoMember(27026)] public   musicGene  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(40323)] public   fileShareBit  {get;set;} int = 0;
       [ProtoMember(40404)] public   recommendPrivacyCtrl  {get;set;} int = 0;
       [ProtoMember(40505)] public   oldFriendChat  {get;set;} int = 0;
       [ProtoMember(40602)] public   businessBit  {get;set;} int = 0;
       [ProtoMember(41305)] public   crmBit  {get;set;} int = 0;
       [ProtoMember(41810)] public   forbidFileshareBit  {get;set;} int = 0;
       [ProtoMember(42333)] public   userLoginGuardFace  {get;set;} int = 0
    }

    [ProtoContract] class RspBody(
       [ProtoMember(11)] public   msgUinData  {get;set;} List<UdcUinData> = new();
       [ProtoMember(12)] public   uint64UnfinishedUins  {get;set;} List<Long> = new()
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   uint64Uins  {get;set;} List<Long> = new();
       [ProtoMember(2)] public   startTime  {get;set;} int = 0;
       [ProtoMember(3)] public   maxPackageSize  {get;set;} int = 0;
       [ProtoMember(4)] public   bytesOpenid  {get;set;} List<byte[]> = new();
       [ProtoMember(5)] public   appid  {get;set;} int = 0;
       [ProtoMember(20002)] public   reqNick  {get;set;} int = 0;
       [ProtoMember(20003)] public   reqCountry  {get;set;} int = 0;
       [ProtoMember(20004)] public   reqProvince  {get;set;} int = 0;
       [ProtoMember(20009)] public   reqGender  {get;set;} int = 0;
       [ProtoMember(20014)] public   reqAllow  {get;set;} int = 0;
       [ProtoMember(20015)] public   reqFaceId  {get;set;} int = 0;
       [ProtoMember(20020)] public   reqCity  {get;set;} int = 0;
       [ProtoMember(20027)] public   reqCommonPlace1  {get;set;} int = 0;
       [ProtoMember(20030)] public   reqMss3Bitmapextra  {get;set;} int = 0;
       [ProtoMember(20031)] public   reqBirthday  {get;set;} int = 0;
       [ProtoMember(20032)] public   reqCityId  {get;set;} int = 0;
       [ProtoMember(20033)] public   reqLang1  {get;set;} int = 0;
       [ProtoMember(20034)] public   reqLang2  {get;set;} int = 0;
       [ProtoMember(20035)] public   reqLang3  {get;set;} int = 0;
       [ProtoMember(20041)] public   reqCityZoneId  {get;set;} int = 0;
       [ProtoMember(20056)] public   reqOin  {get;set;} int = 0;
       [ProtoMember(20059)] public   reqBubbleId  {get;set;} int = 0;
       [ProtoMember(21001)] public   reqMss2Identity  {get;set;} int = 0;
       [ProtoMember(21002)] public   reqMss1Service  {get;set;} int = 0;
       [ProtoMember(21003)] public   reqLflag  {get;set;} int = 0;
       [ProtoMember(21004)] public   reqExtFlag  {get;set;} int = 0;
       [ProtoMember(21006)] public   reqBasicSvrFlag  {get;set;} int = 0;
       [ProtoMember(21007)] public   reqBasicCliFlag  {get;set;} int = 0;
       [ProtoMember(24101)] public   reqPengyouRealname  {get;set;} int = 0;
       [ProtoMember(24103)] public   reqPengyouGender  {get;set;} int = 0;
       [ProtoMember(24118)] public   reqPengyouFlag  {get;set;} int = 0;
       [ProtoMember(26004)] public   reqFullBirthday  {get;set;} int = 0;
       [ProtoMember(26005)] public   reqFullAge  {get;set;} int = 0;
       [ProtoMember(26010)] public   reqSimpleUpdateTime  {get;set;} int = 0;
       [ProtoMember(26011)] public   reqMssUpdateTime  {get;set;} int = 0;
       [ProtoMember(27022)] public   reqGroupMemCreditFlag  {get;set;} int = 0;
       [ProtoMember(27025)] public   reqFaceAddonId  {get;set;} int = 0;
       [ProtoMember(27026)] public   reqMusicGene  {get;set;} int = 0;
       [ProtoMember(40323)] public   reqFileShareBit  {get;set;} int = 0;
       [ProtoMember(40404)] public   reqRecommendPrivacyCtrlBit  {get;set;} int = 0;
       [ProtoMember(40505)] public   reqOldFriendChatBit  {get;set;} int = 0;
       [ProtoMember(40602)] public   reqBusinessBit  {get;set;} int = 0;
       [ProtoMember(41305)] public   reqCrmBit  {get;set;} int = 0;
       [ProtoMember(41810)] public   reqForbidFileshareBit  {get;set;} int = 0;
       [ProtoMember(42333)] public   userLoginGuardFace  {get;set;} int = 0
    }
}

[ProtoContract] class Oidb0xc90  {
    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   communityBid  {get;set;} List<Long> = new();
       [ProtoMember(2)] public   page  {get;set;} int = 0
    }

    [ProtoContract] class CommunityWebInfo(
       [ProtoMember(1)] public   communityInfoItem  {get;set;} List<CommunityConfigInfo> = new();
       [ProtoMember(2)] public   page  {get;set;} int = 0;
       [ProtoMember(3)] public   end  {get;set;} int = 0
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   communityInfoItem  {get;set;} List<CommunityConfigInfo> = new();
       [ProtoMember(2)] public   jumpConcernCommunityUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   communityTitleWording  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   moreUrlWording  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   webCommunityInfo  {get;set;} CommunityWebInfo? = null;
       [ProtoMember(6)] public   jumpCommunityChannelUrl  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class CommunityConfigInfo(
       [ProtoMember(1)] public   jumpHomePageUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   name  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   picUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   dynamicCount  {get;set;} int = 0;
       [ProtoMember(5)] public   communityBid  {get;set;} long = 0L;
       [ProtoMember(6)] public   followStatus  {get;set;} int = 0
    }
}

[ProtoContract] class Cmd0xd8a  {
    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   retcode  {get;set;} int = 0;
       [ProtoMember(2)] public   res  {get;set;} string = ""
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L;
       [ProtoMember(2)] public   cmd  {get;set;} int = 0;
       [ProtoMember(3)] public   body  {get;set;} string = "";
       [ProtoMember(4)] public   clientInfo  {get;set;} ClientInfo? = null
    }

    [ProtoContract] class ClientInfo(
       [ProtoMember(1)] public   implat  {get;set;} int = 0;
       [ProtoMember(2)] public   ingClientver  {get;set;} string = ""
    }
}

[ProtoContract] class Oidb0xb6f  {
    [ProtoContract] class ReportFreqRspBody(
       [ProtoMember(1)] public   identity  {get;set;} Identity? = null;
       [ProtoMember(4)] public   remainTimes  {get;set;} long = 0L;
       [ProtoMember(5)] public   expireTime  {get;set;} int = 0
    }

    [ProtoContract] class Identity(
       [ProtoMember(1)] public   apiName  {get;set;} string = "";
       [ProtoMember(2)] public   appid  {get;set;} int = 0;
       [ProtoMember(3)] public   apptype  {get;set;} int = 0;
       [ProtoMember(4)] public   bizid  {get;set;} int = 0;
       [ProtoMember(10)] public   intExt1  {get;set;} long = 0L;
       [ProtoMember(20)] public   ext1  {get;set;} string = ""
    }

    [ProtoContract] class ThresholdInfo(
       [ProtoMember(1)] public   thresholdPerMinute  {get;set;} long = 0L;
       [ProtoMember(2)] public   thresholdPerDay  {get;set;} long = 0L;
       [ProtoMember(3)] public   thresholdPerHour  {get;set;} long = 0L;
       [ProtoMember(4)] public   thresholdPerWeek  {get;set;} long = 0L
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   reportFreqRsp  {get;set;} ReportFreqRspBody? = null
    }

    [ProtoContract] class ReportFreqReqBody(
       [ProtoMember(1)] public   identity  {get;set;} Identity? = null;
       [ProtoMember(2)] public   invokeTimes  {get;set;} long = 1L
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   reportFreqReq  {get;set;} ReportFreqReqBody? = null
    }
}

[ProtoContract] class Cmd0x7dc  {
    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   seq  {get;set;} int = 0;
       [ProtoMember(2)] public   wording  {get;set;} string = "";
       [ProtoMember(3)] public   msgAppointInfo  {get;set;} List<AppointDefine.AppointInfo> = new()
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   seq  {get;set;} int = 0;
       [ProtoMember(2)] public   msgAppointment  {get;set;} AppointDefine.AppointContent? = null;
       [ProtoMember(3)] public   msgLbsInfo  {get;set;} AppointDefine.LBSInfo? = null;
       [ProtoMember(4)] public   overwrite  {get;set;} int = 0
    }
}

[ProtoContract] class Cmd0x7cd  {
    [ProtoContract] class AppointBrife(
       [ProtoMember(1)] public   msgPublisherInfo  {get;set;} AppointDefine.PublisherInfo? = null;
       [ProtoMember(2)] public   msgAppointsInfo  {get;set;} AppointDefine.AppointInfo? = null
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   stamp  {get;set;} int = 0;
       [ProtoMember(2)] public   over  {get;set;} int = 0;
       [ProtoMember(3)] public   next  {get;set;} int = 0;
       [ProtoMember(4)] public   msgAppointsInfo  {get;set;} List<AppointBrife> = new()
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   stamp  {get;set;} int = 0;
       [ProtoMember(2)] public   start  {get;set;} int = 0;
       [ProtoMember(3)] public   want  {get;set;} int = 0;
       [ProtoMember(4)] public   msgLbsInfo  {get;set;} AppointDefine.LBSInfo? = null;
       [ProtoMember(5)] public   msgAppointIds  {get;set;} List<AppointDefine.AppointID> = new();
       [ProtoMember(6)] public   appointOperation  {get;set;} int = 0;
       [ProtoMember(100)] public   requestUin  {get;set;} long = 0L
    }
}

[ProtoContract] class Oidb0xc0c  {
    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   isTaskCompleted  {get;set;} int = 0;
       [ProtoMember(2)] public   taskPoint  {get;set;} int = 0;
       [ProtoMember(3)] public   guideWording  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   needShowProgress  {get;set;} int = 0;
       [ProtoMember(5)] public   originalProgress  {get;set;} int = 0;
       [ProtoMember(6)] public   nowProgress  {get;set;} int = 0;
       [ProtoMember(7)] public   totalProgress  {get;set;} int = 0;
       [ProtoMember(8)] public   needExecTask  {get;set;} int = 0
    }

    [ProtoContract] class VideoSrcType(
       [ProtoMember(1)] public   sourceType  {get;set;} int = 0;
       [ProtoMember(2)] public   videoFromType  {get;set;} int = 0
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L;
       [ProtoMember(2)] public   taskType  {get;set;} int = 0;
       [ProtoMember(3)] public   rowkey  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   feedsId  {get;set;} long = 0L;
       [ProtoMember(5)] public   msgVideoFromType  {get;set;} VideoSrcType? = null
    }
}

[ProtoContract] class Cmd0x5fb  {
    [ProtoContract] class ReqInfo(
       [ProtoMember(3)] public   time  {get;set;} int = 0;
       [ProtoMember(4)] public   subject  {get;set;} int = 0;
       [ProtoMember(5)] public   gender  {get;set;} int = 0;
       [ProtoMember(6)] public   ageLow  {get;set;} int = 0;
       [ProtoMember(7)] public   ageUp  {get;set;} int = 0;
       [ProtoMember(8)] public   profession  {get;set;} int = 0;
       [ProtoMember(9)] public   cookie  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(10)] public   msgDestination  {get;set;} AppointDefine.LocaleInfo? = null
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   msgHead  {get;set;} BusiReqHead? = null;
       [ProtoMember(2)] public   msgLbsInfo  {get;set;} AppointDefine.LBSInfo? = null;
       [ProtoMember(3)] public   reqInfo  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class BusiRespHead(
       [ProtoMember(1)] public   int32Version  {get;set;} int = 1;
       [ProtoMember(2)] public   int32Seq  {get;set;} int = 0;
       [ProtoMember(3)] public   int32ReplyCode  {get;set;} int = 0;
       [ProtoMember(4)] public   result  {get;set;} string = ""
    }

    [ProtoContract] class UserProfile(
       [ProtoMember(1)] public   int64Id  {get;set;} long = 0L;
       [ProtoMember(2)] public   int32IdType  {get;set;} int = 0;
       [ProtoMember(3)] public   url  {get;set;} string = "";
       [ProtoMember(4)] public   int32PicType  {get;set;} int = 0;
       [ProtoMember(5)] public   int32SubPicType  {get;set;} int = 0;
       [ProtoMember(6)] public   title  {get;set;} string = "";
       [ProtoMember(7)] public   content  {get;set;} string = "";
       [ProtoMember(8)] public   content2  {get;set;} string = "";
       [ProtoMember(9)] public   picUrl  {get;set;} string = ""
    }

    [ProtoContract] class BusiReqHead(
       [ProtoMember(1)] public   int32Version  {get;set;} int = 1;
       [ProtoMember(2)] public   int32Seq  {get;set;} int = 0
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   msgHead  {get;set;} BusiRespHead? = null;
       [ProtoMember(2)] public   msgUserList  {get;set;} byte[] = Array.Empty<byte>()
    }
}

[ProtoContract] class Oidb0xb61  {
    [ProtoContract] class GetAppinfoReq(
       [ProtoMember(1)] public   appid  {get;set;} int = 0;
       [ProtoMember(2)] public   appType  {get;set;} int = 0;
       [ProtoMember(3)] public   platform  {get;set;} int = 0
    }

    [ProtoContract] class GetPkgUrlReq(
       [ProtoMember(1)] public   appid  {get;set;} int = 0;
       [ProtoMember(2)] public   appType  {get;set;} int = 0;
       [ProtoMember(3)] public   appVersion  {get;set;} int = 0;
       [ProtoMember(4)] public   platform  {get;set;} int = 0;
       [ProtoMember(5)] public   sysVersion  {get;set;} string = "";
       [ProtoMember(6)] public   qqVersion  {get;set;} string = ""
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   wording  {get;set;} string = "";
       [ProtoMember(2)] public   nextReqDuration  {get;set;} int = 0;
       [ProtoMember(10)] public   getAppinfoRsp  {get;set;} GetAppinfoRsp? = null;
       [ProtoMember(11)] public   getMqqappUrlRsp  {get;set;} GetPkgUrlRsp? = null
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(10)] public   getAppinfoReq  {get;set;} GetAppinfoReq? = null;
       [ProtoMember(11)] public   getMqqappUrlReq  {get;set;} GetPkgUrlReq? = null
    }

    [ProtoContract] class GetAppinfoRsp(
       [ProtoMember(1)] public   appinfo  {get;set;} Qqconnect.Appinfo? = null
    }

    [ProtoContract] class GetPkgUrlRsp(
       [ProtoMember(1)] public   appVersion  {get;set;} int = 0;
       [ProtoMember(2)] public   pkgUrl  {get;set;} string = ""
    }
}

[ProtoContract] class Oidb0xb60  {
    [ProtoContract] class GetPrivilegeReq(
       [ProtoMember(1)] public   appid  {get;set;} int = 0;
       [ProtoMember(2)] public   appType  {get;set;} int = 3
    }

    [ProtoContract] class CheckUrlReq(
       [ProtoMember(1)] public   appid  {get;set;} int = 0;
       [ProtoMember(2)] public   appType  {get;set;} int = 0;
       [ProtoMember(3)] public   url  {get;set;} string = ""
    }

    [ProtoContract] class ClientInfo(
       [ProtoMember(1)] public   platform  {get;set;} int = 0;
       [ProtoMember(2)] public   sdkVersion  {get;set;} string = "";
       [ProtoMember(3)] public   androidPackageName  {get;set;} string = "";
       [ProtoMember(4)] public   androidSignature  {get;set;} string = "";
       [ProtoMember(5)] public   iosBundleId  {get;set;} string = "";
       [ProtoMember(6)] public   pcSign  {get;set;} string = ""
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   wording  {get;set;} string = "";
       [ProtoMember(10)] public   getPrivilegeRsp  {get;set;} GetPrivilegeRsp? = null;
       [ProtoMember(11)] public   checkUrlRsp  {get;set;} CheckUrlRsp? = null
    }

    [ProtoContract] class CheckUrlRsp(
       [ProtoMember(1)] public   isAuthed  {get;set;} bool = false;
       [ProtoMember(2)] public   nextReqDuration  {get;set;} int = 0
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   clientInfo  {get;set;} ClientInfo? = null;
       [ProtoMember(10)] public   getPrivilegeReq  {get;set;} GetPrivilegeReq? = null;
       [ProtoMember(11)] public   checkUrlReq  {get;set;} CheckUrlReq? = null
    }

    [ProtoContract] class GetPrivilegeRsp(
       [ProtoMember(1)] public   apiGroups  {get;set;} List<int> = new();
       [ProtoMember(2)] public   nextReqDuration  {get;set;} int = 0;
       [ProtoMember(3)] public   apiNames  {get;set;} List<String> = new()
    }
}

[ProtoContract] class Cmd0x5fc  {
    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   lastEventId  {get;set;} long = 0L;
       [ProtoMember(2)] public   readEventId  {get;set;} long = 0L;
       [ProtoMember(3)] public   fetchCount  {get;set;} int = 0;
       [ProtoMember(4)] public   lastNearbyEventId  {get;set;} long = 0L;
       [ProtoMember(5)] public   readNearbyEventId  {get;set;} long = 0L;
       [ProtoMember(6)] public   fetchNearbyEventCount  {get;set;} int = 0;
       [ProtoMember(7)] public   lastFeedEventId  {get;set;} long = 0L;
       [ProtoMember(8)] public   readFeedEventId  {get;set;} long = 0L;
       [ProtoMember(9)] public   fetchFeedEventCount  {get;set;} int = 0
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   msgEventList  {get;set;} List<AppointDefine.DateEvent> = new();
       [ProtoMember(2)] public   actAppointIds  {get;set;} List<AppointDefine.AppointID> = new();
       [ProtoMember(3)] public   maxEventId  {get;set;} long = 0L;
       [ProtoMember(4)] public   errorTips  {get;set;} string = "";
       [ProtoMember(5)] public   msgNearbyEventList  {get;set;} List<AppointDefine.NearbyEvent> = new();
       [ProtoMember(6)] public   msgFeedEventList  {get;set;} List<AppointDefine.FeedEvent> = new();
       [ProtoMember(7)] public   maxFreshEventId  {get;set;} long = 0L
    }
}

[ProtoContract] class Oidb0xc33  {
    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   nextGap  {get;set;} int = 0;
       [ProtoMember(3)] public   newUser  {get;set;} int = 0
    }

    [ProtoContract] class ReqBody 
}

[ProtoContract] class Oidb0xc0b  {
    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   isOpenCoinEntry  {get;set;} int = 0;
       [ProtoMember(2)] public   canGetCoinCount  {get;set;} int = 0;
       [ProtoMember(3)] public   coinIconUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   lastCompletedTaskStamp  {get;set;} long = 0L;
       [ProtoMember(6)] public   cmsWording  {get;set;} List<KanDianCMSActivityInfo> = new();
       [ProtoMember(7)] public   lastCmsActivityStamp  {get;set;} long = 0L;
       [ProtoMember(8)] public   msgKandianCoinRemind  {get;set;} KanDianCoinRemind? = null;
       [ProtoMember(9)] public   msgKandianTaskRemind  {get;set;} KanDianTaskRemind? = null
    }

    [ProtoContract] class KanDianCoinRemind(
       [ProtoMember(1)] public   wording  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class KanDianTaskRemind(
       [ProtoMember(1)] public   wording  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   jumpUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   taskType  {get;set;} int = 0
    }

    [ProtoContract] class KanDianCMSActivityInfo(
       [ProtoMember(1)] public   activityId  {get;set;} long = 0L;
       [ProtoMember(2)] public   wording  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   pictureUrl  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L
    }
}

[ProtoContract] class Cmd0xc85  {
    [ProtoContract] class ReqBody(
       [ProtoMember(101)] public   fromUin  {get;set;} long = 0L;
       [ProtoMember(102)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(103)] public   op  {get;set;} int = 0;
       [ProtoMember(104)] public   intervalDays  {get;set;} int = 0
    }

    [ProtoContract] class InteractionDetailInfo(
       [ProtoMember(101)] public   continuousRecordDays  {get;set;} int = 0;
       [ProtoMember(102)] public   sendDayTime  {get;set;} int = 0;
       [ProtoMember(103)] public   recvDayTime  {get;set;} int = 0;
       [ProtoMember(104)] public   sendRecord  {get;set;} string = "";
       [ProtoMember(105)] public   recvRecord  {get;set;} string = ""
    }

    [ProtoContract] class RspBody(
       [ProtoMember(101)] public   result  {get;set;} int = 0;
       [ProtoMember(102)] public   recentInteractionTime  {get;set;} int = 0;
       [ProtoMember(103)] public   interactionDetailInfo  {get;set;} interactionDetailInfo? = null
    }
}

[ProtoContract] class Cmd0x7ce  {
    [ProtoContract] class AppintDetail(
       [ProtoMember(1)] public   msgPublisherInfo  {get;set;} AppointDefine.PublisherInfo? = null;
       [ProtoMember(2)] public   msgAppointsInfo  {get;set;} AppointDefine.AppointInfo? = null;
       [ProtoMember(3)] public   score  {get;set;} int = 0;
       [ProtoMember(4)] public   joinOver  {get;set;} int = 0;
       [ProtoMember(5)] public   joinNext  {get;set;} int = 0;
       [ProtoMember(6)] public   msgStrangerInfo  {get;set;} List<AppointDefine.StrangerInfo> = new();
       [ProtoMember(7)] public   viewOver  {get;set;} int = 0;
       [ProtoMember(8)] public   viewNext  {get;set;} int = 0;
       [ProtoMember(9)] public   msgVistorInfo  {get;set;} List<AppointDefine.StrangerInfo> = new();
       [ProtoMember(10)] public   meJoin  {get;set;} int = 0;
       [ProtoMember(12)] public   canProfile  {get;set;} int = 0;
       [ProtoMember(13)] public   profileErrmsg  {get;set;} string = "";
       [ProtoMember(14)] public   canAio  {get;set;} int = 0;
       [ProtoMember(15)] public   aioErrmsg  {get;set;} string = "";
       [ProtoMember(16)] public   sigC2C  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(17)] public   uin  {get;set;} long = 0L;
       [ProtoMember(18)] public   limited  {get;set;} int = 0;
       [ProtoMember(19)] public   msgCommentList  {get;set;} List<AppointDefine.DateComment> = new();
       [ProtoMember(20)] public   commentOver  {get;set;} int = 0;
       [ProtoMember(23)] public   meInvited  {get;set;} int = 0
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   msgAppointsInfo  {get;set;} List<AppintDetail> = new();
       [ProtoMember(2)] public   secureFlag  {get;set;} int = 0;
       [ProtoMember(3)] public   secureTips  {get;set;} string = ""
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   appointIds  {get;set;} List<AppointDefine.AppointID> = new();
       [ProtoMember(2)] public   joinStart  {get;set;} int = 0;
       [ProtoMember(3)] public   joinWant  {get;set;} int = 0;
       [ProtoMember(4)] public   viewStart  {get;set;} int = 0;
       [ProtoMember(5)] public   viewWant  {get;set;} int = 0;
       [ProtoMember(6)] public   msgLbsInfo  {get;set;} AppointDefine.LBSInfo? = null;
       [ProtoMember(7)] public   uint64Uins  {get;set;} List<Long> = new();
       [ProtoMember(8)] public   viewCommentCount  {get;set;} int = 0;
       [ProtoMember(100)] public   requestUin  {get;set;} long = 0L
    }
}

[ProtoContract] class Cmd0x7db  {
    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   wording  {get;set;} string = "";
       [ProtoMember(2)] public   msgAppointInfo  {get;set;} AppointDefine.AppointInfo? = null;
       [ProtoMember(3)] public   sigC2C  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   appointAction  {get;set;} int = 0
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   msgAppointId  {get;set;} AppointDefine.AppointID? = null;
       [ProtoMember(2)] public   appointAction  {get;set;} int = 0;
       [ProtoMember(3)] public   overwrite  {get;set;} int = 0;
       [ProtoMember(4)] public   msgAppointIds  {get;set;} List<AppointDefine.AppointID> = new()
    }
}

[ProtoContract] class Oidb0xc6c  {
    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L;
       [ProtoMember(2)] public   msgGroupInfo  {get;set;} List<GroupInfo> = new()
    }

    [ProtoContract] class GroupInfo(
       [ProtoMember(1)] public   groupUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   groupCode  {get;set;} long = 0L
    }

    [ProtoContract] class RspBody 
}

[ProtoContract] class Oidb0xc05  {
    [ProtoContract] class GetAuthAppListReq(
       [ProtoMember(1)] public   start  {get;set;} int = 0;
       [ProtoMember(2)] public   limit  {get;set;} int = 0
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   wording  {get;set;} string = "";
       [ProtoMember(10)] public   getCreateAppListRsp  {get;set;} GetCreateAppListRsp? = null;
       [ProtoMember(11)] public   getAuthAppListRsp  {get;set;} GetAuthAppListRsp? = null
    }

    [ProtoContract] class GetCreateAppListRsp(
       [ProtoMember(1)] public   totalCount  {get;set;} int = 0;
       [ProtoMember(2)] public   appinfos  {get;set;} List<Qqconnect.Appinfo> = new()
    }

    [ProtoContract] class GetAuthAppListRsp(
       [ProtoMember(1)] public   totalCount  {get;set;} int = 0;
       [ProtoMember(2)] public   appinfos  {get;set;} List<Qqconnect.Appinfo> = new();
       [ProtoMember(3)] public   curIndex  {get;set;} int = 0
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(10)] public   getCreateAppListReq  {get;set;} GetCreateAppListReq? = null;
       [ProtoMember(11)] public   getAuthAppListReq  {get;set;} GetAuthAppListReq? = null
    }

    [ProtoContract] class GetCreateAppListReq(
       [ProtoMember(1)] public   start  {get;set;} int = 0;
       [ProtoMember(2)] public   limit  {get;set;} int = 0
    }
}

[ProtoContract] class Cmd0x7da  {
    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   msgAppointIds  {get;set;} List<AppointDefine.AppointID> = new();
       [ProtoMember(2)] public   appointOperation  {get;set;} int = 0;
       [ProtoMember(3)] public   operationReason  {get;set;} int = 0;
       [ProtoMember(4)] public   overwrite  {get;set;} int = 0
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   wording  {get;set;} string = "";
       [ProtoMember(2)] public   msgAppointInfo  {get;set;} List<AppointDefine.AppointInfo> = new();
       [ProtoMember(3)] public   operationReason  {get;set;} int = 0
    }
}

[ProtoContract] class Qqconnect  {
    [ProtoContract] class MobileAppInfo(
       [ProtoMember(11)] public   androidAppInfo  {get;set;} List<AndroidAppInfo> = new();
       [ProtoMember(12)] public   iosAppInfo  {get;set;} List<IOSAppInfo> = new()
    }

    [ProtoContract] class TemplateMsgConfig(
       [ProtoMember(1)] public   serviceMsgUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   publicMsgUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   campMsgUin  {get;set;} long = 0L
    }

    [ProtoContract] class Appinfo(
       [ProtoMember(1)] public   appid  {get;set;} int = 0;
       [ProtoMember(2)] public   appType  {get;set;} int = 0;
       [ProtoMember(3)] public   platform  {get;set;} int = 0;
       [ProtoMember(4)] public   appName  {get;set;} string = "";
       [ProtoMember(5)] public   appKey  {get;set;} string = "";
       [ProtoMember(6)] public   appState  {get;set;} int = 0;
       [ProtoMember(7)] public   iphoneUrlScheme  {get;set;} string = "";
       [ProtoMember(8)] public   androidPackName  {get;set;} string = "";
       [ProtoMember(9)] public   iconUrl  {get;set;} string = "";
       [ProtoMember(10)] public   sourceUrl  {get;set;} string = "";
       [ProtoMember(11)] public   iconSmallUrl  {get;set;} string = "";
       [ProtoMember(12)] public   iconMiddleUrl  {get;set;} string = "";
       [ProtoMember(13)] public   tencentDocsAppinfo  {get;set;} TencentDocsAppinfo? = null;
       [ProtoMember(21)] public   developerUin  {get;set;} long = 0L;
       [ProtoMember(22)] public   appClass  {get;set;} int = 0;
       [ProtoMember(23)] public   appSubclass  {get;set;} int = 0;
       [ProtoMember(24)] public   remark  {get;set;} string = "";
       [ProtoMember(25)] public   iconMiniUrl  {get;set;} string = "";
       [ProtoMember(26)] public   authTime  {get;set;} long = 0L;
       [ProtoMember(27)] public   appUrl  {get;set;} string = "";
       [ProtoMember(28)] public   universalLink  {get;set;} string = "";
       [ProtoMember(29)] public   qqconnectFeature  {get;set;} int = 0;
       [ProtoMember(30)] public   isHatchery  {get;set;} int = 0;
       [ProtoMember(31)] public   testUinList  {get;set;} List<Long> = new();
       [ProtoMember(100)] public   templateMsgConfig  {get;set;} TemplateMsgConfig? = null;
       [ProtoMember(101)] public   miniAppInfo  {get;set;} MiniAppInfo? = null;
       [ProtoMember(102)] public   webAppInfo  {get;set;} WebAppInfo? = null;
       [ProtoMember(103)] public   mobileAppInfo  {get;set;} MobileAppInfo? = null
    }

    [ProtoContract] class ConnectClientInfo(
       [ProtoMember(1)] public   platform  {get;set;} int = 0;
       [ProtoMember(2)] public   sdkVersion  {get;set;} string = "";
       [ProtoMember(3)] public   systemName  {get;set;} string = "";
       [ProtoMember(4)] public   systemVersion  {get;set;} string = "";
       [ProtoMember(21)] public   androidPackageName  {get;set;} string = "";
       [ProtoMember(22)] public   androidSignature  {get;set;} string = "";
       [ProtoMember(31)] public   iosBundleId  {get;set;} string = "";
       [ProtoMember(32)] public   iosDeviceId  {get;set;} string = "";
       [ProtoMember(33)] public   iosAppToken  {get;set;} string = "";
       [ProtoMember(41)] public   pcSign  {get;set;} string = ""
    }

    [ProtoContract] class TencentDocsAppinfo(
       [ProtoMember(1)] public   openTypes  {get;set;} string = "";
       [ProtoMember(2)] public   opts  {get;set;} string = "";
       [ProtoMember(3)] public   ejs  {get;set;} string = "";
       [ProtoMember(4)] public   callbackUrlTest  {get;set;} string = "";
       [ProtoMember(5)] public   callbackUrl  {get;set;} string = "";
       [ProtoMember(6)] public   domain  {get;set;} string = "";
       [ProtoMember(7)] public   userinfoCallback  {get;set;} string = "";
       [ProtoMember(8)] public   userinfoCallbackTest  {get;set;} string = ""
    }

    [ProtoContract] class WebAppInfo(
       [ProtoMember(1)] public   websiteUrl  {get;set;} string = "";
       [ProtoMember(2)] public   provider  {get;set;} string = "";
       [ProtoMember(3)] public   icp  {get;set;} string = "";
       [ProtoMember(4)] public   callbackUrl  {get;set;} string = ""
    }

    [ProtoContract] class IOSAppInfo(
       [ProtoMember(1)] public   bundleId  {get;set;} string = "";
       [ProtoMember(2)] public   urlScheme  {get;set;} string = "";
       [ProtoMember(3)] public   storeId  {get;set;} string = ""
    }

    [ProtoContract] class MsgUinInfo(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L;
       [ProtoMember(2)] public   msgType  {get;set;} int = 0;
       [ProtoMember(3)] public   appid  {get;set;} int = 0;
       [ProtoMember(4)] public   appType  {get;set;} int = 0;
       [ProtoMember(5)] public   ctime  {get;set;} int = 0;
       [ProtoMember(6)] public   mtime  {get;set;} int = 0;
       [ProtoMember(7)] public   mpType  {get;set;} int = 0;
       [ProtoMember(100)] public   nick  {get;set;} string = "";
       [ProtoMember(101)] public   faceUrl  {get;set;} string = ""
    }

    [ProtoContract] class MiniAppInfo(
       [ProtoMember(1)] public   superUin  {get;set;} long = 0L;
       [ProtoMember(11)] public   ownerType  {get;set;} int = 0;
       [ProtoMember(12)] public   ownerName  {get;set;} string = "";
       [ProtoMember(13)] public   ownerIdCardType  {get;set;} int = 0;
       [ProtoMember(14)] public   ownerIdCard  {get;set;} string = "";
       [ProtoMember(15)] public   ownerStatus  {get;set;} int = 0
    }

    [ProtoContract] class AndroidAppInfo(
       [ProtoMember(1)] public   packName  {get;set;} string = "";
       [ProtoMember(2)] public   packSign  {get;set;} string = "";
       [ProtoMember(3)] public   apkDownUrl  {get;set;} string = ""
    }
}

[ProtoContract] class Sync  {
    [ProtoContract] class SyncAppointmentReq(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L;
       [ProtoMember(2)] public   msgAppointment  {get;set;} AppointDefine.AppointContent? = null;
       [ProtoMember(3)] public   msgGpsInfo  {get;set;} AppointDefine.GPS? = null
    }

    [ProtoContract] class SyncAppointmentRsp(
       [ProtoMember(1)] public   result  {get;set;} int = 0
    }
}

[ProtoContract] class Oidb0xc26  {
    [ProtoContract] class RgoupLabel(
       [ProtoMember(1)] public   name  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   enumType  {get;set;} int /* enum */ = 1;
       [ProtoMember(3)] public   textColor  {get;set;} RgroupColor? = null;
       [ProtoMember(4)] public   edgingColor  {get;set;} RgroupColor? = null;
       [ProtoMember(5)] public   labelAttr  {get;set;} int = 0;
       [ProtoMember(6)] public   labelType  {get;set;} int = 0
    }

    [ProtoContract] class AddFriendSource(
       [ProtoMember(1)] public   source  {get;set;} int = 0;
       [ProtoMember(2)] public   subSource  {get;set;} int = 0
    }

    [ProtoContract] class Label(
       [ProtoMember(1)] public   name  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   textColor  {get;set;} Color? = null;
       [ProtoMember(3)] public   edgingColor  {get;set;} Color? = null;
       [ProtoMember(4)] public   labelType  {get;set;} int = 0
    }

    [ProtoContract] class EntryDelay(
       [ProtoMember(1)] public   emEntry  {get;set;} int /* enum */ = 1;
       [ProtoMember(2)] public   delay  {get;set;} int = 0
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   msgPersons  {get;set;} List<MayKnowPerson> = new();
       [ProtoMember(2)] public   entryInuse  {get;set;} List<int> = new();
       [ProtoMember(3)] public   entryClose  {get;set;} List<int> = new();
       [ProtoMember(4)] public   nextGap  {get;set;} int = 0;
       [ProtoMember(5)] public   timestamp  {get;set;} int = 0;
       [ProtoMember(6)] public   msgUp  {get;set;} int = 0;
       [ProtoMember(7)] public   entryDelays  {get;set;} List<EntryDelay> = new();
       [ProtoMember(8)] public   listSwitch  {get;set;} int = 0;
       [ProtoMember(9)] public   addPageListSwitch  {get;set;} int = 0;
       [ProtoMember(10)] public   emRspDataType  {get;set;} int /* enum */ = 1;
       [ProtoMember(11)] public   msgRgroupItems  {get;set;} List<RecommendInfo> = new();
       [ProtoMember(12)] public   boolIsNewuser  {get;set;} bool = false;
       [ProtoMember(13)] public   msgTables  {get;set;} List<TabInfo> = new();
       [ProtoMember(14)] public   cookies  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class TabInfo(
       [ProtoMember(1)] public   tabId  {get;set;} int = 0;
       [ProtoMember(2)] public   recommendCount  {get;set;} int = 0;
       [ProtoMember(3)] public   tableName  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   iconUrlSelect  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   iconUrlUnselect  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   backgroundColorSelect  {get;set;} Color? = null;
       [ProtoMember(7)] public   backgroundColorUnselect  {get;set;} Color? = null
    }

    [ProtoContract] class MayKnowPerson(
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
       [ProtoMember(19)] public   onlineState  {get;set;} int = 0;
       [ProtoMember(20)] public   msgLabels  {get;set;} List<Label> = new();
       [ProtoMember(21)] public   sourceid  {get;set;} int = 0
    }

    [ProtoContract] class RecommendInfo(
       [ProtoMember(1)] public   woring  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   msgGroups  {get;set;} List<RgroupInfo> = new()
    }

    [ProtoContract] class RgroupInfo(
       [ProtoMember(1)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(2)] public   ownerUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   groupName  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   groupMemo  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   memberNum  {get;set;} int = 0;
       [ProtoMember(6)] public   groupLabel  {get;set;} List<RgoupLabel> = new();
       [ProtoMember(7)] public   groupFlagExt  {get;set;} int = 0;
       [ProtoMember(8)] public   groupFlag  {get;set;} int = 0;
       [ProtoMember(9)] public   source  {get;set;} int /* enum */ = 1;
       [ProtoMember(10)] public   tagWording  {get;set;} RgoupLabel? = null;
       [ProtoMember(11)] public   algorithm  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(12)] public   joinGroupAuth  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(13)] public   activity  {get;set;} int = 0;
       [ProtoMember(14)] public   memberMaxNum  {get;set;} int = 0;
       [ProtoMember(15)] public   int32UinPrivilege  {get;set;} int = 0
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   filterUins  {get;set;} List<Long> = new();
       [ProtoMember(2)] public   phoneBook  {get;set;} int = 0;
       [ProtoMember(3)] public   expectedUins  {get;set;} List<Long> = new();
       [ProtoMember(4)] public   emEntry  {get;set;} int /* enum */ = 1;
       [ProtoMember(5)] public   fetchRgroup  {get;set;} int = 0;
       [ProtoMember(6)] public   tabId  {get;set;} int = 0;
       [ProtoMember(7)] public   want  {get;set;} int = 80;
       [ProtoMember(8)] public   cookies  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class RgroupColor(
       [ProtoMember(1)] public   r  {get;set;} int = 0;
       [ProtoMember(2)] public   g  {get;set;} int = 0;
       [ProtoMember(3)] public   b  {get;set;} int = 0
    }

    [ProtoContract] class Color(
       [ProtoMember(1)] public   r  {get;set;} int = 0;
       [ProtoMember(2)] public   g  {get;set;} int = 0;
       [ProtoMember(3)] public   b  {get;set;} int = 0
    }
}

[ProtoContract] class Cmd0xac6  {
    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   results  {get;set;} List<OperateResult> = new();
       [ProtoMember(4)] public   metalCount  {get;set;} int = 0;
       [ProtoMember(5)] public   metalTotal  {get;set;} int = 0;
       [ProtoMember(9)] public   int32NewCount  {get;set;} int = 0;
       [ProtoMember(10)] public   int32UpgradeCount  {get;set;} int = 0;
       [ProtoMember(11)] public   promptParams  {get;set;} string = ""
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   medals  {get;set;} List<MedalReport> = new();
       [ProtoMember(2)] public   clean  {get;set;} int = 0
    }

    [ProtoContract] class MedalReport(
       [ProtoMember(1)] public   id  {get;set;} int = 0;
       [ProtoMember(2)] public   level  {get;set;} int = 0
    }

    [ProtoContract] class OperateResult(
       [ProtoMember(1)] public   id  {get;set;} int = 0;
       [ProtoMember(2)] public   int32Result  {get;set;} int = 0;
       [ProtoMember(3)] public   errmsg  {get;set;} string = ""
    }
}

[ProtoContract] class Oidb0xd32  {
    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   openid  {get;set;} string = ""
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   xmitinfo  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class XmitInfo(
       [ProtoMember(1)] public   signature  {get;set;} string = "";
       [ProtoMember(2)] public   appid  {get;set;} string = "";
       [ProtoMember(3)] public   groupid  {get;set;} string = "";
       [ProtoMember(4)] public   nonce  {get;set;} string = "";
       [ProtoMember(5)] public   timestamp  {get;set;} int = 0
    }
}

[ProtoContract] class Cmd0x7cf  {
    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   stamp  {get;set;} int = 0;
       [ProtoMember(2)] public   start  {get;set;} int = 0;
       [ProtoMember(3)] public   want  {get;set;} int = 0;
       [ProtoMember(4)] public   reqValidOnly  {get;set;} int = 0;
       [ProtoMember(5)] public   msgAppointIds  {get;set;} List<AppointDefine.AppointID> = new();
       [ProtoMember(6)] public   appointOperation  {get;set;} int = 0;
       [ProtoMember(100)] public   requestUin  {get;set;} long = 0L
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   stamp  {get;set;} int = 0;
       [ProtoMember(2)] public   over  {get;set;} int = 0;
       [ProtoMember(3)] public   next  {get;set;} int = 0;
       [ProtoMember(4)] public   msgAppointsInfo  {get;set;} List<AppointDefine.AppointInfo> = new();
       [ProtoMember(5)] public   unreadCount  {get;set;} int = 0
    }
}

[ProtoContract] class Cmd0xac7  {
    [ProtoContract] class DeviceInfo(
       [ProtoMember(1)] public   din  {get;set;} long = 0L;
       [ProtoMember(2)] public   name  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   extd  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   cmd  {get;set;} int = 0;
       [ProtoMember(2)] public   din  {get;set;} long = 0L;
       [ProtoMember(3)] public   extd  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   msgBinderSig  {get;set;} BinderSig? = null
    }

    [ProtoContract] class ReceiveMessageDevices(
       [ProtoMember(1)] public   devices  {get;set;} List<DeviceInfo> = new()
    }

    [ProtoContract] class BinderSig(
       [ProtoMember(1)] public   type  {get;set;} int = 0;
       [ProtoMember(2)] public   uin  {get;set;} long = 0L;
       [ProtoMember(3)] public   sig  {get;set;} byte[] = Array.Empty<byte>()
    }
}

[ProtoContract] class Cmd0x5fa  {
    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   msgStrangerInfo  {get;set;} List<AppointDefine.StrangerInfo> = new();
       [ProtoMember(2)] public   reachStart  {get;set;} int = 0;
       [ProtoMember(3)] public   reachEnd  {get;set;} int = 0
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   appointIds  {get;set;} AppointDefine.AppointID? = null;
       [ProtoMember(2)] public   referIdx  {get;set;} int = 0;
       [ProtoMember(3)] public   getReferRec  {get;set;} int = 0;
       [ProtoMember(4)] public   reqNextCount  {get;set;} int = 0;
       [ProtoMember(5)] public   reqPrevCount  {get;set;} int = 0
    }
}

[ProtoContract] class FavoriteCKVData  {
    [ProtoContract] class PicInfo(
       [ProtoMember(1)] public   uri  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   md5  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   sha1  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   name  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   note  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   width  {get;set;} int = 0;
       [ProtoMember(7)] public   height  {get;set;} int = 0;
       [ProtoMember(8)] public   size  {get;set;} int = 0;
       [ProtoMember(9)] public   type  {get;set;} int = 0;
       [ProtoMember(10)] public   msgOwner  {get;set;} Author? = null;
       [ProtoMember(11)] public   picId  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class KandianFavoriteItem(
       [ProtoMember(1)] public   msgFavoriteExtInfo  {get;set;} KandianFavoriteBizData? = null;
       [ProtoMember(2)] public   bytesCid  {get;set;} List<byte[]> = new();
       [ProtoMember(3)] public   type  {get;set;} int = 0;
       [ProtoMember(4)] public   status  {get;set;} int = 0;
       [ProtoMember(5)] public   msgAuthor  {get;set;} Author? = null;
       [ProtoMember(6)] public   createTime  {get;set;} long = 0L;
       [ProtoMember(7)] public   favoriteTime  {get;set;} long = 0L;
       [ProtoMember(8)] public   modifyTime  {get;set;} long = 0L;
       [ProtoMember(9)] public   dataSyncTime  {get;set;} long = 0L;
       [ProtoMember(10)] public   msgFavoriteSummary  {get;set;} FavoriteSummary? = null
    }

    [ProtoContract] class LinkSummary(
       [ProtoMember(1)] public   uri  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   title  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   publisher  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   brief  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   msgPicInfo  {get;set;} List<PicInfo> = new();
       [ProtoMember(6)] public   type  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(7)] public   resourceUri  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class UserFavoriteList(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L;
       [ProtoMember(2)] public   modifyTs  {get;set;} long = 0L;
       [ProtoMember(100)] public   msgFavoriteItems  {get;set;} List<FavoriteItem> = new()
    }

    [ProtoContract] class FavoriteSummary(
       [ProtoMember(2)] public   msgLinkSummary  {get;set;} LinkSummary? = null
    }

    [ProtoContract] class FavoriteItem(
       [ProtoMember(1)] public   favoriteSource  {get;set;} int = 0;
       [ProtoMember(100)] public   msgKandianFavoriteItem  {get;set;} KandianFavoriteItem? = null
    }

    [ProtoContract] class Author(
       [ProtoMember(1)] public   type  {get;set;} int = 0;
       [ProtoMember(2)] public   numId  {get;set;} long = 0L;
       [ProtoMember(3)] public   strId  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   groupId  {get;set;} long = 0L;
       [ProtoMember(5)] public   groupName  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class KandianFavoriteBizData(
       [ProtoMember(1)] public   rowkey  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   type  {get;set;} int = 0;
       [ProtoMember(3)] public   videoDuration  {get;set;} int = 0;
       [ProtoMember(4)] public   picNum  {get;set;} int = 0;
       [ProtoMember(5)] public   accountId  {get;set;} long = 0L;
       [ProtoMember(6)] public   accountName  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(7)] public   videoType  {get;set;} int = 0;
       [ProtoMember(8)] public   feedsId  {get;set;} long = 0L;
       [ProtoMember(9)] public   feedsType  {get;set;} int = 0
    }
}

[ProtoContract] class Cmd0x5ff  {
    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   errorTips  {get;set;} string = ""
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   msgAppointId  {get;set;} AppointDefine.AppointID? = null;
       [ProtoMember(2)] public   commentId  {get;set;} string = ""
    }
}

[ProtoContract] class Oidb0xccd  {
    [ProtoContract] class Result(
       [ProtoMember(1)] public   appid  {get;set;} int = 0;
       [ProtoMember(2)] public   errcode  {get;set;} int = 0;
       [ProtoMember(3)] public   errmsg  {get;set;} string = ""
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   int64Uin  {get;set;} long = 0L;
       [ProtoMember(2)] public   appids  {get;set;} List<int> = new();
       [ProtoMember(3)] public   platform  {get;set;} int = 0
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   errcode  {get;set;} int = 0;
       [ProtoMember(2)] public   results  {get;set;} List<Result> = new()
    }
}

[ProtoContract] class Oidb0xc36  {
    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   uint64Uins  {get;set;} List<Long> = new()
    }

    [ProtoContract] class RspBody 
}

[ProtoContract] class Oidb0x87c  {
    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   country  {get;set;} string = "";
       [ProtoMember(2)] public   telephone  {get;set;} string = "";
       [ProtoMember(3)] public   smsCode  {get;set;} string = "";
       [ProtoMember(4)] public   guid  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   enumButype  {get;set;} int /* enum */ = 0
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   country  {get;set;} string = "";
       [ProtoMember(2)] public   telephone  {get;set;} string = "";
       [ProtoMember(3)] public   keyType  {get;set;} int = 0;
       [ProtoMember(4)] public   key  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   guid  {get;set;} byte[] = Array.Empty<byte>()
    }
}

[ProtoContract] class Cmd0xbf2  {
    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   phoneAddrBook  {get;set;} List<PhoneAddrBook> = new();
       [ProtoMember(2)] public   end  {get;set;} int = 0;
       [ProtoMember(3)] public   nextIndex  {get;set;} long = 0
    }

    [ProtoContract] class PhoneAddrBook(
       [ProtoMember(1)] public   phone  {get;set;} string = "";
       [ProtoMember(2)] public   nick  {get;set;} string = "";
       [ProtoMember(3)] public   headUrl  {get;set;} string = "";
       [ProtoMember(4)] public   longNick  {get;set;} string = ""
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L;
       [ProtoMember(2)] public   startIndex  {get;set;} long = 0L;
       [ProtoMember(3)] public   num  {get;set;} long = 0L
    }
}

[ProtoContract] class Cmd0x6cd  {
    [ProtoContract] class RedpointInfo(
       [ProtoMember(1)] public   taskid  {get;set;} int = 0;
       [ProtoMember(2)] public   curSeq  {get;set;} long = 0L;
       [ProtoMember(3)] public   pullSeq  {get;set;} long = 0L;
       [ProtoMember(4)] public   readSeq  {get;set;} long = 0L;
       [ProtoMember(5)] public   pullTimes  {get;set;} int = 0;
       [ProtoMember(6)] public   lastPullTime  {get;set;} int = 0;
       [ProtoMember(7)] public   int32RemainedTime  {get;set;} int = 0;
       [ProtoMember(8)] public   lastRecvTime  {get;set;} int = 0;
       [ProtoMember(9)] public   fromId  {get;set;} long = 0L;
       [ProtoMember(10)] public   enumRedpointType  {get;set;} int /* enum */ = 1;
       [ProtoMember(11)] public   msgRedpointExtraInfo  {get;set;} RepointExtraInfo? = null;
       [ProtoMember(12)] public   configVersion  {get;set;} string = "";
       [ProtoMember(13)] public   doActivity  {get;set;} int = 0;
       [ProtoMember(14)] public   msgUnreadMsg  {get;set;} List<MessageRec> = new()
    }

    [ProtoContract] class PullRedpointReq(
       [ProtoMember(1)] public   taskid  {get;set;} int = 0;
       [ProtoMember(2)] public   lastPullSeq  {get;set;} long = 0L
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   msgRedpoint  {get;set;} List<RedpointInfo> = new();
       [ProtoMember(2)] public   unfinishedRedpoint  {get;set;} List<PullRedpointReq> = new()
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   lastPullRedpoint  {get;set;} List<PullRedpointReq> = new();
       [ProtoMember(2)] public   unfinishedRedpoint  {get;set;} List<PullRedpointReq> = new();
       [ProtoMember(3)] public   msgPullSingleTask  {get;set;} PullRedpointReq? = null;
       [ProtoMember(4)] public   retMsgRec  {get;set;} int = 0
    }

    [ProtoContract] class MessageRec(
       [ProtoMember(1)] public   seq  {get;set;} long = 0L;
       [ProtoMember(2)] public   time  {get;set;} int = 0;
       [ProtoMember(3)] public   content  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class RepointExtraInfo(
       [ProtoMember(1)] public   count  {get;set;} int = 0;
       [ProtoMember(2)] public   iconUrl  {get;set;} string = "";
       [ProtoMember(3)] public   tips  {get;set;} string = "";
       [ProtoMember(4)] public   data  {get;set;} byte[] = Array.Empty<byte>()
    }
}

[ProtoContract] class Oidb0xd55  {
    [ProtoContract] class CheckUserRsp(
       [ProtoMember(1)] public   openidUin  {get;set;} long = 0L
    }

    [ProtoContract] class CheckMiniAppRsp 

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   appid  {get;set;} long = 0L;
       [ProtoMember(2)] public   appType  {get;set;} int = 0;
       [ProtoMember(3)] public   srcId  {get;set;} int = 0;
       [ProtoMember(4)] public   rawUrl  {get;set;} string = "";
       [ProtoMember(11)] public   checkAppSignReq  {get;set;} CheckAppSignReq? = null;
       [ProtoMember(12)] public   checkUserReq  {get;set;} CheckUserReq? = null;
       [ProtoMember(13)] public   checkMiniAppReq  {get;set;} CheckMiniAppReq? = null
    }

    [ProtoContract] class CheckAppSignReq(
       [ProtoMember(1)] public   clientInfo  {get;set;} Qqconnect.ConnectClientInfo? = null
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   wording  {get;set;} string = "";
       [ProtoMember(11)] public   checkAppSignRsp  {get;set;} CheckAppSignRsp? = null;
       [ProtoMember(12)] public   checkUserRsp  {get;set;} CheckUserRsp? = null;
       [ProtoMember(13)] public   checkMiniAppRsp  {get;set;} CheckMiniAppRsp? = null
    }

    [ProtoContract] class CheckUserReq(
       [ProtoMember(1)] public   openid  {get;set;} string = "";
       [ProtoMember(2)] public   needCheckSameUser  {get;set;} int = 0
    }

    [ProtoContract] class CheckMiniAppReq(
       [ProtoMember(1)] public   miniAppAppid  {get;set;} long = 0L;
       [ProtoMember(2)] public   needCheckBind  {get;set;} int = 0
    }

    [ProtoContract] class CheckAppSignRsp(
       [ProtoMember(1)] public   iosAppToken  {get;set;} string = "";
       [ProtoMember(2)] public   iosUniversalLink  {get;set;} string = "";
       [ProtoMember(11)] public   optimizeSwitch  {get;set;} int = 0
    }
}

[ProtoContract] class Cmd0x8b4  {
    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   gc  {get;set;} long = 0L;
       [ProtoMember(2)] public   guin  {get;set;} long = 0L;
       [ProtoMember(3)] public   flag  {get;set;} int = 0;
       [ProtoMember(21)] public   dstUin  {get;set;} long = 0L;
       [ProtoMember(22)] public   start  {get;set;} int = 0;
       [ProtoMember(23)] public   cnt  {get;set;} int = 0;
       [ProtoMember(24)] public   tag  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class GroupInfo(
       [ProtoMember(1)] public   gc  {get;set;} long = 0L;
       [ProtoMember(2)] public   groupName  {get;set;} string = "";
       [ProtoMember(3)] public   faceUrl  {get;set;} string = "";
       [ProtoMember(4)] public   setDisplayTime  {get;set;} int = 0;
        // @SerialId(5)] public   groupLabel  {get;set;} List<GroupLabel.Label> = new();
       [ProtoMember(6)] public   textIntro  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(7)] public   richIntro  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class TagInfo(
       [ProtoMember(1)] public   dstUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   start  {get;set;} int = 0;
       [ProtoMember(3)] public   cnt  {get;set;} int = 0;
       [ProtoMember(4)] public   timestamp  {get;set;} int = 0;
       [ProtoMember(5)] public   _0x7ddSeq  {get;set;} int = 0
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   flag  {get;set;} int = 0;
       [ProtoMember(21)] public   tag  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(22)] public   groupInfo  {get;set;} List<GroupInfo> = new();
       [ProtoMember(23)] public   textLabel  {get;set;} List<byte[]> = new()
    }
}

[ProtoContract] class Cmd0x682  {
    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   msgChatinfo  {get;set;} List<ChatInfo> = new()
    }

    [ProtoContract] class ChatInfo(
       [ProtoMember(1)] public   touin  {get;set;} long = 0L;
       [ProtoMember(2)] public   chatflag  {get;set;} int = 0;
       [ProtoMember(3)] public   goldflag  {get;set;} int = 0;
       [ProtoMember(4)] public   totalexpcount  {get;set;} int = 0;
       [ProtoMember(5)] public   curexpcount  {get;set;} int = 0;
       [ProtoMember(6)] public   totalFlag  {get;set;} int = 0;
       [ProtoMember(7)] public   curdayFlag  {get;set;} int = 0;
       [ProtoMember(8)] public   expressTipsMsg  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(9)] public   expressMsg  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   uint64Touinlist  {get;set;} List<Long> = new()
    }
}

[ProtoContract] class Cmd0x6f5  {
    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   qqVersion  {get;set;} string = "";
       [ProtoMember(2)] public   qqPlatform  {get;set;} int = 0
    }

    [ProtoContract] class TaskInfo(
       [ProtoMember(1)] public   taskId  {get;set;} int = 0;
       [ProtoMember(2)] public   appid  {get;set;} int = 0;
       [ProtoMember(3)] public   passthroughLevel  {get;set;} int = 0;
       [ProtoMember(4)] public   showLevel  {get;set;} int = 0;
       [ProtoMember(5)] public   extra  {get;set;} int = 0;
       [ProtoMember(6)] public   priority  {get;set;} int = 0
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   configVersion  {get;set;} string = "";
       [ProtoMember(2)] public   taskInfo  {get;set;} List<TaskInfo> = new()
    }
}

[ProtoContract] class Oidb0xb7e  {
    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   topItem  {get;set;} List<DiandianTopConfig> = new()
    }

    [ProtoContract] class DiandianTopConfig(
       [ProtoMember(1)] public   jumpUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   title  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   subTitle  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   subTitleColor  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   picUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   type  {get;set;} int = 0;
       [ProtoMember(7)] public   topicId  {get;set;} int = 0
    }

    [ProtoContract] class ReqBody 
}

[ProtoContract] class Oidb0xc2f  {
    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   msgGetFollowUserRecommendListRsp  {get;set;} GetFollowUserRecommendListRsp? = null
    }

    [ProtoContract] class GetFollowUserRecommendListReq(
       [ProtoMember(1)] public   followedUin  {get;set;} long = 0L
    }

    [ProtoContract] class RecommendAccountInfo(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L;
       [ProtoMember(2)] public   accountType  {get;set;} int = 0;
       [ProtoMember(3)] public   nickName  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   headImgUrl  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   isVip  {get;set;} int = 0;
       [ProtoMember(6)] public   isStar  {get;set;} int = 0;
       [ProtoMember(7)] public   recommendReason  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class GetFollowUserRecommendListRsp(
       [ProtoMember(1)] public   msgRecommendList  {get;set;} List<RecommendAccountInfo> = new();
       [ProtoMember(2)] public   jumpUrl  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   msgGetFollowUserRecommendListReq  {get;set;} GetFollowUserRecommendListReq? = null
    }
}

[ProtoContract] class Cmd0x7ca  {
    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   msgAppointId  {get;set;} AppointDefine.AppointID? = null;
       [ProtoMember(2)] public   tinyid  {get;set;} long = 0L;
       [ProtoMember(3)] public   opType  {get;set;} int = 0
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   sigC2C  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   peerUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   errorWording  {get;set;} string = "";
       [ProtoMember(4)] public   opType  {get;set;} int = 0
    }
}

[ProtoContract] class Cmd0xd40  {
    [ProtoContract] class DeviceInfo(
       [ProtoMember(1)] public   os  {get;set;} int = 0
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   dev  {get;set;} DeviceInfo? = null;
       [ProtoMember(2)] public   src  {get;set;} int = 0;
       [ProtoMember(3)] public   event  {get;set;} int = 0;
       [ProtoMember(4)] public   redtype  {get;set;} int = 0
    }

    [ProtoContract] class RspBody 
}

[ProtoContract] class Cmd0x6ce  {
    [ProtoContract] class RspBody 

    [ProtoContract] class ReadRedpointReq(
       [ProtoMember(1)] public   taskid  {get;set;} int = 0;
       [ProtoMember(2)] public   readSeq  {get;set;} long = 0L;
       [ProtoMember(3)] public   appid  {get;set;} int = 0
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   msgReadReq  {get;set;} List<ReadRedpointReq> = new()
    }
}

[ProtoContract] class Cmd0xed3  {
    [ProtoContract] class RspBody 

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(3)] public   msgSeq  {get;set;} int = 0;
       [ProtoMember(4)] public   msgRandom  {get;set;} int = 0;
       [ProtoMember(5)] public   aioUin  {get;set;} long = 0L
    }
}
