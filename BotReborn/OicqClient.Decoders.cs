using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BotReborn.Packets;
using BotReborn.Protos;

using Microsoft.Extensions.Logging;

namespace BotReborn
{
    public partial class OicqClient
    {
        //private  Dictionary<string, Func<OicqClient, IncomingPacketInfo, byte[], object>> _decoders = new Dictionary<string, Func<OicqClient, IncomingPacketInfo, byte[], object>>()
        //{
        //    ["wtlogin.login"] = DecodeLoginResponse,
        //    ["wtlogin.exchange_emp"] = DecodeExchangeEmpResponse,
        //    ["wtlogin.trans_emp"] = DecodeTransEmpResponse,
        //    ["StatSvc.register"] = DecodeClientRegisterResponse,
        //    ["StatSvc.ReqMSFOffline"] = DecodeMsfOfflinePacket,
        //    ["MessageSvc.PushNotify"] = DecodeSvcNotify,
        //    ["OnlinePush.ReqPush"] = DecodeOnlinePushReqPacket,
        //    ["OnlinePush.PbPushTransMsg"] = DecodeOnlinePushTransPacket,
        //    ["ConfigPushSvc.PushReq"] = DecodePushReqPacket,
        //    ["MessageSvc.PbGetMsg"] = DecodeMessageSvcPacket,
        //    ["MessageSvc.PushForceOffline"] = DecodeForceOfflinePacket,
        //    ["PbMessageSvc.PbMsgWithDraw"] = DecodeMsgWithDrawResponse,
        //    ["friendlist.getFriendGroupList"] = DecodeFriendGroupListResponse,
        //    ["friendlist.delFriend"] = DecodeFriendDeleteResponse,
        //    ["friendlist.GetTroopListReqV2"] = DecodeGroupListResponse,
        //    ["friendlist.GetTroopMemberListReq"] = DecodeGroupMemberListResponse,
        //    ["group_member_card.get_group_member_card_info"] = DecodeGroupMemberInfoResponse,
        //    ["PttStore.GroupPttUp"] = DecodeGroupPttStoreResponse,
        //    ["LongConn.OffPicUp"] = DecodeOffPicUpResponse,
        //    ["ProfileService.Pb.ReqSystemMsgNew.Group"] = DecodeSystemMsgGroupPacket,
        //    ["ProfileService.Pb.ReqSystemMsgNew.Friend"] = DecodeSystemMsgFriendPacket,
        //    ["OidbSvc.0xd79"] = DecodeWordSegmentation,
        //    ["OidbSvc.0x990"] = DecodeTranslateResponse,
        //    ["SummaryCard.ReqSummaryCard"] = DecodeSummaryCardResponse,
        //    ["LightAppSvc.mini_app_info.GetAppInfoById"] = DecodeAppInfoResponse
        //};

        private object DecodeLoginResponse(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            var stream = new BinaryStream(payload);
            stream.ReadUInt16();
            var t = (byte)stream.ReadByte();
            stream.ReadUInt16();
            var map = stream.ReadTlvMap(2);
            if (map.ContainsKey(0x402))
            {
                Dpwd = Encoding.UTF8.GetBytes(Utils.GetRandomString(16));
                T402 = map[0x402];
                var h = _md5.ComputeHash(DeviceInfo.Guid.Concat(Dpwd).Concat(T402).ToArray());
            }
            throw new NotImplementedException();
        }

        private object DecodeExchangeEmpResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeTransEmpResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeClientRegisterResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeMsfOfflinePacket(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeSvcNotify(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeOnlinePushReqPacket(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeOnlinePushTransPacket(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodePushReqPacket(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeMessageSvcPacket(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeForceOfflinePacket(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeMsgWithDrawResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeFriendGroupListResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeFriendDeleteResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeGroupListResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeGroupMemberListResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeGroupMemberInfoResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeGroupPttStoreResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();

        }

        private object DecodeOffPicUpResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeSystemMsgGroupPacket(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeSystemMsgFriendPacket(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeWordSegmentation(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeTranslateResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeSummaryCardResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeAppInfoResponse(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            var p = QWebRsp.Parser;
            var q = GetAppInfoByIdRsp.Parser;
            var pkg = p.ParseFrom(payload);

            if (pkg.RetCode != 0)
            {
                Logger.LogError(pkg.ErrMsg);
                return null;
            }

            var rsp = q.ParseFrom(pkg.BusiBuff);
            return rsp.AppInfo;
        }
    }
}
