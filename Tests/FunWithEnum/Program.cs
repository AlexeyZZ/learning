using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithEnum
{
    public enum EmpType
    {
        Manager,
        Grunt,
        Contractor,
        VicePresident
    }
    class Program
    {
        public static void ReturnAmountOfDiscount(EmpType emp)
        {
            switch (emp)
            {
                case EmpType.Manager:
                    Console.WriteLine("Discount for Manager:20%");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("Discount for Grunt:15%");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("Discount for Grunt:25 % ");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine($"Discount for {EmpType.VicePresident}:35 % ");
                    break;
                default:
                    Console.WriteLine("incorrect input");
                    break;
            }

        }
        public static void ReturnListOfEnum(System.Enum e)
        {
            Console.WriteLine("return enum pairs key and value");
            Console.WriteLine($"the type of selected array is:{e.GetType().Name}");
            //underlying type for Enum is
            Console.WriteLine($"the underlying type is{Enum.GetUnderlyingType(e.GetType())}");

            // retriving array of enum's items
            Array _enumData = Enum.GetValues(e.GetType());
            //So now we have information about enum and we can get it from Array '_enumData'
            Console.WriteLine($"the number of items in Enum are euals to:{_enumData.Length}");

            // return data to console
            for (int i=0; i<_enumData.Length;i++)
            {
                Console.WriteLine("Name:{0}\t Value:{0:D}",_enumData.GetValue(i));
            }
        }
        static void Main(string[] args)

        {
            Console.WriteLine("Starting game with ENUM");
            Console.WriteLine("return amount of dscount according to employee type");
            EmpType employee = EmpType.VicePresident;
            ReturnAmountOfDiscount(employee);
            Console.WriteLine("_________");
            //next method return the type that uses for enum but in this case you need to declare this enum
            Console.WriteLine(Enum.GetUnderlyingType(employee.GetType()));
            //another method to get Enum type is uses typeof
            Console.WriteLine(Enum.GetUnderlyingType(typeof(EmpType)));

            // NOtice that you are able to work with already defined ENUM value and you can't change its values directly from variable
            //Emp v = Emp.NewValue;
            //or
            //v = anotherValue;

            // To get the name of selected Enum we should use ToString() method exp:
            Console.WriteLine("current employee is a :{0}",employee.ToString());


            // If you want to get numerical representation of the Enum you just simply need to cast selected Enum to its 'type' exp:
            Console.WriteLine($"The value of {employee} is {(int)employee}");

            int[] Iarray = { 1, 2, 3, 4 };
            string[] sArray = { "world", "Hello" };
            Console.WriteLine($"{Iarray.GetType().Name} array before method");
            RepresentArray(Iarray);
            ReverseArray(Iarray);
            Console.WriteLine($"{Iarray.GetType().Name} array after method");
            RepresentArray(Iarray);
            Console.WriteLine("_________");
            Console.WriteLine($"{sArray.GetType().Name} array before method");
            RepresentArray(sArray);
            ReverseArray(sArray);
            Console.WriteLine($"{sArray.GetType().Name} array after method");
            RepresentArray(sArray);
            Console.WriteLine("_________Return Enum Data_______");
            EmpType em = EmpType.Contractor;
            DayOfWeek day = DayOfWeek.Friday;
            ReturnListOfEnum(em);
            Console.Read();
        }
        public static void ReverseArray(System.Array a)
        {
            Array.Reverse(a);
        }
        public static void RepresentArray(Array arr)
        {
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
