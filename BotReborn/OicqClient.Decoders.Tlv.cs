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
                    var r = Read512();
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
    }
}
