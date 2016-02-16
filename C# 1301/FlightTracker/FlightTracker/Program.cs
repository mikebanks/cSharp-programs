using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlightTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] Seats= new bool[10];
            
            int firstClass = 0;
            int economy = 5;

            

            while (firstClass <5 || economy < 9)
            {
                Console.WriteLine("\n" + "Enter 1 for First Class" + "\n" + "Enter 2 for Economy" + "\n" + "Enter 3 to display Flight");
            int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1 && firstClass < 5)
                {
                    Seats[firstClass] = true;
                    firstClass++;
                }
            
                if (option == 1 && firstClass == 5)
                {
                    Console.WriteLine("\n" + "First Class is Full!");
                    Console.Beep();
                }

                if (option == 2 && economy < 9)
                {
                    Seats[economy] = true;
                    economy++;
                }

                if (option == 2 && economy == 9)
                {
                    Console.WriteLine("\n" + "Economy is Full!");
                    Console.Beep();
                }

                if (option == 3)
                {
                    
                    for (int count = 0; count < Seats.Length; count++)
                    {
                        if (count == 0)
                            Console.WriteLine("\n" + "First Class");
                        if (count == 5)
                            Console.WriteLine("\n" + "Economy");
                        if (Seats[count] == true)                        
                           Console.WriteLine("Seat {0} is Taken", (count + 1));                        
                        if (Seats[count] == false)
                            Console.WriteLine("Seat {0} is Empty", (count + 1));
                    }
                }
            }
       }
    }
}
