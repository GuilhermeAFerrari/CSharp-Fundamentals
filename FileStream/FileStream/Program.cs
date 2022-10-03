string sourcePath = @"C:\temp\file1.txt";

FileStream fileStream = null;
StreamReader streamReader = null;

try
{
	fileStream = new FileStream(sourcePath, FileMode.Open);
	streamReader = new StreamReader(fileStream);
	while (!streamReader.EndOfStream)
	{
		string line = streamReader.ReadLine();
		Console.WriteLine(line);
	}
}
catch (IOException ex)
{
	Console.WriteLine("An error accurred. " + ex);
}
finally
{
	if (streamReader != null) streamReader.Close();
	if (fileStream != null) fileStream.Close();
}