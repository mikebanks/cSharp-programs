using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crazy_Cousin
{
    class Program:Class1
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine("Average = {0}", DivMethod());
            for (int i = 0; i < 10; i++)
                Console.WriteLine("Average = {0}", iDivMethod());
        }
    }
}
