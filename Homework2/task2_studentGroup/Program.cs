using System;

namespace task2_studentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ovaa zadacha bi mozhela da se reshi so funkcija za reshenieto da bide pooptimalno

            string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = new string[] { "Elena", "Maja", "Angela", "Kiki", "Nina" };

            Console.WriteLine("Enter students group( 1 or 2 )");

            string number1 = Console.ReadLine();

            bool checkNumber1 = int.TryParse(number1, out int parsedNumber1);

            if (checkNumber1 && (parsedNumber1 == 1 || parsedNumber1 == 2))
            {
                if (parsedNumber1 == 1)
                {
                    Console.WriteLine("We are printing the first group!");
                    foreach (string group1 in studentsG1)
                    {
                        Console.WriteLine(group1);
                    }
                }
                else
                {
                    Console.WriteLine("We are printing the second group!");
                    foreach (string group2 in studentsG2)
                    {
                        Console.WriteLine(group2);
                    }
                }
            }

            else
            {

                Console.WriteLine("Wrong input!");
            }

            Console.ReadLine();
        }
    }
}
