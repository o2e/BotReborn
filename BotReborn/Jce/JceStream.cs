using System;
using System.Buffers.Binary;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace BotReborn.Jce
{
    public struct HeadData
    {
        public byte Type;
        public int Tag;
    }
    public class JceStream : MemoryStream
    {
        //public JceStream Write<T>(T obj)
        //{

        //}

        private void WriteHead(byte t, int tag)
        {
            if (tag < 15)
            {
                var b = (byte)((tag << 4) | t);
                base.WriteByte(b);
            }
            else
            {
                var b = (byte)(0xF0 | t);
                base.WriteByte(b);
                base.WriteByte((byte)tag);
            }
        }

        private int ReadHead(out HeadData head)
        {
            var h = new HeadData();
            var b = ReadByte();
            h.Type = (byte)(b & 0xF);
            h.Tag = (b & 0xF0) >> 4;
            if (h.Tag == 15)
            {
                b = ReadByte();
                h.Tag = b & 0xFF;
                head = h;
                return 2;
            }
            head = h;
            return 1;
        }

        private int PeakHead(out HeadData head)
        {
            throw new NotImplementedException();
        }

        private void Skip(int count)
        {
            Seek(count, SeekOrigin.Current);
        }

        private void SkipField(byte t)
        {
            switch (t)
            {
                case 0:
                    Skip(1);
                    break;
                case 1:
                    Skip(2);
                    break;
                case 2:
                case 4:
                    Skip(4);
                    break;
                case 3:
                case 5:
                    Skip(8);
                    break;
                case 6:
                    var b = ReadByte();
                    Skip(b);
                    break;
                case 7:
                    //Skip(ReadInt32());
                    break;
                case 8:
                    //var s = ReadInt32(0)
                    //for i := 0; i < int(s) * 2; i++ {
                    //        r.skipNextField()

                    //}
                    break;
                case 9:
                    //s:= r.ReadInt32(0)

                    //for i := 0; i < int(s); i++ {
                    //        r.skipNextField()

                    //}
                    break;
                case 13:
                    //    r.readHead()

                    //s:= r.ReadInt32(0)

                    //r.skip(int(s))
                    break;
                case 10:
                    //r.skipToStructEnd()
                    break;
            }
        }

        private void SkipNextField()
        {
            _ = ReadHead(out var head);
            SkipField(head.Type);
        }

        private void SkipField(int count)
        {
            for (int i = 0; i < count; i++)
            {
                SkipNextField();
            }
        }

        private bool SkipToTag(int tag)
        {
            while (true)
            {
                var l = PeakHead(out var head);
                if (tag <= head.Tag || head.Type == 11)
                {
                    return tag == head.Tag;
                }
                Skip(l);
                SkipField(head.Type);
            }
        }

        private void SkipToStructEnd()
        {
            while (true)
            {
                _ = ReadHead(out var head);
                SkipField(head.Type);
                if (head.Type == 11)
                {
                    return;
                }
            }
        }

        private ushort ReadUint16()
        {
            var i = ReadByte();
            var b = ReadByte();
            return (ushort)((i << 8) + b);
        }

        private int ReadInt32()
        {
            Span<byte> span = stackalloc byte[4];
            Read(span);
            return (span[0] << 24) | (span[1] << 16) | (span[2] << 8) | span[3];
        }

        public int ReadByte(int tag)
        {
            if (!SkipToTag(tag))
            {
                return 0;
            }

            _ = ReadHead(out var head);
            return head.Type switch
            {
                12 => 0,
                0 => ReadByte(),
                _ => 0
            };
        }

        public bool ReadBool(int tag)
        {
            return ReadByte(tag) != 0;
        }

        public short ReadInt16(int tag)
        {
            if (!SkipToTag(tag))
            {
                return 0;
            }
            _ = ReadHead(out var head);
            return head.Type switch
            {
                12 => 0,
                0 => (short)ReadByte(),
                1 => (short)ReadUint16()
            };
        }

        public JceStream WriteByte(byte b, int tag)
        {
            if (b == 0)
            {
                WriteHead(12, tag);
            }
            else
            {
                WriteHead(0, tag);
                WriteByte(b);
            }
            return this;
        }

        public JceStream WriteBool(bool b, int tag)
        {
            WriteByte((byte)(b ? 1 : 0));
            return this;
        }

        public JceStream WriteInt16(short n, int tag)
        {
            if (n is >= -128 and <= 127)
            {
                WriteByte((byte)(n), tag);
                return this;
            }
            WriteHead(1, tag);
            var b = new byte[sizeof(short)];
            BinaryPrimitives.WriteInt16BigEndian(b, n);
            base.Write(b);
            return this;
        }

        public JceStream WriteInt32(int n, int tag)
        {
            if (n is >= -32768 and <= 32767)
            { // ? if ((n >= 32768) && (n <= 32767))
                WriteInt16((short)n, tag);
                return this;
            }

            WriteHead(2, tag);
            var b = new byte[sizeof(int)];
            BinaryPrimitives.WriteInt32BigEndian(b, n);
            base.Write(b);
            return this;
        }

        public JceStream WriteInt64(long n, int tag)
        {
            if (n is >= -2147483648 and <= 2147483647)
            {
                WriteInt32((int)n, tag);
                return this;
            }

            WriteHead(3, tag);
            var b = new byte[sizeof(long)];
            BinaryPrimitives.WriteInt64BigEndian(b, n);
            base.Write(b);
            return this;
        }

        public JceStream WriteFloat32(float n, int tag)
        {
            WriteHead(4, tag);
            var b = new byte[sizeof(float)];
            BinaryPrimitives.WriteSingleBigEndian(b, n);
            base.Write(b);
            return this;
        }

        public JceStream WriteFloat64(double n, int tag)
        {
            WriteHead(5, tag);
            var b = new byte[sizeof(double)];
            BinaryPrimitives.WriteDoubleBigEndian(b, n);
            base.Write(b);
            return this;
        }

        public JceStream WriteString(string s, int tag)
        {
            var bytes = Encoding.UTF8.GetBytes(s);
            if (bytes.Length > 255)
            {
                WriteHead(7, tag);
                var b = new byte[sizeof(int)];
                BinaryPrimitives.WriteInt32BigEndian(b, bytes.Length);
                base.Write(b);
                base.Write(bytes);
                return this;
            }
            WriteHead(6, tag);
            WriteByte((byte)bytes.Length);
            base.Write(bytes);
            return this;
        }

        public JceStream WriteBytes(byte[] b, int tag)
        {
            WriteHead(13, tag);
            WriteHead(0, 0);
            WriteInt32(b.Length, 0);
            base.Write(b);
            return this;
        }


        public JceStream WriteInt64Slice(long[] l, int tag)
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


        public JceStream WriteMap(IDictionary m, int tag)
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

        private JceStream WriteJceStruct(IJceStruct s, int tag)
        {
            WriteHead(10, tag);
            WriteJceStructRaw(s);
            WriteHead(11, 0);
            return this;
        }

        private JceStream WriteSlice(Array arr, int tag)
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
    }
}
