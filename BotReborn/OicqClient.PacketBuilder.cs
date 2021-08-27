using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BotReborn.Crypto;
using BotReborn.Packets;

namespace BotReborn
{
    partial class OicqClient
    {
        public byte[] BuildLoginPacket(out ushort seqOut)
        {
            var seq = NextSeq();
            var req = Packet.BuildOicqRequestPacket(Uin, 0x0810, _ecdh, RandomKey, w =>
            {
                w.WriteUInt16(9);
                w.WriteUInt16(AllowSlider ? (ushort)0x17 : (ushort)0x16);
                w.Write(Tlv.T18(16, Uin));
                w.Write(Tlv.T1(Uin, DeviceInfo.IpAddress));
                w.Write(Tlv.T106(Uin, 0, Protocol.AppId, Protocol.SSOVersion, PasswordMd5, true, DeviceInfo.Guid, DeviceInfo.TgtgtKey, 0));
                w.Write(Tlv.T116(Protocol.MiscBitmap, Protocol.SubSigMap));
                w.Write(Tlv.T100(Protocol.SSOVersion, Protocol.SubAppId, Protocol.MainSigMap));
                w.Write(Tlv.T107(0));
                w.Write(Tlv.T142(Protocol.ApkId));
                w.Write(Tlv.T144(Encoding.UTF8.GetBytes(DeviceInfo.IMEI),
                                 DeviceInfo.GetDeviceInfoData(),
                                 DeviceInfo.OSType,
                                 DeviceInfo.Version.Release,
                                 DeviceInfo.SimInfo,
                                 DeviceInfo.APN,
                                 false,
                                 true,
                                 false,
                                 Tlv.GuidFlag,
                                 DeviceInfo.Model,
                                 DeviceInfo.Guid,
                                 DeviceInfo.Brand,
                                 DeviceInfo.TgtgtKey));
                w.Write(Tlv.T145(DeviceInfo.Guid));
                w.Write(Tlv.T147(16, Encoding.UTF8.GetBytes(Protocol.SortVersionName), Protocol.ApkSign));
                w.Write(Tlv.T154(seq));
                w.Write(Tlv.T141(DeviceInfo.SimInfo, DeviceInfo.APN));
                w.Write(Tlv.T8(2052));
                w.Write(Tlv.T511(new[]{"tenpay.com", "openmobile.qq.com", "docs.qq.com", "connect.qq.com",
                        "qzone.qq.com", "vip.qq.com", "gamecenter.qq.com", "qun.qq.com", "game.qq.com",
                        "qqweb.qq.com", "office.qq.com", "ti.qq.com", "mail.qq.com", "mma.qq.com"}));
                w.Write(Tlv.T187(DeviceInfo.MacAddress));
                w.Write(Tlv.T188(DeviceInfo.AndroidId));
                if (DeviceInfo.IMSIMd5.Length != 0)
                {
                    w.Write(Tlv.T194(DeviceInfo.IMSIMd5));
                }

                if (AllowSlider)
                {
                    w.Write(Tlv.T191(0x82));
                }

                if (DeviceInfo.WifiBSSID.Length != 0 && DeviceInfo.WifiSSID.Length != 0)
                {
                    w.Write(Tlv.T202(DeviceInfo.WifiBSSID, DeviceInfo.WifiSSID));
                }

                w.Write(Tlv.T177(Protocol.BuildTime, Protocol.SdkVersion));
                w.Write(Tlv.T516());
                w.Write(Tlv.T521(0));
                w.Write(Tlv.T525(Tlv.T536(new byte[] { 0x01, 0x00 })));
            });
            var sso = Packet.BuildSsoPacket(seq, Protocol.AppId, Protocol.SubAppId, "wtlogin.login", DeviceInfo.IMEI, Array.Empty<byte>(), OutGoingPacketSessionId, req, Ksid);
            var packet = Packet.BuildLoginPacket(Uin, 2, new byte[16], sso, Array.Empty<byte>());

            seqOut = seq;
            return packet;
        }

        public byte[] BuildDeviceLockLoginPacket(out ushort seqId)
        {
            var seq = NextSeq();

            var req = Packet.BuildOicqRequestPacket(Uin, 0x0810, _ecdh, RandomKey, w =>
             {
                 w.WriteUInt16(20)
                     .WriteUInt16(4)
                     .Write(Tlv.T8(2052))
                     .Write(Tlv.T104(T104))
                     .Write(Tlv.T116(Protocol.MiscBitmap, Protocol.SubSigMap))
                     .Write(Tlv.T401(G));
             });
            var sso = Packet.BuildSsoPacket(seq, Protocol.AppId, Protocol.SubAppId, "wtlogin.login", DeviceInfo.IMEI,
                Array.Empty<byte>(), OutGoingPacketSessionId, req, Ksid);
            var packet = Packet.BuildLoginPacket(Uin, 2, new byte[16], sso, Array.Empty<byte>());
            seqId = seq;
            return packet;
        }

        public byte[] BuildQrCodeFetchRequestPacket(out ushort seqOut)
        {
            throw new NotImplementedException();
        }

        public byte[] BuildQrCodeResultQueryRequestPacket(out ushort seqOut)
        {
            throw new NotImplementedException();
        }

        public byte[] BuildQrCodeLoginPacket(out ushort seqOut)
        {
            throw new NotImplementedException();
        }

        public byte[] BuildCaptchaPacket(out ushort seqOut)
        {
            throw new NotImplementedException();
        }
    }
}
