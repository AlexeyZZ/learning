using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] MyShapes = new Shape[] { new Hexagon("hex"), new Circle() };
            foreach (Shape sh in MyShapes)
            {
               sh.Draw();
            }
            Console.ReadLine();
        }
    }
}
