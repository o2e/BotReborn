using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;


namespace BotReborn
{
    public class ECDH
    {
        private const string ServerPublicKey =
            "04EBCA94D733E399B2DB96EACDD3F69A8BB0F74224E2B44E3357812211D2E62EFBC91BB553098E25E33A799ADC7F76FEB208DA7C6522CDB0719A305180CC54A82E";
        private readonly HttpClient _httpClient;

        public byte[] InitialShareKey { get; set; }
        public virtual byte[] PublicKey { get; set; }
        public ushort PublicKeyVersion { get; private set; }
        public ECDH()
        {
            _httpClient = new HttpClient();
            PublicKeyVersion = 1;
        }
        ~ECDH()
        {
            _httpClient.Dispose();
        }



        public async Task FetchPubKeyAsync(Uin uin)
        {
            var stream =
                await _httpClient.GetStreamAsync("https://keyrotate.qq.com/rotate_key?cipher_suite_ver=305&uin=" + uin);
            var json = await JsonDocument.ParseAsync(stream);
            var pubKeyJson = json.RootElement.GetProperty("PubKeyMeta");
            var pubKeyVer = pubKeyJson.GetProperty("KeyVer").GetString();
            var pubKey = pubKeyJson.GetProperty("PubKey").GetString();
        }

        public void GenerateKey(string pubKeyStr)
        {
            var pubKey = ConvertStringToByteArray(pubKeyStr);
            var generator = new ECKeyPairGenerator("ECDH");
            var keyGenerationParameters = new ECKeyGenerationParameters(DerObjectIdentifier.GetInstance(pubKey), new SecureRandom());
            generator.Init(keyGenerationParameters);
            var keyPair = generator.GenerateKeyPair();
            var privateKey = (ECPrivateKeyParameters)keyPair.Private;
            var publicKey = (ECPublicKeyParameters)keyPair.Public;
            var shareKey = privateKey.D.Multiply(new BigInteger(pubKey));
            InitialShareKey = shareKey.ToByteArray(); //May be ToByteArrayUnsigned()
            PublicKey = publicKey.PublicKeyParamSet.GetEncoded();
        }


        public static byte[] ConvertStringToByteArray(string hex)
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
    }
}
