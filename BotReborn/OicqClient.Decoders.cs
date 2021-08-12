using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BotReborn.Jce;
using BotReborn.Model;
using BotReborn.Model.Entities;
using BotReborn.Packets;
using BotReborn.Protos;

using Microsoft.Extensions.Logging;

namespace BotReborn
{
    public partial class OicqClient
    {

        private Func<OicqClient, IncomingPacketInfo, byte[], object> GetDecoderByName(string name)
        {
            return name switch
            {
                "wtlogin.login" => DecodeLoginResponse,
                "wtlogin.exchange_emp" => DecodeExchangeEmpResponse,
                "SummaryCard.ReqSummaryCard" => DecodeSummaryCardResponse,
                "LightAppSvc.mini_app_info.GetAppInfoById" => DecodeAppInfoResponse,
                _ => null
            };
        }
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
                var h = Utils.Md5.ComputeHash(DeviceInfo.Guid.Concat(Dpwd).Concat(T402).ToArray());
                G = h[..];
            }

            if (t == 0)
            {
                if (map.TryGetValue(0x150, out var t150))
                {
                    T150 = t150;
                }
                if (map.TryGetValue(0x161, out var t161))
                {
                    DecodeT161(t161);
                }

                if (map.ContainsKey(0x403))
                {
                    RandSeed = map[0x403];
                }
                DecodeT119(map[0x119], DeviceInfo.TgtgtKey);
                return new LoginResponse() { IsSuccessful = true };
            }

            if (t == 2)
            {
                T104 = map[0x104];
                if (map.ContainsKey(0x192))
                {
                    return new LoginResponse()
                    {
                        IsSuccessful = false,
                        VerifyUrl = Encoding.UTF8.GetString(map[0x192]),
                        ErrorMessage = "Slider Needed Error"
                    };
                }

                if (map.ContainsKey(0x165))
                {
                    var imgData = new BinaryStream(map[0x105]);
                    var signLen = imgData.ReadUInt16();
                    imgData.ReadUInt16();
                    var sign = imgData.ReadBytes(signLen);
                    return new LoginResponse()
                    {
                        IsSuccessful = false,
                        ErrorMessage = "NeedCaptcha",
                        CaptchaImage = imgData.ReadAvailable().ToArray(),
                        CaptchaSign = sign.ToArray()
                    };
                }
                else
                {
                    return new LoginResponse() { IsSuccessful = false, ErrorMessage = "UnknownLoginError" };
                }
            }// need captcha

            if (t == 40)
            {
                return new LoginResponse() { IsSuccessful = false, ErrorMessage = "账号被冻结", };
            }

            if (t == 160 || t == 239)
            {
                if (map.TryGetValue(0x174, out var t174))
                { // 短信验证
                    T104 = map[0x104];
                    T174 = t174;
                    RandSeed = map[0x403];
                    var phone = ((Func<string>)(() =>
                    {
                        var s = new BinaryStream(map[0x178]);
                        return s.ReadStringLimit(s.ReadInt32());
                    }))();


                    if (map.TryGetValue(0x204, out var tt204))
                    { // 同时支持扫码验证 ?
                        return new LoginResponse
                        {
                            IsSuccessful = false,
                            ErrorMessage = Encoding.UTF8.GetString(map[0x17e]),
                            VerifyUrl = Encoding.UTF8.GetString(tt204),
                            SmsPhone = phone
                        };
                    }

                    return new LoginResponse
                    {
                        IsSuccessful = false,
                        ErrorMessage = Encoding.UTF8.GetString(map[0x17e]),
                        SmsPhone = phone
                    };
                }

                if (map.ContainsKey(0x17b))
                { // 二次验证
                    T104 = map[0x104];
                    return new LoginResponse { IsSuccessful = false, ErrorMessage = "SMS Needed" };
                }

                if (map.TryGetValue(0x204, out var t204))
                { // 扫码验证
                    return new LoginResponse
                    {
                        IsSuccessful = false,
                        VerifyUrl = Encoding.UTF8.GetString(t204),
                        ErrorMessage = "UnsafeDeviceError"
                    };


                }
            }

