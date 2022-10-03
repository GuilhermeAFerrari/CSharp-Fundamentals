using DelegateFunc.Entities;

List<Product> list = new List<Product>();

list.Add(new Product("TV", 8000.99));
list.Add(new Product("Mouse", 80.50));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));

//List<string> result = list.Select(NameUpper).ToList();

//Func<Product, string> func = NameUpper;
//List<string> result = list.Select(func).ToList();

//Func<Product, string> func = p => p.Name.ToUpper();
//List<string> result = list.Select(func).ToList();

List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

foreach (var item in result)
{
    Console.WriteLine(item);
}

//static string NameUpper(Product product)
//{
//    return product.Name.ToUpper();
//}