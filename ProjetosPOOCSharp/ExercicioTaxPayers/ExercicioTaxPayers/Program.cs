using ExercicioTaxPayers.Entities;
using System.Globalization;
namespace ExercicioTaxPayers
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<TaxPayer> listTaxPayer = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            double totalTaxes = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer {i}# data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
                    listTaxPayer.Add(new Individual(healthExpenditures, name, anualIncome));
                } else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listTaxPayer.Add(new Company(numberOfEmployees, name, anualIncome));
                }
            }

            Console.WriteLine("\nTAXES PAID: ");
            foreach (TaxPayer payer in listTaxPayer)
            {
                Console.WriteLine($"{payer.Name}: $ {payer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                totalTaxes += payer.Tax();
            }
            Console.WriteLine($"\nTOTAL TAXES: ${totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}