using System;
using System.Collections.Generic;
using ProtoBuf;

[ProtoContract] class GroupFileUploadExt(
    [ProtoMember(1)] public     u1  {get;set;} int;
    [ProtoMember(2)] public     u2  {get;set;} int;
    [ProtoMember(100)] public     entry  {get;set;} GroupFileUploadEntry;
    [ProtoMember(3)] public     u3  {get;set;} int;
}

[ProtoContract] class GroupFileUploadEntry(
    [ProtoMember(100)] public     business  {get;set;} ExcitingBusiInfo;
    [ProtoMember(200)] public     fileEntry  {get;set;} ExcitingFileEntry;
    [ProtoMember(300)] public     clientInfo  {get;set;} ExcitingClientInfo;
    [ProtoMember(400)] public     fileNameInfo  {get;set;} ExcitingFileNameInfo;
    [ProtoMember(500)] public     host  {get;set;} ExcitingHostConfig;
}

[ProtoContract] class ExcitingBusiInfo(
    [ProtoMember(1)] public     busId  {get;set;} int;
    [ProtoMember(100)] public     senderUin  {get;set;} long;
    [ProtoMember(200)] public     receiverUin  {get;set;} long; // maybe
    [ProtoMember(400)] public     groupCode  {get;set;} long; // maybe
}

[ProtoContract] class ExcitingFileEntry(
    [ProtoMember(100)] public     fileSize  {get;set;} long;
    [ProtoMember(200)] public     md5  {get;set;} byte[];
    [ProtoMember(300)] public     sha1  {get;set;} byte[];
    [ProtoMember(600)] public     fileId  {get;set;} byte[];
    [ProtoMember(700)] public     uploadKey  {get;set;} byte[];
}


[ProtoContract] class ExcitingClientInfo(
    [ProtoMember(100)] public     clientType  {get;set;} int; // maybe
    [ProtoMember(200)] public     appId  {get;set;} string;
    [ProtoMember(300)] public     terminalType  {get;set;} int;
    [ProtoMember(400)] public     clientVer  {get;set;} string;
    [ProtoMember(600)] public     unknown  {get;set;} int;
}

[ProtoContract] class ExcitingFileNameInfo(
    [ProtoMember(100)] public     filename  {get;set;} string;
}

[ProtoContract] class ExcitingHostConfig(
    [ProtoMember(200)] public     hosts  {get;set;} List<ExcitingHostInfo>;
}

[ProtoContract] class ExcitingHostInfo(
    [ProtoMember(1)] public     url  {get;set;} ExcitingUrlInfo;
    [ProtoMember(2)] public     port  {get;set;} int;
}

[ProtoContract] class ExcitingUrlInfo(
    [ProtoMember(1)] public     unknown  {get;set;} int;
    [ProtoMember(2)] public     host  {get;set;} string;
}
