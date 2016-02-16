using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crazy_Uncle
{
    public class SmartPhone:Devices
    {

        double phoneNumber;

        public SmartPhone()
        { 
            
        }

        public SmartPhone(double Aprice, double AscreenSize, double Aweight, double AphoneNumber)
            
        {
            price = Aprice;

            while (AscreenSize < 0 || AscreenSize > 6)
            {
                Console.WriteLine("Your Screensize can only be between 0 and 35.");
                Console.WriteLine("Please re-enter a Screensize: ");
                AscreenSize = Convert.ToDouble(Console.ReadLine());
            }

            screensize = AscreenSize;

            weight = Aweight;

            String StringNumber = Convert.ToString(AphoneNumber);
            while (StringNumber.Length != 10)
            {
                Console.WriteLine("Your phone number can only be 10 Digits: ex~ 7061234567");
                Console.WriteLine("Please re-enter your phone number: ");
                StringNumber = Console.ReadLine();
            }

            phoneNumber = Convert.ToDouble(StringNumber);
        }

        public override string ToString()
        {
            return ("" + price);
        }
    }
}
