using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using BotReborn.Crypto;

using Org.BouncyCastle.Crypto;

namespace BotReborn
{
    public class BinaryStream : MemoryStream
    {
        public BinaryStream()
        {
        }

        public BinaryStream(byte[] buffer) : base(buffer)
        {
        }

        public new BinaryStream Write(byte[] buffer, int offset, int count)
        {
            base.Write(buffer, offset, count);
            return this;
        }

        public new BinaryStream Write(ReadOnlySpan<byte> buffer)
        {
            base.Write(buffer);
            return this;
        }

        public new BinaryStream WriteByte(byte value)
        {
            base.WriteByte(value);
            return this;
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


        public BinaryStream WriteHexString(string s)
        {
            var b = Utils.ConvertHexStringToByteArray(s);
            Write(b);
            return this;
        }

        public BinaryStream WriteUInt32(uint n)
        {
            Span<byte> span = stackalloc byte[4];
            BinaryPrimitives.WriteUInt32BigEndian(span, n);
            Write(span);
            return this;
        }

        public BinaryStream WriteUInt16(ushort n)
        {
            Span<byte> span = stackalloc byte[2];
            BinaryPrimitives.WriteUInt16BigEndian(span, n);
            Write(span);
            return this;
        }

        public BinaryStream WriteIntLvPacket(int offset, byte[] data)
        {
            WriteUInt32((uint)(data.Length + offset));
            Write(data);
            return this;
        }

        public BinaryStream EncryptAndWrite(byte[] key, byte[] data)
        {
            var tea = new Tea(key);
            Write(tea.Encrypt(data));
            return this;
        }

        public BinaryStream WriteBytesShort(byte[] data)
        {
            WriteUInt16((ushort)data.Length);
            Write(data);
            return this;
        }
    }
}
