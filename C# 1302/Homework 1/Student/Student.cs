using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Student
    {
        private string P_name;
        private bool P_currStudent;
        private int P_classification;

        public Student(String a_name, bool a_currStudent, int a_classification)
        {
            P_name = a_name;
            P_currStudent = a_currStudent;
            P_classification = a_classification;
        }
        public string name
        {
            get { return P_name; }
            set { P_name = value; }
        }

        public bool currStudent
        {
            get { return P_currStudent; }
            set { P_currStudent = value; }
        }

        public int classification
        {
            get { return P_classification; }
            set
            {
                if (value > 8 || value < 0)
                    throw new Exception("Your classification value is not valid");
                else
                    P_classification = value;
            }
        }

        public override string ToString()
        {
            return P_name + " is a current student: " + P_currStudent + ".S " + P_classification + " year(s) of college experience.";
        }
    }
}
