namespace OopsPrinciples.Coupling;

public class OrderService(INotificationService notificationService)
{
    public void PlaceOrder()
    {
        notificationService.SendNotification("Order placed successfully 🎉");
    }
}
