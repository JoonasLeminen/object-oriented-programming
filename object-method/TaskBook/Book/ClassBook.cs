using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBook
{
    class ClassBook
    {
        //Fields
        public string Title;
        public string Author;
        public int Id;
        public double Price;

        //Constructor
        public ClassBook()
        {
            Title = "unknown";
            Author = "unknown";
            Id = 0;
            Price = 0;
        }
        public ClassBook(string title, string author, int id, double price)
        {
            Title = title;
            Author = author;
            Id = id;
            this.Price = price;
        }

        public void PrintBookInfo()
        {
            Console.WriteLine($"Kirjan nimi: {Title}\n" + 
                             $"Kirjoittajan nimi: {Author}\n"
                           + $"Id: {Id}\n"
                           + $"Hinta: {Price:00.00} euroa");
        }
        public string CompareBook(ClassBook Remes1)
        {
            if (this.Price > Remes1.Price)
            {
                return $"{this.Title} on kalliimpi kuin {Remes1.Title} kirja";
            }
            else
            {
                return $"{Remes1.Title} on kalliimpi kuin {this.Title} kirja";
            }
        }
    }
}
