using System;

namespace task5
{
    class Program
    {
        static string GetCalculator(DateTime aDate)
        {
            DateTime date = DateTime.Now;
            int age = date.Year - aDate.Year;
            return "You are " + age;


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthdate [dd.mm.yyyy]"); // 25.5.1980
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"{GetCalculator(birthday)}");

            Console.ReadLine();
        }
    }
}
