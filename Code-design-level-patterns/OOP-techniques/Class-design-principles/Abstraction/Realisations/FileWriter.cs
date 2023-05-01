using Abstraction.Abstractions;

namespace Abstraction.Realisations;

public class FileWriter : IWriter
{
    public void Write()
    {
        Console.WriteLine("Write to file");
    }
}