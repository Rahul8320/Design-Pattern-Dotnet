namespace OopsPrinciples.Composition;

public class Inventory
{
    private readonly Guid InventoryId = Guid.NewGuid();

    public void CheckStocks()
    {
        Console.WriteLine($"Items are in stocks {InventoryId}");
    }
}
