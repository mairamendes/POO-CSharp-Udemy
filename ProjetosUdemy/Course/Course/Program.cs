using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ------------------ Exercicio classe Pessoa ----------------------- */
            /* 
            Pessoa p1 = new Pessoa();
            p1.Nome = "Maíra";
            p1.Idade = 17;
            Pessoa p2 = new Pessoa();
            p2.Nome = "João";
            p2.Idade = 16;

            Console.WriteLine($"Dados da primeira pessoa: \nNome: {p1.Nome}\nIdade: {p1.Idade}");
            Console.WriteLine($"Dados da segunda pessoa: \nNome: {p2.Nome}\nIdade: {p2.Idade}");

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
            }
            */

            /* ------------------------ Exercicio classe Funcionario ---------------------------- */
            /*
            Funcionario fun = new Funcionario();
            fun.Nome = Console.ReadLine();
            fun.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            fun.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(fun);

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double percentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            fun.AumentarSalario(percentual);

            Console.WriteLine("Dados atualizados:" + fun);
            */

            /* ------------------------------- Exercicio classe Aluno --------------------------- */
            /*
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as 3 notas do aluno: ");
            aluno.Nota1 = int.Parse(Console.ReadLine());
            aluno.Nota2 = int.Parse(Console.ReadLine());
            aluno.Nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal());

            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + aluno.NotaRestante()+ " PONTOS");
            }
            */

            /* ------------------------ Exercicio classe Conversor de Moeda ---------------------- */
            /*
            Console.Write("Qual é a cotação do dólar? ");
            double cotacaoDolar = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar?");
            double qtdDolar = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double qtdPagamento = ConversorDeMoeda.Conversao(qtdDolar, cotacaoDolar);
            Console.WriteLine("Valor a ser pago em reais = " + qtdPagamento.ToString("F2", CultureInfo.InvariantCulture));
            */

            /* ---------------------------- Exercicio classe Conta Bancaria ----------------------------- */

            ContaBancaria conta;
            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char indicador = char.Parse(Console.ReadLine());


            if (indicador == 's')
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
            Console.WriteLine("\nDados da conta atualizados: \n" + conta);
            conta.Sacar();
            Console.WriteLine("\nDados da conta atualizados: \n" + conta);
        }
    }
}
