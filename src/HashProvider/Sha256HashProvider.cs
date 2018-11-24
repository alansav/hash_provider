namespace Savage.Providers
{
    public class Sha256HashProvider : IHashProvider
    {
        public byte[] ComputeHash(byte[] value)
        {
            var alg = System.Security.Cryptography.SHA256.Create();
            return alg.ComputeHash(value);
        }
    }
}
