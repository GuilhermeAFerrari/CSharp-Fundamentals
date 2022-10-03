using System.Globalization;

namespace VehicleRent.Entities
{
    public class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public double TotalPayment => BasicPayment + Tax;

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;  
        }

        public override string ToString()
        {
            return $"Basic payment: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}" +
                   $"\nTax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}" +
                   $"\nTotal payment: {TotalPayment.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
