using AulaHerancaPolimorfismo.Entities;
using System.Globalization;

namespace AulaHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsorced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsorced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    OutsourcedEmployee employee = new (name, hours, valuePerHour, additionalCharge);

                    employees.Add(employee);
                }
                else
                {
                    Employee employee = new (name, hours, valuePerHour);

                    employees.Add(employee);

                }

            }

            Console.WriteLine("\nPAYMENTS:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Name} - $ {employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}