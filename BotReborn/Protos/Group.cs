using ProtoBuf;

[ProtoContract] class GroupLabel  {
    [ProtoContract] class Label(
       [ProtoMember(1)] public   name  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   enumType  {get;set;} int /* enum */ = 1;
       [ProtoMember(3)] public   textColor  {get;set;} Color? = null;
       [ProtoMember(4)] public   edgingColor  {get;set;} Color? = null;
       [ProtoMember(5)] public   labelAttr  {get;set;} int = 0;
       [ProtoMember(6)] public   labelType  {get;set;} int = 0;
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   error  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   groupInfo  {get;set;} List<GroupInfo> = new();
    }

    [ProtoContract] class SourceId(
       [ProtoMember(1)] public   sourceId  {get;set;} int = 0;
    }

    [ProtoContract] class GroupInfo(
       [ProtoMember(1)] public   int32Result  {get;set;} int = 0;
       [ProtoMember(2)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(3)] public   groupLabel  {get;set;} List<Label> = new();
    }

    [ProtoContract] class Color(
       [ProtoMember(1)] public   r  {get;set;} int = 0;
       [ProtoMember(2)] public   g  {get;set;} int = 0;
       [ProtoMember(3)] public   b  {get;set;} int = 0;
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   sourceId  {get;set;} SourceId? = null;
       [ProtoMember(2)] public   uinInfo  {get;set;} UinInfo? = null;
       [ProtoMember(3)] public   numberLabel  {get;set;} int = 5;
       [ProtoMember(4)] public   groupCode  {get;set;} List<Long> = new();
       [ProtoMember(5)] public   labelStyle  {get;set;} int = 0;
    }

    [ProtoContract] class UinInfo(
       [ProtoMember(1)] public   int64Longitude  {get;set;} long = 0L;
       [ProtoMember(2)] public   int64Latitude  {get;set;} long = 0L;
    }
}
