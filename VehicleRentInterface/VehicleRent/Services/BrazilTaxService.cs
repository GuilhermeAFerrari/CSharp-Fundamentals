namespace VehicleRentInheritance.Services
{
    public class BrazilTaxService : ITaxService
    {
        public BrazilTaxService(double amount)
        {
        }
        public double Tax(double amount)
        {
            return amount <= 100.0 ? amount * 0.2 : amount * 0.15;
        }
    }
}
