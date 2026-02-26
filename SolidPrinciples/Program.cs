using SolidPrinciples.SRP;

// Single Responsibility Principle (SRP)
var user = new User(username: "admin", email: "admin@srp.com");
var userService = new UserService();
userService.Register(user);

userService.Register(user);