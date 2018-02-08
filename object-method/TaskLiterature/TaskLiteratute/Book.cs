using System;
using System.Collections.Generic;
using System.Text;

namespace TaskLiterature
{
    class Book
    {
        public string Name;
        public string Author;
        public string Publisher;
        public int Price;
        static string ThemeName;

        public Book()
        {
            Name = null;
            Author = null;
            Publisher = null;
            Price = 0;
            ThemeName = null;
        }

        public Book(string name, string author, string publisher, int price, string themeName)
        {
            name = Name;
            author = Author;
            publisher = Publisher;
            price = Price;
            themeName = ThemeName;
        }

        public void GetBookInfo(string bookName)
        {
            if (Name == bookName)
            {
                Console.WriteLine($"Kirjan nimi: {Name}/n" +
                                  $"Kirjan tekijä: {Author}/n" +
                                  $"Kirjan julkaisija: {Publisher}/n" +
                                  $"Kirjan hinta: {Price}:C/n" +
                                  $"Kirjan teema: {ThemeName}");
            }
            else
            {
                Console.WriteLine($"Kirjaa nimeltä {bookName} ei löytynyt.");
            }
        }
        public void ChangeTheme(Book book)
        {
            ThemeName = "Fantasia";
        }
    }
}
