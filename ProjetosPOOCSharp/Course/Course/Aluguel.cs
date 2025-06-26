using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Aluguel
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Aluguel (string nome, string email)
        {
            Nome = nome;
            Email = email;

        }
        public static void ExecutarClasseAluguel()
        {
            Console.Write("How many rooms will be rented: ");
            int n = int.Parse(Console.ReadLine());
            Aluguel[] vet = new Aluguel[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nRent #{i + 1}:");
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vet[quarto] = new Aluguel(nome, email);
            }
            Console.WriteLine("\nBusy rooms:");
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] != null)
                    Console.WriteLine(i + ": " + vet[i]);
            }
        }
        public override string ToString()
        {
            return Nome + ", " + Email;
        }

    }
}
