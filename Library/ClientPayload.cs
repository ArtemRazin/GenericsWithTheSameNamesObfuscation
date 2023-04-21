using ArmDot.Client;

namespace Library;

public class ClientPayload<TClientPacket>
{
    [ObfuscateNames]
    [VirtualizeCode]
    [ObfuscateControlFlow]
    public uint GetFixedLength1Int() => GetFixedLengthInt(EncodedInteger.GetFixed1Value, 1);

    [ObfuscateNames]
    [VirtualizeCode]
    [ObfuscateControlFlow]
    private TInt GetFixedLengthInt<TInt>(Func<byte[], int, TInt> getFixedLengthInt, int offsetIncrease) =>
        GetFixedLengthInt((data, startIndex, bigEndian) => getFixedLengthInt(data, offsetIncrease), offsetIncrease, false);

    [ObfuscateNames]
    [VirtualizeCode]
    [ObfuscateControlFlow]
    private TInt GetFixedLengthInt<TInt>(Func<byte[], int, bool, TInt> getFixedLengthInt, int offsetIncrease, bool bigEndian)
        => getFixedLengthInt(new byte[10], 10, true); 
}
