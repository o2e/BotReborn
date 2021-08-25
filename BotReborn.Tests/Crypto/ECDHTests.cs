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
        { 4,32
            ,188
            ,141
            ,244
            ,45
            ,154
            ,212
            ,47
            ,200
            ,100
            ,37
            ,254
            ,131
            ,87
            ,39
            ,162
            ,86
            ,243
            ,88
            ,189
            ,18
            ,244
            ,39
            ,156
            ,181
            ,17
            ,124
            ,169
            ,237
            ,130
            ,162
            ,47
            ,88
            ,133
            ,13
            ,142
            ,178
            ,248
            ,56
            ,205
            ,176
            ,82
            ,48
            ,87
            ,5
            ,65
            ,190
            ,7
            ,120
            ,71
            ,97
            ,151
            ,242
            ,93
            ,79
            ,246
            ,31
            ,219
            ,181
            ,195
            ,16
            ,29
            ,199
            ,154 }, new byte[]
        { 94,34,109,78,29,237,205,196,121,253,14,21,15,234,181,28
                ,178
                ,111
                ,250
                ,120
                ,131
                ,171
                ,6
                ,15
                ,65
                ,71
            ,243,138,238,180,31 ,219 })]
        public void EcdhTest1(byte[] pub, byte[] pri)
        {
            var ecdh = new Ecdh();
            var p256 = NistNamedCurves.GetByName("P-256");
            ECDomainParameters ecDomain = new ECDomainParameters(p256);
            IBasicAgreement aKeyAgree = AgreementUtilities.GetBasicAgreement("ECDH");
            aKeyAgree.Init(new ECPrivateKeyParameters("ECDH", new BigInteger(pri), ecDomain));
            var sharedSecret = aKeyAgree.CalculateAgreement(new ECPublicKeyParameters("ECDH", p256.Curve.DecodePoint(ecdh.PublicKey),
                ecDomain));
            byte[] sharedSecretBytes = sharedSecret.ToByteArray();
            var share1 = MD5.HashData(sharedSecretBytes[..16]);
            var share2 = ecdh.CalculateAgreement(pub);
            Assert.Equal(share1, share2);
        }
    }
}
