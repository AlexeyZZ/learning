using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("pet", 33);
            try
            {
                c1.Accelerate(200);
            }

            catch (CarIsDeadException e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
            catch (ArgumentOutOfRangeException e)
            {
                //Console.WriteLine(e.Message);
                //throw e;
            }

            //catch (System.Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //// next catch is the common one becouse it does not get the exception instance and as a result we could not get more information 
            //// from this exception, only a comon information like a message.
            //catch
            //{
            //    Console.WriteLine("Some Error occures");
            //}
            Console.ReadLine();
        }
    }
}
