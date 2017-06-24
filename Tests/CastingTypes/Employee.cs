using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingTypes
{
    partial class Employee
    {
        
        // methods 
        public virtual void GiveBonus(float amount)
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
        public class BenefitPackage
        {
            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }
    }
}
