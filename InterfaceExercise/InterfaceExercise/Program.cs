using InterfaceExercise.Entities;
using InterfaceExercise.Services;
using System.Globalization;

Console.WriteLine("Enter contract data:");

Console.Write("Number: ");
int numberContract = int.Parse(Console.ReadLine());

Console.Write("Date (dd/MM/yyyy): ");
DateOnly dateContract = DateOnly.Parse(Console.ReadLine());

Console.Write("Contract value: ");
double valueContract = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Enter number of installments: ");
int numberOfInstallments = int.Parse(Console.ReadLine());

Contract contract = new Contract(numberContract, dateContract, valueContract);

ContractService contractService = new ContractService(new PaypalService());

contractService.ProcessContract(contract, numberOfInstallments);

Console.WriteLine("INSTALLMENTS:");

foreach (var item in contract.Installments)
{
    Console.WriteLine(item);
}

