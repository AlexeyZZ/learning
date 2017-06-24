using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClases
{
    abstract class Shape
    {
        protected string PetName { get; set; }
        public Shape(string name="defaultName") { PetName = name; }
        // virtual method could be overriden
        public virtual void Draw()
        {
            Console.WriteLine("Inside shape.draw()");
        }
    }
}
