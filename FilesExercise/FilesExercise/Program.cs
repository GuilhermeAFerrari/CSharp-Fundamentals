using FilesExercise.Entities;
using System.Globalization;
using System.IO;

Console.WriteLine("Enter file full path (.csv)");
string path = Console.ReadLine();

try
{
	string[] lines = File.ReadAllLines(path);

	string sourceFolderPath = Path.GetDirectoryName(path);
	string targetFolder = $"{sourceFolderPath}\\out";
	string targetFile = $"{targetFolder}\\summary.csv";

	Directory.CreateDirectory(targetFolder);

	using (StreamWriter streamWriter = File.AppendText(targetFile))
	{
		foreach (var item in lines)
		{
			string[] fields = item.Split(',');
			Itens newItem = new Itens(fields[0], double.Parse(fields[1], CultureInfo.InvariantCulture), int.Parse(fields[2]));

			streamWriter.WriteLine($"{newItem.Product}, R${newItem.TotalValue.ToString("F2", CultureInfo.InvariantCulture)}");
		}

	}

}
catch (IOException ex)
{
	Console.WriteLine($"An error occurred. {ex.Message}");
}
