using System;

namespace exercise02_averageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;

            Console.WriteLine("Enter the first number :");

            string number1 = Console.ReadLine();

            bool checkNumber1 = double.TryParse(number1, out double parsedNumber1);

            //

            Console.WriteLine("Enter the second number :");

            string number2 = Console.ReadLine();

            bool checkNumber2 = double.TryParse(number2, out double parsedNumber2);

            //

            Console.WriteLine("Enter the third number :");

            string number3 = Console.ReadLine();

            bool checkNumber3 = double.TryParse(number3, out double parsedNumber3);

            //

            Console.WriteLine("Enter the fourth number :");

            string number4 = Console.ReadLine();

            bool checkNumber4 = double.TryParse(number4, out double parsedNumber4);

            if(checkNumber1 && checkNumber2 && checkNumber3 && checkNumber4)
            {
                result = (parsedNumber1 + parsedNumber2 + parsedNumber3 + parsedNumber4) / 4;

                Console.WriteLine($"The average of {parsedNumber1},{parsedNumber2},{parsedNumber3} and {parsedNumber4} is {result}");
            }
            else
            {
                Console.WriteLine("Some of your number inputs are invalid!");
            }

            Console.ReadLine();


        }
    }
}
