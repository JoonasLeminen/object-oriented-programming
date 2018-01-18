using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEmployee
{
    class Employee
    {
        public string Name;
        public string Id;
        public string Position;
        public int Salary;

        public Employee()
        {
            Name = "Työntekijän nimi";
            Id = "Työntekijän ID";
            Position = "Työntekijän asema";
            Salary = 0;
        }

        public Employee(string name, string id, string position, int salary)
        {
            Name = name;
            Id = id;
            Position = position;
            Salary = salary;
        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"Työntekijän nimi: {Name}\n" +
                              $"Työntekijän ID: {Id}\n" +
                              $"Työntekijän asema: {Position}\n" +
                              $"Työntekijän palkka: {Salary:C}\n");
        }

        public void CompareSalary(Employee employee)
        {
            if (Salary > employee.Salary)
            {
                Console.WriteLine($"{Name} palkka on suurempi kuin {employee.Name}");
            }
            else
            {
                Console.WriteLine($"{employee.Name} palkka on suurempi kuin {Name}");
            }
        }

    }
}
