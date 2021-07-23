using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto;

namespace BotReborn
{
    public class BinaryStream:MemoryStream
    {
        private StreamWriter _writer;

        public BinaryStream()
        {
            _writer = new StreamWriter(this);
        }
        public void WriteHexString(string s)
        {
            var b = Utils.ConvertHexStringToByteArray(s);
            base.Write(b);
        }

        public void WriteUInt32(uint n)
        {
            var b = new byte[sizeof(uint)];
            BinaryPrimitives.WriteUInt32BigEndian(b,n);
            _writer.Write(b);
        }

        public BinaryStream WriteIntLvPacket(int offset, byte[] data)
        {
            WriteUInt32((uint)(data.Length + offset));
            _writer.Write(data);
            return this;
        }


    }
}
