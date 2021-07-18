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
        public void TeaTwoWayTest1()
        {
            var tea = new Tea(Utils.GetBytes("0123456789ABCDEF"));
            var bytes = Utils.GetBytes("MiraiGO Here");
            var enc1 = tea.Encrypt(bytes);
            var dec = tea.Decrypt(enc1);
            Assert.Equal(bytes, dec);
        }

        [Fact]
        public void TeaTwoWayTest2()
        {
            var tea = new Tea(Utils.GetBytes("0123456789ABCDEF"));
            var bytes = Utils.ConvertHexStringToByteArray("b7b2e52af7f5b1fbf37fc3d5546ac7569aecd01bbacf09bf");
            var dec1 = tea.Decrypt(bytes);
            var enc = tea.Encrypt(dec1);
            var dec2 = tea.Decrypt(enc);
            Assert.Equal(dec1, dec2);
        }
        
        [Theory]
        [InlineData("0123456789ABCDEF", "MiraiGO Here", "b7b2e52af7f5b1fbf37fc3d5546ac7569aecd01bbacf09bf")]
        [InlineData("0123456789ABCDEF", "s", "528e8b5c48300b548e94262736ebb8b7")]
        public void TeaDecryptTest(string key, string str, string enc)
        {
            var tea = new Tea(Encoding.UTF8.GetBytes(key));
            var dec = tea.Decrypt(Utils.ConvertHexStringToByteArray(enc));
            var expected = Encoding.UTF8.GetBytes(str);
            Assert.Equal(expected,dec);
        }

        [Theory]
        [InlineData("0123456789ABCDEF", new byte[] { 183, 178, 229, 42, 247, 245, 177, 251 })]
        public void TeaUnpackTest(string key,byte[] data)
        {
            var tea = new Tea(Utils.GetBytes(key));
            var actual = tea.Unpack(data);
            var expected = (3081954602, 4160074235);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("0123456789ABCDEF", new byte[]{0,0,0,0,0,0,0,0}, 4206698361, 1129146738)]
        public void TeaRepackTest(string key, byte[] data,uint v0,uint v1)
        {
            var tea = new Tea(Utils.GetBytes(key));
            tea.Repack(data,v0,v1);
            var expected = new byte[] {250, 189, 31, 121, 67, 77, 105, 114};
            Assert.Equal(expected,data);
        }
        [Theory]
        [InlineData("0123456789ABCDEF", new byte[] { 250,253,252,7,33,77,105,114 })]
        public void TeaEncodeTest(string key,byte[] src)
        {
            var dst = new byte[8];
            var tea = new Tea(Utils.GetBytes(key));
            tea.Encode(src,dst);
            var expected = new byte[] {7, 19, 55, 116, 179, 195, 186, 143};
            Assert.Equal(expected,dst);
        }

        [Theory]
        [InlineData("0123456789ABCDEF", new byte[] { 183,178,229,42,247,245,177,251 })]
        public void TeaDecodeTest(string key, byte[] src)
        {
            var dst = new byte[8];
            var tea = new Tea(Utils.GetBytes(key));
            tea.Decode(src, dst);
            var expected = new byte[] {250,189,31,121,67,77,105,114};
            Assert.Equal(expected, dst);
        }
    }
}
