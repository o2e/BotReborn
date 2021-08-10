using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BotReborn.Crypto;

using Microsoft.Extensions.Logging;

namespace BotReborn
{
    partial class OicqClient
    {
        public void DecodeT161(byte[] data)
        {
            var s = new BinaryStream(data);
            s.ReadBytes(2);
            var m = s.ReadTlvMap(2);
            if (m.TryGetValue(0x172, out var t172)) RollbackSig = t172;

        }

        public void DecodeT119R(byte[] data)
        {
            var t = new Tea(DeviceInfo.TgtgtKey);
            var b = new BinaryStream(t.Decrypt(data));
            b.ReadBytes(2);
            var m = b.ReadTlvMap(2);
            if (m.TryGetValue(0x120, out var t120))
            {
                SigInfo.SKey = t120;
                SigInfo.SKeyExpiredTime = DateTimeOffset.UtcNow.Second + 21600;
                Logger.LogDebug("Skey updated: {0}", t120);
            }

            if (m.TryGetValue(0x11a, out var t11a))
            {
                var c = ReadT11A(t11a);
                NickName = c.nick;
                Age = c.age;
                Gender = c.gender;
                Logger.LogDebug("account info updated: {0}", NickName);
            }
        }

        public void DecodeT119(byte[] data, byte[] ek)
        {
            var t = new Tea(ek);
            var s = new BinaryStream(t.Decrypt(data));
            s.ReadBytes(2);
            var m = s.ReadTlvMap(2);
            {
                if (m.TryGetValue(0x130, out var v1)) DecodeT130(v1);
                if (m.TryGetValue(0x113, out var v2)) DecodeT113(v2);
                if (m.TryGetValue(0x528, out var v3)) T528 = v3;
                if (m.TryGetValue(0x530, out var v4)) T530 = v4;
                if (m.TryGetValue(0x108, out var v5)) Ksid = v5;
            }

            ushort gender = 0;
            ushort age = 0;
            var nick = "";
            var psKeyMap = new Dictionary<string, byte[]>();
            var pt4TokenMap = new Dictionary<string, byte[]>();

            {
                //	if _, ok := m[0x125]; ok {
                // openId, openKey = readT125(t125)
                //}

                if (m.TryGetValue(0x186, out var v1)) DecodeT186(v1);
                if (m.TryGetValue(0x11a, out var v2))
                {
                    var r = ReadT11A(v2);
                    nick = r.nick;
                    age = r.age;
                    gender = r.gender;
                }

                //if _, ok:= m[0x199]; ok {
                //    // openId, payToken = readT199(t199)
                //}
                //if _, ok:= m[0x200]; ok {
                //    // pf, pfkey = readT200(t200)
                //}

                if (m.TryGetValue(0x512, out var v3))
                {
                    var r = ReadT512(v3);
                    psKeyMap = r.psKeyMap;
                    pt4TokenMap = r.pt4TokenMap;
                }

                //if _, ok:= m[0x531]; ok {
                //    // a1, noPicSig = readT531(t531)
                //}

                //if _, ok:= m[0x138]; ok {
                //    // readT138(t138) // chg time
                //}

                SigInfo =
                    new LogInSigInfo()
                    {
                        LoginBitmap = 0,
                        SrmToken = m[0x16a] ?? SigInfo.SrmToken,
                        T133 = m[0x133] ?? SigInfo.T133,
                        EncryptedA1 = m[0x106] ?? SigInfo.EncryptedA1,
                        Tgt = m[0x10a],
                        TgtKey = m[0x10d],
                        UserStKey = m[0x10e],
                        UserStWebSig = m[0x103],
                        SKey = m[0x120],
                        SKeyExpiredTime = DateTimeOffset.UtcNow.Second + 21600,
                        D2 = m[0x143],
                        D2Key = m[0x305],
                        WtSessionTicketKey = m[0x134] ?? SigInfo.WtSessionTicketKey,
                        DeviceToken = m[0x322],

                        PsKeyMap = psKeyMap,
                        Pt4TokenMap = pt4TokenMap
                    };

                if (PasswordMd5.Length > 0)
                {
                    var key = PasswordMd5.Concat(new byte[] { 0x00, 0x00, 0x00, 0x00 }).Concat(new Func<byte[]>(() =>
                    {
                        var b = new BinaryStream();
                        b.WriteUInt32(Uin);
                        return b.ToArray();
                    })());
                    var decrypted = new Tea(key.ToArray()).Decrypt(SigInfo.EncryptedA1);
                    if (decrypted.Length > 51 + 16)
                    {
                        var dr = new BinaryStream();
                        dr.ReadBytes(51);
                        DeviceInfo.TgtgtKey = dr.ReadBytes(16).ToArray();
                    }

                    NickName = nick;
                    Age = age;
                    Gender = gender;
                }
            }
        }

