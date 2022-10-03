List<int> myList = new List<int>();

myList.Add(500);
myList.Add(580);
myList.Add(120);
myList.Add(70);
myList.Add(88);

// Usando Lambda
//myList.RemoveAll(x => x >= 100);

// Criando o predicate
myList.RemoveAll(TestValues);

foreach (var item in myList)
{
    Console.WriteLine(item);
}

static bool TestValues(int x)
{
    return x >= 100;
}