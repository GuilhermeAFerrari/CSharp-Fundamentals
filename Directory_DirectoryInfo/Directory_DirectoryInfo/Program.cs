string path = @"C:\temp\myfolder";

try
{
	var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
	Console.WriteLine("Folders:");
	foreach(var item in folders)
	{
		Console.WriteLine(item);
	}

    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("Files:");
    foreach (var item in files)
    {
        Console.WriteLine(item);
    }

	Directory.CreateDirectory(path + "\\NewFolder");
}
catch (IOException ex)
{
	Console.WriteLine("An error accurred. " + ex);
}