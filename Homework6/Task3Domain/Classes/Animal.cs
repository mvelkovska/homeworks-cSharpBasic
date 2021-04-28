using System;
using System.Collections.Generic;
using System.Text;
using Task3Domain.Enums;

namespace Task3Domain.Classes
{
    public class Animal
    {
        public string Name { get; set; }

        public string Colors { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }

        public Animal(string name,string colors,int age,Gender gender)
        {
            Name = name;
            Colors = colors;
            Age = age;
            Gender = gender;
        }

    }


}
