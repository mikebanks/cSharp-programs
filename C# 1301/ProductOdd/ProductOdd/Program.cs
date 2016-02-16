using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Homework #6 ~ Michael Banks
 * This program uses a for loop to calculate the product of the odd integers from 1 to 7
 */
namespace ProductOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=1, count2 = 0;

            for (int count = 1; count <= 8; count++)
            {
                if (count % 2 != 0)
                {
                   sum = count * sum;
                   count2 = count;
                }
            }

            Console.WriteLine("The Sum of the product of odd integers to {0} = {1}", count2, sum);
            Console.ReadKey();
        }
    }
}
