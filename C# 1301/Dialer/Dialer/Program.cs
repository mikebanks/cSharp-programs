using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dialer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a letter:");
            String N = Console.ReadLine();
            Char L = Char.ToLower(Convert.ToChar(N));
           
            switch (L)
            {
                case 'a':
                    Console.WriteLine("2");
                    break;
                case 'b':
                    Console.WriteLine("2");
                    break;
                case 'c':
                    Console.WriteLine("2");
                    break;
                case 'd':
                    Console.WriteLine("3");
                    break;
                case 'e':
                    Console.WriteLine("3");
                    break;
                case 'f':
                    Console.WriteLine("3");
                    break;
                case 'g':
                    Console.WriteLine("4");
                    break;
                case 'h':
                    Console.WriteLine("4");
                    break;
                case 'i':
                    Console.WriteLine("4");
                    break;
                case 'j':
                    Console.WriteLine("5");
                    break;
                case 'k':
                    Console.WriteLine("5");
                    break;
                case 'l':
                    Console.WriteLine("5");
                    break;
                case 'm':
                    Console.WriteLine("6");
                    break;
                case 'n':
                    Console.WriteLine("6");
                    break;
                case 'o':
                    Console.WriteLine("6");
                    break;
                case 'p':
                    Console.WriteLine("7");
                    break;
                case 'r':
                    Console.WriteLine("7");
                    break;
                case 's':
                    Console.WriteLine("7");
                    break;
                case 't':
                    Console.WriteLine("8");
                    break;
                case 'u':
                    Console.WriteLine("8");
                    break;
                case 'v':
                    Console.WriteLine("8");
                    break;
                case 'w':
                    Console.WriteLine("9");
                    break;
                case 'x':
                    Console.WriteLine("9");
                    break;
                case 'y':
                    Console.WriteLine("9");
                    break;
                default:
                    Console.WriteLine("Error That letter does not exist! ");
                    break;
            }

            Console.ReadKey();
        }
    }
}
