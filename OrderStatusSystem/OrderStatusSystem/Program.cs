using OrderStatusSystem.Entities;
using OrderStatusSystem.Entities.Enums;
using System.Globalization;

Console.WriteLine("Enter client data:");
Console.Write("Name: ");
string clientName = Console.ReadLine();

Console.Write("Email: ");
string clientEmail = Console.ReadLine();

Console.Write("Birth date (DD/MM/YYYY): ");
DateTime clientBirthDate = DateTime.Parse(Console.ReadLine());

Client client = new Client(clientName, clientEmail, clientBirthDate);

Console.WriteLine("Enter order data:");
Console.Write("Status (Pending_Payment/Processing/Shipped/Delivered): ");
OrderStatus orderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());

Order order = new Order(DateTime.Now, orderStatus, client);

Console.Write("How many items to this order? ");
int numberOfItems = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberOfItems; i++)
{
    Console.WriteLine($"Enter #{i} item data:");
    Console.Write("Product name: ");
    string productName = Console.ReadLine();
    Console.Write("Product price: ");
    double productPrice = double.Parse(Console.ReadLine());
    Console.Write("Quantity: ");
    int productQuantity = int.Parse(Console.ReadLine());

    Product product = new Product(productName, productPrice);
    OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);

    order.AddItem(orderItem);
}

Console.WriteLine("ORDER SUMARY:");
Console.WriteLine($"Order moment: {order.Moment}");
Console.WriteLine($"Order moment: {order.Status}");
Console.WriteLine($"Client: {order.Client.Name} ({order.Client.BirthDate}) - {order.Client.Email}");
Console.WriteLine("ORDER ITEMS:");

Console.WriteLine(order);

Console.Write("Total price: " + order.Total().ToString("F2", CultureInfo.InvariantCulture));




