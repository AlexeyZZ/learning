using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {
        private string empName;
        private int empId;
        private float curPay;

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

        public int EmpId { get; set; }
        public float CurPay { get; set; }

        public Employee() { }
        public Employee(string name, int id, float pay)
        {
            empName = name;
            empId = id;
            curPay = pay;
        }
    }
}
