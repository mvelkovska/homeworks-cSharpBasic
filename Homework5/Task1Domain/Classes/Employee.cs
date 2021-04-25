using System;
using System.Collections.Generic;
using System.Text;
using Task1Domain.Enums;

namespace Task1Domain.Classes
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary { get; set; }
        public RoleEnum Role { get; set; }

        public Employee(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

        }
        /* public void GetInfo()
         {
             Console.WriteLine($"{FirstName} {LastName} {Role}");
         }*/
        public string GetInfo()
        {
            return $"First name:{FirstName},Last name:{LastName},Salary:{Salary}";
        }


        public virtual double GetSalary()
        {
            return Salary;
        }

       
    }
}
