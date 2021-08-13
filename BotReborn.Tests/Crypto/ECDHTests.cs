using System.Diagnostics;
using System.Runtime.InteropServices;
using BotReborn.Crypto;
using Org.BouncyCastle.Asn1.Nist;
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
        public void EcdhTwoWayTest()
        {
            var fixedPointCombMultiplier = new FixedPointCombMultiplier();
            var ecdh1 = new EncryptEcdh();
            var ecdh2 = new EncryptEcdh();
            ecdh1.GenerateKey();
            ecdh2.GenerateKey();
            var p256 = NistNamedCurves.GetByName("P-256");
            var pubKeyPoint1 = p256.Curve.DecodePoint(ecdh1.PublicKey);
            var pubKeyPoint2 = p256.Curve.DecodePoint(ecdh2.PublicKey);
            var shareKey1 = fixedPointCombMultiplier.Multiply(pubKeyPoint1, new BigInteger(ecdh2.PrivateKey));
            var shareKey2 = fixedPointCombMultiplier.Multiply(pubKeyPoint2, new BigInteger(ecdh1.PrivateKey));
            Assert.Equal(shareKey1, shareKey2);
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
        public void EcdhTest1(byte[] pub,byte[] pri)
        {
            var ecdh = new EncryptEcdh();
            var p256 = NistNamedCurves.GetByName("P-256");
            ecdh.GenerateKey();
            var fixedPointCombMultiplier = new FixedPointCombMultiplier();
            var pubPoint1 = p256.Curve.DecodePoint(pub);
            var pubPoint2 = p256.Curve.DecodePoint(ecdh.PublicKey);
            var share1 = fixedPointCombMultiplier.Multiply(pubPoint1, new BigInteger(ecdh.PrivateKey));
            var share2 = fixedPointCombMultiplier.Multiply(pubPoint2, new BigInteger(pri));
            var s1 = share1.GetEncoded();
            var s2 = share2.GetEncoded();
            Assert.Equal(s1,s2);
        }

        [Fact]
        public void FetchPublicKeyTest()
        {
            var ecdh = new EncryptEcdh();
            ecdh.FetchPubKey(1507180359);
            Assert.Equal(65, ecdh.PublicKey.Length);
        }

        [Fact]
        public void GenerateKeyTest()
        {
            var ecdh = new EncryptEcdh();
            ecdh.GenerateKey("0440eaf325b9c66225143aa7f3961c953c3d5a8048c2b73293cdc7dcbab7f35c4c66aa8917a8fd511f9d969d02c8501bcaa3e3b11746f00567e3aea303ac5f2d25");
        }
    }
}
