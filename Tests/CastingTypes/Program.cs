using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingTypes
{
    class Program
    {
        //this method could work with employee type and all nested types
        public static void MakeSomethingWithEmployee(Employee emp)
        {
            Console.WriteLine(emp.Name);
        }
        static void Main(string[] args)
        {
            SalesPerson sp = new SalesPerson("SPname", 11, 1, 22, 33);
            Manager m = new Manager("managerName", 1, 2, 11, 1);
            MakeSomethingWithEmployee(sp);
            MakeSomethingWithEmployee(m);

            // if we have 'sp' as an object then we will get the error message because object is more abstract class then Employee
            // in this cases we should use explicit casting of type
            //object sp1 = new SalesPerson("SPname1", 11, 1, 22, 33);
            //MakeSomethingWithEmployee(sp1);
            object sp2 = new SalesPerson("explCastedName", 11, 1, 22, 33);
            MakeSomethingWithEmployee((Employee)sp2);
            // to be more right we should chack that sp2 could be casted to Employee berfore use casting
            // thare are two ways for that porpose
            // is - reurn false if object could not be casted 
            // as - return null if object could not be casted
            //exp:
            object sp3 = new Manager("isName", 11, 1, 22, 33);
            if (sp3 is Employee)
            {
                MakeSomethingWithEmployee((Employee)sp3);
            }
            else
            {
                Console.WriteLine("sp3 is not an Employee object");
            }

            object sp4 = new Manager("asName", 11, 1, 22, 33);
            var x = sp4 as Employee;
            if (x != null)
            {
                MakeSomethingWithEmployee((Employee)sp4);
            }
            else
            {
                Console.WriteLine("sp4 is not an Employee object");
            }
            Console.ReadLine();
                
        }
    }
}
