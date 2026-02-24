namespace OopsPrinciples.Polymorphism;

public class Car2(string brand, string model, int year, int noOfDoors) : Vehicle2(brand, model, year)
{
    public int NoOfDoors { get; init; } = noOfDoors;
    public bool IsAcIncluded { get; set; } = true;

    public override void Details()
    {
        base.Details();
        Console.WriteLine($"No Of Doors: {NoOfDoors}");
        Console.WriteLine($"Ac Included: {IsAcIncluded}");
    }
}
