using LinqExercise1.Entities;
using System.Globalization;

Console.WriteLine("Enter with file path:");
string filePath = Console.ReadLine();

try
{
	List<Product> products = new List<Product>();

	using (StreamReader streamReader = File.OpenText(filePath))
	{
		while (!streamReader.EndOfStream)
		{
			string[] fields = streamReader.ReadLine().Split(',');
            products.Add(new Product { Name = fields[0], Price = double.Parse(fields[1], CultureInfo.InvariantCulture) });
        }
	}

	var averagePrice = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
	Console.WriteLine("Average price:" + averagePrice.ToString("F2", CultureInfo.InvariantCulture));

	var priceLessthanAveragePrice = products.Where(p => p.Price < averagePrice).OrderByDescending(p => p.Name).Select(p => p.Name);
	Console.WriteLine("Name of products that price is less then average price");

	foreach (var item in priceLessthanAveragePrice)
	{
		Console.WriteLine(item);
	}

}
catch (IOException ex)
{
	throw new IOException("An error occurred " + ex.Message);
}
catch (Exception ex)
{
	throw new Exception("Error: " + ex.Message);
}