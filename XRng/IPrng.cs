/* Attribution
 * Mike DePaul
 * https://github.com/mdepaul/XRng.git
 * */
namespace MD.XRng
{
    public interface IPrng
    {
        byte GetRandomByte();

        byte[] GetRandomBytes(int numberOfBytes);

        void Reseed();
    }
}
