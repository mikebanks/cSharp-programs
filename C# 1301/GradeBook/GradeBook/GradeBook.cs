using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class GradeBook
    {
        public string CourseName
        {
            get; set;
        }

        public GradeBook(string name)
        {
            CourseName = name;
        }

        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to the grade book for\n{0}!", CourseName);
        }
    }

