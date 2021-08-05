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

        public static byte[] T1F() => throw new NotImplementedException();
        public static byte[] T2() => throw new NotImplementedException();
        public static byte[] T8() => throw new NotImplementedException();
        public static byte[] T10A() => throw new NotImplementedException();
        public static byte[] T16() => throw new NotImplementedException();
        public static byte[] T16A() => throw new NotImplementedException();
        public static byte[] T16E() => throw new NotImplementedException();
        public static byte[] T17A() => throw new NotImplementedException();
        public static byte[] T17C() => throw new NotImplementedException();
        public static byte[] T18() => throw new NotImplementedException();
        public static byte[] T33() => throw new NotImplementedException();
        public static byte[] T35() => throw new NotImplementedException();
        public static byte[] T52D() => throw new NotImplementedException();
        public static byte[] T100() => throw new NotImplementedException();
        public static byte[] T104() => throw new NotImplementedException();
        public static byte[] T106() => throw new NotImplementedException();
        public static byte[] T107() => throw new NotImplementedException();
        public static byte[] T108() => throw new NotImplementedException();
        public static byte[] T109() => throw new NotImplementedException();
        public static byte[] T116() => throw new NotImplementedException();
        public static byte[] T124() => throw new NotImplementedException();
        public static byte[] T128() => throw new NotImplementedException();
        public static byte[] T141() => throw new NotImplementedException();
        public static byte[] T142() => throw new NotImplementedException();
        public static byte[] T143() => throw new NotImplementedException();
        public static byte[] T144() => throw new NotImplementedException();
        public static byte[] T145() => throw new NotImplementedException();
        public static byte[] T147() => throw new NotImplementedException();
        public static byte[] T154() => throw new NotImplementedException();
        public static byte[] T166() => throw new NotImplementedException();
        public static byte[] T174() => throw new NotImplementedException();
        public static byte[] T177() => throw new NotImplementedException();
        public static byte[] T187() => throw new NotImplementedException();
        public static byte[] T188() => throw new NotImplementedException();
        public static byte[] T191() => throw new NotImplementedException();
        public static byte[] T193() => throw new NotImplementedException();
        public static byte[] T194() => throw new NotImplementedException();
        public static byte[] T197() => throw new NotImplementedException();
        public static byte[] T198() => throw new NotImplementedException();
        public static byte[] T202() => throw new NotImplementedException();
        public static byte[] T400() => throw new NotImplementedException();
        public static byte[] T401() => throw new NotImplementedException();
        public static byte[] T511() => throw new NotImplementedException();
        public static byte[] T516() => throw new NotImplementedException();
        public static byte[] T521() => throw new NotImplementedException();
        public static byte[] T525() => throw new NotImplementedException();
        public static byte[] T536() => throw new NotImplementedException();
    }
}
