namespace SolidPrinciples.SRP;

/*
    This class has more than one responsibility, like saving user data and registering the user, 
    more than one reason to change.
    1. If we want to save more data like password, phone number etc.
    2. If we are changing our register logic.
*/
public class User(string username, string email)
{
    public string Username { get; set; } = username;
    public string Email { get; set; } = email;

    public void Register()
    {
        // Register user logic
        /*
            1. Checking if the user exists in the database by email
            2. If exits, then redirect to login
            3. If not add them in database
        */

        var emailSender = new EmailSender();
        emailSender.Send(to: Email, message: "Welcome to out platform!");
    }
}
