using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotReborn.Jce;
using Xunit;

namespace BotReborn.Tests
{
    public class ClientTests
    {
        [Fact]
        public void LoginTest()
        {
            var uin = int.Parse(Environment.GetEnvironmentVariable("BotAccount",EnvironmentVariableTarget.User)!);
            var passwd = Environment.GetEnvironmentVariable("BotPassword", EnvironmentVariableTarget.User);
            var client = new Client(uin, passwd);
        }

        [Fact]
        public void JceStreamTest1()
        {
            var expected = new byte[]
            {
                28, 44, 48, 1, 70, 5, 48, 48, 48, 48, 48, 80, 100, 98, 32, 2, 249, 11, 118, 15, 52, 54, 56, 51, 53,
                54, 50, 57, 49, 56, 52, 54, 55, 51, 56, 140, 156, 172, 188, 204, 220, 224, 1
            };
            var payload = new JceStream()
                    .WriteInt64(0, 1)
                    .WriteInt64(0, 2)
                    .WriteByte(1, 3)
                    .WriteString("00000", 4)
                    .WriteInt32(100, 5)
                    .WriteInt32(537065739, 6)
                    .WriteString("468356291846738", 7)
                    .WriteInt64(0, 8)
                    .WriteInt64(0, 9)
                    .WriteInt64(0, 10)
                    .WriteInt64(0, 11)
                    .WriteByte(0, 12)
                    .WriteInt64(0, 13)
                    .WriteByte(1, 14)
                    .ToArray();
            Assert.Equal(expected, payload);
        }
    }
}
