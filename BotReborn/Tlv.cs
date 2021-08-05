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
           })());

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
            })());

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
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T1F(bool isRoot, byte[] osName, byte[] osVersion, byte[] simOperatorName, byte[] apn, ushort networkType)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x1F);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteByte(isRoot ? Convert.ToByte(1) : Convert.ToByte(0))
                    .WriteBytesShort(osName)
                    .WriteBytesShort(osVersion)
                    .WriteUInt16(networkType)
                    .WriteBytesShort(simOperatorName)
                    .WriteBytesShort(new byte[0])
                    .WriteBytesShort(apn);
                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T2(string result, byte[] sign)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x02);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteUInt16(0)
                    .WriteStringShort(result)
                    .WriteBytesShort(sign);
                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T8(uint localId)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x8);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteUInt16(0)
                    .WriteUInt32(localId)
                    .WriteUInt16(0);

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T10A(byte[] arr)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x10A)
                .WriteBytesShort(arr);

            return binaryStream.ToArray();
        }

        public static byte[] T16(uint ssoVersion, uint appId, uint subAppId, byte[] guid, byte[] apkId, byte[] apkVersionName, byte[] apkSign)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x16);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteUInt32(ssoVersion)
                    .WriteUInt32(appId)
                    .WriteUInt32(subAppId)
                    .Write(guid)
                    .WriteBytesShort(apkId)
                    .WriteBytesShort(apkVersionName)
                    .WriteBytesShort(apkSign);

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T16A(byte[] arr)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x16A)
                .WriteBytesShort(arr);

            return binaryStream.ToArray();
        }

        public static byte[] T16E(byte[] buildModel)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x16e);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.Write(buildModel);

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T17A(int value)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x17a);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteUInt32((uint)value);

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T17C(string code)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x17c);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteStringShort(code);

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T18(uint appId, uint uin)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x18);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteUInt16(1)
                    .WriteUInt32(1536)
                    .WriteUInt32(appId)
                    .WriteUInt32(0)
                    .WriteUInt32(uin)
                    .WriteUInt16(0)
                    .WriteUInt16(0);

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T33(byte[] guid)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x33);
            binaryStream.WriteBytesShort(guid);

            return binaryStream.ToArray();
        }

        public static byte[] T35(uint productType)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x35);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteUInt32(productType);

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T52D()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T100()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T104()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T106()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T107()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T108()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T109()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T116()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T124()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T128()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T141()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T142()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T143()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T144()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T145()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T147()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T154()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T166()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T174()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T177()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T187()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T188()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T191()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T193()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T194()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T197()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T198()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T202()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T400()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T401()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T511()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T516()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T521()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T525()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }

        public static byte[] T536()
        {
            var binaryStream = new BinaryStream(); return binaryStream.ToArray();
        }
    }
}
