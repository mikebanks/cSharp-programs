using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Homework 2 by: Michael Banks
 * 
 * This program takes the total amount and calculate how 
 * much interest you'll pay if you wait one month then pay in full.
 * It converts the interest rate from a percentage to a number (/ 100.0) then change 
 * it from a yearly rate into a monthly rate (/ 12.0). Multiplies this number 
 * with the amount owed. 
 * 
 */

namespace Christmas_Bill
{
    class Program
    {
        static void Main(string[] args)
        {
            double bill, interest, amount;

            Console.WriteLine("Please enter your credit card balance (how much you owe): ");
            bill = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your credit card interest rate: ");
            interest = Convert.ToDouble(Console.ReadLine());            
            
            amount = (((interest / 100) / 12) * bill);
            
            Console.WriteLine("Your fee from your interest is: {0:C}", amount);
            

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
