﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try { Class1.Method1();}
            catch (MethodException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            Console.Read();
        }
    }
}
