using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crazy_Cousin
{
    class Class1
    {
        private static Random aRan = new Random();
        public static double DivMethod()
        {
            int[] myArray = new int[aRan.Next() % 12];
            for (int i = 0; i < myArray.Length; i++)
                myArray[i] = aRan.Next(0, 95);
            double total = 0;
            for (int i = 0; i < myArray.Length; i++)
                total = total + (double)i / (double)myArray[i];
            
            try
            {
                return total / myArray.Length;
            }
            catch (System.DivideByZeroException ex)
            {
                System.ArgumentException argEx = new System.ArgumentException("There is a strange occurance in", "index", ex);
                throw argEx;
            }
        }

        public static int iDivMethod()
        {
            int[] myArray = new int[aRan.Next() % 12];
            for (int i = 0; i < myArray.Length; i++)
                myArray[i] = aRan.Next(0, 95);
            int iTotal = 0;
            for (int i = 0; i < myArray.Length; i++)
                iTotal = iTotal + i / myArray[i];

            try
            {
                return iTotal / myArray.Length;
            }
            catch (System.DivideByZeroException ex)
            {
                System.ArgumentException argEx = new System.ArgumentException("There is a strange occurance in", "index", ex);
                throw argEx;
            }
        }
    }
}
