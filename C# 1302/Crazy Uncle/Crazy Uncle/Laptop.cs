using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crazy_Uncle
{
    public class Laptop:Devices
    {        
        string keyboard;
        public Laptop()
        {

        }

        public Laptop(double Aprice, double AscreenSize, double Aweight, String Akeyboard)            
        {            
            price = Aprice;

            while (AscreenSize < 0 || AscreenSize > 35)
            {
                Console.WriteLine("Your Screensize can only be between 0 and 35.");
                Console.WriteLine("Please re-enter a Screensize: ");
                AscreenSize = Convert.ToDouble(Console.ReadLine());
            }

            screensize = AscreenSize;
            weight = Aweight;
            
            while (Akeyboard != "standard" && Akeyboard != "compact" && Akeyboard != "ergonomic" && Akeyboard != "wireless")
            {
                Console.WriteLine("Your Keyboard type can only be one of the following: standard, compact, ergonomic, or wireless (case-sensitive");
                Console.WriteLine("Please re-enter a a keyboard type: ");
                Akeyboard = Console.ReadLine();
            }

            keyboard = Akeyboard;
        }

        public override string ToString()
        {
            return (""+ price);
        }
    }
}
