namespace InterfaceExercise2.Services
{
    public class MasterCard : IPaymentCard
    {
        public double PercentageOfTax => 0.12;

        public double TaxPayment(double valuePayment)
        {
            return valuePayment += valuePayment * PercentageOfTax;
        }
    }
}
