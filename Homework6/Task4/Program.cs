using System;
using Task4Domain;
using System.Collections.Generic;
using System.Linq;
namespace Task4
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //list of 10 Employees
            List<Employee> listOfEmpolyees = new List<Employee>()
            {
                new Employee("name1","surname1",30),
                 new Employee("name2","surname2",16),
                  new Employee("name3","surname3",20),
                   new Employee("name4","surname4",31),
                    new Employee("name5","surname5",30),
                     new Employee("name6","surname6",31),
                      new Employee("name7","surname7",19),
                       new Employee("name8","surname8",20),
                        new Employee("name9","surname9",22),
                         new Employee("name10","surname10",22),
            };

          //  Dictionary<int,List<string>> someDictionary = new Dictionary<int, List<string>>();

            var groupedResult = from s in listOfEmpolyees
                                group s by s.Age;

            foreach (var ageGroup in groupedResult)
            {

                Console.WriteLine($"Age Group:{ageGroup.Key}");
                // Console.WriteLine(ageGroup.Key.GetType());
                //int current = ageGroup.Key;

                foreach (Employee e in ageGroup)
                {
                    Console.WriteLine($"Employee Name: {e.FirstName} {e.LastName}");
            //        someDictionary.Add(current, new List<string> { $"{e.FirstName} - {e.LastName}" });
                }
            }

            //ne uspeav istive da gi preslikam vo dictionary, kako bi mozelo da se prodolzi od ovaa zadaca nataka?

           /* foreach (var item in someDictionary)
            {
                Console.WriteLine($"{item.Key} :");
                foreach (var name in item.Value)
                {
                    Console.WriteLine($" {name} ");
                }
            }*/

            Console.ReadLine();
        }
    }
}
