using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voters
{
    class Program
    {
        static void Main(string[] args)
        {
            int candidate1 = 0, candidate2 = 0, candidate3 = 0, stance1 = 35, stance2 = 55;

            int[] Ballot = new int[200];
            Random randomNumbers = new Random();

            stance1 = randomNumbers.Next(0, 101);
            stance2 = randomNumbers.Next(0, 101);

            for (int count = 0; count < Ballot.Length; count++)
            {
                Ballot[count] = randomNumbers.Next(0, 101);

                if ( Math.Abs((Ballot[count] - stance1 )) < (Math.Abs(Ballot[count] - stance2)))
                    candidate1++;
                else if (Math.Abs((Ballot[count] - stance1)) > (Math.Abs(Ballot[count] - stance2)))
                    candidate2++;
                else
                    candidate3++;
            }

            if (candidate1 > candidate2 && candidate1 > candidate3)
                Console.WriteLine("Candidate #1 is the winner with: {0} votes. \nCandidate #2 has {1} votes \nCandidate #3 has {2} votes.", candidate1, candidate2, candidate3);
            else if (candidate2 > candidate1 && candidate2 > candidate3)
                Console.WriteLine("Candidate #2 is the winner with: {0} votes. \nCandidate #1 has {1} votes \nCandidate #3 has {2} votes.", candidate2, candidate1, candidate3);
            else
                Console.WriteLine("Candidate #3 is the winner with: {0} votes. \nCandidate #2 has {1} votes \nCandidate #1 has {2} votes.", candidate3, candidate2, candidate1);

            Console.ReadKey();
        }
    }
}
