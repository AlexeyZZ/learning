using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initialisation
{
    class Car
    {
        public int x;
        public int y;
        public Car(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Display()
        {
            Console.WriteLine($"x:={this.x}\ny:={this.y}");

        }
    }
}
