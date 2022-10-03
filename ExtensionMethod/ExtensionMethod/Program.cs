using ExtensionMethod.Extensions;

DateTime date = new DateTime(2022, 09, 10, 8, 10, 45);
Console.WriteLine(date.ElapsedTime());

string phrase = "Goog morning dear students!";
Console.WriteLine(phrase.Cut(10) + "...");