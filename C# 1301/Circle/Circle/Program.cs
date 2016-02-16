using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * ================================================
 * Michael Banks ~ Homework1
 * This program get the radius of a circle from the user and prints the circle’s diameter, circumference and area.
 * Next the program converts the stored double variables and converts them to an integer.
 * 
 * ================================================
 */
namespace ConsoleApplication2
{
    class Circle
    {
        static void Main(string[] args)
        {
            double radius, circum, diameter, area;

            Console.WriteLine("Enter Radius:");
            radius = Convert.ToDouble(Console.ReadLine());

            diameter = radius * 2;
            area = Math.PI * (radius * radius);
            circum = (2 * Math.PI) * radius;

            Console.WriteLine("This is the Circle's Diameter: {0}", diameter);
            Console.WriteLine("This is the Circle's Circumfrence: {0}", circum);
            Console.WriteLine("This is the Circle's Area: {0} ", area);

            Console.WriteLine("=====================================");
            Console.WriteLine("This is converting everything to int.");
            Console.WriteLine("=====================================");

            int radius2 = Convert.ToInt32(radius);
            int diameter2 = Convert.ToInt32(diameter);
            int circum2 = Convert.ToInt32(circum);
            int area2 = Convert.ToInt32(area);

            Console.WriteLine("This is the Circle's Diameter: {0}", diameter2);
            Console.WriteLine("This is the Circle's Circumfrence: {0}", circum2);
            Console.WriteLine("This is the Circle's Area: {0}", area2);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
