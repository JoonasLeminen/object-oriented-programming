using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCar
{
    class Car
    {
        //Fields
        public string Brand;
        public int Speed;

        //Constructor
        public Car()
        {
            Brand = "unknown";
            Speed = 0;
        }
        public Car(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        //Methods
        public void ShowCarInfo()
        {
            Console.WriteLine($"Merkki: {Brand}\nNopeus: {Speed}");
        }
        public void AskData()
        {
            Console.WriteLine("Syötä auton merkki:");
            string brand = Console.ReadLine();
            Console.WriteLine("Syötä auton nopeus:");
            int speed = int.Parse(Console.ReadLine());
        }
    }
}
