using System;
using Xunit;

namespace Savage.Providers
{
    public class Sha1HashProviderTests
    {
        [Fact]
        public void ComputeHash_returns_expected_value()
        {
            var source = new byte[] { 1, 2, 3 };
            var expectedHash = Convert.FromBase64String("cDeAcZjCKn0rCAc3HXY3eahP388=");

            var sut = new Sha1HashProvider();
            var actual = sut.ComputeHash(source);

            Assert.Equal(expectedHash, actual);
        }
    }
}
