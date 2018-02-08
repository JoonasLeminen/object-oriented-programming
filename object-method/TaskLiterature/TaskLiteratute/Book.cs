using System;
using System.Collections.Generic;
using System.Text;

namespace TaskLiterature
{
    class Book
    {
        string _name;
        readonly string _author;
        string _publisher;
        double _price;
        static string _themeName;

        public Book()
        {
            _name = null;
            _author = null;
            _publisher = null;
            _price = 0;
            _themeName = null;
        }

        public Book(string name, string author, string publisher, double price, string themeName)
        {
            _name = name;
            _author = author;
            _publisher = publisher;
            _price = price;
            _themeName = themeName;
        }

        public void GetBookInfo(string bookName)
        {
            if (_name == bookName)
            {
                Console.WriteLine($"Kirjan nimi: {_name}\n" +
                                  $"Kirjan tekijä: {_author}\n" +
                                  $"Kirjan julkaisija: {_publisher}\n" +
                                  $"Kirjan hinta: {_price:C}\n" +
                                  $"Kirjan teema: {_themeName}\n");
            }
            else
            {
                Console.WriteLine($"Kirjaa nimeltä {bookName} ei löytynyt.");
            }
        }
        public void ChangeTheme(Book book)
        {
            _themeName = "Fantasia";
        }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 30)
                {
                    _price = value * 0.9;
                }
                else
                {
                    _price = value;
                }
            }
        }
        public string Author
        {
            get
            {
                return _author;
            }
        }
    }
}
