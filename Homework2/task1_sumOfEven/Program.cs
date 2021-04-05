using System;

namespace task1_sumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] someIntegers = new int[6];
            string userInput;
          //  int convertInt;
            bool check;
            //bool flag = false;
            int total = 0;

            //   for (int i = 0; i <= 5; i++)
            for (int i = 0; i < someIntegers.Length; i++)
            {
                Console.WriteLine($"Enter integer no.{i + 1}:");
                userInput = Console.ReadLine();
                /* convertInt = Convert.ToInt32(userInput);
                someIntegers[i] = convertInt;*/
                check = int.TryParse(userInput, out int parsedNumber);
                if (check)
                {
                    someIntegers[i] = parsedNumber;

                    if (parsedNumber % 2 == 0)
                    {
                        total += parsedNumber;
                    }

                }
                else
                {
                    Console.WriteLine("Wrong input!");
                   // flag = true;
                   // break;//ako korisnikot vnese neshto shto ne e broj,programata skroz kje zavrshi kje mora site broevi odponovo da gi vnesuva
                }

            }
        //    if (flag == false)
          //  {
                Console.WriteLine($"The result is {total}");
          //  }
            Console.ReadLine();
        }
    }
}
