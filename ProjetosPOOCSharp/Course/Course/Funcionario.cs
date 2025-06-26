using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }
        public static void ExecutarClasseFuncionario()
        {
            Funcionario fun = new Funcionario();
            fun.Nome = Console.ReadLine();
            fun.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            fun.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(fun);

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double percentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            fun.AumentarSalario(percentual);

            Console.WriteLine("Dados atualizados:" + fun);
        }
        public override string ToString()
        {
            return Nome
            + ", R$ "
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
