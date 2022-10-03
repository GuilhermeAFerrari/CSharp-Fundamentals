using InterfaceExercise.Entities;

namespace InterfaceExercise.Services
{
    public class ContractService
    {
        private readonly IOnlinePayment _onlinePayment;

        public ContractService(IOnlinePayment onlinePayment)
        {
            _onlinePayment = onlinePayment;
        }

        public void ProcessContract(Contract contract, int numberOfInstallments)
        {
            double basicQuota = contract.TotalValue / numberOfInstallments;

            for (int i = 1; i <= numberOfInstallments; i++)
            {
                DateOnly date = contract.Date.AddMonths(i);

                double updateQuota = basicQuota + _onlinePayment.Interest(basicQuota, i);
                double fullQuota = updateQuota + _onlinePayment.PaymentFee(updateQuota);

                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
