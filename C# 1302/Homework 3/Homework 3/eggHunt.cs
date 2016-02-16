using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class eggHunt
    {       

        public void hunt (int[] newArray)
        {
            int position = 0;
            int count = 0;

            if (newArray[0] == 0)
            {
                Console.WriteLine(newArray[0] + "{0}", count);
            }
            else
            {                
                while (newArray[position] != 0)
                {
                    Console.Write(newArray[position]);
                    position = newArray[position];
                    count++;
                }
            }           
            Console.WriteLine("\n" + count); ; 
        }
    }
}
