using System;
using System.Collections.Generic;
using Task1Domain.Enums;
using System.Text;

namespace Task1Domain.Classes
{
    public class CEO : Employee
    {
        public int Shares { get; set; }

        private double SharesPrice { get; set; }

        public Employee[] Employees { get; set; }

        public double AddSharesPrice(double number)
        {
            return SharesPrice = number;
        }

        public void PrintEmployees()
        {
            foreach (Employee e in Employees)
            {
                //e.GetInfo();
                Console.WriteLine(e.GetInfo());
            }
           
        }

        public CEO(string firstname, string lastname, Employee[] employees,int shares) : base(firstname, lastname)
        {
            FirstName = firstname;
            LastName = lastname;
            Shares = shares;
            Employees = employees;
            Role = RoleEnum.CEO;
            Salary = 2000;
            SharesPrice = 5000;
        }

        public override double GetSalary() {

            return Salary + (Shares*SharesPrice);
        }

    }
}
