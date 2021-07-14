/*
 * Copyright 2019-2021 Mamoe Technologies and contributors.
 *
 * 此源代码的使用受 GNU AFFERO GENERAL PUBLIC LICENSE version 3 许可证的约束; 可以在以下链接找到该许可证.
 * Use of this source code is governed by the GNU AGPLv3 license that can be found through the following link.
 *
 * https  {get;set;}//github.com/mamoe/mirai/blob/dev/LICENSE
 */


using ProtoBuf;

internal class MsgRevokeUserDef  {
    [ProtoContract] class MsgInfoUserDef(
       [ProtoMember(1)] public   longMessageFlag  {get;set;} int;
       [ProtoMember(2)] public   longMsgInfo  {get;set;} List<MsgInfoDef> = new();
       [ProtoMember(3)] public   fileUuid  {get;set;} List<String> = listOf()
    } {
        [ProtoContract]
        internal class MsgInfoDef(
           [ProtoMember(1)] public   msgSeq  {get;set;} int = 0;
           [ProtoMember(2)] public   longMsgId  {get;set;} int = 0;
           [ProtoMember(3)] public   longMsgNum  {get;set;} int = 0;
           [ProtoMember(4)] public   longMsgIndex  {get;set;} int = 0
        }
    }

    [ProtoContract] class UinTypeUserDef(
       [ProtoMember(1)] public   fromUinType  {get;set;} int;
       [ProtoMember(2)] public   fromGroupCode  {get;set;} long = 0L;
       [ProtoMember(3)] public   fileUuid  {get;set;} List<String> = new()
    }
}
