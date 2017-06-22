using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initialisation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car{ x = 22, y = 33 };
            c.Display();
            Console.Read();
        }
    }
}
