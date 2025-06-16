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

        public ContaBancaria(int numeroConta, string nomeTitular) : this()
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }

        public ContaBancaria(int numeroConta, string nomeTitular, double saldo)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
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

        public override string ToString()
        {
            return "Conta"
            + NumeroConta
            + ", Titular: "
            + NomeTitular
            + ", Saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
