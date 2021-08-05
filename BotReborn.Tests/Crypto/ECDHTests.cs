using System.Diagnostics;
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
            Assert.Equal(shareKey1,shareKey2);
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
