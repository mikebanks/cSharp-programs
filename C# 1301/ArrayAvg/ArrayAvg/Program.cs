using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Homework# 10: Michael Banks
 * This program gets 10 integers from the user and fills an array. After filling the array, print it to the screen.
 * For the second part of the program, calculate the average of all the numbers except leave out the highest and lowest numbers.
 */

namespace ArrayAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[10];
            double sum = 0, high = 0, low = 0;

            Console.WriteLine("Enter your first number: ");
            for (int count = 0; count < Array.Length; count++)
            {
                Array[count] = Convert.ToInt32(Console.ReadLine());

                if (count < 9)
                    Console.WriteLine("Enter another number: ");

                sum += Array[count];
            }

            low = Array[0];
            high = Array[0];

            for (int count = 0; count < Array.Length; count++)
            {
                if (Array[count] <= low)
                    low = Array[count];
                if (Array[count] >= high)
                    high = Array[count];
            }

            Console.Write("\n You entered: ");
            for (int count = 0; count < Array.Length; count++)
            {
                Console.Write("{0}, ", Array[count]);
            }

            Console.WriteLine("\n \nThe Highest number is: {0}", high);
            Console.WriteLine("The Lowest number is: {0}", low);
            Console.WriteLine("The average of the array with the exception of the highest and lowest number is: {0}", ((sum - (high + low)) / 8));

            Console.ReadKey();
        }
    }
}
