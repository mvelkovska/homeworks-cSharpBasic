using System;

namespace exercise01_realCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter the first number :");

             string number1 = Console.ReadLine();

             bool checkNumber1 = double.TryParse(number1, out double parsedNumber1);


             Console.WriteLine("Enter the second number :");

             string number2 = Console.ReadLine();

             bool checkNumber2 = double.TryParse(number2, out double parsedNumber2);

            double result;




             if (checkNumber1 == true && checkNumber2 == true)
             {
                 Console.WriteLine("Enter the operation :");

                 string operation = Console.ReadLine();

                 if (operation == "+" || operation == "-" || operation == "*" || operation=="/")
                 {
                    if (operation == "+")
                    {
                        result = parsedNumber1 + parsedNumber2;
                        Console.WriteLine("The result is: " + result);
                    }

                    else if (operation == "-")
                    {
                        result = parsedNumber1 - parsedNumber2;
                        Console.WriteLine("The result is: " + result);
                    }

                    else if (operation == "*")
                    {
                        result = parsedNumber1 * parsedNumber2;
                        Console.WriteLine("The result is: " + result);
                    }

                    else
                    {
                        result = parsedNumber1 / parsedNumber2;
                        Console.WriteLine("The result is: " + result);
                    }


                }

                else
                {
                    Console.WriteLine("You entered invalid operation");
                    
                }

             }

             else
             {
                 Console.WriteLine("Some of your number inputs are invalid!");
             }
           

            Console.ReadLine();
        }
    }
}
