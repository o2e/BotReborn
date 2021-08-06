using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotReborn.Packets;

namespace BotReborn
{
    public partial class OicqClient
    {
        //private  Dictionary<string, Func<OicqClient, IncomingPacketInfo, byte[], LoginResponse>> _decoders = new Dictionary<string, Func<OicqClient, IncomingPacketInfo, byte[], LoginResponse>>()
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

        private LoginResponse DecodeLoginResponse(OicqClient client, IncomingPacketInfo packet, byte[] payload)
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
                G = h[..];
            }

            if (t==0)
            {
                if (map.TryGetValue(0x150,out var t150))
                {
                    T150 = t150;
                }
                if (map.TryGetValue(0x161, out var t161))
                {
                    T150 = t150;
                }
            }
            throw new NotImplementedException();
        }

        private  LoginResponse DecodeExchangeEmpResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private  LoginResponse DecodeTransEmpResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private  LoginResponse DecodeClientRegisterResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private  LoginResponse DecodeMsfOfflinePacket(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private  LoginResponse DecodeSvcNotify(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private  LoginResponse DecodeOnlinePushReqPacket(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private  LoginResponse DecodeOnlinePushTransPacket(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private  LoginResponse DecodePushReqPacket(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private  LoginResponse DecodeMessageSvcPacket(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private  LoginResponse DecodeForceOfflinePacket(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private  LoginResponse DecodeMsgWithDrawResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private  LoginResponse DecodeFriendGroupListResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private  LoginResponse DecodeFriendDeleteResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private  LoginResponse DecodeGroupListResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private  LoginResponse DecodeGroupMemberListResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private  LoginResponse DecodeGroupMemberInfoResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private  LoginResponse DecodeGroupPttStoreResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();

        }

        private  LoginResponse DecodeOffPicUpResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private  LoginResponse DecodeSystemMsgGroupPacket(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private  LoginResponse DecodeSystemMsgFriendPacket(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private  LoginResponse DecodeWordSegmentation(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        
        private  LoginResponse DecodeTranslateResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private  LoginResponse DecodeSummaryCardResponse(OicqClient client, IncomingPacketInfo packet,
            byte[] payload)
        {
            throw new NotImplementedException();
        }

        private  LoginResponse DecodeAppInfoResponse(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private void DecodeT161(byte[] data)
        {
            var stream = new BinaryStream(data);
            stream.ReadBytes(2);
            var t = stream.ReadTlvMap(2);
            if (t.TryGetValue(0x172,out var t172))
            {
                RollbackSig = t172;
            }
        }
    }
}
