using InheritancePolymorphimsExercice.Entities;
using InheritancePolymorphimsExercice.Entities.Enums;
using System.Globalization;

List<Product> products = new List<Product>();

Console.Write("Enter the number of products: ");
int numberOfProducts = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberOfProducts; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Product #{i} data:");
    Console.Write("Common, used or imported (0-common / 1-Used / 2-Imported) ? ");
    TypeProduct typeProduct = (TypeProduct)Enum.Parse(typeof(TypeProduct), Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if(typeProduct == TypeProduct.Imported)
    {
        Console.Write("Customs fee: ");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        products.Add(new ImportedProduct(name, price, customsFee));
    }
    else if(typeProduct == TypeProduct.Used)
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateOnly manufactureDate = DateOnly.Parse(Console.ReadLine());
        products.Add(new UsedProduct(name, price, manufactureDate));
    }
    else
    {
        products.Add(new Product(name, price));
    }
}

Console.WriteLine();
Console.WriteLine("PRICE TAGS:");
foreach (var item in products)
{
    Console.WriteLine(item.PriceTag());
}