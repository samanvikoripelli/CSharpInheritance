using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2
{
    class Vehicle1
    {
        public string Brand1 { get; set; }
        public int Speed { get; set; }

        public Vehicle1(string brand, int speed)
        {
            Brand1 = brand;
            Speed = speed;
        }

        public virtual void DisplayInfo1()
        {
            Console.WriteLine($"Brand: {Brand1}, Speed: {Speed} km/h");
        }
    }
    class Car1 : Vehicle1 
    {
        public Car1(string brand, int speed) : base(brand, speed) { }

        public override void DisplayInfo1()
        {
            base.DisplayInfo1();
            Console.WriteLine("This is a car.");
        }
    }
    class Bike1 : Vehicle1
    {
        public Bike1(string brand, int speed) : base(brand, speed) { }

        public override void DisplayInfo1()
        {
            base.DisplayInfo1();
            Console.WriteLine("This is a bike.");
        }
    }
}
