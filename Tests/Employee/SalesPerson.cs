using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class SalesPerson:Employee
    {
        public int SalesNumber { get; set; }

        //ctors
        //default
        public SalesPerson() { }

        public SalesPerson(string name, int id, float pay, int age, int sales) : base(name, id, pay, age)
        {
            SalesNumber = sales;
        }
    }
}
