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
        public BinaryStream()
        {
        }

        public BinaryStream(byte[] buffer) : base(buffer)
        {
        }

        public int ReadInt32()
        {
            return BinaryPrimitives.ReadInt32BigEndian(this.ReadBytes(4));
        }

        public int ReadUInt16()
        {
            return BinaryPrimitives.ReadUInt16BigEndian(this.ReadBytes(2));
        }

        public string ReadString()
        {
            return Encoding.UTF8.GetString(this.ReadBytes(ReadInt32() - 4));
        }

        public Span<byte> ReadAvailable()
        {
            return this.ReadBytes((int)(Length - Position));
        }


        public void WriteHexString(string s)
        {
            var b = Utils.ConvertHexStringToByteArray(s);
            Write(b);
        }

        public void WriteUInt32(uint n)
        {
            Span<byte> span = stackalloc byte[4];
            BinaryPrimitives.WriteUInt32BigEndian(span,n);
            Write(span);
        }

        public BinaryStream WriteIntLvPacket(int offset, byte[] data)
        {
            WriteUInt32((uint)(data.Length + offset));
            Write(data);
            return this;
        }
    }
}
