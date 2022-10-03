string sourcePath = @"C:\temp\file18.txt";

try
{
	using (FileStream fileStream = new FileStream(sourcePath, FileMode.Open))
	{
		using (StreamReader streamReader = new StreamReader(fileStream))
		{
			while (!streamReader.EndOfStream)
			{
				string line = streamReader.ReadLine();
				Console.WriteLine(line);
			}
		}
	}
}
catch (IOException ex)
{
	Console.WriteLine("An error accurred. " + ex.Message);
}