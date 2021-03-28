using System;

namespace exercise5_switchExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a NUMBER :");

            string number = Console.ReadLine();

            bool checkNumber = int.TryParse(number, out int parsedNumber);

   
            switch (parsedNumber)
            {
                case 1:
                    Console.WriteLine("You got a new car!");
                    break;

                case 2:
                    Console.WriteLine("You got a new plane!");
                    break;

                case 3:
                    Console.WriteLine("You got a new bike!");
                    break;

                default:
                    Console.WriteLine("Wrong input!");
                    break;
            
                }
         
            Console.ReadLine();
        }
    }
}
