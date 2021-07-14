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

import kotlin.math.absoluteValue
import kotlin.random.Random


// COMMENTED ON 2020/7/25

[ProtoContract] class SyncCookie(
   [ProtoMember(1)] public   time1  {get;set;} long? = null; // 1580277992
   [ProtoMember(2)] public   time  {get;set;} long; // 1580277992
   [ProtoMember(3)] public   unknown1  {get;set;} long = Random.nextLong().absoluteValue; // 678328038
   [ProtoMember(4)] public   unknown2  {get;set;} long = Random.nextLong().absoluteValue; // 1687142153
   [ProtoMember(5)] public   const1  {get;set;} long = const1_; // 1458467940
   [ProtoMember(11)] public   const2  {get;set;} long = const2_; // 2683038258
   [ProtoMember(12)] public   unknown3  {get;set;} long = 0x1d;
   [ProtoMember(13)] public   lastSyncTime  {get;set;} long? = null;
   [ProtoMember(14)] public   unknown4  {get;set;} long = 0;
}

private val const1_  {get;set;} long = Random.nextLong().absoluteValue
private val const2_  {get;set;} long = Random.nextLong().absoluteValue


/*

[ProtoContract] class SyncCookie(
    @SerialId(1)] public   time1  {get;set;} long? = null; // 1580277992
    @SerialId(2)] public   time  {get;set;} long; // 1580277992
    @SerialId(3)] public   unknown1  {get;set;} long = 678328038;// 678328038
    @SerialId(4)] public   unknown2  {get;set;} long = 1687142153; // 1687142153
    @SerialId(5)] public   const1  {get;set;} long = 1458467940; // 1458467940
    @SerialId(11)] public   const2  {get;set;} long = 2683038258; // 2683038258
    @SerialId(12)] public   unknown3  {get;set;} long = 0x1d;
    @SerialId(13)] public   lastSyncTime  {get;set;} long? = null;
    @SerialId(14)] public   unknown4  {get;set;} long = 0
}
 */
