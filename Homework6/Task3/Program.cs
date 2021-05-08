using System;
using Task3Domain.Classes;
using Task3Domain.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {

        public static void Print(List<Animal> list)
        {
            foreach(var l in list)
            Console.WriteLine($"Name:{l.Name}, Color:{l.Color}, Age:{l.Age}, Gender:{l.Gender}");
        }
        static void Main(string[] args)
        {
           

        List<Animal> listOfAnimalsObjects = new List<Animal>() { 
            new Animal("Aaron","brown",2,Gender.Male),
            new Animal("Sparky","white",3,Gender.Male),
            new Animal("Doge","orange",5,Gender.Female),
            new Animal("Anny","black",7,Gender.Female),
            new Animal("Janky","brown",10,Gender.Male),
            new Animal("Bartholomew","brown",6,Gender.Male),
            new Animal("Constantine","white",3,Gender.Female)
        };
            Console.WriteLine("ANIMALS AGED 5 OR MORE:");
            List<string> above5Age = listOfAnimalsObjects.Where(x => x.Age >= 5).Select(x => $"{x.Name} {x.Age}").ToList();

            foreach (string s in above5Age)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine("ANIMALS THAT HAVE THE LETTER 'A' AS THEIR FIRST LETTER:");
            List<Animal> letterA = listOfAnimalsObjects.Where(x => x.Name.StartsWith("A")).ToList();
            Print(letterA);

            Console.WriteLine("ALL BROWN MALE ANIMALS");
            List<string> brownMale = listOfAnimalsObjects.Where(x => x.Color == "brown" && x.Gender == Gender.Male).Select(x => $"{x.Name} {x.Gender}").ToList();
          
            foreach(string s in brownMale)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("FIRST ANIMAL WHOSE NAME IS LONGER THAN 10 CHARACTERS:");


            Animal longer10 = listOfAnimalsObjects.FirstOrDefault(x => x.Name.Length > 10);
            Console.WriteLine($"{longer10.Name}"); 


            Console.ReadLine();
        }
    }
}
