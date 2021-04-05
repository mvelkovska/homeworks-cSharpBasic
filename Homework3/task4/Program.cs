using System;

namespace task4
{
    class Program
    {
        static double Soberi(double num1, double num2)
        {
            return num1 + num2;
        }

        static double Odzemi(double num1, double num2)
        {
            return num1 - num2;
        }

        static double Mnozi(double num1, double num2)
        {
            return num1 * num2;
        }

        static double Deli(double num1, double num2)
        {
            return num1 / num2;
        }

        static void Kalkulator(string theOperator, double number1, double number2)
        {
            double result;
            switch (theOperator)
            {
                case "+":
                    result = Soberi(number1, number2);
                    Console.WriteLine($"The sum of the two numbers is {result}");
                    break;

                case "-":
                    result = Odzemi(number1, number2);
                    Console.WriteLine($"The substraction of the two numbers is {result}");
                    break;

                case "*":
                    result = Mnozi(number1, number2);
                    Console.WriteLine($"The multiplication of the two numbers is {result}");
                    break;


                case "/":
                    result = Deli(number1, number2);
                    Console.WriteLine($"The division of the two numbers is {result}");
                    break;

                default:
                    Console.WriteLine("Wrong input!");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number :");

            string number1 = Console.ReadLine();

            bool checkNumber1 = double.TryParse(number1, out double parsedNumber1);


            Console.WriteLine("Enter the second number :");

            string number2 = Console.ReadLine();

            bool checkNumber2 = double.TryParse(number2, out double parsedNumber2);

            if (checkNumber1 == true && checkNumber2 == true)
            {
                Console.WriteLine("Enter the operation :");

                string o = Console.ReadLine();

                if (o == "+" || o == "-" || o == "*")
                {
                    Kalkulator(o, parsedNumber1, parsedNumber2);
                }

                else if (o == "/" && parsedNumber2 == 0)
                { //ako slucajno na userot mu tekne da podeli so 0
                    Console.WriteLine("You cannot divide with zero!");
                    Console.ReadLine();
                    return;
                }

                else
                {
                    Console.WriteLine("The operator is not valid!");
                    Console.ReadLine(); //userot da moze da ja procita porakata pred da se iskluci konzolata i da zavrsi programata
                    return;
                }


            }
            else
            {
                Console.WriteLine("Enter valid numbers!");
                Console.ReadLine();
                return;
            }
            Console.ReadLine();
        }
    }
}
