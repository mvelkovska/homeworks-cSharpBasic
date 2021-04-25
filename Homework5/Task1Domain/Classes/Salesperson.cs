using System;
using System.Collections.Generic;
using System.Text;
using Task1Domain.Enums;

namespace Task1Domain.Classes
{
   public class Salesperson : Employee
    {
        private double _successSaleRevenue { get; set; }

        public void AddSuccessRevenue(double number)
        {
            _successSaleRevenue = number;
        }

        public override double GetSalary()
        {
            if (_successSaleRevenue <= 0)
            {
                Console.WriteLine("No Revenue, no Salary, sorry...");
            }
            else
            {
                if (_successSaleRevenue <= 2000)
                {
                    return Salary += 500;
                }
                else if (_successSaleRevenue > 2000 && _successSaleRevenue <= 5000)
                {
                    return Salary += 1000;
                }
                else if (_successSaleRevenue > 5000)
                {
                    return Salary += 1500;
                }
                else
                {
                    return Salary;
                }
            }
            return Salary;
        }

        public Salesperson(string firstname, string lastname) : base(firstname, lastname)
        {
            FirstName = firstname;
            LastName = lastname;
            Role = RoleEnum.Sales;
            Salary = 500;
        }
    }

}
