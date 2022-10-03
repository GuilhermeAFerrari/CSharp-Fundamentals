using InterfaceExercise2.Entities;
using InterfaceExercise2.Services;
using System.Globalization;

Console.WriteLine("Enter with cart data:");
Console.Write("Owner of cart: ");
string nameOwner = Console.ReadLine();

Cart cart = new Cart(nameOwner);

Console.Write("Number of products: ");
int numberProducts = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberProducts; i++)
{
    Console.Write($"Name of product #{i}: ");
    string nameProduct = Console.ReadLine();
    Console.Write($"Value of product #{i}:");
    double valueProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    cart.Products.Add(new Product(nameProduct, valueProduct));
}
Console.WriteLine("MasterCard:");
CartService cartServiceMaster = new CartService(new MasterCard());
cartServiceMaster.ProcessCart(cart);

Console.WriteLine("VisaCard:");
CartService cartServiceVisa = new CartService(new VisaCard());
cartServiceVisa.ProcessCart(cart);
VisaCard visaCard = new VisaCard();
visaCard.MethodTest();
