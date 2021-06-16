using System;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text.Json.Node;
using System.Threading.Tasks;

namespace BotReborn.Protocol.Crypto {
    public class Crypto {
        public async Task GetPubKeyAsync(Uin uin) {
            try {
                using var httpClient = new HttpClient();
                var jsonStr = await httpClient.GetStringAsync(
                    "https://keyrotate.qq.com/rotate_key?cipher_suite_ver=305&uin=" + uin);
                var jsonNode = JsonNode.Parse(jsonStr);

                var keyVer = jsonNode?["PubKeyMeta"]?["KeyVer"]?.GetValue<ushort>();
                var pubKey = jsonNode?["PubKeyMeta"]?["PubKey"]?.ToString();
                var pubKeyBytes = DecodeHexString(pubKey);
                var ecParameters = new ECParameters();//I can't do it. :)
                ECDsa.Create(ecParameters);
            }
            catch (Exception e) {
                System.Console.WriteLine(e);
                throw e;
            }
        }

        public static EncryptEcdh GenerateKey(string str) {
            var curve = ECCurve.CreateFromFriendlyName("ECDSA_P256");
            var ecDsa = ECDsa.Create();
            ecDsa?.GenerateKey(curve);

            return new EncryptEcdh();
        }

        public byte[] DecodeHexString(string hex) => Enumerable.Range(0, hex.Length / 2).Select(x => Convert.ToByte(hex.Substring(x * 2, 2), 16)).ToArray();
    }
}
