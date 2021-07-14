/*
 * Copyright 2019-2021 Mamoe Technologies and contributors.
 *
 * 此源代码的使用受 GNU AFFERO GENERAL PUBLIC LICENSE version 3 许可证的约束; 可以在以下链接找到该许可证.
 * Use of this source code is governed by the GNU AGPLv3 license that can be found through the following link.
 *
 * https  {get;set;}//github.com/mamoe/mirai/blob/dev/LICENSE
 */

using ProtoBuf;

[ProtoContract] class MarketFaceExtPb  {
    [ProtoContract] class ResvAttr{[ProtoMember(1)] public     supportSize  {get;set;} List<SupportSize> = new();
        [ProtoMember(2)] public     sourceType  {get;set;} int = 0;
        [ProtoMember(3)] public     sourceName  {get;set;} string = "";
        [ProtoMember(4)] public     sourceJumpUrl  {get;set;} string = "";
        [ProtoMember(5)] public     sourceTypeName  {get;set;} string = "";
        [ProtoMember(6)] public     startTime  {get;set;} int = 0;
        [ProtoMember(7)] public     endTime  {get;set;} int = 0;
        [ProtoMember(8)] public     emojiType  {get;set;} int = 0;
        [ProtoMember(9)] public     apngSupportSize  {get;set;} List<SupportSize> = new();
        [ProtoMember(10)] public     hasIpProduct  {get;set;} int = 0;
    }

    [ProtoContract] class SupportSize{[ProtoMember(1)] public     width  {get;set;} int = 0;
        [ProtoMember(2)] public     height  {get;set;} int = 0;
    }
}
