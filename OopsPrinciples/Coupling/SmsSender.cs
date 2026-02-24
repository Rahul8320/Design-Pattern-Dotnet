namespace OopsPrinciples.Coupling;

public class SmsSender : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"[{DateTime.UtcNow} Sending SMS: {message}]");
    }
}
