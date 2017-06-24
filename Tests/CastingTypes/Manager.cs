using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingTypes
{
    class Manager:Employee
    {
        public int StockOptions { get; set; }

        //ctors
        //default
        public Manager() { }
        public Manager(string name, int id, float pay, int age, int stock) : base(name, id, pay, age)
        {
            StockOptions = stock;
        }

        public override void GiveBonus(float amont)
        {
            Console.WriteLine("hello world");
        }
    }
}
