using System;
using System.Collections;
using System.IO;
using System.Reflection;
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

        public JceWriter WriteByte(byte b, int tag)
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
            return this;
        }

        public JceWriter WriteBool(bool b, int tag)
        {
            _data.WriteByte((byte)(b ? 1 : 0));
            return this;
        }

        public JceWriter WriteInt16(short n, int tag)
        {
            if (n >= -128 && n <= 127)
            {
                WriteByte((byte)(n), tag);
                return this;
            }
            WriteHead(1, tag);
            _data.Write(BitConverter.GetBytes(n));
            return this;
        }

        public JceWriter WriteInt32(int n, int tag)
        {
            if (n >= -32768 && n <= 32767)
            { // ? if ((n >= 32768) && (n <= 32767))
                WriteInt16((short)n, tag);
                return this;
            }

            WriteHead(2, tag);
            _data.Write(BitConverter.GetBytes(n));
            return this;
        }

        public JceWriter WriteInt64(long n, int tag)
        {
            if (n >= -2147483648 && n <= 2147483647)
            {
                WriteInt32((int)n, tag);
                return this;
            }

            WriteHead(3, tag);
            _data.Write(BitConverter.GetBytes(n));
            return this;
        }

        public JceWriter WriteFloat32(float n, int tag)
        {
            WriteHead(4, tag);
            _data.Write(BitConverter.GetBytes(n));
            return this;
        }

        public JceWriter WriteFloat64(double n, int tag)
        {
            WriteHead(5, tag);
            _data.Write(BitConverter.GetBytes(n));
            return this;
        }

        public JceWriter WriteString(string s, int tag)
        {
            var bytes = Encoding.UTF8.GetBytes(s);
            if (bytes.Length > 255)
            {
                WriteHead(7, tag);
                _data.Write(BitConverter.GetBytes(bytes.Length));
                _data.Write(bytes);
                return this;
            }
            WriteHead(6, tag);
            _data.WriteByte((byte)bytes.Length);
            _data.Write(bytes);
            return this;
        }

        public JceWriter WriteBytes(byte[] b, int tag)
        {
            WriteHead(13, tag);
            WriteHead(0, 0);
            WriteInt32(b.Length, 0);
            _data.Write(b);
            return this;
        }


        public JceWriter WriteInt64Slice(long[] l, int tag)
        {
            WriteHead(9, tag);
            if (l.Length == 0)
            {
                WriteInt32(0, 0);
                return this;
            }
            WriteInt32(l.Length, 0);
            foreach (var v in l)
            {
                WriteInt64(v, 0);
            }
            return this;
        }

        public JceWriter WriteMap(IDictionary m, int tag)
        {
            if (m is null)
            {
                WriteHead(8, tag);
                WriteInt32(0, 0);
                return this;
            }
            WriteHead(8, tag);
            WriteInt32(m.Keys.Count, 0);
            foreach (DictionaryEntry entry in m)
            {
                WriteObject(entry.Key, 0);
                WriteObject(entry.Value, 1);
            }
            return this;
        }

        private void WriteObject(object value, int tag)
        {
            _ = value switch
            {
                IDictionary map => WriteMap(map, tag),
                byte[] bytes => WriteBytes(bytes, tag),
                Array arr => WriteSlice(arr, tag),
                byte b => WriteByte(b, tag),
                bool b => WriteBool(b, tag),
                short n => WriteInt16(n, tag),
                int n => WriteInt32(n, tag),
                long n => WriteInt64(n, tag),
                float f => WriteFloat32(f, tag),
                double d => WriteFloat64(d, tag),
                string s => WriteString(s, tag),
                IJceStruct s => WriteJceStruct(s, tag),
                _ => throw new Exception()
            };
        }

        private JceWriter WriteJceStruct(IJceStruct s, int tag)
        {
            WriteHead(10, tag);
            WriteJceStructRaw(s);
            WriteHead(11, 0);
            return this;
        }

        private JceWriter WriteSlice(Array arr, int tag)
        {
            WriteHead(9, tag);
            if (arr.Length == 0)
            {
                WriteInt32(0, 0);
                return this;
            }
            WriteInt32(arr.Length, 0);

            foreach (var i in arr)
            {
                WriteObject(i, 0);
            }
            return this;
        }

        public void WriteJceStructRaw(IJceStruct s)
        {
            var fields = s.GetType().GetFields();
            foreach (var fieldInfo in fields)
            {
                var attribute = fieldInfo.GetCustomAttribute<JceIdAttribute>();
                var value = fieldInfo.GetValue(s);
                WriteObject(value, attribute!.Id);
            }

        }

        public byte[] GetBytes()
        {
            return _data.ToArray();
        }
    }

    //TODO
}
