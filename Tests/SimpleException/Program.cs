using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Fun With Exception Handling-----------");
            Car c1 = new Car("MyFirstCar", 60);
            // turning on the radio in the Car
            c1.RadioTune(true);
            for (int i = 0; i < 20; i ++)
            {
                c1.Accelerate(10);
            }
            Console.ReadLine();
        }

    }
}
