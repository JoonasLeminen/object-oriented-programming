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
            Car Car2 = new Car();

            Car1.AskData();
            Car2.AskData();

            Car1.ShowCarInfo();
            Car2.ShowCarInfo();

            Car1.Accelerate(10);
            Car1.ShowCarInfo();

            Car2.Brake();
            Car2.ShowCarInfo();

            Console.ReadKey();
        }
    }
}
