using System.Numerics;

Console.WriteLine("Welcome to the ATM Project!");


int balance = 0;

int depositAmount;
int withdrawAmount;


bool isInteger;
bool running = true;

while (running)
{

    Console.WriteLine("MENU");

    string[] userOption =
    {
    "C. Check Balance",
    "D. Deposit Money",
    "W. Withdraw Money",
    "E. Exit"
};

    foreach (string option in userOption)
    {
        Console.WriteLine(option);
    }

    Console.WriteLine("Please, enter an action from the Menu");

    string userInput = Console.ReadLine();
    switch (userInput)
    {
        case "C":
            Console.WriteLine($"Your balance is: {balance} ");
            break;
        case "D":
            Console.WriteLine("Enter how much you want to deposit!");
            isInteger = int.TryParse(Console.ReadLine(), out depositAmount);
            Console.WriteLine($"You have deposited: {depositAmount}");
            balance += depositAmount;
            break;
        case "W":
            Console.WriteLine("Enter how much you want to withdraw!");
            isInteger = int.TryParse(Console.ReadLine(), out withdrawAmount);
            Console.WriteLine($"You have withdrawed: {withdrawAmount}");
            balance -= withdrawAmount;
            break;
        case "E":
            Console.WriteLine($"Exiting...");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid option, please try again.");
            break;

    }
}
