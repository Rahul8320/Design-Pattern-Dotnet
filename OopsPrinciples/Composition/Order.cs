namespace OopsPrinciples.Composition;

public class Order
{
    private readonly Guid OrderId = Guid.NewGuid();
    private readonly Cart cart = new();
    private readonly Inventory inventory = new();
    private readonly Payment payment = new();

    public void CreateOrder()
    {
        cart.AddItem();
        inventory.CheckStocks();
        payment.MakePayment();
        cart.ClearCart();
        Console.WriteLine($"Order {OrderId} placed successfully");
    }
}
