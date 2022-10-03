using InterfaceExercise2.Entities;

namespace InterfaceExercise2.Services
{
    public class CartService
    {
        private readonly IPaymentCard _paymentCard;

        public CartService(IPaymentCard paymentCard)
        {
            _paymentCard = paymentCard;
        }

        public void ProcessCart(Cart cart)
        {
            foreach (var item in cart.Products)
            {
                double valueWithTax = _paymentCard.TaxPayment(item.Value);
                Report report = new Report(item.Name, item.Value, valueWithTax);
                Console.WriteLine(report);
            }
        }
    }
}
