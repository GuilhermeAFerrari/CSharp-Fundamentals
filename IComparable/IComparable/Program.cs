using IComparable;


List<Games> games = new ()
{
    new Games { Name = "God of War", NumberOfPlayers = 1 },
    new Games { Name = "Unravel 2", NumberOfPlayers = 2 },
    new Games { Name = "Unravel 1", NumberOfPlayers = 1 },
    new Games { Name = "Far Cry 5", NumberOfPlayers = 1 },
    new Games { Name = "GTA 5", NumberOfPlayers = 1 },
    new Games { Name = "Fifa 2022", NumberOfPlayers = 2 }
};

games.Sort();

foreach (var item in games)
{
    Console.WriteLine(item);
}

