using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotReborn.Packets;

namespace BotReborn
{
    public static class Decoders
    {
        private static Dictionary<string, Func<OicqClient, IncomingPacketInfo, byte[], LoginResponse>> _decoders = new Dictionary<string, Func<OicqClient, IncomingPacketInfo, byte[], LoginResponse>>()
        {
            ["wtlogin.login"] = DecodeLoginResponse,
            ["wtlogin.exchange_emp"] = DecodeExchangeEmpResponse,
            ["wtlogin.trans_emp"] = DecodeTransEmpResponse,
            ["StatSvc.register"] = DecodeClientRegisterResponse,
            ["StatSvc.ReqMSFOffline"] = DecodeMsfOfflinePacket,
            ["MessageSvc.PushNotify"] = DecodeSvcNotify,
            ["OnlinePush.ReqPush"] = DecodeOnlinePushReqPacket,
            ["OnlinePush.PbPushTransMsg"] = DecodeOnlinePushTransPacket,
            ["ConfigPushSvc.PushReq"] = DecodePushReqPacket,
            ["MessageSvc.PbGetMsg"] = DecodeMessageSvcPacket,
            ["MessageSvc.PushForceOffline"] = DecodeForceOfflinePacket,
            ["PbMessageSvc.PbMsgWithDraw"] = DecodeMsgWithDrawResponse,
            ["friendlist.getFriendGroupList"] = DecodeFriendGroupListResponse,
            ["friendlist.delFriend"] = DecodeFriendDeleteResponse,
            ["friendlist.GetTroopListReqV2"] = DecodeGroupListResponse,
            ["friendlist.GetTroopMemberListReq"] = DecodeGroupMemberListResponse,
            ["group_member_card.get_group_member_card_info"] = DecodeGroupMemberInfoResponse,
            ["PttStore.GroupPttUp"] = DecodeGroupPttStoreResponse,
            ["LongConn.OffPicUp"] = DecodeOffPicUpResponse,
            ["ProfileService.Pb.ReqSystemMsgNew.Group"] = DecodeSystemMsgGroupPacket,
            ["ProfileService.Pb.ReqSystemMsgNew.Friend"] = DecodeSystemMsgFriendPacket,
            ["OidbSvc.0xd79"] = DecodeWordSegmentation,
            ["OidbSvc.0x990"] = DecodeTranslateResponse,
            ["SummaryCard.ReqSummaryCard"] = DecodeSummaryCardResponse,
            ["LightAppSvc.mini_app_info.GetAppInfoById"] = DecodeAppInfoResponse
        };

        private static LoginResponse DecodeLoginResponse(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private static LoginResponse DecodeExchangeEmpResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private static LoginResponse DecodeTransEmpResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private static LoginResponse DecodeClientRegisterResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private static LoginResponse DecodeMsfOfflinePacket(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private static LoginResponse DecodeSvcNotify(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private static LoginResponse DecodeOnlinePushReqPacket(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private static LoginResponse DecodeOnlinePushTransPacket(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private static LoginResponse DecodePushReqPacket(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private static LoginResponse DecodeMessageSvcPacket(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private static LoginResponse DecodeForceOfflinePacket(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private static LoginResponse DecodeMsgWithDrawResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private static LoginResponse DecodeFriendGroupListResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private static LoginResponse DecodeFriendDeleteResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private static LoginResponse DecodeGroupListResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private static LoginResponse DecodeGroupMemberListResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private static LoginResponse DecodeGroupMemberInfoResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private static LoginResponse DecodeGroupPttStoreResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();

        }

        private static LoginResponse DecodeOffPicUpResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private static LoginResponse DecodeSystemMsgGroupPacket(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private static LoginResponse DecodeSystemMsgFriendPacket(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private static LoginResponse DecodeWordSegmentation(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private static LoginResponse DecodeTranslateResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private static LoginResponse DecodeSummaryCardResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private static LoginResponse DecodeAppInfoResponse(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }
    }
}
