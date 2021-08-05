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
                    .Write(Tlv.T1(Uin, DeviceInfo.IpAddress));

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
