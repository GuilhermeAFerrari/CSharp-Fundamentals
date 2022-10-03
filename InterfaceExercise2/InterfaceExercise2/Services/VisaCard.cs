namespace InterfaceExercise2.Services
{
    public class VisaCard : IPaymentCard
    {
        public double PercentageOfTax => 0.16;

        public double TaxPayment(double valuePayment)
        {
            return valuePayment += valuePayment * PercentageOfTax;
        }

        public void MethodTest()
        {
            Console.WriteLine("Inside of Method Test");
        }
    }
}
