using System;
using System.Collections.Generic;
using System.Text;

namespace UsingInheritance
{
    public class CommissionEmployeeTest
    {
        static void Main(string[] args)
        {
            CommissionEmployee employee = new CommissionEmployee("Sue", "Jones", "222-22-2222", 10000.00M, .06M);

            Console.WriteLine("Employee information obtained by properties and methods: \n");
            Console.WriteLine("First name is {0}", employee.FirstName);
            Console.WriteLine("Last name is {0}", employee.LastName);
            Console.WriteLine("Social security number is {0}", employee.SocialSecurityNumber);
            Console.WriteLine("Gross sales are {0:C}", employee.GrossSales);
            Console.WriteLine("Commission rate is {0:F2}", employee.CommissionRate);
            Console.WriteLine("Earnings are {0:C}", employee.Earnings());

            employee.GrossSales = 5000.00M; // set gross sales
            employee.CommissionRate = .1M;  // set commission rate

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(employee.EmployeeInfo());

        }
    }
}
