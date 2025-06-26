using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoInterface.Service
{
    internal class PaypalService : IOnlinepaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }

    }
}
