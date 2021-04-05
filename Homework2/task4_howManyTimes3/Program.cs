using System;

namespace task4_howManyTimes3
{
    class Program
    {

       
        static void Main(string[] args)
        {
            
            string userInput;
            bool check;
            int counter = 0;


            Console.WriteLine("Enter number of elements:");

            string numberOfElements = Console.ReadLine();

            bool checkNumber = int.TryParse(numberOfElements, out int parsedNumberOfElements);


            int[] someIntegerArray = new int[parsedNumberOfElements];

            if (checkNumber)
            {

                for (int i = 0; i < someIntegerArray.Length; i++)
                {
                    Console.WriteLine($"Enter integer no.{i + 1}:");
                    userInput = Console.ReadLine();
                    check = int.TryParse(userInput, out int parsedNumber);

                    if (check)
                    {

                        someIntegerArray[i] = parsedNumber;

                        if (i != 0 && (someIntegerArray[i - 1] == 3 && someIntegerArray[i] == 3))//site ostanati!
                        {
                            counter++;
                        }

                        if (i == 0 && (someIntegerArray[i] == 3 && someIntegerArray[i + 1] == 3))//prviot!
                        {
                            counter++;
                        }
                    }


                    else
                    {
                        Console.WriteLine("Input not valid");
                    }

                }
            }

            else
            {
                Console.WriteLine("Input not valid!!!");
            }

            Console.WriteLine($"{counter} times there are threes next to each other.");
            
            Console.ReadLine();
        }
    }
}
