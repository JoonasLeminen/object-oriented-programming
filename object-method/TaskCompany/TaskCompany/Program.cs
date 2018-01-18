using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tehtävä: Firma luokka");
            Console.WriteLine();
            Company Company1 = new Company("Neppailijat", "Skinnarilankatu 1", "0400-123123", 7900, 2000);
            Company Company2 = new Company(Company1);

            Company1.PrintCompanyInfo();
            Console.WriteLine();
            Company1.CompanyProfit();
            Console.WriteLine();
            Company2.PrintCompanyInfo();
            Console.WriteLine();
            Company2.CompanyProfit();

            Console.ReadKey();
        }
    }
}
