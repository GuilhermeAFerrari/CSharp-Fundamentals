using ExercicioConjuntos.Entities;

HashSet<LogRecord> logRecords = new HashSet<LogRecord>();

Console.Write("Enter file full path");
string path = Console.ReadLine();

try
{
	using (StreamReader streamReader = File.OpenText(path))
	{
		while (!streamReader.EndOfStream)
		{
			string[] line = streamReader.ReadLine().Split(' ');
			string name = line[0];
			DateTime instant = DateTime.Parse(line[1]);
			logRecords.Add(new LogRecord { Username = name, Instant = instant });
			Console.WriteLine(line);
		}
	}

	Console.WriteLine("Total users: " + logRecords.Count);
}
catch (IOException ex)
{
	throw new IOException("An error occurred. " + ex.Message);
}