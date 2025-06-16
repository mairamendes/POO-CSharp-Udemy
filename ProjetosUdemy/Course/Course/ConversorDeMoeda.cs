using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class ConversorDeMoeda
    {
        public static double iof = 6.0;
        
        public static double Conversao(double qtdDolar, double cotacaoDolar)
        {
            double total = qtdDolar * cotacaoDolar;
            return total + total * iof / 100.0;
        }
    }
}
