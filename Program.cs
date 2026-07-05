 Console.WriteLine("Welcome to the ATM Banking System!");


Console.WriteLine("Please enter your account number:");
string number = Console.ReadLine();

Console.WriteLine("Please enter your PIN:");
string pin = Console.ReadLine();

Console.WriteLine("Please select an option:");

string[] options = { "1. Check Balance", "2. Deposit", "3. Withdraw", "4. Exit" };
switch (Console.ReadLine())
{
    case "1":
        Console.WriteLine("Your balance is: $1000");
        break;
    case "2":
        Console.WriteLine("Please enter the amount to deposit:");
        Console.WriteLine("Deposit successful!");
        break;
    case "3":
        Console.WriteLine("Please enter the amount to withdraw:");
        Console.WriteLine("Withdrawal successful!");
        break;
    case "4":
        Console.WriteLine("Thank you for using the ATM Banking System!");
        break;
    default:
        Console.WriteLine("Invalid option. Please try again.");
        break;
}


