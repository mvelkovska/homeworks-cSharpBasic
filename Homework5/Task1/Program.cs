using System;
using Task1Domain.Classes;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 contractors, 2 managers and 1 salesPerson
            Manager manager1 = new Manager("Stole", "Stojanov");
            Manager manager2 = new Manager("Goran", "Goranovski");

            Contractor contractor1 = new Contractor("Nino", "Ninovski", 8.5, 600, manager1);
            Contractor contractor2 = new Contractor("Bojan", "Bojanovski", 7.5, 400, manager2);

            Salesperson salesperson = new Salesperson("Mitre", "Mitrovski");


            Employee[] Company = new Employee[] {
                manager1,manager2,contractor1,contractor2,salesperson
            };
            

            CEO ceo = new CEO("Jane", "Jankovski",Company,2222);


            Console.WriteLine($"CEO : {ceo.GetInfo()}");
            Console.WriteLine("=====");
            Console.WriteLine($"CEO'S SALARY : {ceo.GetSalary()}");
            Console.WriteLine("=====");
            Console.WriteLine($"ALL THE EMPLOYEES:");
                ceo.PrintEmployees();

            Console.ReadLine();
        }
    }
}
