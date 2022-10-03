using System.Globalization;

namespace LinqWithLambdaExemple.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, " +
                   $"Price {Price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                   $"Category: {Category.Name}";
        }
    }
}
