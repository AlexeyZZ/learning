using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructure
{
    struct Point
    {
        public int X;
        public int Y;
        public Point(int Xvalue, int Yvalue)
        {
            X = Xvalue;
            Y = Yvalue;
        }
        public void Increment()
        {
            X++;
            Y++;
        }
        public void DEcrement()
        {
            X--;
            Y--;
        }
        public void Display()
        {
            Console.WriteLine($"X:{X}\tY:{Y}");
        }
    }
    public class PointRef
    {
        //fields
        int X;
        int Y;
        // ctor
        public PointRef(int xValue,int yValue)
        {
            X = xValue;
            Y = yValue;
        }
        //Methods
        public static void Increnement(PointRef pr)
        {
            pr.X ++;
            pr.Y ++;
        }

        public static void Decrenement(PointRef pr)
        {
            pr.X--;
            pr.Y--;
        }
        public static void Display(PointRef pr)
        {
            Console.WriteLine($"Pointref x :{pr.X} /t Pointref y:{pr.Y}");
        }
        public static void RefTypeAssignment()
        {
            PointRef pr1 = new PointRef(2,2);
            PointRef pr2 = pr1;
            Display(pr1);
            Display(pr2);
            pr1.X = 4;
            pr1.Y = 4;
            Display(pr1);
            Display(pr2);
        }

    }
    class Program
    {

        public static void ValueTypeAssignment()
        {
            Point p1 = new Point(10, 10);
            Point p2 = p1;
            p1.Display();
            p2.Display();
            p1.X = 11;
            p1.Display();
            p2.Display();
        }

        static void Main(string[] args)
        {
            //Point myPoint;
            //myPoint.X = 5;
            //myPoint.Y = 10;
            //myPoint.Increment();
            //Console.WriteLine($"Point coordinates:{myPoint.X}:{myPoint.Y}");

            //Just to remember: if you does not use constructor to initalize struct then public fields does not contain default values
            // but if you are using constructor for struct variable th all public firlds are gets defualt values;


            //Point mp1;
            //mp1.X = 10;
            //mp1.DEcrement(); // error because no value for Y 

            //Point mp1 = new Point();
            //mp1.DEcrement();
            //Console.WriteLine("--------");
            //ValueTypeAssignment();
            //Rectangle r1 = new Rectangle("some text",11,11,11,11);
            //Rectangle r2 = r1;
            //r2.rectTop = 333;
            //r2.rectInfo.InfoString = "new text !";
            //r1.Display();
            //r2.Display();
            //PointRef.RefTypeAssignment();
            //Person per = new Person(name: "Fred", age: 17);
            //// new 'fred' person should be displayed before any changes
            //per.Display();
            //// we are trying to change per object
            //Person.SendAPersonByValue(per);
            //// display 'per' changes it is still Fred
            //per.Display();
            //Console.WriteLine("--------");
            //Console.WriteLine("Invoke method with ref param");
            //Person.SendPersonByRef(ref per);
            //per.Display();

            //Console.WriteLine("----Nullable----");
            //NullableTypes nb = new NullableTypes();
            //int? i = nb.GetNumber();
            //if (i.HasValue)
            //{
            //    Console.WriteLine($"the value is:{i.Value}");
            //}
            //else
            //    Console.WriteLine("i does not have any value!");
            //bool? b = nb.GetBoolean();
            //if(b!=null)
            //{
            //    Console.WriteLine($"the value is:{b.Value}");
            //}
            //else
            //    Console.WriteLine("Bool does not have any value");

            // in case when some nullable variable must have a value assigned then one of the possible way to assign this value is:
            // using int d = x??10 -this mean that if x value is null than d will have 10 value otherwise x.value
            //int? x = null;
            int? x = 11;
            Console.WriteLine(x ?? 100);
            

            Console.Read();

        }
    }
}
