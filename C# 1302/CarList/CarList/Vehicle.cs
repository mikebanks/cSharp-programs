using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInheritance
{
    public class Vehicle
    {
        public Vehicle()
        {

        }

        public Vehicle(String aMake, string aModel, double aCost, double aMPG) 
        {

        }
        public string make { get; set; }
        public string model { get; set; }

        private double mCost;
        public double Cost;
        public double MPG;

        public virtual double score()
        {
            return Cost - 100 * MPG;
        }

        public override string ToString()
        {
            return make + " " + model;
        }
    }
}
