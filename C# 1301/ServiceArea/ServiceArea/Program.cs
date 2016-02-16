using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Homework #11: Michael Banks
 * This program tells the user if they are within the company’s service area according to their zip code. 
 */

namespace ServiceArea
{
    class Program
    {
        static void Main(string[] args)
        {          
            int[] Area = {30901,30903,30904,30905,30906,30907,30909,30910,30916,30917};
            bool test = false;
           
            Console.Write("Please enter your zipcode: ");
            int zipCode = Convert.ToInt32(Console.ReadLine());

            for (int count = 0; count < Area.Length; count++)
            {
                if (zipCode == Area[count])
                    test = true;
                else
                    test = false;
            }

            if (test)
            Console.WriteLine("We offer service in your area.");           
            else
            Console.WriteLine("We currently don't provide service in zipcode: {0}", zipCode);
                
            Console.ReadKey();
        }
    }
}
