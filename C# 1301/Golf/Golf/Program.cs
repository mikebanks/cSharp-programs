using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Golf
{
    class Program
    {
        static void Main(string[] args)
        {
            int hole = 1, swings = 0, score = 0; 
            String strokes;

            Dice Roll1 = new Dice();

            while (hole < 19)
            {
                swings = Roll1.Roll();

                switch (swings)
                {
                    case 1:
                        strokes = "Eagle";
                        Console.WriteLine("Hole #{0} is a {1}", hole, strokes);
                        score -= 2;
                        break;

                    case 2:
                        strokes = "Birdie";
                        Console.WriteLine("Hole #{0} is a {1}", hole, strokes);
                        score -= 1;
                        break;

                    case 3:
                        strokes = "Par";
                        Console.WriteLine("Hole #{0} is a {1}", hole, strokes);

                        break;

                    case 4:
                        strokes = "Bogey";
                        Console.WriteLine("Hole #{0} is a {1}", hole, strokes);
                        score += 1;
                        break;

                    case 5:
                        strokes = "Double Bogey";
                        Console.WriteLine("Hole #{0} is a {1}", hole, strokes);
                        score += 2;
                        break;

                    case 6:
                        strokes = "Triple Bogey";
                        Console.WriteLine("Hole #{0} is a {1}", hole, strokes);
                        score += 3;
                        break;
                }
                hole++;
                
            }

            if (score > 0)
            Console.WriteLine("Score is {0} above par", score);
            else if (score < 0)
                Console.WriteLine("Score is {0} below par", score);
            else
                Console.WriteLine("Score is par");

            Console.ReadKey();
        }
    }
}
