using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Fun With Exception Handling-----------");
            Car c1 = new Car("MyFirstCar", 60);
            // turning on the radio in the Car
            c1.RadioTune(true);
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    c1.Accelerate(10);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.TargetSite.Attributes);
                Console.WriteLine(e.Source);
                Console.WriteLine(e.HelpLink);
                if (e.Data != null)
                {
                    foreach (DictionaryEntry de in e.Data)
                    {
                        Console.WriteLine($"Key:{de.Key}\nValue:{de.Value}");
                    }
                }
            }


            Console.ReadLine();
        }

    }
}
