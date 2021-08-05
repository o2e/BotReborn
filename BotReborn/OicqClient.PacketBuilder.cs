using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BotReborn.Crypto;

namespace BotReborn
{
    partial class OicqClient
    {
        public byte[] BuildOicqRequestPacket(long uin, ushort commandId, EncryptEcdh ecdh, byte[] key, Action<BinaryStream> bodyFunc)
        {
            var stream = new BinaryStream();
            bodyFunc.Invoke(stream);
            var body = ecdh.DoEncrypt(stream.ToArray(), key);
            var result = new BinaryStream();
            result.WriteByte(0x02)
                .WriteUInt16((ushort)(27 + 2 + body.Length))
                .WriteUInt16(8001)
                .WriteUInt16(commandId)
                .WriteUInt16(1)
                .WriteUInt32((uint)uin)
                .WriteByte(3)
                .WriteByte(ecdh.Id)
                .WriteByte(0)
                .WriteUInt32(2)
                .WriteUInt32(0)
                .WriteUInt32(0)
                .Write(body)
                .WriteByte(0x03);
            return result.ToArray();
        }

        public (ushort, byte[]) BuildLoginPacket()
        {
            var seq = NextSeq();
            var req = BuildOicqRequestPacket(Uin, 0x0801, _ecdh, RandomKey, w =>
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
                        DeviceInfo.GenDeviceInfoData(),
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


            throw new NotImplementedException();
        }

        public (ushort, byte[]) BuildDeviceLockLoginPacket()
        {
            throw new NotImplementedException();
        }

        public (ushort, byte[]) BuildQrCodeFetchRequestPacket()
        {
            throw new NotImplementedException();
        }

        public (ushort, byte[]) BuildQrCodeResultQueryRequestPacket()
        {
            throw new NotImplementedException();
        }

        public (ushort, byte[]) BuildQrCodeLoginPacket()
        {
            throw new NotImplementedException();
        }

        public (ushort, byte[]) BuildCaptchaPacket()
        {
            throw new NotImplementedException();
        }
    }
}
