using System.Drawing;
using System.Globalization;

namespace InheritancePolymorphimsExercice.Entities
{
    internal class UsedProduct : Product
    {
        public DateOnly ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateOnly manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (Used) - ${Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufactureDate})";
        }
    }
}
