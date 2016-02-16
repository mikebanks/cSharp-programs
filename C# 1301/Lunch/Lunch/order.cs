using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lunch
{
    class order
    {
        private Double CheeseBurger;
        private Double FrenchFries;
        private Double IcedTea;
        private String Cooked;
        
        public order(double Burgers, string cooked, double Fries, double Teas)
        {
            CheeseBurger = Burgers;
            FrenchFries = Fries;
            IcedTea = Teas;
            Cooked = cooked;
        }

        public Double cheeseburger
        {
            get{return CheeseBurger;}
            set{CheeseBurger = value;}
        }

        public Double frenchfries
        {
            get{return FrenchFries;}
            set{FrenchFries = value;}
        }

        public Double icedtea
        {
            get{return IcedTea;}
            set{IcedTea = value;}
        }
        
        public override string ToString()
        {
            Console.WriteLine("=====");
            return string.Format("Your burger will be cooked {0}.", Cooked);
        }

        public void getCost(int Burgers, int Fries, int Teas)
        {
            double total = (Burgers * CheeseBurger) + (Fries * FrenchFries) + (Teas * IcedTea);
            Console.WriteLine("You Ordered: {0} Cheeseburger(s), {1} Frie(s), and {2} IcedTea(s).", Burgers, Fries, Teas);
            Console.WriteLine("Your total is: {0:C}", total);
            Console.WriteLine("=====");
        }

        public void getCostDiscount(int Burgers, int Fries, int Teas, double discount)
        {
            double total = (Burgers * CheeseBurger) + (Fries * FrenchFries) + (Teas * IcedTea);
            total -= (total * (discount/100));
            Console.WriteLine("You Ordered: {0} Cheeseburger(s), {1} Frie(s), and {2} IcedTea(s).", Burgers, Fries, Teas);
            Console.WriteLine("Your total, with Discount, is: {0:C}", total);
            Console.WriteLine("=====");
        }
    }
}
