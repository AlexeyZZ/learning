using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    class Teenager
    {
        public static Random r = new Random();
        public static int GetRandomNumber(short Upperlimit)
        {
            return r.Next(Upperlimit);

        }
        public static string Complain()
        {
            string[] messages = { "Do I have to?", "He started it!","I 'm too tired...", "I hate school'","You are sooooooo wrong!"};
            return messages[GetRandomNumber((short)messages.Length)];
        }
    }
}
