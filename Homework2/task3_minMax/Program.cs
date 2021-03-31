using System;
using System.Linq;

namespace task3_minMax
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("========PRV NACIN========");

            int[] integers = new int[10];

            Random rand = new Random();

            for (int i = 0; i <= 9; i++)
            {
                int R = rand.Next(50, 150); //random broevi vo opsegot od 50 do 150
                integers[i] = R;
            }

            int maximum = integers.Max();
            int minimum = integers.Min();

            Console.WriteLine("Our random generated array is:");
            foreach (int ints in integers)
            {
                Console.Write($"{ints}\t");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"The maximum value is  {maximum} ");
            Console.WriteLine($"The minumum value is  {minimum}");


            Console.WriteLine("\n");
            Console.WriteLine("========VTOR NACIN========");

            int[] someInts = new int[] { 5, 454, 36, 7, 5, 3, 2, 55, 45, 12 };

            int maksimalen = someInts[0];
            int minimalen = someInts[0];

            for (int j = 0; j <= 9; j++)
            {
                if (someInts[j] > maksimalen)
                {
                    maksimalen = someInts[j];
                }

                if (someInts[j] < minimalen)
                {
                    minimalen = someInts[j];
                }

            }
            Console.WriteLine($"Maksimalna vrednost: {maksimalen} ");
            Console.WriteLine($"Minimalen vrednost:  {minimalen}");


            Console.ReadLine();
        }
    }
}
