using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Iterations
    {
        //for loop
        // "i" variable is visible only in a scope of loop
        public static void ForLoopMethod1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i}");
            }

            //here i will be out of scope , it is not exist in here!
        }
        public static void ForLoopMethod2()
        {
            //here we will have endless loop
            for (int i = 0;;) 
            {
                Console.WriteLine($"{i}");
            }

            //here i will be out of scope , it is not exist in here!
        }
        public static void ForLoopMethod3()
        {
            //here we will have endless loop
            for (;;)
            {
                Console.WriteLine("Hello");
            }

            //here i will be out of scope , it is not exist in here!
        }

        public static void WhileCircle()
        {
            string s = "";
            while (s != "yes")
            {
                Console.WriteLine("still in while loop");
                Console.WriteLine("Do you want to finish");
                s = Console.ReadLine();
            }
        }

        public static void SwitchMethod(string s)
        {
            DayOfWeek dayOfWeek;
            dayOfWeek=(DayOfWeek)Enum.Parse(typeof(DayOfWeek),Console.ReadLine());
        }

    }
}
