using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 *Homework #3 ~ Michael D. Banks
 *
 * Thia Program calculates a heating fuel bill.The programs check to see If the customer is a senior (over 65), they are allowed a 5% discount.
 * If and only if the customer is not a senior, it checks if they qualify for a low income discount of 4%.
 */

namespace FuelBill
{
    class Program
    {
        static void Main(string[] args)
        {
            double gPurcashed = 0, perGallon = 0, surcharge = 0, discount = 0, income, age, price;

            //Quality Control
            Console.WriteLine("Please enter your age");
            age = Convert.ToDouble(Console.ReadLine());

            while (age < 0)
            {
                Console.WriteLine("ERROR!!! You cannot be {0} years old. Please enter a number higher than 0.", age);
                age = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Please Enter your income");
            income = Convert.ToDouble(Console.ReadLine());

            while (income < 0)
            {
                Console.WriteLine("ERROR!!! You cannot have an income of {0:C}. Please enter a number higher than 0.", gPurcashed);
                income = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Please Enter the amount of gallons you wish to purchase");
            gPurcashed = Convert.ToDouble(Console.ReadLine());

            while (gPurcashed < 0)
            {
                Console.WriteLine("ERROR!!! You cannot purchase {0} Gallons. Please enter a number higher than 0.", gPurcashed);
                gPurcashed = Convert.ToDouble(Console.ReadLine());
            }

            //Prices
            if (gPurcashed > 0 && gPurcashed < 100)
            {
                perGallon = 2.29;
                surcharge = 29.99;
            }

            if (gPurcashed >= 100 && gPurcashed < 250)
            {
                perGallon = 2.24;
                surcharge = 24.99;
            }
            
            if (gPurcashed >= 250)
            {
                perGallon = 2.19;
                surcharge = 19.99;
            }

            //Subtotal
            price = (gPurcashed * perGallon) + surcharge;
            Console.WriteLine("Your SubTotal is: {0:C}", price);

            //Discounts
            if (age > 65)
            {
                discount = 0.05;
                price = price - (price * discount);
                Console.WriteLine("Senior Citizen Discout Applied!");
            }

            if (age <= 65 && income < 30000)
            {
                discount = 0.04;
               price = price - (price * discount);
                Console.WriteLine("Income Discount");
            }

            Console.WriteLine("Your Total is: {0:C}", price);
            Console.ReadKey();
        }
    }
}
