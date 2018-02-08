using System;

namespace TaskLiterature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Tehtävä: Kirja-luokka");
            Book book = new Book("Moukanpeli", "Jussi Vares", "Otava", 30, "Dekkari");
            Book book2 = new Book("Valkovenäläinen", "Jussi Vares", "Otava", 29, "Dekkari");

            book.GetBookInfo("Moukanpeli");
            book.GetBookInfo("6/12");
            book.ChangeTheme(book);
            book.GetBookInfo("Moukanpeli");
            book2.GetBookInfo("Valkovenäläinen");


            Console.ReadKey();
        }
    }
}
