using Comparison.Entities;

List<Product> listProducts = new List<Product>();

listProducts.Add(new Product { Name = "Notebook", Value = 3400.00 });
listProducts.Add(new Product { Name = "Monitor", Value = 1240.00 });
listProducts.Add(new Product { Name = "Celphone", Value = 1900.00 });

//Comparison<Product> comp = CompareProducts;

listProducts.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

foreach (var item in listProducts)
{
    Console.WriteLine(item);
}

//static int CompareProducts(Product p1, Product p2)
//{
//    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
//}