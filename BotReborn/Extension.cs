using System;
using System.Buffers.Binary;
using System.Net.Sockets;

namespace BotReborn
{
    public static class Extension
    {
        public static int ReadInt32(this TcpClient c)
        {
            var b = c.GetStream().ReadBytes(4);
            return (int)BinaryPrimitives.ReadUInt32BigEndian(b);
        }

        public static byte[] ReadBytes(this TcpClient c, int len)
        {
            var buf = new byte[len];
            c.GetStream().Read(buf);
            return buf;
        }

        public static int ReadInt32(this NetworkStream s)
        {
            var b = s.ReadBytes(4);
            return (int)BinaryPrimitives.ReadUInt32BigEndian(b);
        }

        public static byte[] ReadBytes(this NetworkStream s, int len)
        {
            var buf = new byte[len];
            s.Read(buf);
            return buf;
        }

        public static uint NextUInt32(this Random rand) => (uint)rand.Next(1 << 30) << 2 | (uint)rand.Next(1 << 2);
    }
}
