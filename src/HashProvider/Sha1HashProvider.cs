namespace Savage.Providers
{
    public class Sha1HashProvider : IHashProvider
    {
        public byte[] ComputeHash(byte[] value)
        {
            var alg = System.Security.Cryptography.SHA1.Create();
            return alg.ComputeHash(value);
        }
    }
}
