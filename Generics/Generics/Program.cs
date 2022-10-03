using Generics;

PrintService<int> printService = new PrintService<int>();

Console.Write("How many values? ");
int numberOfValues = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfValues; i++)
{
    int x = int.Parse(Console.ReadLine());
    printService.Addvalue(x);
}

printService.Print();
Console.WriteLine("First: " + printService.First());