﻿using System;
using System.Globalization;

namespace ExercicioProductLinq.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

    }
}
