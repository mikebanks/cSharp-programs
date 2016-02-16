using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInheritance
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<Vehicle> aList = new List<Vehicle>();
            aList.Add(new Car("Ford","Mustang", 20000,20,2));
            aList.Add(new pickup("Toyota", "Tundra", "Extended", 15000));
            aList.Sort();
            aList.Reverse();

            for (int i = 0; i < 10; i++)
                Console.WriteLine(aList[i]);
            
            Vehicle V = new Car();
            Console.WriteLine("V's Score = {0}", V.score());
            V = new pickup();
            Console.WriteLine("V's Score = {0}", V.score());
        
            Random aRan = new Random();
            if (aRan.Next() % 2 == 1)
                V = new Car();
            else
                V = new pickup();
            Console.WriteLine("V's Score = {0}", V.score());

            Car aCar = new Car();
            aCar.make = "Toyota";
            aCar.model = "Rav4";
            aCar.MPG = 30;

            /*
             * less than 0 is 1 < 2
             * Zero if 1 = 2
             * greater than id 1 > 2
             */ 

            Console.ReadKey();

        }
    }
}
