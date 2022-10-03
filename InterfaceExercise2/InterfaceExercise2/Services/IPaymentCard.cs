namespace InterfaceExercise2.Services
{
    public interface IPaymentCard
    {
        public double PercentageOfTax { get; }
        public double TaxPayment(double valuePayment);
    }
}
