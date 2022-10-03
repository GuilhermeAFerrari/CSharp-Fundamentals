using PolymorphismExercise.Entities;
using System.Globalization;

List<Employee> employees = new List<Employee>();

Console.Write("Enter the number of employees: ");
int numberOfEmployee = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberOfEmployee; i++)
{
    Console.WriteLine($"Employee #{i} data:");
    Console.Write("Outsourced (y/n)? ");
    char outsorced = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if(outsorced == 'y' || outsorced == 'Y')
    {
        Console.Write("Additional charge: ");
        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
    }
    else
    {
        employees.Add(new Employee(name, hours, valuePerHour));
    }
}

Console.WriteLine();
Console.WriteLine("PAYMENTS:");
foreach(var employee in employees)
{ 
    Console.WriteLine(employee.Name + " - $" + employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
}