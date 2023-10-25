using System;
using System.Globalization;
using Primeiro.Entities.Enums;

namespace Primeiro.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<Hourscontract> Contract { get; set; } new List<Hourscontract>(); 
        
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
        Name = name;
        Level = level;
        BaseSalary = baseSalary;
        Department = department;
        }
 
       public void AddContratc(Hourscontract contratc)
       {
           Contract.Add(contratc);
       }

       public void RemeveContract(Hourscontract contratc)
       {
           Contract.Remove(contratc);
       }

       public double Income(int year, int month)
       {
          double sum = BaseSalary;
          foreach(Hourscontract contrac in Contract)
          {
             if (contrac.Date.Year == year && contrac.Date.Month == month)
             {
                sum += contrac.TotalValue();
             }
          }
          return sum; 
       }
    }
}