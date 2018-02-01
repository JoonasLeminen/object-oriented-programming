using System;
using System.Collections.Generic;
using System.Text;

namespace TicketPrice
{
    class Customer
    {
        //Fields
        public string Name;
        public int Age;
        public double Price;
        public string Conscript;
        public string Student;
        public string MtkMember;

        //Constructor
        public Customer()
        {
            Name = null;
            Age = 0;
            Price = 16;
            Conscript = null;
            Student = null;
            MtkMember = null;
        }

        public void AskCustomerData()
        {
            Console.WriteLine("Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Age: ");
            Age = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Oletko varusmies? Y/N");
                Conscript = Console.ReadLine().ToUpper();
            } while (Conscript != "Y" && Conscript != "N");

            do
            {
                Console.WriteLine("Oletko opiskelija? Y/N");
                Student = Console.ReadLine().ToUpper();
            } while (Student != "Y" && Student != "N");

            do
            {
                Console.WriteLine("Oletko Mtk:n jäsen? Y/N");
                MtkMember = Console.ReadLine().ToUpper();
            } while (MtkMember != "Y" && MtkMember != "N");
        }
        public void PrintCustomerInfo(Customer customer)
        {
            Console.WriteLine($"Nimi: {Name}\n" +
                              $"Ikä: {Age}\n" +
                              $"Lipun hinta: {Price * (1 - Ticket.TicketPriceCalc(customer)):C}");
        }
    }
}
