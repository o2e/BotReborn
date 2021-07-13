using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;


namespace BotReborn
{
    

    public class EncryptECDH
    {
        private const string ServerPublicKey =
            "04EBCA94D733E399B2DB96EACDD3F69A8BB0F74224E2B44E3357812211D2E62EFBC91BB553098E25E33A799ADC7F76FEB208DA7C6522CDB0719A305180CC54A82E";
        private readonly HttpClient _httpClient;

        public byte[] InitialShareKey { get; set; }
        public virtual byte[] PublicKey { get; set; }
        public ushort PublicKeyVersion { get; private set; }
        public EncryptECDH()
        {
            _httpClient = new HttpClient();
            PublicKeyVersion = 1;
        }
        ~EncryptECDH()
        {
            _httpClient.Dispose();
        }



        public  void FetchPubKey(Uin uin)
        {
            var stream =
                 _httpClient.GetStreamAsync("https://keyrotate.qq.com/rotate_key?cipher_suite_ver=305&uin=" + uin).Result;
            var json =  JsonDocument.Parse(stream);
            var pubKeyJson = json.RootElement.GetProperty("PubKeyMeta");
            PublicKeyVersion = pubKeyJson.GetProperty("KeyVer").GetUInt16();
            var pubKey = pubKeyJson.GetProperty("PubKey").GetString();
            GenerateKey(pubKey);
        }

        public void GenerateKey(string pubKeyStr)
        {
            var md5 = HashAlgorithm.Create("md5");
            var fixedPointCombMultiplier = new FixedPointCombMultiplier();
            var pubKeyBytes = Utils.ConvertHexStringToByteArray(pubKeyStr);
            var generator = new ECKeyPairGenerator("EC");
            var p256 = NistNamedCurves.GetByName("P-256");
            var pubKeyPoint = p256.Curve.DecodePoint(pubKeyBytes);
            var domainParameters = new ECDomainParameters(p256);
            var keyGenerationParameters = new ECKeyGenerationParameters(domainParameters, new SecureRandom());
            generator.Init(keyGenerationParameters);
            var keyPair = generator.GenerateKeyPair();
            var privateKey = (ECPrivateKeyParameters)keyPair.Private;
            var publicKey = (ECPublicKeyParameters)keyPair.Public;
            var shareEcPoint = fixedPointCombMultiplier.Multiply(pubKeyPoint, privateKey.D);
            var x = shareEcPoint.XCoord.GetEncoded();
            var hash = md5!.ComputeHash(x.TakeLast(16).ToArray());
            InitialShareKey = hash[..];
            PublicKey = publicKey.Q.GetEncoded();
        }
    }
}
