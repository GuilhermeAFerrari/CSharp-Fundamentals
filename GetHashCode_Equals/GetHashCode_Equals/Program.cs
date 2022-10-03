using GetHashCode_Equals;

Client client1 = new Client { Name = "Bill", Email = "bill@equals.com.br" };
Client client2 = new Client { Name = "Mary", Email = "mary@equals.com.br" };

Console.WriteLine("Is equal:");
Console.WriteLine(client1.Equals(client2));

Console.WriteLine("HashCode");
Console.WriteLine(client1.GetHashCode());

Console.WriteLine("HashCode");
Console.WriteLine(client2.GetHashCode());
