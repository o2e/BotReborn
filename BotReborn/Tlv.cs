using System;

namespace BotReborn
{
    public static class Tlv
    {
        public static byte[] T1(uint uin, byte[] ip)
        {
            if (ip.Length != 4)
            {
                throw new Exception("Invalid ip");
            }

            var b = new BinaryStream();
            b.WriteUInt16(0x01);
            b.WriteBytesShort(new Func<byte[]>(() =>
           {
               var stream = new BinaryStream();
               stream.WriteUInt16(1)
                    .WriteUInt32((uint)new Random().Next())
                    .WriteUInt32(uin)
                    .WriteUInt32((uint)DateTimeOffset.UtcNow.ToUnixTimeMilliseconds())
                    .Write(ip)
                    .WriteUInt16(0);
               return stream.ToArray();
           }).Invoke());

            return b.ToArray();
        }

        public static byte[] T1B(uint micro, uint version, uint size, uint margin, uint dpi, uint ecLevel, uint hint)
        {
            var stream = new BinaryStream();
            stream.WriteUInt16(0x1B);
            stream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var binaryStream = new BinaryStream();
                binaryStream.WriteUInt32(micro)
                    .WriteUInt32(version)
                    .WriteUInt32(size)
                    .WriteUInt32(margin)
                    .WriteUInt32(dpi)
                    .WriteUInt32(ecLevel)
                    .WriteUInt32(hint)
                    .WriteUInt16(0);
                return binaryStream.ToArray();
            }).Invoke());

            return stream.ToArray();
        }

        public static byte[] T1D(uint miscBitmap)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x1D);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var stream = new BinaryStream();
                stream.WriteByte(1)
                    .WriteUInt32(miscBitmap)
                    .WriteUInt32(0)
                    .WriteByte(0)
                    .WriteUInt32(0);
                return stream.ToArray();
            }).Invoke());

            return binaryStream.ToArray();
        }
    }
}
