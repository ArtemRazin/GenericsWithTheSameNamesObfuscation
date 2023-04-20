using ArmDot.Client;

namespace GenericsWithTheSameNamesObfuscation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("{0}", GetFixedLengthInt<uint>((_1, _2) => 0, 1));
    }

    [ObfuscateNames]
    private static TInt GetFixedLengthInt<TInt>(Func<byte[], int, TInt> getFixedLengthInt, int offsetIncrease) =>
        GetFixedLengthInt((data, startIndex, bigEndian) => getFixedLengthInt(data, offsetIncrease), offsetIncrease, false);

    [ObfuscateNames]
    private static TInt GetFixedLengthInt<TInt>(Func<byte[], int, bool, TInt> getFixedLengthInt, int offsetIncrease, bool bigEndian) =>
        getFixedLengthInt(new byte[] { 0 }, 1, bigEndian);
}
