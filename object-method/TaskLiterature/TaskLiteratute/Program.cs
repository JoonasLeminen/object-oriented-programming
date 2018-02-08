using System;

namespace TaskLiterature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Tehtävä: Kirja-luokka");
            Console.WriteLine();
            Book book = new Book("Moukanpeli", "Jussi Vares", "Otava", 30, "Dekkari");

            book.GetBookInfo("Moukanpeli");

            book.GetBookInfo("6/12");
            Console.WriteLine();

            book.ChangeTheme(book);
            book.GetBookInfo("Moukanpeli");

            Book book2 = new Book("Valkovenäläinen", "Jussi Vares", "Otava", 35, "Dekkari");
            Console.WriteLine();

            book2.GetBookInfo("Valkovenäläinen");

            book2.Price = 35;
            book2.GetBookInfo("Valkovenäläinen");

            Console.WriteLine($"{book2.Author}");
            Console.WriteLine();

            Author author = new Author("Jussi Vares", "20.6.1958", book);
            author.PrintAuthor("Jussi Vares");

            Console.ReadKey();
        }
    }
}
