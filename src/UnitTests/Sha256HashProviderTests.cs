using System;
using Xunit;

namespace Savage.Providers
{
    public class Sha256HashProviderTests
    {
        [Fact]
        public void ComputeHash_returns_expected_value()
        {
            var source = new byte[] { 1, 2, 3 };
            var expectedHash = Convert.FromBase64String("A5BYxvLAy0ksUzsKTRTvd8wPeKvMztUofYShogEc+4E=");

            var sut = new Sha256HashProvider();
            var actual = sut.ComputeHash(source);

            Assert.Equal(expectedHash, actual);
        }
    }
}
