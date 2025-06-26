using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoInterface.Service
{
    interface IOnlinepaymentService
    {
        public double PaymentFee(double amount);
        public double Interest(double amount, int months);
    }
}
