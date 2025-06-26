using EnumAula.Entities;
using EnumAula.Entities.Enums;
using System;

namespace EnumAula
{
    class Program
    {
        static void Main(string[] args) { 
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PedingPayment
            };
            
            string txt = OrderStatus.PedingPayment.ToString(); // Converter o valor do enum para uma string 
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // Converter uma string para o valor correspondente do enum OrderStatus
            Console.WriteLine(os);
        }  
    }
}