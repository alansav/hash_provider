namespace Savage.Providers
{
    public class Sha512HashProvider : IHashProvider
    {
        public byte[] ComputeHash(byte[] value)
        {
            var alg = System.Security.Cryptography.SHA512.Create();
            return alg.ComputeHash(value);
        }
    }
}
