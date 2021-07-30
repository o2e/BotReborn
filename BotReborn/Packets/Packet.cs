using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotReborn.Crypto;

namespace BotReborn.Packets
{
    public static class Packet
    {
        private static IncomingPacket ParseSsoFrame(byte[] payload, byte flag2)
        {
            
        }
        public  static IncomingPacket ParseIncomingPacket(byte[] payload, byte[] d2key)
        {
            if (payload.Length < 6)
            {
                throw new Exception("Invalid payload.");
            }

            var stream = new BinaryStream(payload);
            var flag1 = stream.ReadInt32();
            var flag2 = stream.ReadByte();
            if (stream.ReadByte() != 0)// flag3
            {
                // return nil, errors.WithStack(ErrUnknownFlag)
            }

            stream.ReadString();
            var decrypted = flag2 switch
            {
                0 => stream.ReadAvailable(),
                1 => new Tea(d2key).Decrypt(stream.ReadAvailable()),
                2 => new Tea(new byte[16]).Decrypt(stream.ReadAvailable()),
                _=>null
            };
            if (decrypted.Length == 0)
            {
                throw new Exception("Decrypt failed.");
            }

            if (flag1 != 0x0A && flag1 != 0x0B)
            {
                throw new Exception("Decrypt failed.");
            }
        }
    }
}
