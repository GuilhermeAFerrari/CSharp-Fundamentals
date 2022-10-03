using LinqWithLambdaExemple.Entities;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

Category firstCategory = new Category() { Id = 1, Name = "Tools", Tier = 2 };
Category secondCategory = new Category() { Id = 2, Name = "Computers", Tier = 1 };
Category thirdCategory = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

List<Product> products = new List<Product>()
{
    new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = secondCategory },
    new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = firstCategory },
    new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = thirdCategory },
    new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = secondCategory },
    new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = firstCategory },
    new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = secondCategory },
    new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = thirdCategory },
    new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = thirdCategory },
    new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = secondCategory },
    new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = thirdCategory },
    new Product() { Id = 11, Name = "Level", Price = 70.0, Category = firstCategory }
};

static void PrintResults<T>(string message, IEnumerable<T> collection)
{
    Console.WriteLine(message);
    foreach (T obj in collection)
    {
        Console.WriteLine(obj);
    }
    Console.WriteLine();
}

// Todas as consultas estão com um opção de sintaxe alternativa, ficando mais próxima do SQL


// -----------------------------------------------------------------------------------------
// Sintaxe com expressão lambda
//var result1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);

// Sintaxe similar a SQL
var result1 = from p in products where p.Category.Tier == 1 && p.Price < 900.0 select p;
PrintResults("Products with tier == 1 and price < 900", result1);
// -----------------------------------------------------------------------------------------


// -----------------------------------------------------------------------------------------
// Sintaxe com expressão lambda
//var result2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);

// Sintaxe similar a SQL
var result2 = from p in products where p.Category.Name == "Tools" select p.Name;
PrintResults("Names of products from tools", result2);
// -----------------------------------------------------------------------------------------


// -----------------------------------------------------------------------------------------
// Sintaxe com expressão lambda
/*var result3 = products
    .Where(p => p.Name[0] == 'C')
    .Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });*/

// Sintaxe similar a SQL
var result3 = from p in products where p.Name[0] == 'C' select new { p.Name, p.Price, CategoryName = p.Category.Name };
PrintResults("Products name started with letter C", result3);
// -----------------------------------------------------------------------------------------


// -----------------------------------------------------------------------------------------
// Sintaxe com expressão lambda
/*var result4 = products
    .Where(p => p.Category.Tier == 1)
    .OrderBy(p => p.Price)
    .ThenBy(p => p.Name);*/

// Sintaxe similar a SQL
var result4 = from p in products where p.Category.Tier == 1 orderby p.Name orderby p.Price select p;
PrintResults("Tier 1 order by price and name", result4);
// -----------------------------------------------------------------------------------------


// -----------------------------------------------------------------------------------------
// Sintaxe com expressão lambda
//var result5 = result4.Skip(2).Take(4);

// Sintaxe similar a SQL
var result5 = (from p in result4 select p).Skip(2).Take(4);
PrintResults("Tier 1 order by price and name skip 2 and take 4", result5);
// -----------------------------------------------------------------------------------------


// -----------------------------------------------------------------------------------------
// Sintaxe com expressão lambda
//var result6 = products.FirstOrDefault();

// Sintaxe similar a SQL
var result6 = (from p in products select p).FirstOrDefault();
Console.WriteLine("First or default test 1: " + result6);
// -----------------------------------------------------------------------------------------


// -----------------------------------------------------------------------------------------
// Sintaxe com expressão lambda
//var result7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();

// Sintaxe similar a SQL
var result7 = (from p in products where p.Price > 3000.0 select p).FirstOrDefault();
Console.WriteLine("First or default test 2: " + result7);
Console.WriteLine();
// -----------------------------------------------------------------------------------------


// -----------------------------------------------------------------------------------------
var result8 = products.Where(p => p.Id == 3).SingleOrDefault();
Console.WriteLine("Single or default test 1: " + result8);
// -----------------------------------------------------------------------------------------


// -----------------------------------------------------------------------------------------
var result9 = products.Where(p => p.Id == 30).SingleOrDefault();
Console.WriteLine("Single or default test 2: " + result9);
Console.WriteLine();
// -----------------------------------------------------------------------------------------


// -----------------------------------------------------------------------------------------
var result10 = products.Max(p => p.Price);
Console.WriteLine("Max price of my products: " + result10);
// -----------------------------------------------------------------------------------------


// -----------------------------------------------------------------------------------------
var result11 = products.Min(p => p.Price);
Console.WriteLine("Min price of my products: " + result11);
// -----------------------------------------------------------------------------------------


// -----------------------------------------------------------------------------------------
var result12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
Console.WriteLine("Category 1 sum price: " + result12);
// -----------------------------------------------------------------------------------------


// -----------------------------------------------------------------------------------------
var result13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
Console.WriteLine("Category 1 Average price: " + result13);
// -----------------------------------------------------------------------------------------


// -----------------------------------------------------------------------------------------
var r14 = products
    .Where(p => p.Category.Id == 5)
    .Select(p => p.Price)
    .DefaultIfEmpty(0.0)
    .Average();
Console.WriteLine("Category 5 Average prices: " + r14);
// -----------------------------------------------------------------------------------------


// -----------------------------------------------------------------------------------------
var r15 = products
    .Where(p => p.Category.Id == 1)
    .Select(p => p.Price)
    .Aggregate(0.0, (x, y) => x + y);
Console.WriteLine("Category 1 aggregate sum: " + r15);
Console.WriteLine();
// -----------------------------------------------------------------------------------------


// -----------------------------------------------------------------------------------------
// Sintaxe com expressão lambda
//var result16 = products.GroupBy(p => p.Category);

// Sintaxe similar a SQL
var result16 = from p in products group p by p.Category;
foreach (IGrouping<Category, Product> group in result16)
{
    Console.WriteLine("Category: " + group.Key.Name + ": ");

    foreach (Product product in group)
    {
        Console.WriteLine(product);
    }
    Console.WriteLine();
}
// -----------------------------------------------------------------------------------------