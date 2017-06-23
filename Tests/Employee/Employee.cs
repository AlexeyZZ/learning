﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    partial class Employee
    {
        
        // methods 
        public void GiveBonus(float amount)
        {
            curPay += amount;
        }
        public void DisplayStatus()
        {
            Console.WriteLine($"Name:={empName}/n EmpId:={empId}/n Pay:={curPay}");
        }
        public double GetBenefitCost()
        {
            return empBenefit.ComputePayDeduction();
        }
    }
}
