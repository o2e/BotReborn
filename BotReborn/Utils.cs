using System;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text.Json.Node;
using System.Threading.Tasks;

namespace BotReborn {
    public class Utils {
        public async Task GetPubKeyAsync(Uin uin)
        {
            using var httpClient = new HttpClient();
            var jsonStr = await httpClient.GetStringAsync(
                "https://keyrotate.qq.com/rotate_key?cipher_suite_ver=305&uin=" + uin);
            var jsonNode = JsonNode.Parse(jsonStr);

            var keyVer = jsonNode?["PubKeyMeta"]?["KeyVer"]?.GetValue<ushort>();
            var pubKey = jsonNode?["PubKeyMeta"]?["PubKey"]?.ToString();
            var pubKeyBytes = DecodeHexString(pubKey);
            var curve = ECCurve.CreateFromFriendlyName("secp256r1");
            var ecdh = ECDiffieHellman.Create();
        }



        public  static byte[] DecodeHexString(string hex) => Enumerable.Range(0, hex.Length / 2).Select(x => Convert.ToByte(hex.Substring(x * 2, 2), 16)).ToArray();
    }
}
