using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;

            Console.Write("Enter First integer ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second integer ");
            number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 == number2)
                Console.WriteLine("{0} == {1}", number1, number2);

            if (number1 != number2)
                Console.WriteLine("{0} != {1}", number1, number2);

            if (number1 > number2)
                Console.WriteLine("{0} > {1}", number1, number2);

            if (number1 < number2)
                Console.WriteLine("{0} < {1}", number1, number2);

            if (number1 <= number2)
                Console.WriteLine("{0} <= {1}", number1, number2);

            if (number1 >= number2)
                Console.WriteLine("{0} >=i {1}", number1, number2);
        }
    }
}
