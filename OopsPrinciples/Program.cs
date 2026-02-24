using OopsPrinciples.Abstraction;
using OopsPrinciples.Composition;
using OopsPrinciples.Coupling;
using OopsPrinciples.Encapsulation;
using OopsPrinciples.Inheritance;
using OopsPrinciples.Polymorphism;

var bankAccount = new BadBankAccount
{
    Balance = 100
};

Console.WriteLine(bankAccount.Balance);

// But clint app can modify this balance, no encapsulation
bankAccount.Balance = -500;
Console.WriteLine(bankAccount.Balance);

// var account = new BankAccount(-500); // Throw an exception
var account = new BankAccount(100);
var balance = account.GetBalance();
Console.WriteLine($"Your Current Balance: $ {balance}");


// account.Balance = -500; // Client can't directly access the data member as it is encapsulated properly.
// account.Withdraw(200); // Throw an exception as account has only 100 balance! Correctly implement the business rule.  
account.Deposit(500);
account.Withdraw(200);
balance = account.GetBalance();
Console.WriteLine($"Your Current Balance: $ {balance}");

// Abstraction (Reduce complexity by hiding unnecessary details)
var emailService = new EmailService();
emailService.SendEmail();

// Inheritance 
var car = new Car(brand: "RR", model: "Ghost", year: 2025, noOfDoors: 4);
car.Start();
car.Details();
car.Stop();

var bike = new Bike(brand: "RE", model: "Himalayan 450", year: 2026);
bike.Start();
bike.Details();
bike.Stop();


// Polymorphism
var vehicles = new List<Vehicle2>()
{
    new Car2(brand: "RR", model: "Ghost", year: 2025, noOfDoors: 4),
    new Bike2(brand: "RE", model: "Himalayan 450", year: 2026),
    new Bike2(brand: "HD", model: "Fat Boy", year: 2024)
    {
        IsHelmetIncluded = true,
    }
};

foreach (var vehicle in vehicles)
{
    vehicle.Feature();
}

// Coupling
var orderService = new OrderService(new SmsSender());
orderService.PlaceOrder();

// Composition
var order = new Order();
order.CreateOrder();