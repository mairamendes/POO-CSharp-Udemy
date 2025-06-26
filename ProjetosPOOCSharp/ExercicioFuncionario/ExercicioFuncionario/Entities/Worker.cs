using System;
using ExercicioFuncionario.Entities.Enums;
using System.Collections.Generic;
using System.Globalization;


namespace ExercicioFuncionario.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        WorkerLevel Level { get; set; }
        public double BaseSalary{ get; set; }
        public Department Department{ get; set; } // Associação entre classes diferentes

        // No diagrama estava "*", a lista vai possibilitar criar vários
        public List<HourContract> Contracts{ get; set; } = new List<HourContract>();

        public Worker() 
        {
        }
        // Não incluir associação para muitos no construtor
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
        
    }
}
