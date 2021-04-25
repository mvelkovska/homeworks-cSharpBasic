using System;
using System.Collections.Generic;
using System.Text;
using Task1Domain.Enums;

namespace Task1Domain.Classes
{
    public class Manager : Employee
    {
        private double _bonus { get; set; }

        public double AddBonus(double bonus)
        {
            return _bonus=bonus;
        }

        public override double GetSalary()
        {
            return Salary + _bonus;
        }
        public Manager(string firstname,string lastname) : base(firstname, lastname)
        {
            FirstName = firstname;
            LastName = lastname;
            Role = RoleEnum.Manager;
            Salary = 8000;
        }
    }
}
