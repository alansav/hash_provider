using System;
using Xunit;

namespace Savage.Providers
{
    public class Sha512HashProviderTests
    {
        [Fact]
        public void ComputeHash_returns_expected_value()
        {
            var source = new byte[] { 1, 2, 3 };
            var expectedHash = Convert.FromBase64String("J4ZMxSGalRp6blK4yN3faYHQmNoWWNliWMhwssiN+8tRhBrqFyoouvpqeXMRZVhGdwZgRclZ7Q+ZKWiNBN78KQ==");

            var sut = new Sha512HashProvider();
            var actual = sut.ComputeHash(source);

            Assert.Equal(expectedHash, actual);
        }
    }
}
