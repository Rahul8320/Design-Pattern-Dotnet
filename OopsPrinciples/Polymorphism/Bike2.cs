namespace OopsPrinciples.Polymorphism;

public class Bike2(string brand, string model, int year) : Vehicle2(brand, model, year)
{
    public bool IsHelmetIncluded { get; set; } = false;

    public override void Details()
    {
        base.Details();
        Console.WriteLine($"Helmet Included: {IsHelmetIncluded}");
    }
}
