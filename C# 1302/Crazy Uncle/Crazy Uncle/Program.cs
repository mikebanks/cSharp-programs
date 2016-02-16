using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crazy_Uncle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Devices> DeviceList = new List<Devices>();
           

            double sum = 0;
            double count = 0;

            DeviceList.Add(new Laptop(755, 99, 55, "compact"));
            DeviceList.Add(new Laptop(1022, 8, 75, "wireless"));

            DeviceList.Add(new SmartPhone(500, 5, 99, 7061234567));
            DeviceList.Add(new SmartPhone(250, 4, 10, 123456789099));

            DeviceList.Add(new Tablet(399, 7, 35));
            DeviceList.Add(new Tablet(499, 99, 75));
            
            foreach (Laptop x in DeviceList)
            {
                count += DeviceList.Count();
                sum += Convert.ToDouble(DeviceList.ToString());                
            }
            
            Console.WriteLine("The Average Price of all the devices is: {0:C}",sum/(count/2));
            Console.ReadKey();
        }
    }
}
