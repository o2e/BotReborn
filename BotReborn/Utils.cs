using System;
using System.Buffers.Binary;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BotReborn
{
    public static class Utils
    {
        public static byte[] ConvertHexStringToByteArray(string hex)
        {
            static int GetHexVal(char hex) => hex - (hex < 58 ? 48 : hex < 97 ? 55 : 87);
            if (hex.Length % 2 == 1)
                throw new Exception("The binary key cannot have an odd number of digits");

            var arr = new byte[hex.Length >> 1];

            for (var i = 0; i < hex.Length >> 1; ++i)
            {
                arr[i] = (byte)((GetHexVal(hex[i << 1]) << 4) + (GetHexVal(hex[(i << 1) + 1])));
            }
            return arr;
        }

        public static string ConvertByteArrayToHexString(byte[] bytes)
        {
            return string.Concat(bytes.Select(b => b.ToString("X2")));
        }

        public static byte[] GetBytes(string s) => Encoding.UTF8.GetBytes(s);
        public static string GetString(Span<byte> b) => Encoding.UTF8.GetString(b);

        public static byte[] PackUniRequestData(byte[] data)
        {
            var r = new List<byte> { 0x0A };
            r.AddRange(data);
            r.Add(0x0B);
            return r.ToArray();

        }
    }
}
