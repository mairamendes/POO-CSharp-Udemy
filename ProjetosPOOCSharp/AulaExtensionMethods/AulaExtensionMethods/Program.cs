using AulaExtensionMethods.Extensions;

namespace AulaExtensionMethods
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Formatar data/horário
            DateTime dt = new DateTime(2025, 06, 01, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}