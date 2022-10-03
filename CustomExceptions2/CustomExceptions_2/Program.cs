using CustomExceptions_2.Entities;
using CustomExceptions_2.Entities.Exceptions;
using System.Globalization;


Console.WriteLine("Enter Account data");
Console.Write("Number: ");
int numberAccount = int.Parse(Console.ReadLine());

Console.Write("Holder: ");
string holderAccount = Console.ReadLine();

Console.Write("Initial balance: ");
double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Withdraw limit: ");
double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Account account = new Account(numberAccount, holderAccount, initialBalance, withDrawLimit);

Console.WriteLine();
Console.Write("Enter amount for withdraw: ");
double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

try
{
    account.WithDraw(amount);
    Console.WriteLine($"New balance: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
}
catch (DomainException ex)
{
    Console.WriteLine("Withdraw Error: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}


