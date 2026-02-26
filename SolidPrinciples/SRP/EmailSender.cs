namespace SolidPrinciples.SRP;

public class EmailSender
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"Sending email to: {to} with message: {message}");
    }
}
