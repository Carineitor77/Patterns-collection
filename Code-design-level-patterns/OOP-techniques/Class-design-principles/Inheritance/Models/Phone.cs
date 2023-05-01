namespace Inheritance.Models;

public class Phone
{
    public string Name { get; set; }

    public void Call()
    {
        Console.WriteLine("Calling");
    }
}