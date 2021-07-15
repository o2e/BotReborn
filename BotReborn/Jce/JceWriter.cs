using System;
using System.IO;
using System.Text;

namespace BotReborn.Jce
{
    class JceWriter
    {
        private MemoryStream _data = new MemoryStream();

        public void WriteHead(byte t, int tag)
        {
            if (tag < 15)
            {
                var b = (byte)((tag << 4) | t);
                _data.WriteByte(b);
            }
            else
            {
                var b = (byte)(0xF0 | t);
                _data.WriteByte(b);
                _data.WriteByte((byte)tag);
            }
        }

        public void WriteByte(byte b, int tag)
        {
            if (b == 0)
            {
                WriteHead(12, tag);
            }
            else
            {
                WriteHead(0, tag);
                _data.WriteByte(b);
            }
        }

        public void WriteBool(bool b, int tag)
        {
            _data.WriteByte((byte)(b ? 1 : 0));
        }

        public void WriteInt16(short n, int tag)
        {
            if (n >= -128 && n <= 127)
            {
                WriteByte((byte)(n), tag);
                return;
            }
            WriteHead(1, tag);
            _data.Write(BitConverter.GetBytes(n));
        }

        public void WriteInt32(int n, int tag)
        {
            if (n >= -32768 && n <= 32767)
            { // ? if ((n >= 32768) && (n <= 32767))
                WriteInt16((short)n, tag);
                return;
            }

            WriteHead(2, tag);
            _data.Write(BitConverter.GetBytes(n));
        }

        public void WriteInt64(long n, int tag)
        {
            if (n >= -2147483648 && n <= 2147483647)
            {
                WriteInt32((int)n, tag);
                return;
            }

            WriteHead(3, tag);
            _data.Write(BitConverter.GetBytes(n));
        }

        public void WriteFloat32(float n, int tag)
        {
            WriteHead(4, tag);
            _data.Write(BitConverter.GetBytes(n));
        }

        public void WriteFloat64(double n, int tag)
        {
            WriteHead(5, tag);
            _data.Write(BitConverter.GetBytes(n));
        }

        public void WriteString(string s, int tag)
        {
            var bytes = Encoding.UTF8.GetBytes(s);
            if (bytes.Length > 255)
            {
                WriteHead(7, tag);
                _data.Write(BitConverter.GetBytes(bytes.Length));
                _data.Write(bytes);
                return;
            }
            WriteHead(6, tag);
            _data.WriteByte((byte)bytes.Length);
            _data.Write(bytes);
        }
    }

    //TODO
}
