using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClases
{
    class Circle:Shape
    {
        public Circle() { }
        public Circle(string name) : base(name)
        {

        }
    }
    class Hexagon : Shape
    {
        public Hexagon()
        {

        }
        public Hexagon(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the Hexagon");
            //base.Draw();
        }
    }
}
