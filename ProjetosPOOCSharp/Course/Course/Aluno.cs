using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course
{
    internal class Aluno
    {
        public string Nome;
        public int Nota1, Nota2, Nota3;

        public int NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int NotaRestante()
        {
            if (Aprovado())
            {
                return 0;
            }
            else
            {
                return 60 - NotaFinal();
            }
        }

        public static void ExecutarClasseAluno()
        {
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
                Console.WriteLine("FALTARAM " + aluno.NotaRestante() + " PONTOS");
            }
        }
    }
}
