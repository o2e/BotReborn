using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

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

        public static int ReadInt32(this Socket s)
        {
            var b = new byte[4];
            s.Receive(b);
            return (int)BinaryPrimitives.ReadUInt32BigEndian(b);
        }

        public static byte[] ReadBytes(this NetworkStream s, int len)
        {
            var buf = new byte[len];
            s.Read(buf);
            return buf;
        }

        public static byte[] ReadBytes(this Socket s, int len)
        {
            var buf = new byte[len];
            s.Receive(buf);
            return buf;
        }

        public static uint NextUInt32(this Random rand) => (uint)rand.Next(1 << 30) << 2 | (uint)rand.Next(1 << 2);

        public static byte[] DebugInput()
        {
            var bs = new List<byte>();
            var f = File.ReadAllLines(@"C:\Users\Nullpinter\Desktop\SMAPI 3.11.0 installer\d.txt")[14..];
            foreach (var s in f)
            {
                if (string.IsNullOrEmpty(s))
                {
                    continue;
                }
                if (s.Contains(".."))
                {
                    continue;
                }

                bs.Add((byte)int.Parse(s.Split(" ")[1]));
            }

            return bs.ToArray();
        }
    }
}
