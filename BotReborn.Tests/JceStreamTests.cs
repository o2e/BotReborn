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
    public class JceStreamTests
    {
        [Fact]
        public void JceStreamReadTest1()
        {
            var key = Utils.ConvertHexStringToByteArray("F0441F5FF42DA58FDCF7949ABA62D411");
            var payload = new byte[]
            {
                28, 44, 48, 1, 70, 5, 48, 48, 48, 48, 48, 80, 100, 98, 32, 2, 249, 11, 118, 15, 52, 54, 56, 51, 53,
                54, 50, 57, 49, 56, 52, 54, 55, 51, 56, 140, 156, 172, 188, 204, 220, 224, 1
            };
            var buf = new JceStructs.RequestDataVersion3()
            {
                Map = new Dictionary<string, byte[]>() { ["HttpServerListReq"] = Utils.PackUniRequestData(payload) }
            };
            var sBuffer = new byte[]
            {
                8, 0, 1, 6, 17, 72, 116, 116, 112, 83, 101, 114, 118, 101, 114, 76, 105, 115, 116, 82, 101, 113, 29,
                0, 0, 45, 10, 28, 44, 48, 1, 70, 5, 48, 48, 48, 48, 48, 80, 100, 98, 32, 2, 249, 11, 118, 15, 52,
                54, 56, 51, 53, 54, 50, 57, 49, 56, 52, 54, 55, 51, 56, 140, 156, 172, 188, 204, 220, 224, 1, 11
            };
            var pkt = new JceStructs.RequestPacket
            {
                IVersion = 3,
                SServantName = "ConfigHttp",
                SFuncName = "HttpServerListReq",
                SBuffer = sBuffer
            };
            var data = pkt.GetBytes();

            var expected = new byte[]
            {
                16, 3, 44, 60, 76, 86, 10, 67, 111, 110, 102, 105, 103, 72, 116, 116, 112, 102, 17, 72, 116, 116,
                112, 83, 101, 114, 118, 101, 114, 76, 105, 115, 116, 82, 101, 113, 125, 0, 0, 71, 8, 0, 1, 6, 17,
                72, 116, 116, 112, 83, 101, 114, 118, 101, 114, 76, 105, 115, 116, 82, 101, 113, 29, 0, 0, 45, 10,
                28, 44, 48, 1, 70, 5, 48, 48, 48, 48, 48, 80, 100, 98, 32, 2, 249, 11, 118, 15, 52, 54, 56, 51, 53,
                54, 50, 57, 49, 56, 52, 54, 55, 51, 56, 140, 156, 172, 188, 204, 220, 224, 1, 11, 140, 152, 12, 168,
                12
            };

            Assert.Equal(expected,data);
        }
    }
}
