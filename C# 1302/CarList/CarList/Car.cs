using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInheritance
{
    public class Car:Vehicle
    {
        public Car(){ }

        public Car(String aMake, String aModel, double aCost, double aMPG, int numDoors)
            :base(aMake, aModel, aCost, aMPG)
        {
            make = aMake;
            model = aModel;
            Cost = aCost;
            MPG = aMPG;
            Doors = numDoors;
        }

        private int mDoors;
        public int Doors 
        { 
            get { return mDoors; }
            set
            {
                if (value >= 0 && value <= 6)
                    mDoors = value;
            } 
        }

        public double Score()
        {
            return base.score() - 10 * Doors;
        }

        public override string ToString()
        {
            return base.ToString() + "and has" + Doors + "doors.";
        }
    
}
}
