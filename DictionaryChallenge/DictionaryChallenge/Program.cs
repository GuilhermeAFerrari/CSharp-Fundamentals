Console.Write("Enter full path file: ");

string path = Console.ReadLine();

try
{
	using (StreamReader streamReader = File.OpenText(path))
	{
		Dictionary<string, int> data = new Dictionary<string, int>();

		while (!streamReader.EndOfStream)
		{
			string[] lineOfFile = streamReader.ReadLine().Split(',');
			string nameOfCandidate = lineOfFile[0];
			int votes = int.Parse(lineOfFile[1]);

			if (data.ContainsKey(nameOfCandidate))
			{
				data[nameOfCandidate] += votes;
			}
			else
			{
				data[nameOfCandidate] = votes;
			}
		}

		foreach (var item in data)
		{
			Console.WriteLine(item.Key + ": " + item.Value);
		}
	}
}
catch (IOException ex)
{
	throw new IOException("An error occurred. " + ex.Message);
}