using System;
using BotReborn.Protocol.Crypto;
using Xunit;

namespace BotReborn.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1() {
            
            Crypto.GenerateKey("114");
        }
    }
}
