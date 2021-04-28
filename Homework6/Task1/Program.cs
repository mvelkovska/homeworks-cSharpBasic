using System;
using System.Collections.Generic;
namespace Task1
{
    class Program
    {

        //mozebi povtoruvackite delovi mozea da se izvadat vo poseben metod, probav so bool, ne mi bese celosno funkcionalna programata na toj nacin, ne znaev tocno kako da go napravam toa

        public static bool Check()
        {
            string userinput = Console.ReadLine();
            if (userinput.ToLower() != "x")
            {
                Console.Clear();
                return true;
            }

            else

            {
                Console.WriteLine("GOODBYE!");
                return false;
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Queue<int> queueOfNumbers = new Queue<int>();
                string userInput1,userInput3;
                bool flag1 = false;
                Console.WriteLine("How many numbers to you want to enter?");
                userInput1 = Console.ReadLine();
                bool checkNumber0 = int.TryParse(userInput1, out int parsedNumber1);

                if (checkNumber0 && parsedNumber1>0)
                {
                    for (int i = 0; i < parsedNumber1; i++)
                    {
                        Console.WriteLine($"Enter number {i + 1}");
                        userInput3 = Console.ReadLine();
                        bool checkNumber1 = int.TryParse(userInput3, out int parsedNumber2);
                        if (checkNumber1)
                        {
                            queueOfNumbers.Enqueue(parsedNumber2);

                        }
                        else
                        {
                            flag1 = true;
                        }
                    }

                    if (flag1 == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You didn't enter a number in some of the fields.");
                        Console.WriteLine("Enter any key to try again and x to exit.");
                        Console.ResetColor();
                        if (Check() == false)
                        {
                            break;
                        }


                    }
                    if (flag1 == false)
                    {
                        Console.WriteLine("You have entered the numbers:");

                        int counter = 1;
                        foreach (int num in queueOfNumbers)
                        {
                            Console.WriteLine($"[{counter}]. {num}");
                            counter++;

                        }


                        Console.WriteLine("Enter any key to try again and x to exit.");
                        if (Check() == false)
                        {
                            break;
                        }
                    }
                }


                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You haven't entered a proper number or you entered a number below 1.Enter any key to try again and x to exit.");
                    Console.ResetColor();
                    if (Check()==false)
                    {
                        break;
                    }

                }
            }
            Console.ReadLine();
        }
    }
}
