using System;

namespace TicketPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Tehtävä: Lipunhinnan laskenta");

            Customer customer = new Customer();
            customer.AskCustomerData();
            customer.PrintCustomerInfo(customer);

            Console.ReadKey();
        }
    }
}
