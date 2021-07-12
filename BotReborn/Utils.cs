using System;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace BotReborn
{
    public class Utils {
        public static byte[] ConvertHexStringToByteArray(string hex)
        {
            static int GetHexVal(char hex) => hex - (hex < 58 ? 48 : hex < 97 ? 55 : 87);
            if (hex.Length % 2 == 1)
                throw new("The binary key cannot have an odd number of digits");

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
    }
}
