using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crazy_Uncle
{
    public class Tablet:Devices
    {        
        public Tablet()
        { 
            
        }

        public Tablet(double Aprice, double AscreenSize, double Aweight)
        {                      
            while (AscreenSize < 0 || AscreenSize > 6)
            {
                Console.WriteLine("Your Screensize can only be between 0 and 35.");
                Console.WriteLine("Please re-enter a Screensize: ");
                AscreenSize = Convert.ToDouble(Console.ReadLine());
            }
            
            price = Aprice;
            screensize = AscreenSize;
            weight = Aweight;
        }

        public override string ToString()
        {
            return ("" + price);
        }
    }
}
