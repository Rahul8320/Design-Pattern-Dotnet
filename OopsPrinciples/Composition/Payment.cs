namespace OopsPrinciples.Composition;

public class Payment
{
    private readonly Guid PaymentId = Guid.NewGuid();

    public void MakePayment()
    {
        Console.WriteLine($"Payment {PaymentId} successfully");
    }
}
