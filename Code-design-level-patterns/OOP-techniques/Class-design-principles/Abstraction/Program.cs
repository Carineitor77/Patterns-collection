using Abstraction.Abstractions;
using Abstraction.Realisations;

var writers = new List<IWriter>(
    new IWriter[]
    {
        new DbWriter(), 
        new FileWriter(), 
        new MemoryWriter()
    }
);

foreach (var writer in writers)
{
    writer.Write();
}