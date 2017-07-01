using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("MyCarName", 60);
            try
            {
                c1.Accelerate(100);
            }
            catch (CarIsDeadException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ErroTtimeStamp);
                Console.WriteLine(ex.CauseOfError);
            }
            Console.ReadLine();
        }
    }
}