            if (t == 162)
            {
                return new LoginResponse() { ErrorMessage = "TooManySMSRequestError" };
            }

            if (t == 204)
            {// drive lock
                T104 = map[0x104];
                RandSeed = map[0x403];
                return SendAndWait(BuildDeviceLockLoginPacket(out var seq), seq);
            }

            if (map.TryGetValue(0x149, out var t149))
            {
                var s = new BinaryStream(t149);
                s.ReadBytes(2);
                s.ReadStringShort();//title
                return new LoginResponse() { IsSuccessful = false, ErrorMessage = s.ReadStringShort() };
            }

            if (map.TryGetValue(0x146, out var t146))
            {
                var s = new BinaryStream(t146);
                s.ReadBytes(4);
                s.ReadStringShort();//title
                return new LoginResponse() { IsSuccessful = false, ErrorMessage = s.ReadStringShort() };
            }
            Logger.LogDebug("Unknown login response:{0}", t);
            foreach (var (k, v) in map)
            {
                Logger.LogDebug("Type: {0} Value: {1}", k.ToString("X16"), Utils.ConvertByteArrayToHexString(v));
            }
            throw new Exception($"Unknown login response:{t}");
        }

        private object DecodeExchangeEmpResponse(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            var b = new BinaryStream(payload);
            var cmd = b.ReadUInt16();
            var t = b.ReadByte();
            b.ReadUInt16();
            var m = b.ReadTlvMap(2);

            if (t != 0)
            {
                Logger.LogError("Emp error.");
                return null;
            }

            if (cmd == 15)
            {
                DecodeT119R(m[0x119]);
            }

            if (cmd == 11)
            {
                DecodeT119(m[0x119], Utils.Md5.ComputeHash(SigInfo.D2Key));
            }

            return null;
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
            var pkt = D388RespBody.Parser.ParseFrom(payload);
            var rsp = pkt.MsgTryUpPttRsp[0];

            if (rsp.Result != 0)
            {
                return new PttUploadResponse { ResultCode = rsp.Result, Message = rsp.FailMsg };
            }

            if (rsp.BoolFileExit)
            {
                return new PttUploadResponse { IsExists = true };
            }

            var ips = new List<string>();
            foreach (var i in rsp.Uint32UpIp)
            {
                ips.Add(Utils.UInt32ToIpv4Address((uint)i));
            }

            return new PttUploadResponse
            {
                UploadKey = rsp.UpUkey.ToByteArray(),
                UploadIp = ips.ToArray(),
                UploadPort = rsp.Uint32UpPort.ToArray(),
                FileKey = rsp.FileKey.ToByteArray(),
                FileId = rsp.FileId
            };
        }

        private object DecodeOffPicUpResponse(OicqClient client, IncomingPacketInfo packet, byte[] payload)
        {
            var rsp = RspBody.Parser.ParseFrom(payload);
            if (rsp.FailMsg is not null)
            {
                return new ImageUploadResponse { ResultCode = -1, Message = rsp.FailMsg.ToString() };
            }

            if (rsp.Subcmd != 1 || rsp.TryupImgRsp.Count != 0)
            {
                return new ImageUploadResponse { ResultCode = -2 };
            }

            var imgRsp = rsp.TryupImgRsp[0];

            if (imgRsp.Result != 0)
            {
                return new ImageUploadResponse { ResultCode = (int)imgRsp.Result, Message = imgRsp.FailMsg.ToString() };
            }

            if (imgRsp.FileExit)
            {
                return new ImageUploadResponse { IsExists = true, ResourceId = imgRsp.UpResid.ToString() };
            }

            return new ImageUploadResponse
            {
                ResourceId = imgRsp.UpResid.ToString(),
                UploadKey = imgRsp.UpUkey.ToByteArray(),
                UploadIp = imgRsp.UpIp.ToArray(),
                UploadPort = imgRsp.UpPort.ToArray()
            };
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
