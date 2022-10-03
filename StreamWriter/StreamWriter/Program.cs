string sourcePath = @"C:\temp\file1.txt";
string targetPath = @"C:\temp\file2.txt";

try
{
	string[] lines = File.ReadAllLines(sourcePath);

	using (StreamWriter streamWriter = File.AppendText(targetPath))
	{
		foreach (var item in lines)
		{
			streamWriter.WriteLine(item.ToUpper());
		}
	}
}
catch (IOException ex)
{
	Console.WriteLine("An error accurred. " + ex);
}