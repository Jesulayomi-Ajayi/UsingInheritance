using System;
using System.Collections.Generic;
using System.Text;

namespace UsingInheritance
{
    public class CommissionEmployee
    {
        private string firstName;
        private string lastName;
        private string socialSecurityNumber;
        private decimal grossSales;
        private decimal commissionRate;

        // five-parameter constructor
        public CommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate)
        {
            firstName = first;
            lastName = last;
            socialSecurityNumber = ssn;
            GrossSales = sales;
            CommissionRate = rate;
        } // end five-parameter CommissionEmployee constructor


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


        // calculate commission employee's pay
        public virtual decimal Earnings()
        {
            return CommissionRate * GrossSales;
        }// end method Earnings


        public virtual string EmployeeInfo()
        {
            return "Employee" + "\n"
                + "First name: " + FirstName + "\n"
                + "Last Name: " + LastName + "\n"
                + "Social Security Number: " + SocialSecurityNumber + "\n"
                + "Gross Sales: " + GrossSales + "\n"
                + "Commission Rate: " + CommissionRate + "\n"
                + "Earnings: " + Earnings();
        }
    }
}
