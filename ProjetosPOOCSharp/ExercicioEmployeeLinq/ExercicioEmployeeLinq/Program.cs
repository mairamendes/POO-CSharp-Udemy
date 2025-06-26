using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using ExercicioEmployeeLinq.Entities;
namespace ExercicioEmployeeLinq
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double exSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            List<Employee> employees = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!(sr.EndOfStream))
                {
                    string[] lines = sr.ReadLine().Split(',');
                    string name = lines[0];
                    string email = lines[1];
                    double salary = double.Parse(lines[2], CultureInfo.InvariantCulture);
                    employees.Add(new Employee(name, email, salary));
                }
            }

            Console.WriteLine($"Email of people whose salary is more than {exSalary}:");
            var emails = employees.Where(e => e.Salary > exSalary).Select(e => e.Email).ToList();
            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }

            var sum = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
            Console.Write("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}