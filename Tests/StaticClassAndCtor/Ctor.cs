using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAndCtor
{
    class Ctor
    {
        //static field
        protected int Age;
    }
    class s2 : Ctor
    {
        public void M(int Age)
        {
            base.Age = 7;        }
    }
}
