namespace SolidPrinciples.SRP;

/*
    This class has only one responsibility, storing user data. 
*/
public class User(string username, string email)
{
    public string Username { get; set; } = username;
    public string Email { get; set; } = email;
}
