namespace OopsPrinciples.Abstraction;

public class EmailService
{
    private const string EmailClient = "SMTP Client";

    public void SendEmail()
    {
        Connect();
        Authenticate();
        Console.WriteLine($"Sending email via {EmailClient} ...");
        Disconnect();
    }

    private static void Connect()
    {
        Console.WriteLine($"Connecting to email server via {EmailClient}...");
    }

    private static void Authenticate()
    {
        Console.WriteLine("Authenticating ....");
    }

    private static void Disconnect()
    {
        Console.WriteLine("Disconnecting from email server... ");
    }
}
