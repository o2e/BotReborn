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
            var tea = new Tea(Encoding.UTF8.GetBytes("0123456789ABCDEF"));
            var bytes = (byte[])Encoding.UTF8.GetBytes("MiraiGO Here");
            var enc1 = tea.Encrypt(bytes);
            var dec = tea.Decrypt(enc1);
            Assert.Equal(bytes, dec);
        }

        [Fact]
        public void TeaTwoWayTest2()
        {
            var tea = new Tea(Encoding.UTF8.GetBytes("0123456789ABCDEF"));
            var bytes = Utils.ConvertHexStringToByteArray("b7b2e52af7f5b1fbf37fc3d5546ac7569aecd01bbacf09bf");
            var dec1 = tea.Decrypt(bytes);
            var enc = tea.Encrypt(dec1);
            var dec2 = tea.Decrypt(enc);
            Assert.Equal(dec1, dec2);
        }

        [Theory]
        [InlineData("0123456789ABCDEF", "MiraiGO Here", "b7b2e52af7f5b1fbf37fc3d5546ac7569aecd01bbacf09bf")]
        [InlineData("0123456789ABCDEF", "s", "528e8b5c48300b548e94262736ebb8b7")]
        [InlineData("0123456789ABCDEF", "LXY Testing~", "9d0ab85aa14f5434ee83cd2a6b28bf306263cdf88e01264c")]
        [InlineData("0123456789ABCDEF", "long long long long long long long",
            "95715fab6efbd0fd4b76dbc80bd633ebe805849dbc242053b06557f87e748effd9f613f782749fb9fdfa3f45c0c26161")]
        public void TeaDecryptTest1(string key, string str, string enc)
        {
            var tea = new Tea(Encoding.UTF8.GetBytes(key));
            var dec = tea.Decrypt(Utils.ConvertHexStringToByteArray(enc));
            var expected = Encoding.UTF8.GetBytes(str);
            Assert.Equal(expected, dec);
        }

        [Theory]
        [InlineData("F0441F5FF42DA58FDCF7949ABA62D411",
            new byte[]
            {
                    0, 0, 0, 116, 16, 3, 44, 60, 76, 86, 10, 67, 111, 110, 102, 105, 103, 72, 116, 116, 112, 102,
                    17, 72, 116, 116, 112, 83, 101, 114, 118, 101, 114, 76, 105, 115, 116, 82, 101, 113, 125, 0, 0,
                    71, 8, 0, 1, 6, 17, 72, 116, 116, 112, 83, 101, 114, 118, 101, 114, 76, 105, 115, 116, 82, 101,
                    113, 29, 0, 0, 45, 10, 28, 44, 48, 1, 70, 5, 48, 48, 48, 48, 48, 80, 100, 98, 32, 2, 249, 11,
                    118, 15, 52, 54, 56, 51, 53, 54, 50, 57, 49, 56, 52, 54, 55, 51, 56, 140, 156, 172, 188, 204,
                    220, 224, 1, 11, 140, 152, 12, 168, 12,
            },
            new byte[]
            {
                    164, 2, 95, 121, 71, 248, 201, 56, 221, 119, 62, 160, 35, 142, 244, 39, 212, 173, 70, 236, 81,
                    102, 112, 108, 134, 128, 235, 64, 24, 236, 10, 196, 183, 100, 11, 140, 16, 166, 236, 200, 234,
                    214, 214, 94, 55, 39, 211, 40, 26, 232, 107, 63, 31, 177, 69, 100, 64, 199, 1, 130, 112, 161,
                    161, 49, 116, 3, 23, 229, 85, 97, 94, 53, 224, 108, 169, 87, 190, 183, 14, 241, 159, 13, 186,
                    43, 16, 69, 59, 46, 4, 247, 191, 224, 216, 99, 187, 140, 111, 38, 39, 118, 132, 12, 73, 238, 4,
                    14, 154, 96, 161, 28, 137, 152, 114, 236, 4, 0, 40, 172, 10, 127, 3, 239, 228, 128, 144, 82, 33,
                    236, 51, 102, 40, 72, 7, 130, 163, 112
            })]
        public void TeaDecryptTest2(string key, byte[] dec, byte[] enc)
        {
            var tea = new Tea(Utils.ConvertHexStringToByteArray(key));
            var tmp = tea.Decrypt(enc);
            Assert.Equal(dec, tmp);
        }

        [Theory]
        [InlineData("F0441F5FF42DA58FDCF7949ABA62D411",
            new byte[]
            {
                    0, 0, 0, 116, 16, 3, 44, 60, 76, 86, 10, 67, 111, 110, 102, 105, 103, 72, 116, 116, 112, 102,
                    17, 72, 116, 116, 112, 83, 101, 114, 118, 101, 114, 76, 105, 115, 116, 82, 101, 113, 125, 0, 0,
                    71, 8, 0, 1, 6, 17, 72, 116, 116, 112, 83, 101, 114, 118, 101, 114, 76, 105, 115, 116, 82, 101,
                    113, 29, 0, 0, 45, 10, 28, 44, 48, 1, 70, 5, 48, 48, 48, 48, 48, 80, 100, 98, 32, 2, 249, 11,
                    118, 15, 52, 54, 56, 51, 53, 54, 50, 57, 49, 56, 52, 54, 55, 51, 56, 140, 156, 172, 188, 204,
                    220, 224, 1, 11, 140, 152, 12, 168, 12,
            },
            new byte[]
            {
                    164, 2, 95, 121, 71, 248, 201, 56, 221, 119, 62, 160, 35, 142, 244, 39, 212, 173, 70, 236, 81,
                    102, 112, 108, 134, 128, 235, 64, 24, 236, 10, 196, 183, 100, 11, 140, 16, 166, 236, 200, 234,
                    214, 214, 94, 55, 39, 211, 40, 26, 232, 107, 63, 31, 177, 69, 100, 64, 199, 1, 130, 112, 161,
                    161, 49, 116, 3, 23, 229, 85, 97, 94, 53, 224, 108, 169, 87, 190, 183, 14, 241, 159, 13, 186,
                    43, 16, 69, 59, 46, 4, 247, 191, 224, 216, 99, 187, 140, 111, 38, 39, 118, 132, 12, 73, 238, 4,
                    14, 154, 96, 161, 28, 137, 152, 114, 236, 4, 0, 40, 172, 10, 127, 3, 239, 228, 128, 144, 82, 33,
                    236, 51, 102, 40, 72, 7, 130, 163, 112
            })]
        public void TeaDecryptTest3(string key, byte[] dec, byte[] enc)
        {
            var tea = new Tea(Utils.ConvertHexStringToByteArray(key));
            var tmp = tea.Encrypt(dec);
            var tmp1 = tea.Decrypt(tmp);
            Assert.Equal(dec, tmp1);
        }

        [Theory]
        [InlineData("0123456789ABCDEF", new byte[] { 183, 178, 229, 42, 247, 245, 177, 251 })]
        public void TeaUnpackTest(string key, byte[] data)
        {
            var tea = new Tea(Encoding.UTF8.GetBytes(key));
            var actual = tea.Unpack(data);
            var expected = (3081954602, 4160074235);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("0123456789ABCDEF", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }, 4206698361, 1129146738)]
        public void TeaRepackTest(string key, byte[] data, uint v0, uint v1)
        {
            var tea = new Tea(Encoding.UTF8.GetBytes(key));
            tea.Repack(data, v0, v1);
            var expected = new byte[] { 250, 189, 31, 121, 67, 77, 105, 114 };
            Assert.Equal(expected, data);
        }

        [Theory]
        [InlineData("0123456789ABCDEF", new byte[] { 250, 253, 252, 7, 33, 77, 105, 114 })]
        public void TeaEncodeTest(string key, byte[] src)
        {
            var dst = new byte[8];
            var tea = new Tea(Encoding.UTF8.GetBytes(key));
            tea.Encode(src, dst);
            var expected = new byte[] { 7, 19, 55, 116, 179, 195, 186, 143 };
            Assert.Equal(expected, dst);
        }

        [Theory]
        [InlineData("0123456789ABCDEF", new byte[] { 183, 178, 229, 42, 247, 245, 177, 251 })]
        public void TeaDecodeTest(string key, byte[] src)
        {
            var dst = new byte[8];
            var tea = new Tea(Encoding.UTF8.GetBytes(key));
            tea.Decode(src, dst);
            var expected = new byte[] { 250, 189, 31, 121, 67, 77, 105, 114 };
            Assert.Equal(expected, dst);
        }
    }
}
