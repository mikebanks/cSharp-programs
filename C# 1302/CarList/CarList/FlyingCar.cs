using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInheritance
{
    class FlyingCar: Vehicle, IFlyable, IDrivable
    {
        public int Fly()
        {
            return 15;
        }

        public int Drive()
        {
            return 25;
        }

        public double Score()
        {
            return 35;
        }
    }
}
