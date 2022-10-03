using AbstractExercise2.Entities;
using AbstractExercise2.Entities.Enums;
using System.Globalization;

List<Taxpayer> taxpayers = new List<Taxpayer>();
Console.Write("Enter the number of tax payers: ");
int numberOfTaxPayers = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberOfTaxPayers; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Tax payer #{i} data:");

    Console.Write("Individual or company (0-Individual or 1-Company)? ");
    TypeOfContribution typeOfContribution = (TypeOfContribution)Enum.Parse(typeof(TypeOfContribution), Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Anual income: ");
    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (typeOfContribution == TypeOfContribution.Individual)
    {
        Console.Write("Health expenditures: ");
        double healthExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        taxpayers.Add(new Individual(name, anualIncome, healthExpenses));
    }
    else
    {
        Console.Write("Number of employees: ");
        int numberOfEmployees = int.Parse(Console.ReadLine());

        taxpayers.Add(new Company(name, anualIncome, numberOfEmployees));
    }
}

Console.WriteLine();
Console.WriteLine("TAXES PAID:");
double totalTaxes = 0;
foreach (Taxpayer taxpayer in taxpayers)
{
    Console.WriteLine($"{taxpayer.Name}: ${taxpayer.TaxesPaid().ToString("F2", CultureInfo.InvariantCulture)}");
    totalTaxes += taxpayer.TaxesPaid();
}

Console.WriteLine();
Console.Write($"Total taxes: ${totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");