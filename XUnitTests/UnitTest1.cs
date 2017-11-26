using MD.XRng;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void NegativeByteCountTest()
        {
            const int byteCounnt = -1;
            IPrng prng = new PrngSHA256();

            byte[] bytes;
            Exception ex = Assert.Throws<ArgumentException>(() => bytes = prng.GetRandomBytes(byteCounnt));

            Assert.Contains("A non-negative integer is required.", ex.Message);
        }

        [Fact]
        public void GetSingleRandomByteTest()
        {
            IPrng prng = new PrngSHA256();

            byte b = prng.GetRandomByte();

            Assert.True(Convert.ToInt32(b) > -1 && Convert.ToInt32(b) < 256);
        }

        [Theory]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(33)]
        [InlineData(1024)]
        [InlineData(4096)]
        public void GetBytesEntropyTest(int byteCount)
        {
            IPrng prng = new PrngSHA256();
            bool isFilled = false;

            byte[] bytes = prng.GetRandomBytes(byteCount);
            foreach (var b in bytes)
            {
                if (Convert.ToInt32(b) > 0)
                {
                    //Testing that we are getting at least some non-zero values. Not testing the quality of the PRNG.
                    isFilled = true;
                }
            }

            Assert.True(isFilled);
        }

        [Theory]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(33)]
        [InlineData(1024)]
        [InlineData(4096)]
        public void GetBytesCountTest(int byteCount)
        {
            IPrng prng = new PrngSHA256();

            byte[] bytes = prng.GetRandomBytes(byteCount);

            Assert.True(bytes.Length == byteCount);
        }
    }
}
