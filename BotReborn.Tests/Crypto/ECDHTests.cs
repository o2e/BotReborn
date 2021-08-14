using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using BotReborn.Crypto;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;
using Xunit;

namespace BotReborn.Tests.Crypto
{
    public class ECDHTests
    {
        [Fact]
        public void EcdhTwoWayTest1()
        {
            var ecdh1 = new Ecdh();
            var ecdh2 = new Ecdh();
            var share1 = ecdh1.CalculateAgreement(ecdh2.PublicKey);
            var share2 = ecdh2.CalculateAgreement(ecdh1.PublicKey);
            Assert.Equal(share1, share2);
        }

        [Theory]
        [InlineData(new byte[]
        {
            4, 144, 231, 207, 89, 52, 57, 34, 0, 75, 19, 127, 181, 0, 140, 211, 229, 97, 52, 217, 160, 34, 205,
            105, 56, 241, 130, 180, 94, 31, 59, 80, 136, 233, 118, 9, 147, 215, 226, 225, 83, 0, 76, 35, 35, 57,
            90, 6, 37, 47, 27, 77, 86, 201, 138, 8, 159, 201, 219, 133, 176, 169, 164, 199, 224
        }, new byte[]
        {
            180, 0, 39, 177, 136, 100, 197, 77, 62, 183, 55, 174, 219, 38, 213, 35, 153, 230, 119, 164, 200,
            204, 63, 235, 78, 79, 92, 162, 55, 49, 46, 128
        })]
        public void EcdhTest1(byte[] pub, byte[] pri)
        {
            using var md5 = MD5.Create();
            var ecdh = new Ecdh();
            var p256 = NistNamedCurves.GetByName("P-256");
            ECDomainParameters ecDomain = new ECDomainParameters(p256);
            IBasicAgreement aKeyAgree = AgreementUtilities.GetBasicAgreement("ECDH");
            aKeyAgree.Init(new ECPrivateKeyParameters("ECDH", new BigInteger(pri), ecDomain));
            var sharedSecret = aKeyAgree.CalculateAgreement(new ECPublicKeyParameters("ECDH", p256.Curve.DecodePoint(ecdh.PublicKey),
                ecDomain));
            byte[] sharedSecretBytes = sharedSecret.ToByteArray();
            var share1 =  md5.ComputeHash(sharedSecretBytes[..16]);
            var share2 = ecdh.CalculateAgreement(pub);
            Assert.Equal(share1, share2);
        }
    }
}
