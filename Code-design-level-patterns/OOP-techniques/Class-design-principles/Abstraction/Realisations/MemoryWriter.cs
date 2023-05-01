using Abstraction.Abstractions;

namespace Abstraction.Realisations;

public class MemoryWriter : IWriter
{
    public void Write()
    {
        Console.WriteLine("Write to memory");
    }
}