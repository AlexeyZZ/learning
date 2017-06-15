using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    public class Employee
    {

        //out modificator uses to get value by reference type
        // when uses out you can get several output values from methods
        // pay attension to assigning vARIABLES REMEMBER  ABOUT VARIABLES SCOPE

        public static void GetOutParams(out int Age, out string Sex, out string Name)
        {
            //some implementation that can modify out variables!! some conditions!!!
            Name = "Alex"; // we did not provide type for Name because we are working with existing variable that already declared by using reference
            Sex = "Male"; // we did not provide type for Name because we are working with existing variable that already declared by using reference
            Age = 22; // we did not provide type for Name because we are working with existing variable that already declared by using reference

        }

        public static void GetSortedValues(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }

        public static double GetAvarege(params double[] values)
        {
            double averege = 0;
            for (int i = 0; i <= values.Length; i++)
            {
                averege += values[i];
            }

            return averege;

        }

    }
    class Program
    {
        #region Properties

        public static int Fnumber=1;
        public static int Snumber = 2;

        public static int Age;
        public static string Name;
        public static string Sex;
        #endregion
        private static int X;
        // arguments are passed by vale by default
        static void WhatWithX(int value)
        {
            X = 1000;
        }

        static int Add(int x, int y)
        {
            int ans = x + y;
            /*since we have the copy of original data than user will not get new values for x and y*/
            x = 1000;
            y = 2324;
            return ans;
            //return ans + 2;
        }

        // in case user uses out modifier than this argument must be assigned in a scope of this method
        static void Add2(int x, int y, out int ans)
        {
            ans = x + y;
        }




        static void Main(string[] args)
        {
            // Fun with methods
            int x = 5, y = 10;
            int ans;
            Console.WriteLine($"before the method invoked x:={x}\ty:={y}");
            Console.WriteLine($"result of x+y:={Add(x, y)}");
            Console.WriteLine($"After the method invoked x:={x}\ty:={y}");
            Add2(11, 1, out ans);

            Console.WriteLine("-----------------");
            X = 10;
            WhatWithX(20);
            Console.WriteLine(X);
            Console.WriteLine("-----------------");
            Console.WriteLine("using 'params' in method ");
            // here you can pass args from 0 to any (int) number
            UseParams();
            // here you can pass only array of ints (could not be empty)-- fixed number of args (array limitations) 
            GetArraySum(new int[] { 1 });



            //out modificator uses when method declared and when we execute it 
            Employee.GetOutParams(out Program.Age,out Program.Sex,out Program.Name);

            //ref modificator should be used when declaring method and when invoking it
            // when using ref you must declare variable before use it in method otherwise will compile error
            Employee.GetSortedValues(ref Program.Fnumber, ref Program.Snumber);

            // you can pass any number of strongly typical args to method as a array of type or as a number of args delemeted by the ','
            // both cases are acceptable
            Employee.GetAvarege(1.1, 2.3, 5, 5.3);
            //or
            double[] testArray = new double[ ]{2.2,3.3,4.4,5,5};
            Employee.GetAvarege(testArray);
           
            ///Method overload , method with similar name but different signature

            MethodsOverload.Add(1, 1);
            MethodsOverload.Add(2.3, 3.3);
            MethodsOverload.Add(11L, 22L);


            Console.ReadLine();

        }
        //using of 'params' modifier
        // params uses for representing an array of arguments that could be added to the method
        public static int UseParams(params int[] args)
        {
            int sum = 0;
            //if (args.Length == 0)
            //   return sum;
            for (int i = 0; i <= args.Length; i++)
            {
                sum += args[i];
            }
            return sum;
        }
        public static int GetArraySum(int[] args)
        {
            int sum = 0;
            for (int i = 0; i <= args.Length; i++)
            { sum += args[i]; }
            return sum;
        }

       
        
        
    }
}
//private static int value;

//static void ShowValue(string description)
//{
//    Console.WriteLine(description + value);
//}
//static void Main(string[] args)
//{
//    Console.WriteLine("Return value test...");
//    value = 5;
//    value = ReturnValue();
//    ShowValue("Value after return value");
//    Console.WriteLine("---------------");
//    value = 5;
//    Console.WriteLine("OUT param test...");
//    OutParameters(out value);
//    ShowValue("Value after OUTParam...");
//    Console.ReadLine();

//}

//static int ReturnValue()
//{
//    ShowValue("ReturnValue PRE:");
//    int tmp = 10;
//    ShowValue("ReturnValue Post:");
//    return tmp;
//}

//private static void OutParameters(out int tmp)
//{
//    ShowValue("OutParam pre:");
//    tmp = 10;
//    ShowValue("OutParam post:");

//}