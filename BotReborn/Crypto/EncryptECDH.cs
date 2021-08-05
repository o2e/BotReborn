using System;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text.Json;
using BotReborn.Packets;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;

namespace BotReborn.Crypto
{


    public class EncryptECDH
    {
        // ReSharper disable once UnusedMember.Local
        private const string ServerPublicKey =
            "04EBCA94D733E399B2DB96EACDD3F69A8BB0F74224E2B44E3357812211D2E62EFBC91BB553098E25E33A799ADC7F76FEB208DA7C6522CDB0719A305180CC54A82E";
        private readonly HttpClient _httpClient;

        public byte[] ShareKey { get; set; }
        public byte[] PublicKey { get; set; }
        public byte[] PrivateKey { get; set; }
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



        public void FetchPubKey(Uin uin)
        {
            var stream =
                 _httpClient.GetStreamAsync("https://keyrotate.qq.com/rotate_key?cipher_suite_ver=305&uin=" + uin).Result;
            var json = JsonDocument.Parse(stream);
            var pubKeyJson = json.RootElement.GetProperty("PubKeyMeta");
            PublicKeyVersion = pubKeyJson.GetProperty("KeyVer").GetUInt16();
            var pubKey = pubKeyJson.GetProperty("PubKey").GetString();
            GenerateKey(pubKey);
        }

        public byte[] GenerateKey(string pubKeyStr)
        {
            var md5 = MD5.Create();
            var generator = new ECKeyPairGenerator("EC");
            var p256 = NistNamedCurves.GetByName("P-256");
            var domainParameters = new ECDomainParameters(p256);
            var keyGenerationParameters = new ECKeyGenerationParameters(domainParameters, new SecureRandom());
            generator.Init(keyGenerationParameters);
            var keyPair = generator.GenerateKeyPair();
            var privateKey = (ECPrivateKeyParameters)keyPair.Private;
            var publicKey = (ECPublicKeyParameters)keyPair.Public;
            PrivateKey = privateKey.D.ToByteArray();
            PublicKey = publicKey.Q.GetEncoded();
            if (string.IsNullOrEmpty(pubKeyStr))
            {
                return null;
            }
            var fixedPointCombMultiplier = new FixedPointCombMultiplier();
            var pubKeyBytes = Utils.ConvertHexStringToByteArray(pubKeyStr);
            var pubKeyPoint = p256.Curve.DecodePoint(pubKeyBytes);
            var shareEcPoint = fixedPointCombMultiplier.Multiply(pubKeyPoint, privateKey.D);
            var x = shareEcPoint.XCoord.GetEncoded();
            var hash = md5!.ComputeHash(x.TakeLast(16).ToArray());
            return hash[..];
        }

        public void GenerateKey()
        {
            _ = GenerateKey(null);
        }

        public byte[] DecryptPayload(byte[] random, byte[] sessionKey, IncomingPacket incomingPacket)
        {
            var stream = new BinaryStream(incomingPacket.Payload);
            if (stream.ReadByte() != 2)
            {
                throw new Exception("Unknown flag.");
            }

            stream.ReadBytes(2);
            stream.ReadBytes(2);
            stream.ReadUInt16();
            stream.ReadUInt16();
            stream.ReadInt32();
            var encryptType = stream.ReadUInt16();
            stream.ReadByte();
            if (encryptType == 0)
            {
                var d = stream.ReadBytes((int)(stream.Length - stream.Position - 1));
                return new Tea(this.ShareKey).Decrypt(d);
            }

            if (encryptType == 3)
            {
                var d = stream.ReadBytes((int)(stream.Length - stream.Position - 1));
                return new Tea(sessionKey).Decrypt(d);
            }

            if (encryptType==4)
            {
                throw new NotImplementedException();
            }
            throw new Exception("Unknown flag.");
        }
    }
}
