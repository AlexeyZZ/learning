using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    class Class1
    {
        public static void Method1()
        {
            Method2("s");
            throw new MethodException();

        }
        public static void Method2(string s)
        {
            try
            {
                string from3 = Method3();
                if (from3!= s)
                    throw new MethodException("Incorrect message inserted");
            }
            catch (MethodException e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        public static string Method3()
        {
            return "Hello";
        }
    }
}
