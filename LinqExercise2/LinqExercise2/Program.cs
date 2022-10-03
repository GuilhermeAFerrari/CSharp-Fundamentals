using LinqExercise2.Entities;
using System.Globalization;

Console.Write("Enter full file path: ");
string filePath = Console.ReadLine();

Console.Write("Enter salary: ");
double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

try
{
	List<Employee> employees = new List<Employee>();

	using (StreamReader streamReader = File.OpenText(filePath))
	{
		while (!streamReader.EndOfStream)
		{
			string[] field = streamReader.ReadLine().Split(',');
			employees.Add(new Employee(name: field[0], email: field[1], salary: double.Parse(field[2], CultureInfo.InvariantCulture)));
		}
	}

	var emailSalaryMoreThanRequested = employees.Where(e => e.Salary > salary).OrderBy(e => e.Email).Select(e => e.Email);
	Console.WriteLine($"Email of people whose salary is more than {salary.ToString("F2", CultureInfo.InvariantCulture)}");
	foreach (var item in emailSalaryMoreThanRequested)
	{
		Console.WriteLine(item);
	}

	var sumOfSalaryNames = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
	Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sumOfSalaryNames.ToString("F2", CultureInfo.InvariantCulture));

}
catch (IOException ex)
{
	throw new IOException("An error occurred: " + ex);
}
catch (Exception ex)
{
    throw new Exception("Error: " + ex);
}