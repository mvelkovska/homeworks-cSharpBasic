using System;

namespace task3
{
    class Program
    {
        static int GetSum(int someNumber)
        {
            int sum = 0;
            while (someNumber > 0)
            {

                sum += (someNumber % 10);
                someNumber/=10;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");

            string number1 = Console.ReadLine();

            bool checkNumber1 = int.TryParse(number1, out int parsedNumber1);

            if (checkNumber1)
            {
                int getTheResult = GetSum(parsedNumber1);
                Console.WriteLine($"The sum of the digits of the number you entered is: {getTheResult}");
            }

            else
            {

                Console.WriteLine("Input not number!");
            }


            Console.ReadLine();
        }
    }
}
