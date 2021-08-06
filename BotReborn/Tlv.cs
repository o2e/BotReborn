using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BotReborn
{
    public static class Tlv
    {
        public static uint GuidFlag
        {
            get
            {
                uint flag = 0;
                flag |= 1 << 24 & 0xFF000000;
                flag |= 0 << 8 & 0xFF00;
                return flag;
            }
        }

        public static byte[] T1(Uin uin, byte[] ip)
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
                    .WriteUInt32((uint)uin)
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

        public static byte[] T18(uint appId, Uin uin)
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

        public static byte[] T52D(byte[] devInfo)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x52d);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.Write(devInfo);

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T100(uint ssoVersion, uint protocol, uint mainSigMap)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x100);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteUInt16(1)
                    .WriteUInt32(ssoVersion)
                    .WriteUInt32(16)
                    .WriteUInt32(protocol)
                    .WriteUInt32(0)          // App client version
                    .WriteUInt32(mainSigMap); // 34869472

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T104(byte[] data)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x104);
            binaryStream.WriteBytesShort(data);

            return binaryStream.ToArray();
        }

        public static byte[] T106(Uin uin, uint salt, uint appId, uint ssoVer, byte[] passwordMd5, bool guidAvailable, byte[] guid, byte[] tgtgtKey, uint wtf)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x106);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var a = new byte[4];
                BinaryPrimitives.WriteUInt32BigEndian(a, salt != 0 ? salt : uin);
                var c = passwordMd5.Concat(new byte[] { 0x00, 0x00, 0x00, 0x00 }).Concat(a);
                var key = MD5.Create().ComputeHash(c.ToArray());
                var s = new BinaryStream();
                s.EncryptAndWrite(key, new Func<byte[]>(() =>
                 {
                     var b = new BinaryStream();
                     b.WriteUInt16(4)
                         .WriteUInt32((uint)new Random().Next())
                         .WriteUInt32(ssoVer)
                         .WriteUInt32(16) // appId
                         .WriteUInt32(0);  // app client version

                     if (uin == 0)
                     {
                         b.WriteUInt64(salt);
                     }
                     else
                     {
                         b.WriteUInt64(uin);
                     }

                     b.WriteUInt32((uint)DateTimeOffset.UtcNow.Millisecond)
                         .Write(new byte[] { 0x00, 0x00, 0x00, 0x00 }) // fake ip
                         .WriteByte(0x01)
                         .Write(passwordMd5)
                         .Write(tgtgtKey)
                         .WriteUInt32(wtf)
                         .WriteBool(guidAvailable);

                     if (guid.Length == 0)
                     {
                         for (int i = 0; i < 4; i++)
                         {
                             b.WriteUInt32((uint)new Random().Next());
                         }
                     }
                     else
                     {
                         b.Write(guid);
                     }

                     b.WriteUInt32(appId)
                         .WriteUInt32(1); // password login

                     b.WriteBytesShort(Encoding.UTF8.GetBytes(uin.ToString()))
                         .WriteUInt16(0);
                     return b.ToArray();
                 })());

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T107(ushort picType)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x107);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteUInt16(picType)
                    .WriteByte(0x00)
                    .WriteUInt16(0)
                    .WriteByte(0x01);

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T108(string imei)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x108);
            binaryStream.WriteStringShort(imei);

            return binaryStream.ToArray();
        }

        public static byte[] T109(byte[] androidId)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x109);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.Write(MD5.Create().ComputeHash(androidId));

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T116(uint miscBitmap, uint subSigMap)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x116);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteByte(0x00)
                    .WriteUInt32(miscBitmap)
                    .WriteUInt32(subSigMap)
                    .WriteByte(0x01)
                    .WriteUInt32(1600000226); // app id list

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T124(byte[] osType, byte[] osVersion, byte[] simInfo, byte[] apn)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x124);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteTlvLimitedSize(osType, 16)
                    .WriteTlvLimitedSize(osVersion, 16)
                    .WriteUInt16(2) // Network type wifi
                    .WriteTlvLimitedSize(simInfo, 16)
                    .WriteTlvLimitedSize(new byte[0], 16)
                    .WriteTlvLimitedSize(apn, 16);

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T128(bool isGuidFromFileNull, bool isGuidAvailable, bool isGuidChanged, uint guidFlag, byte[] buildModel, byte[] guid, byte[] buildBrand)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x128);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteUInt16(0)
                    .WriteBool(isGuidFromFileNull)
                    .WriteBool(isGuidAvailable)
                    .WriteBool(isGuidChanged)
                    .WriteUInt32(guidFlag)
                    .WriteTlvLimitedSize(buildModel, 32)
                    .WriteTlvLimitedSize(guid, 16)
                    .WriteTlvLimitedSize(buildBrand, 16);

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T141(byte[] simInfo, byte[] apn)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x141);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteUInt16(1)
                    .WriteBytesShort(simInfo)
                    .WriteUInt16(2) // network type wifi
                    .WriteBytesShort(apn);

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T142(string apkId)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x142);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteUInt32(0)
                    .WriteTlvLimitedSize(Encoding.UTF8.GetBytes(apkId), 32);

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T143(byte[] arr)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x143);
            binaryStream.WriteBytesShort(arr);

            return binaryStream.ToArray();
        }

        public static byte[] T144(byte[] imei, byte[] devInfo, byte[] osType, byte[] osVersion, byte[] simInfo, byte[] apn,
                                    bool isGuidFromFileNull, bool isGuidAvailable, bool isGuidChanged,
                                    uint guidFlag,
                                    byte[] buildModel, byte[] guid, byte[] buildBrand, byte[] tgtgtKey)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x144);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.EncryptAndWrite(tgtgtKey, new Func<byte[]>(() =>
                 {
                     var b = new BinaryStream();
                     b.WriteUInt16(5)
                         .Write(T109(imei))
                         .Write(T52D(devInfo))
                         .Write(T124(osType, osVersion, simInfo, apn))
                         .Write(T128(isGuidFromFileNull, isGuidAvailable, isGuidChanged, guidFlag, buildModel, guid,
                             buildBrand))
                         .Write(T16E(buildModel));

                     return b.ToArray();
                 })());

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T145(byte[] guid)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x145);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.Write(guid);

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T147(uint appId, byte[] apkVersionName, byte[] apkSignatureMd5)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x147);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteUInt32(appId)
                    .WriteTlvLimitedSize(apkVersionName, 32)
                    .WriteTlvLimitedSize(apkSignatureMd5, 32);

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T154(ushort seq)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x154);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteUInt32(seq);

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T166(byte imageType)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x166);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteByte(imageType);

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T174(byte[] data)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x174);
            binaryStream.WriteBytesShort(data);

            return binaryStream.ToArray();
        }

        public static byte[] T177(uint buildTime, string sdkVersion)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x177);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteByte(0x01)
                    .WriteUInt32(buildTime)
                    .WriteStringShort(sdkVersion);

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T187(byte[] macAddress)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x187);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.Write(MD5.Create().ComputeHash(macAddress));

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T188(byte[] androidId)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x188);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.Write(MD5.Create().ComputeHash(androidId));

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T191(byte k)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x191);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteByte(k);

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T193(string ticket)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x193);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.Write(Encoding.UTF8.GetBytes(ticket));

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T194(byte[] imsiMd5)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x194);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.Write(imsiMd5);

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T197()
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x197);
            binaryStream.WriteBytesShort(new byte[] { 0 });

            return binaryStream.ToArray();
        }

        public static byte[] T198()
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x198);
            binaryStream.WriteBytesShort(new byte[] { 0 });

            return binaryStream.ToArray();
        }

        public static byte[] T202(byte[] wifiBssid, byte[] wifiSsid)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x202);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteTlvLimitedSize(wifiBssid, 16)
                    .WriteTlvLimitedSize(wifiSsid, 32);

                return s.ToArray();
            })());


            return binaryStream.ToArray();
        }

        public static byte[] T400(byte[] g, Uin uin, byte[] guid, byte[] dpwd, long j2, long j3, byte[] randSeed)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x400);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteBytesShort(new Func<byte[]>(() =>
                {
                    var b = new BinaryStream();
                    b.WriteUInt16(1) // version
                        .WriteUInt64(uin)
                        .Write(guid)
                        .Write(dpwd)
                        .WriteUInt32((uint)j2)
                        .WriteUInt32((uint)j3)
                        .WriteUInt32((uint)DateTimeOffset.UtcNow.Second)
                        .Write(randSeed);

                    return b.ToArray();
                })());

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T401(byte[] d)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x401);
            binaryStream.WriteBytesShort(d);

            return binaryStream.ToArray();
        }

        public static byte[] T511(IEnumerable<string> domains)
        {
            var list = domains.ToList().Where(_ => _ != "").ToList();

            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x511);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteUInt16((ushort)list.Count);
                list.ForEach(str =>
                {
                    var index1 = str.IndexOf("(", StringComparison.Ordinal);
                    var index2 = str.IndexOf(")", StringComparison.Ordinal);

                    if (index1 != 0 || index2 <= 0)
                    {
                        s.WriteByte(0x01)
                            .WriteStringShort(str);
                    }
                    else
                    {
                        if (int.TryParse(str[(index1 + 1)..index2], out var i))
                        {
                            var z2 = (1048576 & i) > 0;
                            var z = (i & 134217728) > 0;
                            var b = z2 ? (byte)1 : (byte)0;
                            if (z)
                            {
                                b |= 2;
                            }
                            s.WriteByte(b);
                            s.WriteStringShort(str[(index2 + 1)..]);
                        }
                    }
                });

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T516()
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x516);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteUInt32(0);

                return s.ToArray();
            })());
            return binaryStream.ToArray();
        }

        public static byte[] T521(uint i)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x521);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteUInt32(i)
                    .WriteUInt16(0);

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T525(byte[] t536)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x525);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteUInt16(1)
                    .Write(t536);

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] T536(byte[] loginExtraData)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteUInt16(0x536);
            binaryStream.WriteBytesShort(new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.Write(loginExtraData);

                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }
    }
}
