





using ProtoBuf;

import net.mamoe.mirai.internal.network.Packet



[ProtoContract] class MsgSvc  {
    [ProtoContract] class Grp(
       [ProtoMember(1)] public   groupCode  {get;set;} long = 0L;
    }

    [ProtoContract] class PbGetMsgResp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   errmsg  {get;set;} string = "";
       [ProtoMember(3)] public   syncCookie  {get;set;} byte[]? = Array.Empty<byte>();
       [ProtoMember(4)] public   syncFlag  {get;set;} SyncFlag = SyncFlag.CONTINUE;
       [ProtoMember(5)] public   uinPairMsgs  {get;set;} List<MsgComm.UinPairMsg> = new();
       [ProtoMember(6)] public   bindUin  {get;set;} long = 0L;
       [ProtoMember(7)] public   msgRspType  {get;set;} int = 0;
       [ProtoMember(8)] public   pubAccountCookie  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(9)] public   isPartialSync  {get;set;} bool = false;
       [ProtoMember(10)] public   msgCtrlBuf  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class PbGroupMsgWithDrawReq(
       [ProtoMember(1)] public   subCmd  {get;set;} int;
       [ProtoMember(2)] public   groupType  {get;set;} int;
       [ProtoMember(3)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(4)] public   msgList  {get;set;} List<MessageInfo> = new();
       [ProtoMember(5)] public   userdef  {get;set;} byte[] = Array.Empty<byte>();
    } {
        [ProtoContract]
        internal class MessageInfo(
           [ProtoMember(1)] public   msgSeq  {get;set;} int = 0;
           [ProtoMember(2)] public   msgRandom  {get;set;} int = 0;
           [ProtoMember(3)] public   msgType  {get;set;} int = 0;
        )
    }

    [ProtoContract] class PbGroupReadedReportReq(
       [ProtoMember(1)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(2)] public   lastReadSeq  {get;set;} long = 0L;
    }

    [ProtoContract] class BusinessWPATmp(
       [ProtoMember(1)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   sigt  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class C2C(
       [ProtoMember(1)] public   toUin  {get;set;} long = 0L;
    }

    [ProtoContract] class PbGetGroupMsgReq(
       [ProtoMember(1)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(2)] public   beginSeq  {get;set;} long = 0L;
       [ProtoMember(3)] public   endSeq  {get;set;} long = 0L;
       [ProtoMember(4)] public   filter  {get;set;} int /* enum */ = 0;
       [ProtoMember(5)] public   memberSeq  {get;set;} long = 0L;
       [ProtoMember(6)] public   publicGroup  {get;set;} bool = false;
       [ProtoMember(7)] public   shieldFlag  {get;set;} int = 0;
       [ProtoMember(8)] public   saveTrafficFlag  {get;set;} int = 0;
    }

    [ProtoContract] class PbBindUinMsgReadedConfirmReq(
       [ProtoMember(1)] public   syncCookie  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   bindUin  {get;set;} long = 0L;
    }

    [ProtoContract] class AccostTmp(
       [ProtoMember(1)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   reply  {get;set;} bool = false;
    }

    [ProtoContract] class PbDiscussReadedReportResp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   errmsg  {get;set;} string = "";
       [ProtoMember(3)] public   confUin  {get;set;} long = 0L;
       [ProtoMember(4)] public   memberSeq  {get;set;} long = 0L;
       [ProtoMember(5)] public   confSeq  {get;set;} long = 0L;
    }

    [ProtoContract] class NearByAssistantTmp(
       [ProtoMember(1)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   reply  {get;set;} bool = false;
    }

    [ProtoContract] class MsgSendInfo(
       [ProtoMember(1)] public   receiver  {get;set;} int = 0;
    }

    [ProtoContract] class PubGroupTmp(
       [ProtoMember(1)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   groupUin  {get;set;} long = 0L;
    }

    [ProtoContract] class AddressListTmp(
       [ProtoMember(1)] public   fromPhone  {get;set;} string = "";
       [ProtoMember(2)] public   toPhone  {get;set;} string = "";
       [ProtoMember(3)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(4)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   fromContactSize  {get;set;} int = 0;
    }

    [ProtoContract] class DisTmp(
       [ProtoMember(1)] public   disUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   toUin  {get;set;} long = 0L;
    )

    [ProtoContract] class PbMsgWithDrawResp(
       [ProtoMember(1)] public   c2cWithDraw  {get;set;} List<PbC2CMsgWithDrawResp> = new();
       [ProtoMember(2)] public   groupWithDraw  {get;set;} List<PbGroupMsgWithDrawResp> = new();
    }

    [ProtoContract] class AuthTmp(
       [ProtoMember(1)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class PbMsgWithDrawReq(
       [ProtoMember(1)] public   c2cWithDraw  {get;set;} List<PbC2CMsgWithDrawReq> = new();
       [ProtoMember(2)] public   groupWithDraw  {get;set;} List<PbGroupMsgWithDrawReq> = new();
    }

    internal enum class SyncFlag {
        START;
        CONTINUE;
        STOP
    }

    [ProtoContract] class PbGetMsgReq(
       [ProtoMember(1)] public   syncFlag  {get;set;} SyncFlag;
       [ProtoMember(2)] public   syncCookie  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   rambleFlag  {get;set;} int = 1;
       [ProtoMember(4)] public   latestRambleNumber  {get;set;} int = 20;
       [ProtoMember(5)] public   otherRambleNumber  {get;set;} int = 3;
       [ProtoMember(6)] public   onlineSyncFlag  {get;set;} int = 1;
       [ProtoMember(7)] public   contextFlag  {get;set;} int = 0;
       [ProtoMember(8)] public   whisperSessionId  {get;set;} int = 0;
       [ProtoMember(9)] public   msgReqType  {get;set;} int = 0;
       [ProtoMember(10)] public   pubaccountCookie  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(11)] public   msgCtrlBuf  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(12)] public   serverBuf  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class PbGetOneDayRoamMsgReq(
       [ProtoMember(1)] public   peerUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   lastMsgtime  {get;set;} long = 0L;
       [ProtoMember(3)] public   random  {get;set;} long = 0L;
       [ProtoMember(4)] public   readCnt  {get;set;} int = 0;
    }

    [ProtoContract] class GrpTmp(
       [ProtoMember(1)] public   groupUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   toUin  {get;set;} long = 0L;
    }

    [ProtoContract] class PbGetDiscussMsgResp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   errmsg  {get;set;} string = "";
       [ProtoMember(3)] public   discussUin  {get;set;} long = 0L;
       [ProtoMember(4)] public   returnEndSeq  {get;set;} long = 0L;
       [ProtoMember(5)] public   returnBeginSeq  {get;set;} long = 0L;
       [ProtoMember(6)] public   msg  {get;set;} List<MsgComm.Msg> = new();
       [ProtoMember(7)] public   lastGetTime  {get;set;} long = 0L;
       [ProtoMember(8)] public   discussInfoSeq  {get;set;} long = 0L;
    }

    [ProtoContract] class CommTmp(
       [ProtoMember(1)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   c2cType  {get;set;} int = 0;
       [ProtoMember(3)] public   svrType  {get;set;} int = 0;
       [ProtoMember(4)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   reserved  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class PbGroupMsgWithDrawResp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   errmsg  {get;set;} string = "";
       [ProtoMember(3)] public   subCmd  {get;set;} int = 0;
       [ProtoMember(4)] public   groupType  {get;set;} int = 0;
       [ProtoMember(5)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(6)] public   failedMsgList  {get;set;} List<MessageResult> = new();
       [ProtoMember(7)] public   userdef  {get;set;} byte[] = Array.Empty<byte>();
    } {
        [ProtoContract]
        internal class MessageResult(
           [ProtoMember(1)] public   result  {get;set;} int = 0;
           [ProtoMember(2)] public   msgSeq  {get;set;} int = 0;
           [ProtoMember(3)] public   msgTime  {get;set;} int = 0;
           [ProtoMember(4)] public   msgRandom  {get;set;} int = 0;
           [ProtoMember(5)] public   errMsg  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(6)] public   msgType  {get;set;} int = 0;
        }
    }

    [ProtoContract] class PbC2CReadedReportResp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   errmsg  {get;set;} string = "";
       [ProtoMember(3)] public   syncCookie  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class PbC2CUnReadMsgNumReq 

    [ProtoContract] class PbC2CMsgWithDrawReq(
       [ProtoMember(1)] public   msgInfo  {get;set;} List<MsgInfo> = new();
       [ProtoMember(2)] public   longMessageFlag  {get;set;} int;
       [ProtoMember(3)] public   reserved  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   subCmd  {get;set;} int = 0;
    } {
        [ProtoContract]
        internal class MsgInfo(
           [ProtoMember(1)] public   fromUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   toUin  {get;set;} long = 0L;
           [ProtoMember(3)] public   msgSeq  {get;set;} int = 0;
           [ProtoMember(4)] public   msgUid  {get;set;} long = 0L;
           [ProtoMember(5)] public   msgTime  {get;set;} long = 0L;
           [ProtoMember(6)] public   msgRandom  {get;set;} int = 0;
           [ProtoMember(7)] public   pkgNum  {get;set;} int = 0;
           [ProtoMember(8)] public   pkgIndex  {get;set;} int = 0;
           [ProtoMember(9)] public   divSeq  {get;set;} int = 0;
           [ProtoMember(10)] public   msgType  {get;set;} int;
           [ProtoMember(20)] public   routingHead  {get;set;} RoutingHead? = null;
        )
    }

    [ProtoContract] class PbDelRoamMsgResp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   errmsg  {get;set;} string = "";
    }

    [ProtoContract] class Dis(
       [ProtoMember(1)] public   disUin  {get;set;} long = 0L;
    }

    [ProtoContract] class TransSvrInfo(
       [ProtoMember(1)] public   subType  {get;set;} int = 0;
       [ProtoMember(2)] public   int32RetCode  {get;set;} int = 0;
       [ProtoMember(3)] public   errMsg  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   transInfo  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class PbPullGroupMsgSeqResp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   errmsg  {get;set;} string = "";
       [ProtoMember(3)] public   groupInfoResp  {get;set;} List<GroupInfoResp> = new();
    } {
        [ProtoContract]
        internal class GroupInfoResp(
           [ProtoMember(1)] public   groupCode  {get;set;} long = 0L;
           [ProtoMember(2)] public   memberSeq  {get;set;} long = 0L;
           [ProtoMember(3)] public   groupSeq  {get;set;} long = 0L;
        )
    }

    [ProtoContract] class PbSendMsgReq(
       [ProtoMember(1)] public   routingHead  {get;set;} RoutingHead? = null;
       [ProtoMember(2)] public   contentHead  {get;set;} MsgComm.ContentHead? = null;
       [ProtoMember(3)] public   msgBody  {get;set;} ImMsgBody.MsgBody = ImMsgBody.MsgBody();
       [ProtoMember(4)] public   msgSeq  {get;set;} int = 0;
       [ProtoMember(5)] public   msgRand  {get;set;} int = 0;
       [ProtoMember(6)] public   syncCookie  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(7)] public   appShare  {get;set;} MsgComm.AppShareInfo? = null;
       [ProtoMember(8)] public   msgVia  {get;set;} int = 0;
       [ProtoMember(9)] public   dataStatist  {get;set;} int = 0;
       [ProtoMember(10)] public   multiMsgAssist  {get;set;} MultiMsgAssist? = null;
       [ProtoMember(11)] public   inputNotifyInfo  {get;set;} PbInputNotifyInfo? = null;
       [ProtoMember(12)] public   msgCtrl  {get;set;} MsgCtrl.MsgCtrl? = null;
       [ProtoMember(13)] public   receiptReq  {get;set;} ImReceipt.ReceiptReq? = null;
       [ProtoMember(14)] public   multiSendSeq  {get;set;} int = 0;
    }

    [ProtoContract] class TransMsg(
       [ProtoMember(1)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   c2cCmd  {get;set;} int = 0;
    }

    [ProtoContract] class PbDeleteMsgResp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   errmsg  {get;set;} string = "";
    }

    [ProtoContract] class PbSearchRoamMsgInCloudResp(
       [ProtoMember(1)] public   msg  {get;set;} List<MsgComm.Msg> = new();
       [ProtoMember(2)] public   serializeRspbody  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class PbInputNotifyInfo(
       [ProtoMember(1)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   ime  {get;set;} int = 0;
       [ProtoMember(3)] public   notifyFlag  {get;set;} int = 0;
       [ProtoMember(4)] public   pbReserve  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   iosPushWording  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class PbUnReadMsgSeqResp(
       [ProtoMember(1)] public   c2cUnreadInfo  {get;set;} PbC2CUnReadMsgNumResp? = null;
       [ProtoMember(2)] public   binduinUnreadInfo  {get;set;} List<PbBindUinUnReadMsgNumResp> = new();
       [ProtoMember(3)] public   groupUnreadInfo  {get;set;} PbPullGroupMsgSeqResp? = null;
       [ProtoMember(4)] public   discussUnreadInfo  {get;set;} PbPullDiscussMsgSeqResp? = null;
       [ProtoMember(5)] public   thirdqqUnreadInfo  {get;set;} PbThirdQQUnReadMsgNumResp? = null;
    }

    [ProtoContract] class PbDeleteMsgReq(
       [ProtoMember(1)] public   msgItems  {get;set;} List<MsgItem> = new();
    } {
        [ProtoContract]
        internal class MsgItem(
           [ProtoMember(1)] public   fromUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   toUin  {get;set;} long = 0L;
           [ProtoMember(3)] public   msgType  {get;set;} int = 0;
           [ProtoMember(4)] public   msgSeq  {get;set;} int = 0;
           [ProtoMember(5)] public   msgUid  {get;set;} long = 0L;
           [ProtoMember(7)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
        }
    }

    [ProtoContract] class MultiMsgAssist(
       [ProtoMember(1)] public   repeatedRouting  {get;set;} List<RoutingHead> = new();
       [ProtoMember(2)] public   msgUse  {get;set;} int /* enum */ = 1;
       [ProtoMember(3)] public   tempId  {get;set;} long = 0L;
       [ProtoMember(4)] public   vedioLen  {get;set;} long = 0L;
       [ProtoMember(5)] public   redbagId  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(6)] public   redbagAmount  {get;set;} long = 0L;
       [ProtoMember(7)] public   hasReadbag  {get;set;} int = 0;
       [ProtoMember(8)] public   hasVedio  {get;set;} int = 0;
    }

    [ProtoContract] class PbMsgReadedReportReq(
       [ProtoMember(1)] public   grpReadReport  {get;set;} List<PbGroupReadedReportReq> = new();
       [ProtoMember(2)] public   disReadReport  {get;set;} List<PbDiscussReadedReportReq> = new();
       [ProtoMember(3)] public   c2cReadReport  {get;set;} PbC2CReadedReportReq? = null;
       [ProtoMember(4)] public   bindUinReadReport  {get;set;} PbBindUinMsgReadedConfirmReq? = null;
    }

    [ProtoContract] class PbGetOneDayRoamMsgResp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   errmsg  {get;set;} string = "";
       [ProtoMember(3)] public   peerUin  {get;set;} long = 0L;
       [ProtoMember(4)] public   lastMsgtime  {get;set;} long = 0L;
       [ProtoMember(5)] public   random  {get;set;} long = 0L;
       [ProtoMember(6)] public   msg  {get;set;} List<MsgComm.Msg> = new();
       [ProtoMember(7)] public   iscomplete  {get;set;} int = 0;
    }

    [ProtoContract] class PbBindUinGetMsgReq(
       [ProtoMember(1)] public   bindUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   bindUinSig  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   syncFlag  {get;set;} int /* enum */ = 0;
       [ProtoMember(4)] public   syncCookie  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class NearByDatingTmp(
       [ProtoMember(1)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   reply  {get;set;} bool = false;
    }

    [ProtoContract] class BsnsTmp(
       [ProtoMember(1)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class RoutingHead(
       [ProtoMember(1)] public   c2c  {get;set;} C2C? = null;
       [ProtoMember(2)] public   grp  {get;set;} Grp? = null;
       [ProtoMember(3)] public   grpTmp  {get;set;} GrpTmp? = null;
       [ProtoMember(4)] public   dis  {get;set;} Dis? = null;
       [ProtoMember(5)] public   disTmp  {get;set;} DisTmp? = null;
       [ProtoMember(6)] public   wpaTmp  {get;set;} WPATmp? = null;
       [ProtoMember(7)] public   secretFile  {get;set;} SecretFileHead? = null;
       [ProtoMember(8)] public   publicPlat  {get;set;} PublicPlat? = null;
       [ProtoMember(9)] public   transMsg  {get;set;} TransMsg? = null;
       [ProtoMember(10)] public   addressList  {get;set;} AddressListTmp? = null;
       [ProtoMember(11)] public   richStatusTmp  {get;set;} RichStatusTmp? = null;
       [ProtoMember(12)] public   transCmd  {get;set;} TransCmd? = null;
       [ProtoMember(13)] public   accostTmp  {get;set;} AccostTmp? = null;
       [ProtoMember(14)] public   pubGroupTmp  {get;set;} PubGroupTmp? = null;
       [ProtoMember(15)] public   trans0x211  {get;set;} Trans0x211? = null;
       [ProtoMember(16)] public   businessWpaTmp  {get;set;} BusinessWPATmp? = null;
       [ProtoMember(17)] public   authTmp  {get;set;} AuthTmp? = null;
       [ProtoMember(18)] public   bsnsTmp  {get;set;} BsnsTmp? = null;
       [ProtoMember(19)] public   qqQuerybusinessTmp  {get;set;} QQQueryBusinessTmp? = null;
       [ProtoMember(20)] public   nearbyDatingTmp  {get;set;} NearByDatingTmp? = null;
       [ProtoMember(21)] public   nearbyAssistantTmp  {get;set;} NearByAssistantTmp? = null;
       [ProtoMember(22)] public   commTmp  {get;set;} CommTmp? = null;
    }

    [ProtoContract] class TransResp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   errmsg  {get;set;} string = "";
       [ProtoMember(3)] public   respTag  {get;set;} int = 0;
       [ProtoMember(4)] public   respBuff  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class PbSendMsgResp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   errmsg  {get;set;} string = "";
       [ProtoMember(3)] public   sendTime  {get;set;} int = 0;
       [ProtoMember(4)] public   svrbusyWaitTime  {get;set;} int = 0;
       [ProtoMember(5)] public   msgSendInfo  {get;set;} MsgSendInfo? = null;
       [ProtoMember(6)] public   errtype  {get;set;} int = 0;
       [ProtoMember(7)] public   transSvrInfo  {get;set;} TransSvrInfo? = null;
       [ProtoMember(8)] public   receiptResp  {get;set;} ImReceipt.ReceiptResp? = null;
       [ProtoMember(9)] public   textAnalysisResult  {get;set;} int = 0;
    }; Packet

    [ProtoContract] class PbBindUinUnReadMsgNumResp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   errmsg  {get;set;} string = "";
       [ProtoMember(3)] public   bindUin  {get;set;} long = 0L;
       [ProtoMember(4)] public   msgNum  {get;set;} int = 0;
    }

    [ProtoContract] class PbGetDiscussMsgReq(
       [ProtoMember(1)] public   discussUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   endSeq  {get;set;} long = 0L;
       [ProtoMember(3)] public   beginSeq  {get;set;} long = 0L;
       [ProtoMember(4)] public   lastGetTime  {get;set;} long = 0L;
       [ProtoMember(5)] public   discussInfoSeq  {get;set;} long = 0L;
       [ProtoMember(6)] public   filter  {get;set;} int /* enum */ = 0;
       [ProtoMember(7)] public   memberSeq  {get;set;} long = 0L;
    }

    [ProtoContract] class PbC2CMsgWithDrawResp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   errmsg  {get;set;} string = "";
       [ProtoMember(3)] public   msgStatus  {get;set;} List<MsgStatus> = new();
       [ProtoMember(4)] public   subCmd  {get;set;} int = 0;
    } {
        [ProtoContract]
        internal class MsgStatus(
           [ProtoMember(1)] public   msgInfo  {get;set;} PbC2CMsgWithDrawReq.MsgInfo? = null;
           [ProtoMember(2)] public   status  {get;set;} int = 0;
        }
    }

    [ProtoContract] class SecretFileHead(
       [ProtoMember(1)] public   secretFileMsg  {get;set;} SubMsgType0xc1.MsgBody? = null;
        //   [ProtoMember(2)] public   secretFileStatus  {get;set;} SubMsgType0x1a.MsgBody? = null
    )

    [ProtoContract] class PbGetRoamMsgReq(
       [ProtoMember(1)] public   peerUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   lastMsgtime  {get;set;} long = 0L;
       [ProtoMember(3)] public   random  {get;set;} long = 0L;
       [ProtoMember(4)] public   readCnt  {get;set;} int = 0;
       [ProtoMember(5)] public   checkPwd  {get;set;} int = 0;
       [ProtoMember(6)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(7)] public   pwd  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(8)] public   subcmd  {get;set;} int = 0;
       [ProtoMember(9)] public   beginMsgtime  {get;set;} long = 0L;
       [ProtoMember(10)] public   reqType  {get;set;} int = 0;
    }

    [ProtoContract] class TransCmd(
       [ProtoMember(1)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   msgType  {get;set;} int = 0;
    }

    [ProtoContract] class PbMsgReadedReportResp(
       [ProtoMember(1)] public   grpReadReport  {get;set;} List<PbGroupReadedReportResp> = new();
       [ProtoMember(2)] public   disReadReport  {get;set;} List<PbDiscussReadedReportResp> = new();
       [ProtoMember(3)] public   c2cReadReport  {get;set;} PbC2CReadedReportResp? = null;
       [ProtoMember(4)] public   bindUinReadReport  {get;set;} PbBindUinMsgReadedConfirmResp? = null;
    }

    [ProtoContract] class PbThirdQQUnReadMsgNumResp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   errmsg  {get;set;} string = "";
       [ProtoMember(3)] public   thirdqqRespInfo  {get;set;} List<ThirdQQRespInfo> = new();
       [ProtoMember(4)] public   interval  {get;set;} int = 0;
    } {
        [ProtoContract]
        internal class ThirdQQRespInfo(
           [ProtoMember(1)] public   thirdUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   thirdUinCookie  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   msgNum  {get;set;} int = 0;
           [ProtoMember(4)] public   msgFlag  {get;set;} int = 0;
           [ProtoMember(5)] public   redbagTime  {get;set;} int = 0;
           [ProtoMember(6)] public   status  {get;set;} int = 0;
           [ProtoMember(7)] public   lastMsgTime  {get;set;} int = 0;
        }
    }

    [ProtoContract] class RichStatusTmp(
       [ProtoMember(1)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class QQQueryBusinessTmp(
       [ProtoMember(1)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class PbDelRoamMsgReq(
       [ProtoMember(1)] public   c2cMsg  {get;set;} C2CMsg? = null;
       [ProtoMember(2)] public   grpMsg  {get;set;} GrpMsg? = null;
       [ProtoMember(3)] public   disMsg  {get;set;} DisMsg? = null;
    } {
        [ProtoContract]
        internal class GrpMsg(
           [ProtoMember(1)] public   groupCode  {get;set;} long = 0L;
           [ProtoMember(2)] public   msgSeq  {get;set;} long = 0L;
        }

        [ProtoContract]
        internal class C2CMsg(
           [ProtoMember(1)] public   fromUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   peerUin  {get;set;} long = 0L;
           [ProtoMember(3)] public   msgTime  {get;set;} int = 0;
           [ProtoMember(4)] public   msgRandom  {get;set;} int = 0;
           [ProtoMember(5)] public   msgSeq  {get;set;} int = 0;
        }

        [ProtoContract]
        internal class DisMsg(
           [ProtoMember(1)] public   discussUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   msgSeq  {get;set;} long = 0L;
        }
    }

    [ProtoContract] class PbUnReadMsgSeqReq(
       [ProtoMember(1)] public   c2cUnreadInfo  {get;set;} PbC2CUnReadMsgNumReq? = null;
       [ProtoMember(2)] public   binduinUnreadInfo  {get;set;} List<PbBindUinUnReadMsgNumReq> = new();
       [ProtoMember(3)] public   groupUnreadInfo  {get;set;} PbPullGroupMsgSeqReq? = null;
       [ProtoMember(4)] public   discussUnreadInfo  {get;set;} PbPullDiscussMsgSeqReq? = null;
       [ProtoMember(5)] public   thirdqqUnreadInfo  {get;set;} PbThirdQQUnReadMsgNumReq? = null;
    }

    [ProtoContract] class PbPullDiscussMsgSeqResp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   errmsg  {get;set;} string = "";
       [ProtoMember(3)] public   discussInfoResp  {get;set;} List<DiscussInfoResp> = new();
    } {
        [ProtoContract]
        internal class DiscussInfoResp(
           [ProtoMember(1)] public   confUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   memberSeq  {get;set;} long = 0L;
           [ProtoMember(3)] public   confSeq  {get;set;} long = 0L;
        }
    }

    [ProtoContract] class PbPullDiscussMsgSeqReq(
       [ProtoMember(1)] public   discussInfoReq  {get;set;} List<DiscussInfoReq> = new();
    } {
        [ProtoContract]
        internal class DiscussInfoReq(
           [ProtoMember(1)] public   confUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   lastSeq  {get;set;} long = 0L;
        }
    }

    [ProtoContract] class WPATmp(
       [ProtoMember(1)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class PublicPlat(
       [ProtoMember(1)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class PbBindUinMsgReadedConfirmResp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   errmsg  {get;set;} string = "";
       [ProtoMember(3)] public   syncCookie  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   bindUin  {get;set;} long = 0L;
    }

    [ProtoContract] class PbGetRoamMsgResp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   errmsg  {get;set;} string = "";
       [ProtoMember(3)] public   peerUin  {get;set;} long = 0L;
       [ProtoMember(4)] public   lastMsgtime  {get;set;} long = 0L;
       [ProtoMember(5)] public   random  {get;set;} long = 0L;
       [ProtoMember(6)] public   msg  {get;set;} List<MsgComm.Msg> = new();
       [ProtoMember(7)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class PbDiscussReadedReportReq(
       [ProtoMember(1)] public   confUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   lastReadSeq  {get;set;} long = 0L;
    }

    [ProtoContract] class PbC2CReadedReportReq(
       [ProtoMember(1)] public   syncCookie  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   pairInfo  {get;set;} List<UinPairReadInfo> = new();
    } {
        [ProtoContract]
        internal class UinPairReadInfo(
           [ProtoMember(1)] public   peerUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   lastReadTime  {get;set;} int = 0;
           [ProtoMember(3)] public   crmSig  {get;set;} byte[] = Array.Empty<byte>();
        }
    }

    [ProtoContract] class Trans0x211(
       [ProtoMember(1)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   ccCmd  {get;set;} int = 0;
       [ProtoMember(3)] public   instCtrl  {get;set;} ImMsgHead.InstCtrl? = null;
       [ProtoMember(4)] public   sig  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   c2cType  {get;set;} int = 0;
       [ProtoMember(6)] public   serviceType  {get;set;} int = 0;
    }

    [ProtoContract] class PbSearchRoamMsgInCloudReq(
       [ProtoMember(1)] public   serializeReqbody  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class PbBindUinUnReadMsgNumReq(
       [ProtoMember(1)] public   bindUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   syncCookie  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class PbC2CUnReadMsgNumResp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   errmsg  {get;set;} string = "";
       [ProtoMember(3)] public   msgNum  {get;set;} int = 0;
    }

    [ProtoContract] class PbPullGroupMsgSeqReq(
       [ProtoMember(1)] public   groupInfoReq  {get;set;} List<GroupInfoReq> = new();
    } {
        [ProtoContract]
        internal class GroupInfoReq(
           [ProtoMember(1)] public   groupCode  {get;set;} long = 0L;
           [ProtoMember(2)] public   lastSeq  {get;set;} long = 0L;
        }
    }

    [ProtoContract] class TransReq(
       [ProtoMember(1)] public   command  {get;set;} int = 0;
       [ProtoMember(2)] public   reqTag  {get;set;} int = 0;
       [ProtoMember(3)] public   reqBuff  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class PbGroupReadedReportResp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   errmsg  {get;set;} string = "";
       [ProtoMember(3)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(4)] public   memberSeq  {get;set;} long = 0L;
       [ProtoMember(5)] public   groupMsgSeq  {get;set;} long = 0L;
    }

    [ProtoContract] class PbGetGroupMsgResp(
       [ProtoMember(1)] public   result  {get;set;} int = 0;
       [ProtoMember(2)] public   errmsg  {get;set;} string = "";
       [ProtoMember(3)] public   groupCode  {get;set;} long = 0L;
       [ProtoMember(4)] public   returnBeginSeq  {get;set;} long = 0L;
       [ProtoMember(5)] public   returnEndSeq  {get;set;} long = 0L;
       [ProtoMember(6)] public   msg  {get;set;} List<MsgComm.Msg> = new();
    }

    [ProtoContract] class PbThirdQQUnReadMsgNumReq(
       [ProtoMember(1)] public   thirdqqReqInfo  {get;set;} List<ThirdQQReqInfo> = new();
       [ProtoMember(2)] public   source  {get;set;} int = 0;
    } {
        [ProtoContract]
        internal class ThirdQQReqInfo(
           [ProtoMember(1)] public   thirdUin  {get;set;} long = 0L;
           [ProtoMember(2)] public   thirdUinSig  {get;set;} byte[] = Array.Empty<byte>();
           [ProtoMember(3)] public   thirdUinCookie  {get;set;} byte[] = Array.Empty<byte>();
        }
    }
}

[ProtoContract] class MsgCtrl {
    [ProtoContract] class MsgCtrl(
       [ProtoMember(1)] public   msgFlag  {get;set;} int = 0;
       [ProtoMember(2)] public   resvResvInfo  {get;set;} ResvResvInfo? = null;
    }

    [ProtoContract] class ResvResvInfo(
       [ProtoMember(1)] public   flag  {get;set;} int = 0;
       [ProtoMember(2)] public   reserv1  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   reserv2  {get;set;} long = 0L;
       [ProtoMember(4)] public   reserv3  {get;set;} long = 0L;
       [ProtoMember(5)] public   createTime  {get;set;} int = 0;
       [ProtoMember(6)] public   picHeight  {get;set;} int = 0;
       [ProtoMember(7)] public   picWidth  {get;set;} int = 0;
       [ProtoMember(8)] public   resvFlag  {get;set;} int = 0;
    }
}

[ProtoContract] class SubMsgType0xc1 {
    [ProtoContract] class NotOnlineImage(
       [ProtoMember(1)] public   filePath  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   fileLen  {get;set;} int = 0;
       [ProtoMember(3)] public   downloadPath  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   oldVerSendFile  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(5)] public   imgType  {get;set;} int = 0;
       [ProtoMember(6)] public   previewsImage  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(7)] public   picMd5  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(8)] public   picHeight  {get;set;} int = 0;
       [ProtoMember(9)] public   picWidth  {get;set;} int = 0;
       [ProtoMember(10)] public   resId  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(11)] public   flag  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(12)] public   downloadUrl  {get;set;} string = "";
       [ProtoMember(13)] public   original  {get;set;} int = 0;
    }

    [ProtoContract] class MsgBody(
       [ProtoMember(1)] public   fileKey  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   fromUin  {get;set;} long = 0L;
       [ProtoMember(3)] public   toUin  {get;set;} long = 0L;
       [ProtoMember(4)] public   status  {get;set;} int = 0;
       [ProtoMember(5)] public   ttl  {get;set;} int = 0;
       [ProtoMember(6)] public   type  {get;set;} int = 0;
       [ProtoMember(7)] public   encryptPreheadLength  {get;set;} int = 0;
       [ProtoMember(8)] public   encryptType  {get;set;} int = 0;
       [ProtoMember(9)] public   encryptKey  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(10)] public   readTimes  {get;set;} int = 0;
       [ProtoMember(11)] public   leftTime  {get;set;} int = 0;
       [ProtoMember(12)] public   notOnlineImage  {get;set;} NotOnlineImage? = null;
    }
}

/*
[ProtoContract] class SubMsgType0x1a {
    [ProtoContract] class MsgBody(
       [ProtoMember(1)] public   fileKey  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(2)] public   fromUin_int32  {get;set;} int = 0;
       [ProtoMember(3)] public   toUin_int32  {get;set;} int = 0;
       [ProtoMember(4)] public   status  {get;set;} int = 0;
       [ProtoMember(5)] public   ttl  {get;set;} int = 0;
       [ProtoMember(6)] public   ingDesc  {get;set;} string = "";
       [ProtoMember(7)] public   type  {get;set;} int = 0;
       [ProtoMember(8)] public   captureTimes  {get;set;} int = 0;
       [ProtoMember(9)] public   fromUin  {get;set;} long = 0L;
       [ProtoMember(10)] public   toUin  {get;set;} long = 0L
    }
}*/
