using Library;

namespace Program;

class MainProgram
{
    static void Main(string[] args)
    {
        var clientPayload = new ClientPayload<SpecializeClientPayload>();
        Console.WriteLine("{0}", clientPayload.GetFixedLength1Int());
    }

}

