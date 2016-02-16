using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Profile
{
    class Profile
    {
        public Profile(String Name, int Age, int ID, String Status)
        {
            name = Name;
            age = Age;
            id = ID;
            status = Status;
        }

        private String name;
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
               name = value;
            }
        }

        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        private double id;
        public double  ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        private String status = "This is my default status";
        public override string ToString()
        {
            return string.Format("[{0}...]", status);
        }
    }
}
