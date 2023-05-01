using Abstraction.Abstractions;

namespace Abstraction.Realisations;

public class DbWriter : IWriter
{
    public void Write()
    {
        Console.WriteLine("Write to db");
    }
}