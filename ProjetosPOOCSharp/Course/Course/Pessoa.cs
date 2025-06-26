using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Pessoa
    {
        public string Nome;
        public int Idade;

        public static void ExecutarClassePessoa()
        {
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
        }
        
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
