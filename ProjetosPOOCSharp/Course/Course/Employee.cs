using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void increaseSalary(double percentage)
        {
            Salary += (Salary * (percentage / 100));
        }
        public static void ExecutarClasseEmployee()
        {
            List<Employee> list = new List<Employee>();
            Console.Write("How many employees will be registred? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nEmployee #{i}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            int findId = int.Parse(Console.ReadLine());

            Employee temp = list.Find(x => x.Id == findId);
            if (temp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                temp.increaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("\nUpdate list of employees:");
            foreach (Employee employees in list)
            {
                Console.WriteLine(employees);
            }
        }

        public override string ToString()
        {
            return Id
            + ", "
            + Name
            + ", "
            + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