        public void DecodeT130(byte[] data)
        {
            var s = new BinaryStream(data);
            s.ReadBytes(2);
            TimeDiff = (long)s.ReadInt32() - DateTimeOffset.UtcNow.Second;
            T149 = s.ReadBytes(4).ToArray();
        }

        public void DecodeT113(byte[] data)
        {
            var s = new BinaryStream(data);
            Uin = s.ReadInt32(); //?
            Logger.LogInformation("Got uin: {0}", Uin.ToString());
        }

        public void DecodeT186(byte[] data)
        {
            PwdFlag = data[1] == 1;
        }

        public (byte[] openID, byte[] openKey) ReadT125(byte[] data)
        {
            var s = new BinaryStream(data);
            return (s.ReadBytesShort(), s.ReadBytesShort());
        }

        public (string nick, ushort age, ushort gender) ReadT11A(byte[] data)
        {
            var s = new BinaryStream(data);
            s.ReadUInt16();
            var age = (ushort)s.ReadByte();
            var gender = (ushort)s.ReadByte();
            var nick = s.ReadStringLimit(s.ReadByte() & 0xff);
            return (nick, age, gender);
        }

        public (byte[] openID, byte[] payToken) ReadT199(byte[] data)
        {
            var s = new BinaryStream(data);
            return (s.ReadBytesShort(), s.ReadBytesShort());
        }

        public (byte[] pf, byte[] pfKey) ReadT200(byte[] data)
        {
            var s = new BinaryStream(data);
            return (s.ReadBytesShort(), s.ReadBytesShort());
        }

        public (Dictionary<string, byte[]> psKeyMap, Dictionary<string, byte[]> pt4TokenMap) ReadT512(byte[] data)
        {
            var s = new BinaryStream(data);
            var length = (int)s.ReadUInt16();

            Dictionary<string, byte[]> psKeyMap = new(), pt4TokenMap = new();

            for (int i = 0; i < length; i++)
            {
                var domain = s.ReadStringShort();
                var psKey = s.ReadBytesShort();
                var pt4Token = s.ReadBytesShort();

                if (psKey.Length > 0)
                {
                    psKeyMap.Add(domain, psKey);
                }

                if (pt4Token.Length > 0)
                {
                    pt4TokenMap.Add(domain, pt4Token);
                }
            }

            return (psKeyMap, pt4TokenMap);
        }

        public (byte[] a1, byte[] noPicSig) ReadT531(byte[] data)
        {
            var s = new BinaryStream(data);
            var m = s.ReadTlvMap(2);
            var t = new List<byte>();

            if (m.ContainsKey(0x103) && m.ContainsKey(0x16a) && m.ContainsKey(0x113) && m.ContainsKey(0x10c))
            {
                t.AddRange(m[0x106]);
                t.AddRange(m[0x10c]);
                return (t.ToArray(), m[0x16a]);
            }

            return (null, null);
        }
    }
}
