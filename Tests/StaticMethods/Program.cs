using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Fun with static methods-----");
            //executing static method with rundom message in a cicle
            for (int i=0; i < 5; i++)
            {
                Console.WriteLine(Teenager.Complain()); 
            }

            Console.ReadLine();


        }
    }
}
