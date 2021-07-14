using ProtoBuf;

[ProtoContract] class MsgOnlinePush {
    [ProtoContract] class PbPushMsg(
       [ProtoMember(1)] public   msg  {get;set;} MsgComm.Msg;
       [ProtoMember(2)] public   svrip  {get;set;} int = 0;
       [ProtoMember(3)] public   pushToken  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   pingFlag  {get;set;} int = 0;
       [ProtoMember(9)] public   generalFlag  {get;set;} int = 0;
    }
}

[ProtoContract] class OnlinePushTrans  {
    [ProtoContract] class ExtGroupKeyInfo(
       [ProtoMember(1)] public   curMaxSeq  {get;set;} int = 0;
       [ProtoMember(2)] public   curTime  {get;set;} long = 0L;
    }

    [ProtoContract] class PbMsgInfo(
       [ProtoMember(1)] public   fromUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   msgType  {get;set;} int = 0;
       [ProtoMember(4)] public   msgSubtype  {get;set;} int = 0;
       [ProtoMember(5)] public   msgSeq  {get;set;} int = 0;
       [ProtoMember(6)] public   msgUid  {get;set;} long = 0L;
       [ProtoMember(7)] public   msgTime  {get;set;} int = 0;
       [ProtoMember(8)] public   realMsgTime  {get;set;} int = 0;
       [ProtoMember(9)] public   nickName  {get;set;} string = "";
       [ProtoMember(10)] public   msgData  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(11)] public   svrIp  {get;set;} int = 0;
       [ProtoMember(12)] public   extGroupKeyInfo  {get;set;} ExtGroupKeyInfo? = null;
       [ProtoMember(17)] public   generalFlag  {get;set;} int = 0;
    }
}
