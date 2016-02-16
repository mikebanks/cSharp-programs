using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Homework ~ Michael Banks
 * A Class and program that set and get information.
 * Using a constructor
 * 
 */ 
namespace Profile
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile user = new Profile("Mike", 20, 1, "Hi");

            Console.WriteLine("Name: {0}, Age: {1}, Weight: {2}", user.Name, user.Age, user.ID);
            Console.WriteLine("{0}", user.ToString());
            
            Console.ReadKey();
        }
    }
}
