using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingTypes
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
        public override void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
                salesBonus = 10;
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                    salesBonus = 15;
                else
                    salesBonus = 20;
            }
            base.GiveBonus(amount * salesBonus);
        } 

    }
}
