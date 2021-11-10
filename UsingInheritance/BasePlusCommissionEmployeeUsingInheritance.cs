using System;
using System.Collections.Generic;
using System.Text;

namespace UsingInheritance
{
    public class BasePlusCommissionEmployeeUsingInheritance : CommissionEmployee
    {
        private decimal baseSalary;

        // six-parameter constructor
        public BasePlusCommissionEmployeeUsingInheritance(string first, string last, string ssn, decimal sales, decimal rate, decimal salary)
              : base(first, last, ssn, sales, rate)
        {
            BaseSalary = salary;
        }

        public decimal BaseSalary
        {
            get
            {
                return baseSalary;
            }
            set
            {
                if (value >= 0)
                    baseSalary = value;
                else
                    throw new ArgumentOutOfRangeException("BaseSalary",
                    value, "BaseSalary must be >= 0");
            }
        }

        // calculate earnings
        public override decimal Earnings()
        {
            return BaseSalary + base.Earnings();
        }

        public override string EmployeeInfo()
        {
            return base.EmployeeInfo() + "\n" + "Base Salary: " + BaseSalary;
        }
    }
}
