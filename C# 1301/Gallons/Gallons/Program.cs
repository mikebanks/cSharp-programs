using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 
 * 
 */ 
namespace Gallons
{
    class Program
    {
        static void Main(string[] args)
        {
            Double miles_driven, price_gallon, cheaper, higher, difference;
            Double old_car, new_car, newDifference,years;

            Console.WriteLine("Input the number of miles driven each year:");
            miles_driven = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the price per gallon:");
            price_gallon = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the mpg of the cheaper car:");
            cheaper = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the mpg of the more expense car:");
            higher = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input price difference for better model:");
            difference = Convert.ToDouble(Console.ReadLine());

            old_car = (miles_driven / cheaper) * price_gallon;
            new_car = (miles_driven / higher) * price_gallon;
            newDifference = new_car - old_car;
            years =  Math.Round(Math.Abs(difference / newDifference), 2);

            Console.WriteLine("The cost using the old car is: {0:C}", old_car);
            Console.WriteLine("The cost using the new car is: {0:C}", new_car);
            Console.WriteLine("Cost Difference is: {0:C}", newDifference);
            Console.WriteLine("It will take {0} years to break even", years);

            Console.ReadKey();
        }
    }
}
