using System.Globalization;

namespace Comparison.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Value { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Value.ToString("F2", CultureInfo.InvariantCulture)}";
        }
        
    }
}
