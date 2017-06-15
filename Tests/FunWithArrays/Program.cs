using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArrays
{
    class Program
    {
        public static void GetArrayOfObject()
        {
            Console.WriteLine("here we have one array of object");
            object[] arr = new object[] { "hello", 123, 's' };
            foreach (var a in arr)
            {
                Console.WriteLine($"element:{a.ToString()}/t {a.GetType()}");
            }

        }

        public static void GetMultyLevelArray()
        {
            int[,] MultyArry = new int[2,2];
            //filing the array
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2;  j++)
                {
                    MultyArry[i, j] = i+j;
                    //here is the one way of printing Array
                    //Console.WriteLine($"{MultyArry[i, j].ToString()}/t|");
                }
            }
            //another way of printing Array
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j==1)
                    Console.Write($"{MultyArry[i,j]}\n");
                    else
                    {
                        Console.Write($"|{MultyArry[i, j]}\t|");
                    }
                    //if (j==1) Console.WriteLine("\n");
                }
            }
        }

        public static void ArrayOfArray()
        {
            int [][] arr=new int[3][];
            // filling the array
            for (int i = 0; i < arr.Length; i++)
            {
              arr[i]=new int[i+5];
                Console.WriteLine(arr[i].Length.ToString());
            }
            
            //printing array
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                
                    Console.Write(arr[i][j]+" ");
                    Console.WriteLine();
                
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //declaration of array
            //with the size
            int[] arrInt = new int[5];

            //Explicit Array initialization of Array
            int[] arr1 = new int[4] { 1, 2, 3, 4 };

            int[] arr2 = { 1, 2, 3, 4 };

            int[] arr3 = new int[] { 1, 2, 3, 4 };

            //Implicit Array Initialization !!!Notice that when Implicit Array you must always use 'new' keyword at the right

            // array of int 
            var arr4 = new[] { 1, 2, 3, 4 };

            //array of strings
            var arr5 = new[] { "hello", "world" };

            ///Remember that if Implicit Array than type of array will be chaked only when compilation so next example will fails with error on compilation
            /// because it contains different types.
            //var arr6 = new[] {"string", 'c', 123};

            //Also it is possible to define array of object and since all types in general are objects we can see the next example:
            object[] ArrayOfObject = { "string", 123, 'q' };

            //Rectangular multidimensional Array int[,]=new int[2,2];

            //Jagged multidimensional Array int[][] = new int[5][]; this mean that array will contains 5 different arrays (array of arrays)


            GetArrayOfObject();
            GetMultyLevelArray();
            ArrayOfArray();
            Console.Read();
        }
    }
}
