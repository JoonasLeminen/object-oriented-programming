using System;
using System.Collections.Generic;
using System.Text;

namespace TicketPrice
{
    class Ticket
    {
        public static double TicketPriceCalc(Customer customer)
        {
            if (customer.Age < 7)
            {
                return 0;
            }
            else if (customer.Age >= 65)
            {
                return 0.5;
            }
            else if (customer.Age >= 7 && customer.Age <= 15)
            {
                return 0.5;
            }
            else if (customer.Conscript == "Y")
            {
                return 0.5;
            }
            else if (customer.Student == "Y" && customer.MtkMember == "Y")
            {
                return 0.6;
            }
            else if (customer.Student == "Y")
            {
                return 0.45;
            }
            else if (customer.MtkMember == "Y")
            {
                return 0.15;
            }
            else
            {
                return 1;
            }
        }
    }
}
