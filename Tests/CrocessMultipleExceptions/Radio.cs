using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions
{
    class Radio
    {
        public void TurnRadioOn(bool on)
        {
            if (on)
            {
                Console.WriteLine("The Radio is On");
            }
            Console.WriteLine("The Radio is OFF");
        }
    }
}
