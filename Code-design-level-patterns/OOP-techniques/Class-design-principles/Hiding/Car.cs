namespace Hiding;

public class Car
{
    private readonly string _make;
    private readonly string _model;
    private readonly int _year;

    public Car(string make, string model, int year)
    {
        _make = make;
        _model = model;
        _year = year;
    }

    public void Drive()
    {
        Console.WriteLine("Driving the car...");
        UpdateMileage();
    }

    private void UpdateMileage()
    {
        Console.WriteLine("Updating the mileage...");
    }
}
