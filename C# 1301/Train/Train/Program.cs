using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Double Dist= 0, Time = 0, initTrain1 = 0;

            Console.WriteLine("Please Enter the Positon of Train #1: ");
            double train1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Please Enter the Speed of Train #1: ");
            double train1speed = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter the Positon of Train #2: ");
            double train2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter the Speed of Train #2: ");
            double train2speed = Convert.ToDouble(Console.ReadLine());

            initTrain1 = train1;

            while (train1 > train2)
            {
                Console.WriteLine("Train #1 Must be moving toward Train #2. Please Renter");
                Console.WriteLine("Please Enter the Positon of Train #1: ");
                train1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Enter the Positon of Train #2: ");
                train2 = Convert.ToDouble(Console.ReadLine());
            }

                if (train1 > train2)
                {
                   Time = (train1 - train2) / (train1speed + train2speed);
                   
                    while (train1 != train2)
                    {
                        train2++;
                        train1--;
                        count++;
                        Console.WriteLine("{0} Hours has passed: Train 1's Position is: {1} and Train 2's Position is: {2}", count, train1, train2);
                    }
                }

                if (train1 < train2)
                {
                    Time = (train2 - train1) / (train1speed + train2speed);

                    while (train1 != train2)
                    {
                        train2--;
                        train1++;
                        count++;
                        Console.WriteLine("{0} Hours has passed: Train 1's Position is: {1} and Train 2's Position is: {2}", count, train1, train2);
                    }
                }

            Console.WriteLine("Colision");

            Dist = initTrain1 + (train1speed * Time);

            Console.WriteLine("The time of the collision is: {0} and The distance the first train traveled is: {1} ", Time, Dist);
            Console.ReadKey();
        }
    }
}
