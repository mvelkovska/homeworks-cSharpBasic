using System;
using System.Collections.Generic;
namespace Task1
{
    class Program
    {

  
        static void Main(string[] args)
        {
            while (true)
            {
                Queue<int> queueOfNumbers = new Queue<int>();
                string userInput1;
                string userInput2;
                string number;
                Console.WriteLine("How many numbers to you want to enter?");
                userInput1 = Console.ReadLine();
                bool checkNumber0 = int.TryParse(userInput1, out int parsedNumber);

                if (checkNumber0)
                {
                    Console.WriteLine("Yes");
                    for(int i = 0; i < parsedNumber; i++)
                    {
                        number = Console.ReadLine();
                        bool checkNumber1 = int.TryParse(number, out int parsed);
                        if (checkNumber1)
                        {
                            queueOfNumbers.Enqueue(parsed);

                        }
                    }

                    Console.WriteLine("You have entered numbers:");

                    foreach (int num in queueOfNumbers)
                    {
                        Console.WriteLine(num);
                    }



                        break;
                }

                else
                {
                    Console.WriteLine("You haven't entered a number.Enter any key to try again and x to exit.");
                    userInput2 = Console.ReadLine();
                    if (userInput2.ToLower() == "x")
                    {
                        Console.WriteLine("GOODBYE!");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                    }


                }
            }
            Console.ReadLine();
        }
    }
}
