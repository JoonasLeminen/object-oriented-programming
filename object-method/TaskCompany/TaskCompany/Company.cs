using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCompany
{
    class Company
    {
        public string Title;
        public string Address;
        public string Phone;
        public int Outcome;
        public int Expense;

        public Company()
        {
            Title = "Company name";
            Address = "Company address";
            Phone = "Company phone";
            Outcome = 0;
            Expense = 0;
        }
        public Company(string title, string address, string phone, int outcome, int expense)
        {
            Title = title;
            Address = address;
            Phone = phone;
            Outcome = outcome;
            Expense = expense;
        }
        public void PrintCompanyInfo()
        {
            Console.WriteLine($"Yrityksen nimi: {Title}\n" +
                              $"Yrityksen osoite: {Address}\n" +
                              $"Yrityksen puhelin: {Phone}\n" +
                              $"Yrityksen tulot: {Outcome:C}\n" +
                              $"Yrityksen menot: {Expense:C}");
        }
        public Company(Company previousCompany)
        {
            Title = previousCompany.Title;
            Address = previousCompany.Address;
            Phone = previousCompany.Phone;
            Outcome = previousCompany.Outcome;
            Expense = previousCompany.Expense;
        }
        public void CompanyProfit()
        {
            int profit = (Outcome - Expense) / Expense;

            if (profit < 1)
            {
                Console.WriteLine("Firmalla menee kehnosti.");
            }
            else if (profit >= 1 && profit < 3)
            {
                Console.WriteLine("Firmalla menee tyydyttävästi.");
            }
            else if (profit >= 3)
            {
                Console.WriteLine("Firmalla menee hyvin.");
            }
        }
    }
}
