using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    partial class Employee
    {
        private string empName = "";
        protected int empId;
        private float curPay;
        // class Employee has a BenefitPackage item
        protected BenefitPackage empBenefit = new BenefitPackage();

        public BenefitPackage Benefits { get{ return empBenefit; } set{empBenefit=value;}} 

        //implementation of incapsulation
        public string Name
        {
            get { return empName; }
            set
            {
                if (empName.Length > 15)
                    Console.WriteLine("Choose shorter name!");
                empName = value;
            }
        }
        public int Age {get;set;}

        public int EmpId { get; set; }
        public float CurPay { get; set; }

        public Employee() { }
        public Employee(string name, int id, float pay,int age)
        {
            empName = name;
            empId = id;
            curPay = pay;
            Age = age;
        }
    }
}
