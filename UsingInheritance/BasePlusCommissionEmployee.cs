using System;
using System.Collections.Generic;
using System.Text;

namespace UsingInheritance
{
    public class BasePlusCommissionEmployee
    {
        private string firstName;
        private string lastName;
        private string socialSecurityNumber;
        private decimal grossSales;
        private decimal commissionRate;
        private decimal baseSalary;

        public BasePlusCommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate, decimal salary)
        {
            firstName = first;
            lastName = last;
            socialSecurityNumber = ssn;
            GrossSales = sales;
            CommissionRate = rate;
            BaseSalary = salary;
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public string SocialSecurityNumber
        {
            get
            {
                return socialSecurityNumber;
            }
        }

        public decimal GrossSales
        {
            get
            {
                return grossSales;
            }
            set
            {
                if (value >= 0)
                    grossSales = value;
                else
                    throw new ArgumentOutOfRangeException("GrossSales", value, "GrossSales must be >= 0");
            }
        }

        // property that gets and sets commission employee's commission rate
        public decimal CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                if (value > 0 && value < 1)
                    commissionRate = value;
                else
                    throw new ArgumentOutOfRangeException("CommissionRate", value, "CommissionRate must be > 0 and < 1");
            }
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
                    throw new ArgumentOutOfRangeException("BaseSalary", value, "BaseSalary must be >= 0");
            }
        }


        // calculate commission employee's pay
        public virtual decimal Earnings()
        {
            return BaseSalary + (CommissionRate * GrossSales);
        }// end method Earnings


        public virtual string EmployeeInfo()
        {
            return "Employee" + "\n"
                + "First name: " + FirstName + "\n"
                + "Last Name: " + LastName + "\n"
                + "Social Security Number: " + SocialSecurityNumber + "\n"
                + "Base Salary: " + BaseSalary + "\n"
                + "Gross Sales: " + GrossSales + "\n"
                + "Commission Rate: " + CommissionRate + "\n"
                + "Earnings: " + Earnings();
        }
    }
}
