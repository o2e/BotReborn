using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotReborn.Crypto;
using Xunit;

namespace BotReborn.Tests.Crypto
{
    public class TeaTests
    {
        [Fact]
        public void TeaTwoWayTest()
        {
            var tea = new Tea(Encoding.UTF8.GetBytes("0123456789ABCDEF"));
            var bytes = Encoding.UTF8.GetBytes("1145148101919");
            var enc = tea.Encrypt(bytes);
            var dec = tea.Decrypt(enc);
            Assert.Equal(bytes,dec);
        }
        [Theory()]
        [InlineData("0123456789ABCDEF", "MiraiGO Here", "b7b2e52af7f5b1fbf37fc3d5546ac7569aecd01bbacf09bf")]
        [InlineData("0123456789ABCDEF", "s", "528e8b5c48300b548e94262736ebb8b7")]
        public void TeaEncryptTest(string cipher,string s,string enc)
        {
            var tea = new Tea(Encoding.UTF8.GetBytes(cipher));
            var actual = tea.Encrypt(Encoding.UTF8.GetBytes(s));
            var expected = Utils.ConvertHexStringToByteArray(enc);
            Assert.Equal(expected,actual);
        }
    }
}
