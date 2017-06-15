using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
         //Goods g= new Goods("Phone",DateTime.Now, 2,0001,new Money(22,11));
         //Console.WriteLine(g.ToString());
            
         //g.IncreasePrice(new Money(11, 1));
         //   Console.WriteLine(g.ToString());
            Console.WriteLine(  "-----------------------");
           // SystemClasses.ReturnVerbatimString();
            //SystemClasses.ShowStringEquality();
            //SystemClasses.ReturnStringFormatedByStringBulder();
            //short var1 = 3;
            //short var2 = 5;
            //Console.WriteLine($"{ SomeMethod(var1, var2)}");
           // Iterations.ForLoopMethod3();
           //Iterations.WhieCircle();
            int x = 0;
            var input = Console.ReadLine();
            x = int.Parse(input);
            Console.ReadLine();
        }

        static int SomeMethod(int x, int y)
        {
            return x+y;
        }
    }
}
