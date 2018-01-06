# XRng
C# library to generate an arbitrary array of cryptographically strong pseudo-random bytes.

## Useage

```
IPrng prng = new PrngSHA256();
byte oneByte = prng.GetRandomByte();
byte[] manyBytes = prng.GetRandomBytes(1024);
```
