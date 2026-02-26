namespace SolidPrinciples.SRP;

/// <summary>
/// This class has only one responsibility, handling user like register, login etc.
/// </summary>
public class UserService
{
    private readonly List<User> _users = [];

    public void Register(User user)
    {
        //Checking if the user exists in the database by email
        var existingUser = _users.FirstOrDefault(u => string.Equals(
            u.Email,
            user.Email,
            StringComparison.OrdinalIgnoreCase));

        if (existingUser != null)
        {
            Console.WriteLine("User already register!");
            return;
        }

        // Saving user into db
        _users.Add(user);

        var emailSender = new EmailSender();
        // Sending email
        emailSender.Send(to: user.Email, message: "Welcome to our platform!");
    }
}
