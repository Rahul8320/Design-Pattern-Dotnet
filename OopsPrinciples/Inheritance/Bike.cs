namespace OopsPrinciples.Inheritance;

public class Bike(string brand, string model, int year) : Vehicle(brand, model, year)
{
    public bool IsHelmetIncluded { get; set; } = false;

    public new void Details()
    {
        base.Details();
        Console.WriteLine($"Helmet Included: {IsHelmetIncluded}");
    }
}
