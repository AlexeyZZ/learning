using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        // state of the class defined by fields
        public int currSpeed;
        public string petName;
        // intraction with class defined by methods;
        public int SpeedUp(int delta)
        {
            return currSpeed += delta;
        }
        public void PrintState()
        {
            Console.WriteLine("The {0} car moves with {1}MPH", petName, currSpeed);
        }
    }
}
