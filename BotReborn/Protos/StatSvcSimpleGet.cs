using System;
using ProtoBuf;

internal class StatSvcSimpleGet {
    [ProtoContract] class RspBody{[ProtoMember(1)] public     errorCode  {get;set;} int = 0;
        [ProtoMember(2)] public     errmsg  {get;set;} string = "";
        [ProtoMember(3)] public     helloInterval  {get;set;} int = 0;
        [ProtoMember(4)] public     clientip  {get;set;} string = "";
        [ProtoMember(5)] public     clientBatteyGetInterval  {get;set;} int = 0
    }
}
