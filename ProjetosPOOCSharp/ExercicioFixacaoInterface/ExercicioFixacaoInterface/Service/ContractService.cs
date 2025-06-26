using ExercicioFixacaoInterface.Entities;
using System.Globalization;

namespace ExercicioFixacaoInterface.Service
{
    class ContractService
    {
        private IOnlinepaymentService _onlinePaymentService;
        
        public ContractService(IOnlinepaymentService onlinepaymentService)
        {
            _onlinePaymentService = onlinepaymentService;
        }
        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }       
    }
}
