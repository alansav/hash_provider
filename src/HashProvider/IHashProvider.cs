namespace Savage.Providers
{
    public interface IHashProvider
    {
        byte[] ComputeHash(byte[] value);
    }
}
