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
            var req = Packet.BuildOicqRequestPacket(Uin, 0x0801, _ecdh, RandomKey, w =>
            {
                w.WriteUInt16(9)
                    .WriteUInt16(AllowSlider ? (ushort)0x17 : (ushort)0x16)
                    .Write(Tlv.T18(16, Uin))
                    .Write(Tlv.T1(Uin, DeviceInfo.IpAddress))
                    .Write(Tlv.T106(Uin, 0, Version.AppId, Version.SSOVersion, PasswordMd5, true, DeviceInfo.Guid, DeviceInfo.TgtgtKey, 0))
                    .Write(Tlv.T116(Version.MiscBitmap, Version.SubSigmap))
                    .Write(Tlv.T100(Version.SSOVersion, Version.SubAppId, Version.MainSigMap))
                    .Write(Tlv.T107(0))
                    .Write(Tlv.T142(Version.ApkId))
                    .Write(Tlv.T144(Encoding.UTF8.GetBytes(DeviceInfo.IMEI),
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
                        DeviceInfo.TgtgtKey))
                    .Write(Tlv.T145(DeviceInfo.Guid))
                    .Write(Tlv.T147(16, Encoding.UTF8.GetBytes(Version.SortVersionName), Version.ApkSign))
                    .Write(Tlv.T154(seq))
                    .Write(Tlv.T141(DeviceInfo.SimInfo, DeviceInfo.APN))
                    .Write(Tlv.T8(2052))
                    .Write(Tlv.T511(new[]{"tenpay.com", "openmobile.qq.com", "docs.qq.com", "connect.qq.com",
                        "qzone.qq.com", "vip.qq.com", "gamecenter.qq.com", "qun.qq.com", "game.qq.com",
                        "qqweb.qq.com", "office.qq.com", "ti.qq.com", "mail.qq.com", "mma.qq.com"}))
                    .Write(Tlv.T187(DeviceInfo.MacAddress))
                    .Write(Tlv.T188(DeviceInfo.AndroidId));
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

                w.Write(Tlv.T177(Version.BuildTime, Version.SdkVersion))
                    .Write(Tlv.T516())
                    .Write(Tlv.T521(0))
                    .Write(Tlv.T525(Tlv.T536(new byte[] { 0x01, 0x00 })));
            });
            var sso = Packet.BuildSsoPacket(seq, Version.AppId, Version.SubAppId, "wtlogin.login", DeviceInfo.IMEI, Array.Empty<byte>(), OutGoingPacketSessionId, req, Ksid);
            var packet = Packet.BuildLoginPacket(0, 2, new byte[16], sso, new byte[0]);

            seqOut = seq;
            return packet;
        }

        public byte[] BuildDeviceLockLoginPacket(out ushort seqOut)
        {
            throw new NotImplementedException();
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
