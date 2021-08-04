using System;
using System.Buffers.Binary;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualBasic.CompilerServices;

namespace BotReborn.Jce
{
    public struct HeadData
    {
        public byte Type;
        public int Tag;
    }
    public class JceStream : MemoryStream
    {
        public JceStream()
        {
        }

        public JceStream(byte[] buffer) : base(buffer)
        {
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

        private int PeekHead(out HeadData head)
        {
            var length = ReadHead(out var h);
            Seek(-length, SeekOrigin.Current);
            head = h;
            return length;
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
                var l = PeekHead(out var head);
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

            return BinaryPrimitives.ReadUInt16BigEndian(this.ReadBytes(2));
        }

        private int ReadInt32()
        {
            return BinaryPrimitives.ReadInt32BigEndian(this.ReadBytes(4));
        }

        private long ReadInt64()
        {
            return BinaryPrimitives.ReadInt64BigEndian(this.ReadBytes(8));
        }

        private float ReadFloat32()
        {
            return BinaryPrimitives.ReadSingleBigEndian(this.ReadBytes(4));
        }

        private double ReadFloat64()
        {
            Span<byte> span = stackalloc byte[8];
            Read(span);
            return BinaryPrimitives.ReadDoubleBigEndian(span);
        }

        public byte ReadByte(int tag)
        {
            if (!SkipToTag(tag))
            {
                return 0;
            }

            _ = ReadHead(out var head);
            return head.Type switch
            {
                12 => 0,
                0 => Convert.ToByte(ReadByte()),
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
                1 => (short)ReadUInt16(),
                _ => 0
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
                6 => Encoding.UTF8.GetString(this.ReadBytes(ReadByte())),
                7 => Encoding.UTF8.GetString(this.ReadBytes(ReadInt32())),
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
                    return Encoding.UTF8.GetString(this.ReadBytes(ReadByte()));
                case 7:
                    return Encoding.UTF8.GetString(this.ReadBytes(ReadInt32()));
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
                    return this.ReadBytes(ReadInt32(0)).ToArray();
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

        public void ReadMapF(int tag, Action<object, object> func)
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

        public object ReadObject(Type type, int tag)
        {
            object obj;
            switch (type)
            {
                case var t when typeof(byte) == t:
                    obj = (byte)ReadByte(tag);
                    break;
                case var t when typeof(bool) == t:
                    obj = ReadBool(tag);
                    break;
                case var t when typeof(short) == t:
                    obj = ReadInt16(tag);
                    break;
                case var t when typeof(int) == t:
                    obj = ReadInt32(tag);
                    break;
                case var t when typeof(int) == t:
                    obj = ReadInt64(tag);
                    break;
                case var t when typeof(float) == t:
                    obj = ReadFloat32(tag);
                    break;
                case var t when typeof(double) == t:
                    obj = ReadFloat64(tag);
                    break;
                case var t when typeof(string) == t:
                    obj = ReadString(tag);
                    break;
                case var t when t.GetInterfaces().Contains(typeof(IJceStruct)):
                    var s = Activator.CreateInstance(type);
                    t?.GetMethod("ReadFrom")?.Invoke(s, new object[] { this });
                    obj = s;
                    break;
                default:
                    obj = null;
                    break;
            }
            return obj;
        }

        public IEnumerable ReadSlice(Type type, int tag)
        {
            var list = new List<object>();
            if (!SkipToTag(tag))
            {
                return null;
            }
            ReadHead(out var head);
            if (head.Type == 9)
            {
                var l = ReadInt32(0);
                for (int i = 0; i < l; i++)
                {
                    list.Add(ReadObject(type, 0));
                }
                return list;
            }
            if (head.Type == 13)
            {
                ReadHead(out _);
                var arr = this.ReadBytes(ReadInt32(0));
                return arr.ToArray();
            }
            throw new Exception();
        }


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
            switch (value)
            {
                case IDictionary map:
                    _ = WriteMap(map, tag);
                    break;
                case byte[] bytes:
                    _ = WriteBytes(bytes, tag);
                    break;
                case Array arr:
                    _ = WriteSlice(arr, tag);
                    break;
                case byte b:
                    _ = WriteByte(b, tag);
                    break;
                case bool b:
                    _ = WriteBool(b, tag);
                    break;
                case short n:
                    _ = WriteInt16(n, tag);
                    break;
                case int n:
                    _ = WriteInt32(n, tag);
                    break;
                case long n:
                    _ = WriteInt64(n, tag);
                    break;
                case float f:
                    _ = WriteFloat32(f, tag);
                    break;
                case double d:
                    _ = WriteFloat64(d, tag);
                    break;
                case string s:
                    _ = WriteString(s, tag);
                    break;
                case IJceStruct s:
                    _ = WriteJceStruct(s, tag);
                    break;
                default:
                    throw new Exception();
            }
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
                WriteObject(value ?? Activator.CreateInstance(fieldInfo.FieldType), attribute!.Id);
            }

        }
    }
}
