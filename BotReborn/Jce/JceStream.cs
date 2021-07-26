using System;
using System.Buffers.Binary;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Microsoft.Extensions.Logging.Abstractions;

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
                    Skip(ReadInt32());
                    break;
                case 8:
                    var s = ReadInt32(0);
                    for (var i = 0; i < s * 2; i++)
                    {
                        SkipNextField();
                    }
                    break;
                case 9:
                    var n = ReadInt32(0);

                    for (var i = 0; i < n; i++)
                    {
                        SkipNextField();
                    }
                    break;
                case 13:
                    ReadHead(out _);
                    var l = ReadInt32(0);

                    Skip(l);
                    break;
                case 10:
                    SkipToStructEnd();
                    break;
            }
        }

        private Span<byte> ReadBytes(int len)
        {
            Span<byte> span = new byte[len];
            Read(span);
            return span;
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

        private ushort ReadUInt16()
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

        private long ReadInt64()
        {
            Span<byte> span = stackalloc byte[8];
            Read(span);
            return (long)(((ulong)(span[0]) << 56) | ((ulong)(span[1]) << 48) | ((ulong)(span[2]) << 40) |
                   ((ulong)(span[3]) << 32) | ((ulong)(span[4]) << 24) | ((ulong)(span[5]) << 16) |
                   ((ulong)(span[6]) << 8) | (span[7]));
        }

        private float ReadFloat32()
        {
            Span<byte> span = stackalloc byte[4];
            Read(span);
            return BinaryPrimitives.ReadSingleBigEndian(span);
        }

        private double ReadFloat64()
        {
            Span<byte> span = stackalloc byte[8];
            Read(span);
            return BinaryPrimitives.ReadDoubleBigEndian(span);
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
                1 => (short)ReadUInt16()
            };
        }

        public int ReadInt32(int tag)
        {
            if (!SkipToTag(tag))
            {
                return 0;
            }
            ReadHead(out var head);
            return head.Type switch
            {
                12 => 0,
                0 => ReadByte(),
                1 => ReadUInt16(),
                2 => ReadInt32(),
                _ => 0
            };
        }

        public long ReadInt64(int tag)
        {
            if (!SkipToTag(tag))
            {
                return 0;
            }

            ReadHead(out var head);
            return head.Type switch
            {
                12 => 0,
                0 => ReadByte(),
                1 => ReadUInt16(),
                2 => ReadInt32(),
                3 => ReadInt64(),
                _ => 0
            };
        }

        public float ReadFloat32(int tag)
        {
            if (!SkipToTag(tag))
            {
                return 0;
            }
            ReadHead(out var head);
            return head.Type switch
            {
                12 => 0,
                4 => ReadFloat32(),
                _ => 0
            };
        }

        public double ReadFloat64(int tag)
        {
            if (!SkipToTag(tag))
            {
                return 0;
            }
            ReadHead(out var head);
            return head.Type switch
            {
                12 => 0,
                4 => ReadFloat32(),
                5 => ReadFloat64(),
                _ => 0
            };
        }

        public string ReadString(int tag)
        {
            if (!SkipToTag(tag))
            {
                return string.Empty;
            }
            ReadHead(out var head);

            return head.Type switch
            {
                6 => Utils.GetString(ReadBytes(ReadByte())),
                7 => Utils.GetString(ReadBytes(ReadInt32())),
                _ => string.Empty
            };
        }

        public object ReadAny(int tag)
        {
            if (!SkipToTag(tag))
            {
                return null;
            }
            ReadHead(out var head);
            switch (head.Type)
            {
                case 0:
                    return ReadByte();
                case 1:
                    return ReadUInt16();
                case 2:
                    return ReadInt32();
                case 3:
                    return ReadInt64();
                case 4:
                    return ReadFloat32();
                case 5:
                    return ReadFloat64();
                case 6:
                    return Utils.GetString(ReadBytes(ReadByte()));
                case 7:
                    return Utils.GetString(ReadBytes(ReadInt32()));
                case 8:
                    var s = ReadInt32(0);
                    var m = new Hashtable();
                    for (var i = 0; i < s; i++)
                    {
                        m[ReadAny(0)] = ReadAny(1);
                    }
                    return m;
                case 9:
                    var sl = new List<object>();
                    var n = ReadInt32(0);
                    for (var i = 0; i < n; i++)
                    {
                        sl.Add(ReadAny(0));
                    }
                    return sl;
                case 12:
                    return 0;
                case 13:
                    ReadHead(out _);
                    return ReadBytes(ReadInt32(0)).ToArray();
                default:
                    return null;
            }
        }

        public void ReadJceStruct(IJceStruct obj, int tag)
        {
            if (!SkipToTag(tag))
            {
                return;
            }
            ReadHead(out var head);
            if (head.Type != 10)
            {
                return;
            }
            obj.ReadFrom(this);
            SkipToStructEnd();
        }

        public void ReadMapF(int tag, Action<object,object> func)
        {
            if (!SkipToTag(tag))
            {
                return;
            }
            ReadHead(out var head);
            var s = ReadInt32(0);
            for (int i = 0; i < s; i++)
            {
                var k = ReadAny(0);
                var v = ReadAny(1);
                if (k != null)
                {
                    func(k, v);
                }
            }
        }

        public object ReadObject(int tag)
        {
            throw new NotImplementedException();
        }

        public void ReadSlice(object obj,int tag)
        {
            if (!SkipToTag(tag))
            {
                return;
            }
            ReadHead(out var head);
            throw new NotImplementedException();
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
