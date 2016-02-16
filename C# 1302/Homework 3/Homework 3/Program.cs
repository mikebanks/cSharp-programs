using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Homework #3: Michael Banks
 * Write a method that looks for an egg. 
 * The egg is the value zero and it might be somewhere in an array of integers.
 */

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] eggs = new int[5] {3, 2, 4, 2, 0};          
            eggHunt hunter1 = new eggHunt();

            hunter1.hunt(eggs);
            Console.ReadKey();
        }
    }
}
