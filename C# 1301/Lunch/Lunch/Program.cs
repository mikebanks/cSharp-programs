using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lunch
{
    class Program
    {
        static void Main(string[] args)
        {
            order order1 = new order(3.50,"well-done",2.00,2.00);
            
            Console.WriteLine(order1.ToString());

            order1.getCost(1, 1, 1);

            order1.getCostDiscount(1, 1, 1, 10);

            Console.ReadKey();
        }
    }
}
