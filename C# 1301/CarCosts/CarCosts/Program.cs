using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Homework #9: Michael Banks
 * This Program Creates a Car class with a name and miles per gallon. Creates a set and get methods for each property plus a ToString method. 
 * Adds a yearlyCost method that accepts the cost of gasoline and the number of miles driven in a year, and returns the cost of driving using the mpg, cost of gasoline, and miles driven.
 */

namespace CarCosts
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Kreature = new Car("Kreature", 32.00);
            Car Dobby = new Car("Dobby", 20.15);

            Kreature.yearlyCost(3.51, 2500);
            Console.WriteLine("============");
            Dobby.yearlyCost(3.51, 2250);

            Console.WriteLine("============");

            if (Kreature.carTotal < Dobby.carTotal)
            {
                Console.WriteLine(Kreature.ToString());
                Console.WriteLine("{0} is more cost efficient.", Kreature.Name);
            }
            else
            {
                Console.WriteLine(Dobby.ToString());
                Console.WriteLine("{0} is more cost efficient.", Dobby.Name);
            }
            
            Console.ReadKey();
        }
    }
}
