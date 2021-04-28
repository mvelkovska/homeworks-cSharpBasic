using System;
using System.Linq;
using System.Collections.Generic;
namespace Task2
{
    class Program
    {
        public static void Print(List<int> list)
        {
            int counter = 1;
            foreach (int numbers in list)
            {
                Console.WriteLine($"{counter}. {numbers} ");
                counter++;
            }

        }


        static void Main(string[] args)
        {
           

            List<int> listOfNumbers = new List<int>();
            int R;
            Random rand = new Random();

            for (int i = 0; i <= 9; i++)
            {
                R= rand.Next(1, 50);
                listOfNumbers.Add(R);
                
            }



            Console.WriteLine("Let's print the random generated numbers:");

            Print(listOfNumbers);

            List<int> squares = listOfNumbers.Select(x => x * x).ToList();

            Console.WriteLine("Let's print the squares of the numbers:");

            Print(squares);

            Console.ReadLine();
        }
    }
}
