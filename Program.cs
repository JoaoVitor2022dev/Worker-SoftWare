using System;
using System.Globalization;
using Primeiro.Entities.Enums;
using Primeiro.Entities;

namespace Primeiro
{
    class Program
    {
        static void Main()
        {
          // entrada de dados 

          Console.Write("Enter epartament's name: ");
          string deptName = Console.ReadLine();

          Console.WriteLine("Enter worker data: ");
          Console.Write("Name: ");
          string name = Console.ReadLine(); 

          Console.Write("Level (junior/MidLevel/Senior): "); 
          WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

          Console.WriteLine("Base Salary: ");
          double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

          //  instaciamento das classes 

          Department dept = new Department(deptName);
          Worker worker = new Worker(name, level, baseSalary, dept);
 
          // percorrer a lsita de contartos 

          Console.Write("How Many contratcts to this worker ? ");
          int n = int.Parse(Console.ReadLine());
          
        for (int i = 1; i <= n ; i++)
        {
          Console.WriteLine($"Enter #{i} contracts data:");
          Console.Write("Date (DD/MM/YYYY): ");
          DateTime date = DateTime.Parse(Console.ReadLine());

          Console.Write("Value per Hour: "); 
          double valuePeHour = double.Parse(Console.ReadLine());

          Console.Write("Duration (Hours): "); 
          int hours = int.Parse(Console.ReadLine());

          Hourscontract contract = new Hourscontract(date, valuePeHour, hours);
          worker.AddContratc(contract);
        }

        Console.WriteLine();
        Console.Write("Enter month and year to calculate income (MM/YYYY): "); 
        string monthAndYear = Console.ReadLine(); 
        int month = int.Parse(monthAndYear.Substring(0, 2));
        int year = int.Parse(monthAndYear.Substring(3));
        Console.WriteLine("Name: " + worker.Name);
        Console.WriteLine("Departamento " + worker.Department.Name);
        Console.WriteLine("Income " +  monthAndYear + " " + worker.Income(year, month));
       }
   }
}

