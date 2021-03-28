using System;

namespace exercise04_findStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;

            Console.WriteLine("Input the first number :");

            string number1 = Console.ReadLine();

            bool checkNumber1 = double.TryParse(number1, out double parsedNumber1);

            //

            Console.WriteLine("Input the second number :");

            string number2 = Console.ReadLine();

            bool checkNumber2 = double.TryParse(number2, out double parsedNumber2);

            //If the two of them are even, print their sum, if one of them is odd, print their difference, if the two off them are odd, multiply them. Don't print just the result, but also the whole operation. 

            if(checkNumber1 && checkNumber2)
            {
                if(parsedNumber1 % 2 == 0 &&  parsedNumber2 % 2 == 0)
                {
                    result = parsedNumber1 + parsedNumber2;
                    Console.WriteLine($"Both of the inputs are EVEN.The operation and result are {parsedNumber1}+{parsedNumber2}={result}");
                }
                else if (parsedNumber1 % 2 != 0 && parsedNumber2 % 2 != 0)
                {
                    result = parsedNumber1 * parsedNumber2;
                    Console.WriteLine($"Both of the inputs are ODD.The operation and result are {parsedNumber1}*{parsedNumber2}={result}");
                }

                else
                {
                    result = parsedNumber1 - parsedNumber2;
                    Console.WriteLine($"One number is ODD, and one number is EVEN .The operation and result are {parsedNumber1}-{parsedNumber2}={result}");
                }
            }

            else
            {
                Console.WriteLine("Not all of your inputs are numbers!");
            }
            Console.ReadLine();
        }
    }
}
