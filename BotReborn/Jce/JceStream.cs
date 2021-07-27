using System;
using System.Buffers.Binary;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Mapster.Adapters;
using MapsterMapper;
using Microsoft.Extensions.Logging.Abstractions;

namespace BotReborn.Jce
{
    public enum JceType
    {
        Int8 = 0,
        Int16 = 1,
        Int32 = 2,
        Int64 = 3,
        Float = 4,
        Double = 5,
        String1 = 6,
        String4 = 7,
        Map = 8,
        List = 9,
        StructBegin = 10,
        StructEnd = 11,
        Zero = 12,
        SimpleList = 13
    }

    enum JceTag : byte
    {
        MapKey = 0,
        MapValue = 1,
        ListE = 0,
        Bytes = 0,
        Length = 0,
        StructEnd = 0
    }

    struct EndOfStruct
    {

    }

    struct HeadData
    {
        public JceTag Tag;
        public JceType Type;
    }

    struct Element
    {
        public JceTag Tag;
        public object Value;
    }

    public class JceStream : MemoryStream
    {
        public string EndOfStruct = "EndOfStruct";
        private HeadData ReadHead()
        {
            var head = ReadByte();
            var type = head & 0xf;
            var tag = (head & 0xf0) >> 4;
            if (tag == 0xf)
            {
                tag = ReadByte();
            }
            return new HeadData() { Tag = (JceTag)tag, Type = (JceType)type };
        }

        private Element ReadElement()
        {
            var head = ReadHead();
            var value = ReadBody(head.Type);
            return new Element() { Tag = head.Tag, Value = value };
        }

        public object ReadBody(JceType type)
        {
            Span<byte> ReadBytes(uint size)
            {
                var span = new byte[size];
                Read(span);
                return span;
            }
            uint length = 0;
            switch (type)
            {
                case JceType.Zero:
                    return 0;
                case JceType.Int8:
                    return ReadByte();
                case JceType.Int16:
                    return BinaryPrimitives.ReadInt16BigEndian(ReadBytes(2));
                case JceType.Int32:
                    return BinaryPrimitives.ReadInt32BigEndian(ReadBytes(4));
                case JceType.Int64:
                    return BinaryPrimitives.ReadInt64BigEndian(ReadBytes(8));
                case JceType.String1:
                    length = (byte)ReadByte();
                    return Encoding.UTF8.GetString(ReadBytes(length));
                case JceType.String4:
                    length = BinaryPrimitives.ReadUInt32BigEndian(ReadBytes(4));
                    return Encoding.UTF8.GetString(ReadBytes(length));
                case JceType.SimpleList:
                    ReadHead();
                    length = (uint)ReadElement().Value;
                    return length > 0 ? ReadBytes(length).ToArray() : Array.Empty<byte>();
                case JceType.List:
                    length = (uint)ReadElement().Value;
                    var list = new List<object>();
                    while (length > 0)
                    {
                        list.Add(ReadElement().Value);
                        --length;
                    }
                    return list;
                case JceType.Map:
                    length = (uint)ReadElement().Value;
                    var map = new Hashtable();
                    while (length > 0)
                    {
                        map[ReadElement().Value] = ReadElement().Value;
                        --length;
                    }
                    return map;
                case JceType.StructBegin:
                    return ReadStruct();
                case JceType.StructEnd:
                    return EndOfStruct;
                case JceType.Float:
                    return BinaryPrimitives.ReadSingleBigEndian(ReadBytes(4));
                case JceType.Double:
                    return BinaryPrimitives.ReadDoubleBigEndian(ReadBytes(8));
                default:
                    throw new JceException("unknown jce type: " + type);
            }
        }

        private ExpandoObject ReadStruct()
        {
            IDictionary<string, object> s = new ExpandoObject();
            while (CanRead)
            {
                var elem = ReadElement();
                if ((string)elem.Value != EndOfStruct)
                {
                    s[elem.Tag.ToString()] = elem.Value;
                }
            }
            return (ExpandoObject)s;
        }

        private void WriteHead(HeadData head)
        {
            if ((int)head.Tag < 15)
            {
                WriteByte((byte)((int)head.Tag<<4|(int)head.Type));
            }
            else
            {
                Write(new byte[]{(byte)(0xF0|(int)head.Type),(byte)head.Tag});
            }
        }

        public void WriteBody(JceType type,object value)
        {
            Span<byte> CreateBytes(int size,out Span<byte> span)
            {
                var s = new byte[size];
                span = s;
                return span;
            }

            uint length = 0;
            switch (type)
            {
                case JceType.Int8:
                    WriteByte((byte)value);
                    break;
                case JceType.Int16:
                    BinaryPrimitives.WriteInt16BigEndian(CreateBytes(2,out var span1),(short)value);
                    Write(span1);
                    break;
                case JceType.Int32:
                    BinaryPrimitives.WriteInt32BigEndian(CreateBytes(4, out var span2), (int)value);
                    Write(span2);
                    break;
                case JceType.Int64:
                    BinaryPrimitives.WriteInt64BigEndian(CreateBytes(8, out var span3), (long)value);
                    Write(span3);
                    break;
                case JceType.Float:
                    BinaryPrimitives.WriteSingleBigEndian(CreateBytes(4, out var span4), (float)value);
                    Write(span4);
                    break;
                case JceType.Double:
                    BinaryPrimitives.WriteDoubleBigEndian(CreateBytes(8, out var span5), (double)value);
                    Write(span5);
                    break;
                case JceType.String1:
                    length = 
                    break;
                case JceType.String4:
                    break;
                case JceType.Map:
                    break;
                case JceType.List:
                    break;
                case JceType.StructBegin:
                    break;
                case JceType.StructEnd:
                    break;
                case JceType.Zero:
                    break;
                case JceType.SimpleList:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}
