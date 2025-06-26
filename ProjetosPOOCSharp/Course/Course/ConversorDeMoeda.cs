using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class ConversorDeMoeda
    {
        public static double iof = 6.0;
        public static void ExecutarClasseConversorDeMoeda()
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacaoDolar = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar?");
            double qtdDolar = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double qtdPagamento = ConversorDeMoeda.Conversao(qtdDolar, cotacaoDolar);
            Console.WriteLine("Valor a ser pago em reais = " + qtdPagamento.ToString("F2", CultureInfo.InvariantCulture));
        }
        public static double Conversao(double qtdDolar, double cotacaoDolar)
        {
            double total = qtdDolar * cotacaoDolar;
            return total + total * iof / 100.0;
        }
    }
}
