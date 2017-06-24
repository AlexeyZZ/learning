using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingTypes
{
    sealed class PTSalesPerson:SalesPerson
    {
        public PTSalesPerson(string name, int id, float pay, int age, int sales) : base(name,id,pay,age,sales)
        {

        }
    }
}
