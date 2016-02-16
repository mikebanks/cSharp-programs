using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInheritance
{
    public class pickup:Vehicle
    {
        public string CabType { set; get; }

        public pickup() 
        {
                
        }

        public pickup(string aMake, string aModel, string aCabType, double aCost)
           :base(aMake, aModel, aCost, 15)
        {
            CabType = aCabType;
        }

        public override string ToString()
        {
            return base.ToString() + "with a" + CabType; ;
        }

        public double Score()
        {
            return Cost - 100 * MPG;
        }
    }
}
