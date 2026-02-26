using SolidPrinciples.OCP;
using SolidPrinciples.SRP;

// Single Responsibility Principle (SRP)
var user = new User(username: "admin", email: "admin@srp.com");
var userService = new UserService();
userService.Register(user);

// Open/Closed Principle (OCP)
var shape = new Shape()
{
    Type = ShapeType.Circle,
    Radius = 5,
};

Console.WriteLine($"Area: {shape.CalculateArea()}");
