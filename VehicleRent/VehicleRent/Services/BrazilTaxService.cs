namespace VehicleRent.Services
{
    public class BrazilTaxService
    {
        public double Tax(double amount)
        {
            return amount <= 100.0 ? amount * 0.2 : amount * 0.15;
        }
    }
}
