using System;

namespace exercise03_swapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number :");

            string number1 = Console.ReadLine();

            bool checkNumber1 = double.TryParse(number1, out double parsedNumber1);

            //

            Console.WriteLine("Input the second number :");

            string number2 = Console.ReadLine();

            bool checkNumber2 = double.TryParse(number2, out double parsedNumber2);

            double pomoshna;
            pomoshna = parsedNumber1;
            parsedNumber1 = parsedNumber2;
            parsedNumber2 = pomoshna;

            if (checkNumber1 && checkNumber2)
            {

                Console.WriteLine("After swapping: ");

                Console.WriteLine($"First number: {parsedNumber1}");

                Console.WriteLine($"Second number: {parsedNumber2}");
            }

            else
            {
                Console.WriteLine("You have some wrong number inputs!");
            }

            Console.ReadLine();
        }

    }
}
