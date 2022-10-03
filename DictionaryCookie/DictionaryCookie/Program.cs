Dictionary<string, string> cookies = new Dictionary<string, string>();
cookies["user"] = "Bill";
cookies["email"] = "bill@gmail.com";
cookies["phone"] = "991144552233";
cookies["phone"] = "181144552233";

Console.WriteLine(cookies["email"]);
Console.WriteLine(cookies["phone"]);

cookies.Remove("email");

if (cookies.ContainsKey("email"))
{
    Console.WriteLine(cookies["email"]);
}
else
{
    Console.WriteLine("There is no 'email' key");
}

Console.WriteLine("Size: " + cookies.Count);

Console.WriteLine("All cookies:");
foreach (KeyValuePair<string, string> item in cookies)
{
    Console.WriteLine(item.Key + ": " + item.Value);
}
