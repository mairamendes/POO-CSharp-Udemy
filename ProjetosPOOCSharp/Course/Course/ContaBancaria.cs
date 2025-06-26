using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course
{
    internal class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria()
        {
        }

        public ContaBancaria(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }

        public ContaBancaria(int numeroConta, string nomeTitular, double saldo) : this()
        {

            Saldo = saldo;
        }

        public void Depositar()
        {
            Console.Write("\nEntre um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Saldo += valorDeposito;
        }

        public void Sacar()
        {
            Console.Write("\nEntre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Saldo -= valorSaque + 5.0;
        }
        public static void ExecutarClasseContaBancaria()
        {
            ContaBancaria conta;
            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char indicador = char.Parse(Console.ReadLine());


            if (indicador == 's' || indicador == 'S')
            {
                Console.Write("Entre um valor para depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numeroConta, nomeTitular, depositoInicial);
                Console.WriteLine("\nDados da conta: \n" + conta);
            }
            else
            {
                conta = new ContaBancaria(numeroConta, nomeTitular);
                Console.WriteLine("\nDados da conta: \n" + conta);
            }

            conta.Depositar();
            Console.WriteLine("Dados da conta atualizados: \n" + conta);
            conta.Sacar();
            Console.WriteLine("Dados da conta atualizados: \n" + conta);
        }
        public override string ToString()
        {
            return "Conta "
            + NumeroConta
            + ", Titular: "
            + NomeTitular
            + ", Saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
