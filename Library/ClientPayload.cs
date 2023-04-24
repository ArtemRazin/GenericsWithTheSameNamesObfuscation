using ArmDot.Client;

namespace Library;

public class ClientPayload<TClientPacket>
{
    public uint GetFixedLength1Int() => GetFixedLengthInt<uint>(EncodedInteger.GetFixed1Value, 1);

    //FAILS
    [ObfuscateNames]
    private TInt GetFixedLengthInt<TInt>(Func<byte[], int, TInt> getFixedLengthInt, int offsetIncrease) =>
        getFixedLengthInt(new byte[10], 10);

    //WORKS
    //[ObfuscateNames]
    //private uint GetFixedLengthInt<TInt>(Func<byte[], int, uint> getFixedLengthInt, int offsetIncrease) =>
    //    getFixedLengthInt(new byte[10], 10);

}
