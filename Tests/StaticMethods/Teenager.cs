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
    class SavingAccount
    {
        public double currBalance;
        // static ctor
        SavingAccount()
        {
            currInterestRate = 0.04;
            Console.WriteLine("Static ctor executed");
        }

        //static field
        public static double currInterestRate;
        public static int Counter;
        // ctor
        public SavingAccount(double balance)
        {
            currBalance = balance;
            Counter++;
            Console.WriteLine("instance ctor executed");
            // Console.WriteLine(Counter);
        }
        public static void SetCurrRate(double newRate)
        {
            currInterestRate = newRate;
        }
        public static double GetCurrRate()
        {
            return currInterestRate;
        }
    }
}
