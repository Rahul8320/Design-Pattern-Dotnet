namespace OopsPrinciples.Inheritance;

/// <summary>
/// Base Vehicle class 
/// </summary>
/// <param name="brand">Brand name</param>
/// <param name="model">Model name</param>
/// <param name="year">Manufacturing year</param>
public abstract class Vehicle(string brand, string model, int year)
{
    public string Brand { get; init; } = brand;
    public string Model { get; init; } = model;
    public int Year { get; init; } = year;

    public void Start()
    {
        Console.WriteLine($"Vehicle-{Brand} is starting...");
    }

    public void Stop()
    {
        Console.WriteLine($"Vehicle-{Brand} is stopping...");
    }

    public void Details()
    {
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
    }

}
