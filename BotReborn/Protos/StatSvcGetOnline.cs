/*
 * Copyright 2019-2021 Mamoe Technologies and contributors.
 *
 * 此源代码的使用受 GNU AFFERO GENERAL PUBLIC LICENSE version 3 许可证的约束; 可以在以下链接找到该许可证.
 * Use of this source code is governed by the GNU AGPLv3 license that can be found through the following link.
 *
 * https  {get;set;}//github.com/mamoe/mirai/blob/dev/LICENSE
 */


using System.Collections.Generic;
using ProtoBuf;

internal class StatSvcGetOnline {
    [ProtoContract] class Instance(
       [ProtoMember(1)] public   instanceId  {get;set;} int = 0;
       [ProtoMember(2)] public   clientType  {get;set;} int = 0
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L;
       [ProtoMember(2)] public   appid  {get;set;} int = 0
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   errorCode  {get;set;} int = 0;
       [ProtoMember(2)] public   errorMsg  {get;set;} string = "";
       [ProtoMember(3)] public   uin  {get;set;} long = 0L;
       [ProtoMember(4)] public   appid  {get;set;} int = 0;
       [ProtoMember(5)] public   timeInterval  {get;set;} int = 0;
       [ProtoMember(6)] public   msgInstances  {get;set;} List<> StatSvcGetOnline.Instance> = new()
    }
}
