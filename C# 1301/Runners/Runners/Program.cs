using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * ===================================================================================================
 * Homework 4 by: Michael Banks
 * 
 * This program asks the user for names of three runners and the time it took them to finish a race.
 * The program prints out which runner was first, second, and third.
 * ===================================================================================================
 */
namespace Runners
{
    class Program
    {
        static void Main(string[] args)
        {
            int t1, t2, t3;
            int first, second, third;
            string r1, r2, r3;

            Console.WriteLine("Please Enter the name of the runner #1:");
            r1 = Console.ReadLine();

            Console.WriteLine("Please Enter the time of {0}:", r1);
            t1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter the name of the runner #2:");
            r2 = Console.ReadLine();

            Console.WriteLine("Please Enter the time of {0}:", r2);
            t2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter the name of the runner #3:");
            r3 = Console.ReadLine();

            Console.WriteLine("Please Enter the time of {0}:", r3);
            t3 = Convert.ToInt32(Console.ReadLine());

            if (t1 < t2)
            {
                if (t1 < t3)
                {
                    first = t1;
                    if (t2 < t3)
                    {
                        second = t2;
                        third = t3;
                        Console.WriteLine("The winner is {0}. Second place is {1}. Third place is {2}.", r1, r2, r3);
                    }
                    else
                    {
                        second = t3;
                        third = t2;
                        Console.WriteLine("The winner is {0}. Second place is {1}. Third place is {2}.", r1, r3, r2);
                    }
                }
            }

            if (t2 < t1)
            {
                if (t2 < t3)
                {
                    first = t2;
                    if (t1 < t3)
                    {
                        second = t1;
                        third = t3;
                        Console.WriteLine("The winner is {0}. Second place is {1}. Third place is {2}.", r2, r1, r3);
                    }
                }
                else
                {
                    second = t3;
                    third = t1;
                    Console.WriteLine("The winner is {0}. Second place is {1}. Third place is {2}.", r2, r3, r1);
                }
            }

            else 
            {
                if (t3 < t2)
                {
                    first = t3;
                 if (t1 < t2)
                    {
                        second = t1;
                        third = t2;
                        Console.WriteLine("The winner is {0}. Second place is {1}. Third place is {2}.", r3, r1, r2);
                    }
                }
                else
                {
                    second = t2;
                    third = t1;
                    Console.WriteLine("The winner is {0}. Second place is {1}. Third place is {2}.", r3, r2, r1);
                }
            }

            Console.ReadKey();
       }
    }
}
