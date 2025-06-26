using ExercicioProduct.Entities;
using System.Globalization;

namespace ExercicioProduct
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Product> listProducts = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Common, used or imported (c/u/i)?  ");
                char type = char.Parse(Console.ReadLine());
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    listProducts.Add(new UsedProduct(name, price, manufactureDate));
                } else if (type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listProducts.Add(new ImportedProduct(name, price, customsFee));
                }
                else
                {
                    listProducts.Add(new Product(name, price));
                }
            }
            Console.WriteLine("\nPRICE TAGS:");
            foreach (Product products in listProducts)
            {
                Console.WriteLine(products.PriceTag());
            }
        }
    }
}