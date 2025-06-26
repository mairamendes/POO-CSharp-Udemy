using ExercicioAccountException.Entities;
using ExercicioAccountException.Exceptions;
using System.Globalization;
namespace ExercicioAccountException
{
    class Program
    {
        public static void Main(string[] args)
        {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("\nEnter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("");

                Account account = new Account(number, holder, balance, withdrawLimit);

            try
            {
                account.WithDraw(amount);
                Console.WriteLine($"New balance: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (DomainException e) {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
        }
    }
}