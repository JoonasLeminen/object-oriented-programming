using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tehtävä: Auto luokka");
            Car Car1 = new Car();
            Car1.AskData();
            Car1.ShowCarInfo();

            Console.ReadKey();
        }
    }
}
