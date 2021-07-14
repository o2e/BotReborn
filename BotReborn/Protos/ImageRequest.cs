/*
 * Copyright 2019-2021 Mamoe Technologies and contributors.
 *
 * 此源代码的使用受 GNU AFFERO GENERAL PUBLIC LICENSE version 3 许可证的约束; 可以在以下链接找到该许可证.
 * Use of this source code is governed by the GNU AGPLv3 license that can be found through the following link.
 *
 * https  {get;set;}//github.com/mamoe/mirai/blob/dev/LICENSE
 */


using ProtoBuf;

import net.mamoe.mirai.utils.currentTimeSeconds

internal interface ImgReq 

// cmd0x352$ReqBody

[ProtoContract] class GetImgUrlReq(
   [ProtoMember(1)] public   srcUni  {get;set;} int;
   [ProtoMember(2)] public   dstUni  {get;set;} int;
   [ProtoMember(3)] public   fileResID  {get;set;} string; //UUID
    /**
     * UUID例子  {get;set;} 没有找到
     */
   [ProtoMember(4)] public   urlFlag  {get;set;} int = 1;
    //5 unknown; 好像没用
   [ProtoMember(6)] public   urlType  {get;set;} int = 4;
   [ProtoMember(7)] public   requestTerm  {get;set;} int = 5; //确定
   [ProtoMember(8)] public   requestPlatformType  {get;set;} int = 9; //确定
   [ProtoMember(9)] public   srcFileType  {get;set;} int = 1; //2=ftn，1=picplatform，255
   [ProtoMember(10)] public   innerIP  {get;set;} int = 0; //确定
   [ProtoMember(11)] public   addressBook  {get;set;} int = 0; //[ChatType.internalID]== 1006为1[为CONTACT时] 我觉得发0没问题
   [ProtoMember(12)] public   buType  {get;set;} int = 1; //确定
   [ProtoMember(13)] public   buildVer  {get;set;} string = "8.2.7.4410"; //版本号
   [ProtoMember(14)] public   timestamp  {get;set;} int = currentTimeSeconds().toInt(); //(pic_up_timestamp)
   [ProtoMember(15)] public   requestTransferType  {get;set;} int = 1;
)   {get;set;} ImgReq
