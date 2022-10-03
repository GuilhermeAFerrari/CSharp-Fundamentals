string sourcePath = @"C:\temp\file1.txt";
string targetPath = @"C:\temp\file2.txt";

try
{
	FileInfo fileInfo = new FileInfo(sourcePath);

	fileInfo.CopyTo(targetPath);

	string[] lines = File.ReadAllLines(sourcePath);

	foreach (var item in lines)
	{
		Console.WriteLine(item);
	}
}
catch (IOException ex)
{
	Console.WriteLine("An error occurred " + ex.Message);
}