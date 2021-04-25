using System;
using System.Collections.Generic;
using System.Text;
using Task1Domain.Enums;

namespace Task1Domain.Classes
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }

        public int PayPerHour { get; set; }

        public Employee Responsible { get; set; }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }

        public RoleEnum CurrentPosition()
        {
            return Role;
        }
        public Contractor(string firstname, string lastname, double workhours,int payperhour,Employee responsible) : base(firstname, lastname)
        {
            FirstName = firstname;
            LastName = lastname;
            WorkHours = workhours;
            PayPerHour = payperhour;
            Responsible = responsible;
            Salary = 1000;
            Role = RoleEnum.Contractor;
        }

  
    }
}
