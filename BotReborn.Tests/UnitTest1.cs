using System;
using Xunit;

namespace BotReborn.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1() {
            
            MyECDiffieHellman.GenerateKey("114");
        }
    }
}
