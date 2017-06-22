using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("basic inheritance");
            // initializing new car
            Car c1 = new Car(80);
            // set current speed 
            c1.Speed = 44;
            Console.WriteLine($"My car is going {c1.Speed}MPH");

            //Since we have minivan as a Car than we can use all available properties from Car class
            Minivan m1 = new Minivan();
            m1.Speed = 57;
        }
    }
}
