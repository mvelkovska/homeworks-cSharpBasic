
using System;

namespace bonusHomework
{
    class Program
    {


        static void Main(string[] args)
        {




            /* int i = 1;
             Console.WriteLine($"        {i} ");//1
             Console.WriteLine($"  {i + 1} {i + 2}  ");//2 3
             Console.WriteLine($"{i + 3} {i + 4} {i + 5} ");//4 5 6 
             Console.WriteLine($" {i + 6} {i + 7} {i + 8} {i + 9} ");// 7 8 9 10
            
            */


            int broj = 1;


            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"   {broj}  ");
                    broj++;

                } 

                Console.WriteLine("");
            }






            Console.ReadLine();

        }
    }
}
