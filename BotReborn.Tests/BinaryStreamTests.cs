using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotReborn.Crypto;
using BotReborn.Jce;
using Xunit;

namespace BotReborn.Tests
{
    public class BinaryStreamTests
    {
        [Fact]
        public void BinaryTeaTest1()
        {
            var key = Utils.ConvertHexStringToByteArray("F0441F5FF42DA58FDCF7949ABA62D411");
            var tea = new Tea(key);
            var payload = new byte[]
            {
                28, 44, 48, 1, 70, 5, 48, 48, 48, 48, 48, 80, 100, 98, 32, 2, 249, 11, 118, 15, 52, 54, 56, 51, 53,
                54, 50, 57, 49, 56, 52, 54, 55, 51, 56, 140, 156, 172, 188, 204, 220, 224, 1
            };
            var buf = new JceStructs.RequestDataVersion3()
            {
                Map = new Dictionary<string, byte[]>() { ["HttpServerListReq"] = Utils.PackUniRequestData(payload) }
            };
            var pkt = new JceStructs.RequestPacket
            {
                IVersion = 3,
                SServantName = "ConfigHttp",
                SFuncName = "HttpServerListReq",
                SBuffer = buf.GetBytes()
            };
            var reqData =
                tea.Encrypt(new BinaryStream().WriteIntLvPacket(0, pkt.GetBytes()).ToArray());
            var expected = new byte[]
            {
                183, 103, 207, 65, 78, 199, 191, 28, 207, 195, 78, 23, 243, 105, 4, 8, 240, 174, 233, 126, 6, 77,
                197, 124, 50, 71, 205, 99, 30, 203, 97, 111, 219, 143, 222, 244, 219, 156, 193, 46, 18, 44, 111,
                202, 191, 24, 217, 126, 178, 246, 135, 128, 208, 208, 99, 171, 59, 89, 234, 188, 135, 44, 9, 160
            };
            Assert.Equal(expected,reqData);
        }
    }
}
