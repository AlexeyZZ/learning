using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesPerson denny = new SalesPerson();
            denny.Name = "Danny";
            denny.Age=31;
            denny.EmpId = 22;
            denny.SalesNumber = 11;

            Console.Read();
        }
    }
}
