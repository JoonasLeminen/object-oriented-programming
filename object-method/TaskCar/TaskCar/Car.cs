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
        public void Accelerate(int speed)
        {
            if (speed >= 0)
            {
                Speed += speed;
            }
        }
        public void Brake()
        {
            Speed = Speed / 10 * 9;
        }
    }
}
