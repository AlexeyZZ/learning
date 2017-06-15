using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructure
{
    class Person
    {
        //fields
        public int PersonAge;
        public string PersonName;
        //ctor
        public Person() { }
        public Person(int age,string name)
        {
            PersonAge = age;
            PersonName = name;
        }
        public void Display()
        {
            Console.WriteLine("Name:{0}\tAge:{1}",PersonName , PersonAge);
        }
        // method that alows you to pass Person type by value
        public static void SendAPersonByValue(Person p)
        {
            //here we are changing some state of the 'p' object age==22
            p.PersonAge = 22;
            // in here we are trying to assigng new object to 'p' (we decided that we will have new object at the same memory address)
            // as a fact it imposible wile we are using 'value' type of arguments.
            //next query will not take affect!!!!
            p = new Person(33, "Semen");
        }
        public static void SendPersonByRef(ref Person p)
        {
            p.PersonAge = 22;
            p = new Person(name: "Nikki", age:24);

        }
    }
}
