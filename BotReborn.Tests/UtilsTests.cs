using System;
using Xunit;

namespace BotReborn.Tests
{
    public class UtilsTests
    {
        [Fact]
        public void ConvertHexStringToByteArrayTest()
        {
            var expected = new byte[] { 4, 64, 234, 243, 37, 185, 198, 98, 37, 20, 58, 167, 243, 150, 28, 149, 60, 61, 90, 128, 72, 194, 183, 50, 147, 205, 199, 220, 186, 183, 243, 92, 76, 102, 170, 137, 23, 168, 253, 81, 31, 157, 150, 157, 2, 200, 80, 27, 202, 163, 227, 177, 23, 70, 240, 5, 103, 227, 174, 163, 3, 172, 95, 45, 37 };
            var actual =Utils.ConvertHexStringToByteArray(
                "0440eaf325b9c66225143aa7f3961c953c3d5a8048c2b73293cdc7dcbab7f35c4c66aa8917a8fd511f9d969d02c8501bcaa3e3b11746f00567e3aea303ac5f2d25");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConvertByteArrayToHexStringTest()
        {
            var bytes = new byte[] { 4, 64, 234, 243, 37, 185, 198, 98, 37, 20, 58, 167, 243, 150, 28, 149, 60, 61, 90, 128, 72, 194, 183, 50, 147, 205, 199, 220, 186, 183, 243, 92, 76, 102, 170, 137, 23, 168, 253, 81, 31, 157, 150, 157, 2, 200, 80, 27, 202, 163, 227, 177, 23, 70, 240, 5, 103, 227, 174, 163, 3, 172, 95, 45, 37 };
            var expected =
                "0440eaf325b9c66225143aa7f3961c953c3d5a8048c2b73293cdc7dcbab7f35c4c66aa8917a8fd511f9d969d02c8501bcaa3e3b11746f00567e3aea303ac5f2d25";
            var actual = Utils.ConvertByteArrayToHexString(bytes);
            Assert.Equal(expected, actual,StringComparer.InvariantCultureIgnoreCase);
        }

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
    }
}
