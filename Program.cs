using System;
using System.Globalization;
using Primeiro.Entities.Enums
using Primeiro.Entities

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
          Console.Write("Name: ")
          string name = Console.ReadLine(); 

          Console.Write("Level (junior/MidLevel/Senior): "); 
          Console.ReadLine();
          WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

          Console.WriteLine("Base Salary: ");
          double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

          //  instaciamento das classes 

          Department dept = new Department(deptName);
          Worker work = new Worker(name, level, baseSalary, dept);
 
          // percorrer a lsita de contartos 

          Console.Write("How Many contratcts to this worker ? ");
          int n = int.Parse(Console.ReadLine());
          
          for (int i = 1; i < n ; i++)
          {
              Console.WriteLine($"Enter #{i} contracts data:");
          }
        }
    }
}

