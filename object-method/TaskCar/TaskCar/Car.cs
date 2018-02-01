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

        //Contructor
        public Car()
        {
            Brand = null;
            Speed = 0;
        }

        //Methods
        public void ShowCarInfo()
        {
            Console.WriteLine($"Merkki: {Brand}\nNopeus: {Speed}");
        }
        public void AskData()
        {
            Console.WriteLine("Syötä auton merkki:");
            Brand = Console.ReadLine();
            Console.WriteLine("Syötä auton nopeus:");
            Speed = int.Parse(Console.ReadLine());
        }
        public void Accelerate()
        {
            Speed = Speed + 0;
        }

        public void Accelerate(int addSpeed)
        {
            if (addSpeed > 0)
            {
                Speed = Speed + addSpeed;
                Console.WriteLine($"Auto kiihdyttää, nopeus kiihdytyksen jälkeen on: {Speed}");
            }
            else
            {
                Console.WriteLine($"Negatiivinen muutos ei ole sallittu!");
            }
        }

        public void Brake()
        {
            Console.WriteLine($"Auto jarruttaa, nopeus jarrutuksen jälkeen on: {Speed * 0.9}");
        }
    }
}
