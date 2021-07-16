using System.Diagnostics;
using BotReborn.Crypto;
using Xunit;

namespace BotReborn.Tests
{
    public class ECDHTests
    {
        [Fact]
        public void FetchPublicKeyTest()
        {
            var ecdh = new EncryptECDH();
            ecdh.FetchPubKey(1507180359);
            Assert.Equal(65, ecdh.PublicKey.Length);
        }

        [Fact]
        public void GenerateKeyTest()
        {
            var ecdh = new EncryptECDH();
            ecdh.GenerateKey("0440eaf325b9c66225143aa7f3961c953c3d5a8048c2b73293cdc7dcbab7f35c4c66aa8917a8fd511f9d969d02c8501bcaa3e3b11746f00567e3aea303ac5f2d25");
            Debug.WriteLine("ShareKey: " + Utils.ConvertByteArrayToHexString(ecdh.InitialShareKey));
            Debug.WriteLine("PublicKey: " + Utils.ConvertByteArrayToHexString(ecdh.PublicKey));
        }
    }
}
