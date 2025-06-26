using System;
using ExercicioOrder.Entities;
using ExercicioOrder.Entities.Enums;
using System.Globalization;

namespace ExercicioOrder
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth data (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.WriteLine("Quantity: ");
                int qt = int.Parse(Console.ReadLine());

                OrderItem item = new OrderItem(qt, price, product);

                order.AddItem(item);
            }
            Console.WriteLine("\nORDER SUMMARY:");
            Console.WriteLine(order);

        }
    }
}