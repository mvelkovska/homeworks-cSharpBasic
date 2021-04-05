using System;

namespace task1ANDtask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====TASK 1=====");

            Console.Write("Please enter some word:");

            string userInput = Console.ReadLine();

            if (String.IsNullOrEmpty(userInput) || String.IsNullOrWhiteSpace(userInput)) //ako userot ostavi prazno mesto ili pak ne vnese nishto i klikne enter
            {
                Console.WriteLine("Please enter something!");

            }

            else
            {
                char[] chars = userInput.ToCharArray();

                Console.WriteLine("Printing each CHARACTER in reverse"); 
                for (int i = chars.Length - 1; i >= 0; i--)
                {
                    Console.Write($"{chars[i]}  ");
                }

                string[] razdeli = userInput.Split(" ");

                Console.WriteLine("\n");
                Console.WriteLine("Printing each WORD in reverse"); 

                Array.Reverse(razdeli);

                foreach (string prom in razdeli)
                {
                    Console.WriteLine(prom);
                }


            }




            Console.WriteLine("\n");
            Console.WriteLine("=====TASK 2=====");

            Console.Write("Please enter a sentence:");

            string someUserInput = Console.ReadLine();

            if (String.IsNullOrEmpty(someUserInput) || String.IsNullOrWhiteSpace(someUserInput))
            {
                Console.WriteLine("Please enter something!");

            }

            else
            {

                string[] razdeli1 = someUserInput.Split(" ");

                Console.WriteLine("\n");
                Console.WriteLine("Printing each WORD");

                foreach (string prom in razdeli1)
                {
                    Console.WriteLine(prom);
                }
            }
                Console.ReadLine();
        }
    }
}
