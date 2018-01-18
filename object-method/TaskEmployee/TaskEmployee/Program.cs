using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tehtävä: Työntekijä luokka");
            Employee Employee1 = new Employee("Matti Meikäläinen", "1337", "Toimitusjohtaja", 3000);
            Employee Employee2 = new Employee("Maisa Meikäläinen", "1336", "Markkinapäällikkö", 2500);
            Employee Employee3 = new Employee();
            Employee1.PrintEmployeeInfo();
            Employee2.PrintEmployeeInfo();
            Console.WriteLine();

            Employee1.CompareSalary(Employee2);
            Console.WriteLine();

            Employee[] employees = new Employee[3];
            employees[0] = new Employee("Matti Meikäläinen", "1337", "Toimitusjohtaja", 3000);
            employees[1] = new Employee("Maisa Meikäläinen", "1336", "Markkinapäällikkö", 2500);
            employees[2] = new Employee("Mikko Meikäläinen", "1338", "Varatoimitusjohtaja", 2400);

            for (int i = 0; i < 3; i++)
            {
                employees[i].PrintEmployeeInfo();
            }
            employees[1].CompareSalary(employees[2]);

            Console.ReadKey();
        }
    }
}
