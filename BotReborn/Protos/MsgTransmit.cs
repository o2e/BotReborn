using ProtoBuf;

internal class MsgTransmit  {
    [ProtoContract] class PbMultiMsgItem(
       [ProtoMember(1)] public   fileName  {get;set;} string = "";
       [ProtoMember(2)] public   buffer  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class PbMultiMsgNew(
       [ProtoMember(1)] public   msg  {get;set;} List<MsgComm.Msg> = new();
    }

    [ProtoContract] class PbMultiMsgTransmit(
       [ProtoMember(1)] public   msg  {get;set;} List<MsgComm.Msg> = new();
       [ProtoMember(2)] public   pbItemList  {get;set;} List<PbMultiMsgItem> = new();
    }
}
