namespace InterfaceExercise.Services
{
    public interface IOnlinePayment
    {
        public double PaymentFee(double amount);
        public double Interest(double amount, int months);
    }
}
