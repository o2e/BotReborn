using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotReborn.Crypto;

namespace BotReborn.Packets
{
    public class IncomingPacket
    {
        public ushort SequenceId;
        public byte Flag2;
        public string CommandName;
        public byte[] SessionId;
        public byte[] Payload;

        public byte[] DecryptPayload(EncryptECDH ecdh, byte[] random, byte[] sessionKey)
        {
            var stream = new BinaryStream(Payload);
            if (stream.ReadByte() != 2)
            {
                throw new Exception("Unknown flag.");
            }

            stream.ReadBytes(2);
            stream.ReadBytes(2);
            stream.ReadUInt16();
            stream.ReadUInt16();
            stream.ReadInt32();
            var encryptType = stream.ReadUInt16();
            stream.ReadByte();
            if (encryptType == 0)
            {
                var d = stream.ReadBytes((int)(stream.Length - stream.Position - 1));
                return new Tea(ecdh.ShareKey).Decrypt(d);
            }

            if (encryptType == 3)
            {
                var d = stream.ReadBytes((int)(stream.Length - stream.Position - 1));
                return new Tea(sessionKey).Decrypt(d);
            }

            if (encryptType==4)
            {
                throw new NotImplementedException();
            }
            throw new Exception("Unknown flag.");
        }
    }
}
