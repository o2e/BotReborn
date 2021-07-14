using ProtoBuf;

[ProtoContract] class MultiMsg  {
    [ProtoContract] class ExternMsg(
       [ProtoMember(1)] public   channelType  {get;set;} int = 0;
    }

    [ProtoContract] class MultiMsgApplyDownReq(
       [ProtoMember(1)] public   msgResid  {get;set;} string = "";
       [ProtoMember(2)] public   msgType  {get;set;} int = 0;
       [ProtoMember(3)] public   srcUin  {get;set;} long = 0L;
    }

    [ProtoContract] class MultiMsgApplyDownRsp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   thumbDownPara  {get;set;} string = "";
       [ProtoMember(3)] public   msgKey  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   uint32DownIp  {get;set;} List<int> = new();
       [ProtoMember(5)] public   uint32DownPort  {get;set;} List<int> = new();
       [ProtoMember(6)] public   msgResid  {get;set;} string = "";
       [ProtoMember(7)] public   msgExternInfo  {get;set;} ExternMsg? = null;
       [ProtoMember(8)] public   bytesDownIpV6  {get;set;} List<byte[]> = new();
       [ProtoMember(9)] public   uint32DownV6Port  {get;set;} List<int> = new();
    }

    [ProtoContract] class MultiMsgApplyUpReq(
       [ProtoMember(1)] public   dstUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   msgSize  {get;set;} long = 0L;
       [ProtoMember(3)] public   msgMd5  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   msgType  {get;set;} int = 0;
       [ProtoMember(5)] public   applyId  {get;set;} int = 0;
    }

    [ProtoContract] class MultiMsgApplyUpRsp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   msgResid  {get;set;} string = "";
       [ProtoMember(3)] public   msgUkey  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   uint32UpIp  {get;set;} List<int> = new();
       [ProtoMember(5)] public   uint32UpPort  {get;set;} List<int> = new();
       [ProtoMember(6)] public   blockSize  {get;set;} long = 0L;
       [ProtoMember(7)] public   upOffset  {get;set;} long = 0L;
       [ProtoMember(8)] public   applyId  {get;set;} int = 0;
       [ProtoMember(9)] public   msgKey  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(10)] public   msgSig  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(11)] public   msgExternInfo  {get;set;} ExternMsg? = null;
       [ProtoMember(12)] public   bytesUpIpV6  {get;set;} List<byte[]> = new();
       [ProtoMember(13)] public   uint32UpV6Port  {get;set;} List<int> = new();
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   subcmd  {get;set;} int = 0;
       [ProtoMember(2)] public   termType  {get;set;} int = 0;
       [ProtoMember(3)] public   platformType  {get;set;} int = 0;
       [ProtoMember(4)] public   netType  {get;set;} int = 0;
       [ProtoMember(5)] public   buildVer  {get;set;} string = "";
       [ProtoMember(6)] public   multimsgApplyupReq  {get;set;} List<MultiMsg.MultiMsgApplyUpReq> = new();
       [ProtoMember(7)] public   multimsgApplydownReq  {get;set;} List<MultiMsg.MultiMsgApplyDownReq> = new();
       [ProtoMember(8)] public   buType  {get;set;} int = 0;
       [ProtoMember(9)] public   reqChannelType  {get;set;} int = 0;
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   subcmd  {get;set;} int = 0;
       [ProtoMember(2)] public   multimsgApplyupRsp  {get;set;} List<MultiMsg.MultiMsgApplyUpRsp> = new();
       [ProtoMember(3)] public   multimsgApplydownRsp  {get;set;} List<MultiMsg.MultiMsgApplyDownRsp> = new();
    }
}
