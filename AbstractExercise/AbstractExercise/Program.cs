using AbstractExercise.Entities;
using AbstractExercise.Entities.Enums;
using System.Globalization;

List<Shape> shapes = new List<Shape>();
Console.Write("Enter the number of shapes:");
int numberOfShapes = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberOfShapes; i++)
{
    Console.WriteLine($"Shape #{i} data:");
    Console.Write("Rectangle or Circle (r / c)? ");
    char rectagleOrCircle = char.Parse(Console.ReadLine());

    if (rectagleOrCircle == 'r' || rectagleOrCircle == 'R')
    {
        Console.Write("Color (Black/Blue/Red): ");
        Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        shapes.Add(new Rectangle(color, width, height));
    }
    if (rectagleOrCircle == 'c' || rectagleOrCircle == 'C')
    {
        Console.Write("Color (Black/Blue/Red): ");
        Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        shapes.Add(new Circle(color, radius));
    }
}

Console.WriteLine();
Console.WriteLine("SHAPE AREAS:");

foreach (var item in shapes)
{
    Console.WriteLine(item.Area().ToString("F2", CultureInfo.InvariantCulture));
}