using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructure
{
    class NullableTypes
    {
        int? number = 11;
        public int? GetNumber()
        {
            return number;
        }
        bool? Boolean = null;
        public bool? GetBoolean()
        {
            return Boolean;
        }
        //methods
        public static void GetValues()
        {

        }
    }
}
