using System.Globalization;

namespace InterfaceExercise2.Entities
{
    public class Report
    {
        public string NameProduct { get; set; }
        public double ValueWithoutTax { get; set; }
        public double ValueWithTax { get; set; }

        public Report(string nameProduct, double valueWithoutTax, double valueWithTax)
        {
            NameProduct = nameProduct;
            ValueWithoutTax = valueWithoutTax;
            ValueWithTax = valueWithTax;
        }

        public override string ToString()
        {
            return $"Product: {NameProduct} - Value without tax: {ValueWithoutTax.ToString("F2", CultureInfo.InvariantCulture)} - Value with tax: {ValueWithTax.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
