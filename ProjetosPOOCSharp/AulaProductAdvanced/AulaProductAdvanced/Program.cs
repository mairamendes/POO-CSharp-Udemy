﻿using System;
using AulaProductAdvanced.Entities;
namespace AulaProductAdvanced
{
    class Program
    {
        public static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.0));
            list.Add(new Product("Tablet", 450.0));

            // Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            // ou...
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

        }
    }
}