using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crazy_Uncle
{
    public abstract class Devices
    {
        public Devices() { }

        public Devices(double Aprice, double AscreenSize, double Aweight)
        {
            price = Aprice;
            screensize = AscreenSize;
            weight = Aweight;
        }

        public double price
        {
            get { return price; }
            
            set
            {
                while (price <= 0)
                {
                    Console.WriteLine("Your Price cannot be less than or equal to 0.");
                    Console.WriteLine("Please re-enter a price: ");
                    price = Convert.ToDouble(Console.ReadLine());
                }
            }
        }    
           
        
        public double screensize
        {
            get{return screensize;}

            set
            {
               
            }
        }
            
           
        public double weight
        {
            get{return weight;}

            set
            {
                while (weight < 0 || weight > 80)
                {
                    Console.WriteLine("Your weight can only be between 0 and 80.");
                    Console.WriteLine("Please re-enter a Weight: ");
                    weight = Convert.ToDouble(Console.ReadLine());
                }
            }
        }     
                    
        public override string ToString()
        {
            return ("" + price);
        }        
    }
}
