using System;
using AulaDelegates.Services;
using AulaDelegates.Entities;


namespace AulaDelegates
{
    delegate void BinaryNumericOperation(double n1, double n2);
    class Program
    { 
        public static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            // BinaryNumericOperation op = CalculationService.Sum;
            BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.ShowSum);
            op += CalculationService.ShowMax;

            op.Invoke(a, b);
            // ou... op(a, b);

            // --------------- DELEGATE PREDICATE
            Console.WriteLine("\nDelegate Predicate:");

            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // list.RemoveAll(p => p.Price >= 100.0);
            foreach (Product p in list)
            {
                Console.WriteLine(p);   
            }


            // ------------------- DELEGATE ACTION
            Console.WriteLine("\nDelegate Action:");

            List<Product> list2 = new List<Product>();
            list2.Add(new Product("Tv", 900.00));
            list2.Add(new Product("Mouse", 50.00));
            list2.Add(new Product("Tablet", 350.50));
            list2.Add(new Product("HD Case", 80.90));

            // Action<Product> act = p => { p.Price += p.Price * 0.1; };
            // ou...
            list2.ForEach(p => { p.Price += p.Price * 0.1; });
            //list2.ForEach(UpdatePrice);
            foreach (Product p in list2)
            {
                Console.WriteLine(p);
            }

            //------------------------- DELEGATE FUNC
            Console.WriteLine("\nDelegate Func (exemplo com Select):");
            List<Product> list3 = new List<Product>();
            list3.Add(new Product("Tv", 900.00));
            list3.Add(new Product("Mouse", 50.00));
            list3.Add(new Product("Tablet", 350.50));
            list3.Add(new Product("HD Case", 80.90));

            // List<string> result = list3.Select(NameUpper).ToList();
            
            // Func<Product, string> func = NameUpper;

            // Func<Product, string> func = p => p.Name.ToUpper();  //versão com expressão lambda 

            List<string> result = list3.Select(p => p.Name.ToUpper()).ToList(); // versão com expressão lambda inline 
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }

        }
        
        public static bool ProductTeste(Product p)
        {
            return p.Price >= 100.0;
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }

        static string NameUpper(Product p )
        {
            return p.Name.ToUpper();
        }
    }
}