using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Pessoa.ExecutarClassePessoa();
            Aluno.ExecutarClasseAluno();
            Funcionario.ExecutarClasseFuncionario();
            ConversorDeMoeda.ExecutarClasseConversorDeMoeda();
            ContaBancaria.ExecutarClasseContaBancaria(); // Foco na abordagem de classe e construtor
            Aluguel.ExecutarClasseAluguel(); // Foco na abordagem de vetor
            Employee.ExecutarClasseEmployee(); //Foco na abordagem de lista
            */
            
            string[] entrada = Console.ReadLine().Split(" ");
            int m = int.Parse(entrada[0]);
            int n = int.Parse(entrada[1]);

            int[,] mtz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(" ");
                for (int j = 0; j < n; j++)
                {
                    mtz[i, j] = int.Parse(values[j]);
                }
            }
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mtz[i, j] == x)
                    {
                        Console.WriteLine($"Position: {i},{j}");
                        if (j > 0)
                            Console.WriteLine($"Left: {mtz[i, j - 1]}");
                        else if (j < n - 1)
                            Console.WriteLine($"Right: {mtz[i, j + 1]}");
                        else if (i > 0)
                            Console.WriteLine($"Up: {mtz[i - 1, j]}");
                        else if (i < m - 1)
                            Console.WriteLine($"Down: {mtz[i + 1, j]}");
                    }
                }
            }
           




        }
    }
}

