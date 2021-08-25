using System;
using System.Net.Http;
using Xunit;

namespace BotReborn.Tests
{
    public class UtilsTests
    {
        [Fact]
        public void PackUniRequestDataTest()
        {
            var payload = new byte[]
            {
                28, 44, 48, 1, 70, 5, 48, 48, 48, 48, 48, 80, 100, 98, 32, 2, 249, 11, 118, 15, 52, 54, 56, 51, 53,
                54, 50, 57, 49, 56, 52, 54, 55, 51, 56, 140, 156, 172, 188, 204, 220, 224, 1
            };

            var expected = new byte[]
            {
                10, 28, 44, 48, 1, 70, 5, 48, 48, 48, 48, 48, 80, 100, 98, 32, 2, 249, 11, 118, 15, 52, 54, 56, 51,
                53, 54, 50, 57, 49, 56, 52, 54, 55, 51, 56, 140, 156, 172, 188, 204, 220, 224, 1, 11
            };
            var actual = Utils.PackUniRequestData(payload);
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void HttpPostBytesTest()
        {
            var data = new byte[]
            {
                164, 2, 95, 121, 71, 248, 201, 56, 221, 119, 62, 160, 35, 142, 244, 39, 212, 173, 70, 236, 81, 102,
                112, 108, 134, 128, 235, 64, 24, 236, 10, 196, 183, 100, 11, 140, 16, 166, 236, 200, 234, 214, 214,
                94, 55, 39, 211, 40, 26, 232, 107, 63, 31, 177, 69, 100, 64, 199, 1, 130, 112, 161, 161, 49, 116, 3,
                23, 229, 85, 97, 94, 53, 224, 108, 169, 87, 190, 183, 14, 241, 159, 13, 186, 43, 16, 69, 59, 46, 4,
                247, 191, 224, 216, 99, 187, 140, 111, 38, 39, 118, 132, 12, 73, 238, 4, 14, 154, 96, 161, 28, 137,
                152, 114, 236, 4, 0, 40, 172, 10, 127, 3, 239, 228, 128, 144, 82, 33, 236, 51, 102, 40, 72, 7, 130,
                163, 112
            };
            var httpClient = new HttpClient();
            var rsp = httpClient.PostBytes("https://configsvr.msf.3g.qq.com/configsvr/serverlist.jsp", data);
            Console.WriteLine();
        }
    }
}
