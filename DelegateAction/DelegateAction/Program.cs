using DelegateAction.Entities;

List<Product> list = new List<Product>();

list.Add(new Product("TV", 8000.99));
list.Add(new Product("Mouse", 80.50));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));

//Action<Product> actionProduct = UpdatePrice;

//Action<Product> actionProduct = p => { p.Price += p.Price * 0.1; };

//list.ForEach(actionProduct);

list.ForEach(p => { p.Price += p.Price * 0.1; });

foreach (var item in list)
{
    Console.WriteLine(item.Price);
}

static void UpdatePrice(Product product)
{
    product.Price += product.Price * 0.1;
}