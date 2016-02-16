using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

/*
 *  Homework #4: Michael Banks
 *  This program adds code to the main routine to compute the average for each column of the two dimensional array.
 *  It also stores the average for each column in a one dimensional array and then print each number in the array.
 */

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "Lotto.txt";
            if (File.Exists(fileName) == false)
            {
                Console.WriteLine();
                Console.WriteLine("File does not exist");
                Console.Write("Press any key to continue ....");
                Console.ReadKey();
                return;
            }

            StreamReader fileReader = new StreamReader(fileName);
            if (fileReader == null)
            {
                Console.WriteLine();
                Console.WriteLine("Attempt to open file failed ");
                Console.Write("Press any key to continue ....");
                Console.ReadKey();
                return;
            }

            // each row contains 6 numbers where the last number is the mega ball
            // this data is from actual winning numbers from Mega Millions
            double[,] myArray = new double[35, 6];
            string str = fileReader.ReadLine();
            int numRows = 0;
            while (str != null && numRows < myArray.GetLength(0))
            {
                myArray[numRows, 0] = Convert.ToInt32(str);
                for (int col = 1; col < myArray.GetLength(1); col++)
                    myArray[numRows, col] = Convert.ToInt32(fileReader.ReadLine());
                numRows++;
                str = fileReader.ReadLine();
            }

            // Add code to display the 2D array
            for (int row = 0; row < myArray.GetLength(0); row++)
            {                                
                for (int col = 0; col < myArray.GetLength(1); col++)
                {
                    Console.Write(String.Format("{0} ", myArray[row,col]));
                }
                    
            Console.WriteLine("");
            }
                

            // Add code to create a one dimensional array
            double[] myNewArray = new double[6];

            // Compute the average of each column of the 2D array and store the result in the 1D array just created            
            double holderSum = 0;            

            for (int row = 0; row < myArray.GetLength(0); row++)
            {
                for (int col = 0; col < myArray.GetLength(1); col++)
                {
                    holderSum += myArray[row, col];                    
                    myNewArray[col] += holderSum;                    
                }
                                                                   
                holderSum = 0;                                
            }

            for (int col = 0; col < myNewArray.GetLength(0); col++)
                myNewArray[col] = myNewArray[col] / 35;
            // 6 columns in the 2D array --> 6 averages to store in the 1D array
            Console.WriteLine(Environment.NewLine);

            // Add code to display the 1D array holding the averages
            for (int col = 0; col < myNewArray.GetLength(0); col++)
            {
                
                Console.WriteLine(myNewArray[col]);
            }

            Console.WriteLine(); Console.WriteLine();
            Console.Write("Press any key to continue ....");
            Console.ReadKey();
        }
    }

}
