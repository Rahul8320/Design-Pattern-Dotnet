namespace OopsPrinciples.Inheritance;

public class Car(string brand, string model, int year, int noOfDoors) : Vehicle(brand, model, year)
{
    public int NoOfDoors { get; init; } = noOfDoors;
    public bool IsAcIncluded { get; set; } = true;

    public new void Details()
    {
        base.Details();
        Console.WriteLine($"No Of Doors: {NoOfDoors}");
        Console.WriteLine($"Ac Included: {IsAcIncluded}");
    }
}
