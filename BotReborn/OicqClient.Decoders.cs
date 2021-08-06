using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BotReborn.Jce;
using BotReborn.Model;
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

        private object DecodeExchangeEmpResponse(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeTransEmpResponse(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeClientRegisterResponse(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeMsfOfflinePacket(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeSvcNotify(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeOnlinePushReqPacket(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeOnlinePushTransPacket(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodePushReqPacket(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeMessageSvcPacket(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeForceOfflinePacket(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeMsgWithDrawResponse(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeFriendGroupListResponse(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeFriendDeleteResponse(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeGroupListResponse(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeGroupMemberListResponse(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeGroupMemberInfoResponse(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeGroupPttStoreResponse(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();

        }

        private object DecodeOffPicUpResponse(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeSystemMsgGroupPacket(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeSystemMsgFriendPacket(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            throw new NotImplementedException();
        }

        private object DecodeWordSegmentation(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            var pkg = OIDBSSOPkg.Parser.ParseFrom(payload);
            var rsp = D79RspBody.Parser.ParseFrom(pkg.Bodybuffer);
            if (rsp.Content is not null)
            {
                return rsp.Content;
            }

            Logger.LogError("No word received.");
            return null;
        }

        private object DecodeTranslateResponse(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            var pkg = OIDBSSOPkg.Parser.ParseFrom(payload);
            var rsp = TranslateRspBody.Parser.ParseFrom(pkg.Bodybuffer);

            return rsp.BatchTranslateRsp;
        }

        private object DecodeSummaryCardResponse(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            var request = new JceStructs.RequestPacket();
            request.ReadFrom(new JceStream(payload));
            var data = new JceStructs.RequestDataVersion2();
            data.ReadFrom(new JceStream(request.SBuffer));
            JceStream rsp = new Func<JceStream>(() =>
            {
                if (data.Map.TryGetValue("RespSummaryCard", out var d1))
                {
                    if (d1.TryGetValue("SummaryCard.RespSummaryCard", out var b))
                    {
                        return new JceStream(b[1..]);
                    }
                }

                return new JceStream(data.Map["RespSummaryCard"]["SummaryCard_Old.RespSummaryCard"][1..]);
            })();

            var info = new SummaryCardInfo
            {
                Sex = (byte)rsp.ReadByte(1),
                Age = (byte)rsp.ReadByte(2),
                Nickname = rsp.ReadString(3),
                Level = rsp.ReadInt32(5),
                City = rsp.ReadString(7),
                Sign = rsp.ReadString(8),
                Mobile = rsp.ReadString(11),
                Uin = rsp.ReadInt64(23),
                LoginDays = rsp.ReadInt64(36),
            };

            var services = (byte[][])rsp.ReadSlice(typeof(byte[][]), 46);
            var readService = new Func<byte[], (BusiComm, byte[])>(buf =>
              {
                  var b = new BinaryStream(buf);
                  b.ReadByte();
                  var l1 = b.ReadInt32();
                  var l2 = b.ReadInt32();
                  var comm = b.ReadBytes(l1);
                  var d = b.ReadBytes(l2);
                  var c = BusiComm.Parser.ParseFrom(comm);
                  return (c, d.ToArray());
              });

            foreach (var service in services)
            {
                var (comm, p) = readService(service);
                if (comm.Service == 16)
                {
                    var r = GateVaProfileGateRsp.Parser.ParseFrom(p);
                    if (r is not null)
                    {
                        info.Qid = r.QidInfo.Qid;
                    }
                }
            }

            return info;
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
