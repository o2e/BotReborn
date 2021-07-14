/*
 * Copyright 2019-2021 Mamoe Technologies and contributors.
 *
 * 此源代码的使用受 GNU AFFERO GENERAL PUBLIC LICENSE version 3 许可证的约束; 可以在以下链接找到该许可证.
 * Use of this source code is governed by the GNU AGPLv3 license that can be found through the following link.
 *
 * https  {get;set;}//github.com/mamoe/mirai/blob/dev/LICENSE
 */

using System;
using ProtoBuf;

internal class FrdSysMsg {
    [ProtoContract] class AddFrdSNInfo{[ProtoMember(1)] public     notSeeDynamic  {get;set;} int = 0;
        [ProtoMember(2)] public     setSn  {get;set;} int = 0;
    }

    [ProtoContract] class AddFriendVerifyInfo{[ProtoMember(1)] public     type  {get;set;} int = 0;
        [ProtoMember(2)] public     url  {get;set;} string = "";
        [ProtoMember(3)] public     verifyInfo  {get;set;} string = "";
    }

    [ProtoContract] class AddtionInfo{[ProtoMember(1)] public     poke  {get;set;} int = 0;
        [ProtoMember(2)] public     format  {get;set;} int = 0;
        [ProtoMember(3)] public     entityCategory  {get;set;} string = "";
        [ProtoMember(4)] public     entityName  {get;set;} string = "";
        [ProtoMember(5)] public     entityUrl  {get;set;} string = "";
    }

    [ProtoContract] class DiscussInfo{[ProtoMember(1)] public     discussUin  {get;set;} long = 0L;
        [ProtoMember(2)] public     discussName  {get;set;} string = "";
        [ProtoMember(3)] public     discussNick  {get;set;} string = "";
    }

    [ProtoContract] class EimInfo{[ProtoMember(1)] public     eimFuin  {get;set;} long = 0L;
        [ProtoMember(2)] public     eimId  {get;set;} string = "";
        [ProtoMember(3)] public     eimTelno  {get;set;} string = "";
        [ProtoMember(4)] public     groupId  {get;set;} long = 0L;
    }

    [ProtoContract] class FriendHelloInfo{[ProtoMember(1)] public     sourceName  {get;set;} string = "";
    }

    [ProtoContract] class FriendMiscInfo{[ProtoMember(1)] public     fromuinNick  {get;set;} string = "";
    }

    [ProtoContract] class FriendSysMsg{[ProtoMember(11)] public     msgGroupExt  {get;set;} GroupInfoExt? = null;
        [ProtoMember(12)] public     msgIntiteInfo  {get;set;} InviteInfo? = null;
        [ProtoMember(13)] public     msgSchoolInfo  {get;set;} SchoolInfo? = null;
        [ProtoMember(100)] public     doubtFlag  {get;set;} int = 0;
    }

    [ProtoContract] class GroupInfo{[ProtoMember(1)] public     groupUin  {get;set;} long = 0L;
        [ProtoMember(2)] public     groupName  {get;set;} string = "";
        [ProtoMember(3)] public     groupNick  {get;set;} string = "";
    }

    [ProtoContract] class GroupInfoExt{[ProtoMember(1)] public     notifyType  {get;set;} int = 0;
        [ProtoMember(2)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(3)] public     fromGroupadmlist  {get;set;} int = 0;
    }

    [ProtoContract] class InviteInfo{[ProtoMember(1)] public     recommendUin  {get;set;} long = 0L;
    }

    [ProtoContract] class MsgEncodeFlag{[ProtoMember(1)] public     isUtf8  {get;set;} int = 0;
    }

    [ProtoContract] class SchoolInfo{[ProtoMember(1)] public     schoolId  {get;set;} string = "";
        [ProtoMember(2)] public     schoolName  {get;set;} string = "";
    }

    [ProtoContract] class TongXunLuNickInfo{[ProtoMember(1)] public     fromuin  {get;set;} long = 0L;
        [ProtoMember(2)] public     touin  {get;set;} long = 0L;
        [ProtoMember(3)] public     tongxunluNickname  {get;set;} string = "";
    }
}
