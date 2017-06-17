using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        static string driverName;
        public int Age;
        string s;

        // main ctor
        public Motorcycle(int dIntencity,int age,string dname= "")
        {
            driverIntensity = dIntencity;
            driverName = dname;
            Age = age;
        }
        // chained ctor
        public Motorcycle (int idencitty) : this(idencitty,11)
        {
            //some logic for age
        }

        public void SetDriverName(string name)
        {
            //both operators are equvalent
            // this.driverName= name;
            driverName = name;
            
            
        }
    }
}
