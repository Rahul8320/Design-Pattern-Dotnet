namespace OopsPrinciples.Composition;

public class Cart
{
    private readonly Guid CartId = Guid.NewGuid();

    public void AddItem()
    {
        Console.WriteLine($"Item added to the cart {CartId}");
    }

    public void ClearCart()
    {
        Console.WriteLine($"Cart {CartId} is cleared");
    }
}
