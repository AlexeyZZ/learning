using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating new car

            Car c1 = new Car();

            // define car c1 state

            c1.petName = "tedd";

            c1.currSpeed = 55;

            //incresing few times speed of 'c1' car

            for (int i = 0; i < 5; i++)

            {
                c1.SpeedUp(i);
                c1.PrintState();
            }

            c1.PrintState();

            Console.ReadLine();
        }
    }
}
