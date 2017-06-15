using System;
using System.Collections.Generic;
using System.Linq;
//String Builder lives here
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class SystemClasses
    {
        // define verbatim string
        public static void ReturnVerbatimString()
        {
            Console.WriteLine(@"This string 
            is the best 
            example of 
            "" using verbatim strings");
        }

        public static void ShowStringEquality()
        {
            Console.WriteLine("Example of string equality");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1==s2:{0}",s1==s2);
            Console.WriteLine("s1==Hello!:{0}",s1=="Hello!");
            Console.WriteLine("s1==hello!:{0}", s1 == "hello!");
            Console.WriteLine($"s1 equals s2:{s1.Equals(s2)}");
            Console.WriteLine($"Yo! equals s2:{"Yo!".Equals(s2)}");
        }
        //System.StringBuilder is the class that helps you to work with strings we they need to be corrected quiet frequently
        // String builder lives in System.Text namespace 
        public static void ReturnStringFormatedByStringBulder()
        {
            StringBuilder sb = new StringBuilder("=> Using the String builder:");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Deus Ex" +" "+"2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", "Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine($"String builder contains:{sb.Length}_of chars");
            Console.WriteLine("--------------------");
        }
    }
}
