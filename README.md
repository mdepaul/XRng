# XRng
C# library to generate an arbitrary array of cryptographically strong pseudo-random bytes.
Used as the base functionality behind RandomizedList https://github.com/mdepaul/RandomizedList.git.

## Useage

```
IPrng prng = new PrngSHA256();
byte oneByte = prng.GetRandomByte();
byte[] manyBytes = prng.GetRandomBytes(1024);
```
