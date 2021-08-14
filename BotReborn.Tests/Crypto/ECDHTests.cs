using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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
        public void EcdhTwoWayTest1()
        {
            var ecdh1 = new Ecdh();
            var ecdh2 = new Ecdh();
            var share1 = ecdh1.CalculateAgreement(ecdh2.PublicKey);
            var share2 = ecdh2.CalculateAgreement(ecdh1.PublicKey);
            Assert.Equal(share1,share2);
        }
    }
}
