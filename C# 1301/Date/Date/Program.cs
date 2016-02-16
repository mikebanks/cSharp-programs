using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date1 = new Date();
                date1.Year = 2012;
                date1.Month = 3;
                date1.Day = 5;
                
            Date date2 = new Date();

            Date date3 = new Date(3, 9, 2012);

            

                Console.WriteLine("Day is {0}, Month is {1}, Year is {2}", date1.Day, date1.Month, date1.Year);

                Console.WriteLine("Day is {0}, Month is {1}, Year is {2}", date2.Day, date2.Month, date2.Year);

                Console.WriteLine("Day is {0}, Month is {1}, Year is {2}", date3.Day, date3.Month, date3.Year);
                Console.ReadKey();

        }
    }
}
