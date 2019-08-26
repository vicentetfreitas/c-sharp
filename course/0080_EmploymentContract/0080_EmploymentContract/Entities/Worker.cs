using System;
using System.Collections.Generic;
using _0080_EmploymentContract.Entities.Enums;

namespace _0080_EmploymentContract.Entities
{
    class Worker
    {
        //Atributos
        public string Name { get; set; }
        //Enumeração
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        //Composição
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        //Construtor padrão
        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Department departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = departament;
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
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
