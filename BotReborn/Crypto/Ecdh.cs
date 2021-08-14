using System;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text.Json;
using System.Threading;
using Microsoft.Win32.SafeHandles;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;

namespace BotReborn.Crypto
{


    public class Ecdh
    {
        private readonly byte[] _remotePublicKey = Utils.ConvertHexStringToByteArray(
            "04EBCA94D733E399B2DB96EACDD3F69A8BB0F74224E2B44E3357812211D2E62EFBC91BB553098E25E33A799ADC7F76FEB208DA7C6522CDB0719A305180CC54A82E");
        public byte Id => 0x87;
        public byte[] ShareKey { get; set; }
        public byte[] PublicKey { get; set; }
        public ushort PublicKeyVersion { get; private set; }
        public Ecdh()
        {
            PublicKeyVersion = 1;
            using var md5 = MD5.Create();
            var p256 = NistNamedCurves.GetByName("P-256");
            ECDomainParameters ecDomain = new ECDomainParameters(p256);
            ECKeyPairGenerator generator = (ECKeyPairGenerator)GeneratorUtilities.GetKeyPairGenerator("ECDH");
            generator.Init(new ECKeyGenerationParameters(ecDomain, new SecureRandom()));
            AsymmetricCipherKeyPair localKeyPair = generator.GenerateKeyPair();
            var localPublicKey = (ECPublicKeyParameters)localKeyPair.Public;
            PublicKey=SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(localPublicKey).GetEncoded();
            IBasicAgreement aKeyAgree = AgreementUtilities.GetBasicAgreement("ECDH");
            aKeyAgree.Init(localKeyPair.Private);
            var otherPubkey = new ECPublicKeyParameters("ECDH", p256.Curve.DecodePoint(_remotePublicKey), ecDomain);
            BigInteger sharedSecret = aKeyAgree.CalculateAgreement(otherPubkey);
            byte[] sharedSecretBytes = sharedSecret.ToByteArray();
            ShareKey = md5.ComputeHash(sharedSecretBytes[..16]);
        }

        public byte[] DoEncrypt(byte[] b1, byte[] b2)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteByte(0x02);
            binaryStream.WriteByte(0x01);
            binaryStream.Write(b2);
            binaryStream.WriteUInt16(0x01_31);
            binaryStream.WriteUInt16(PublicKeyVersion);
            binaryStream.WriteUInt16((ushort)PublicKey.Length);
            binaryStream.Write(PublicKey);
            binaryStream.EncryptAndWrite(ShareKey, b1);
            return binaryStream.ToArray();
        }
    }
}
