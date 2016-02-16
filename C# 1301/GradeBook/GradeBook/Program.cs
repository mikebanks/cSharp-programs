using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            GradeBook myGradeBook = new GradeBook("CS101 Introduction to C3 Programming");
            GradeBook myGradeBook1 = new GradeBook("CS102 Data Structures");

            Console.WriteLine("myGradeBook course name is: {0}", myGradeBook);
            Console.WriteLine("myGradeBook1 course name is: {0}", myGradeBook1);
        }
    }

