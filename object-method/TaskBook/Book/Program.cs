using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tehtävä: Kirja luokka\n");
            ClassBook Remes1 = new ClassBook("Musta Kobra", "Ilkka Remes", 1337, 32.90);
            ClassBook Remes2 = new ClassBook("Kirottu Koodi", "Ilkka Remes", 1336, 34.90);
            ClassBook Remes3 = new ClassBook("Jäätyvä helvetti", "Ilkka Remes", 1338, 29.90);
            Remes1.PrintBookInfo();
            Console.WriteLine();
            Remes2.PrintBookInfo();
            Console.WriteLine();
            Remes3.PrintBookInfo();
            Console.WriteLine();
            Console.WriteLine(Remes2.CompareBook(Remes1));
            Console.WriteLine(Remes3.CompareBook(Remes2));
            Console.WriteLine(Remes1.CompareBook(Remes3));

            Console.ReadKey();
        }
    }
}
