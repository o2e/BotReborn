using ProtoBuf;

internal class LongMsg  {
    [ProtoContract] class MsgDeleteReq(
       [ProtoMember(1)] public   msgResid  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   msgType  {get;set;} int = 0;
    }

    [ProtoContract] class MsgDeleteRsp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   msgResid  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class MsgDownReq(
       [ProtoMember(1)] public   srcUin  {get;set;} int = 0;
       [ProtoMember(2)] public   msgResid  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   msgType  {get;set;} int = 0;
       [ProtoMember(4)] public   needCache  {get;set;} int = 0;
    }

    [ProtoContract] class MsgDownRsp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   msgResid  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   msgContent  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class MsgUpReq(
       [ProtoMember(1)] public   msgType  {get;set;} int = 0;
       [ProtoMember(2)] public   dstUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   msgId  {get;set;} int = 0;
       [ProtoMember(4)] public   msgContent  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   storeType  {get;set;} int = 0;
       [ProtoMember(6)] public   msgUkey  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(7)] public   needCache  {get;set;} int = 0;
    }

    [ProtoContract] class MsgUpRsp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   msgId  {get;set;} int = 0;
       [ProtoMember(3)] public   msgResid  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   subcmd  {get;set;} int = 0;
       [ProtoMember(2)] public   termType  {get;set;} int = 0;
       [ProtoMember(3)] public   platformType  {get;set;} int = 0;
       [ProtoMember(4)] public   msgUpReq  {get;set;} List<LongMsg.MsgUpReq> = new();
       [ProtoMember(5)] public   msgDownReq  {get;set;} List<LongMsg.MsgDownReq> = new();
       [ProtoMember(6)] public   msgDelReq  {get;set;} List<LongMsg.MsgDeleteReq> = new();
       [ProtoMember(10)] public   agentType  {get;set;} int = 0;
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   subcmd  {get;set;} int = 0;
       [ProtoMember(2)] public   msgUpRsp  {get;set;} List<LongMsg.MsgUpRsp> = new();
       [ProtoMember(3)] public   msgDownRsp  {get;set;} List<LongMsg.MsgDownRsp> = new();
       [ProtoMember(4)] public   msgDelRsp  {get;set;} List<LongMsg.MsgDeleteRsp> = new();
    }
}
