﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task4Domain
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Employee(string firstname,string lastname,int age)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
        }

    }

}
