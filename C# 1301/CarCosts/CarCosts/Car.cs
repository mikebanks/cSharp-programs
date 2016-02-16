using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarCosts
{
    class Car
    {
        public Car(String thisName, Double thisMPG)
        {
            name = thisName;
            mpg = thisMPG;
            
        }
        private string name;
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private double mpg;
        public Double MPG
        {
            get
            {
                return mpg;
            }
            set
            {
                mpg = value;
            }
        }

        public override String ToString()
        {
            Console.WriteLine("============");
            return String.Format("This Car's Name is: {0}. This Car's MPG is: {1}.", Name, MPG);
            Console.WriteLine("============");
        }

        public Double carTotal;
        public void yearlyCost(double cost, double miles)
        {
            Double total = (miles / mpg) * cost;
            carTotal = total;
            Console.WriteLine("============");
            Console.WriteLine("The Cost of Gasoline for {0} is: {1}. {0} has driven {2} Miles.", Name, MPG, miles);
            Console.WriteLine("This total cost of driving {0} is: {1:C}", Name, total);            
        }
    }
}
