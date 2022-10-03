// See https://aka.ms/new-console-template for more information
using System.Globalization;
using WorkerIncome.Entities;
using WorkerIncome.Entities.Enums;

Console.Write("Enter departament's name: ");
string departamentName = Console.ReadLine();

Departament departament = new Departament(departamentName);

Console.WriteLine("Enter worker data: ");
Console.Write("Name: ");
string workerName = Console.ReadLine();

Console.Write("Level (Junior/MidLevel/Senior): ");
WorkerLevel workerLevel = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine());

Console.Write("Base salary: ");
double workerBaseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("How many contracts to this worker? ");
int numberOfContracts = int.Parse(Console.ReadLine());

Worker worker = new Worker(workerName, workerLevel, workerBaseSalary, departament);

for (int i = 1; i <= numberOfContracts; i++)
{
    Console.Write($"Enter #{i} contract data:");
    Console.Write("Date (DD/MM/YYYY): ");
    DateTime contractDate = DateTime.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double contractValueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Duration (hours): ");
    int contractHours = int.Parse(Console.ReadLine());

    HourContract contract = new HourContract(contractDate, contractValueHour, contractHours);
    worker.AddContract(contract);
}
Console.WriteLine();
Console.Write("Enter month and year to calculate income (MM/YYYY): ");
string monthAndYear = Console.ReadLine();
int onlyMonth = int.Parse(monthAndYear.Substring(0, 2));
int onlyYear = int.Parse(monthAndYear.Substring(3, 4));

Console.WriteLine($"Name: {worker.Name}");
Console.WriteLine($"Departament: {worker.Departament.Name}");
Console.WriteLine($"Income for {monthAndYear}: {worker.Income(onlyYear, onlyMonth).ToString("F2", CultureInfo.InvariantCulture)}");