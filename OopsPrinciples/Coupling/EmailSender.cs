namespace OopsPrinciples.Coupling;

public class EmailSender : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"[{DateTime.UtcNow}] Sending email notification: {message}");
    }
}
