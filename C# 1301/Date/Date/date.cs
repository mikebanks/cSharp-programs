using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Date
{
    public class Date
    {
        private int day;
        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                if ((value > 0) && (value <= DaysInMonth()))
                    day = value;
                else
                    throw new ArgumentException("Invalid value for Date's Day: " + value);
            }
        }
                
        private int month;
        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                if ((value > 0) && (value < 13))
                    month = value;
                else
                    throw new ArgumentException("Invalid value for Date's Month: " + value);
            }
        }

        public int Year { get; set; }

    
        public  Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public  Date()
        {
            Day = 1;
            Month = 1;
            Year = 1;
        }

        public void set(int day, int month, int year = 2020) //DateTime.Now.Year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public void set(string str)
        {
            string tmpStr = str.Substring(0,2);
            int month = Convert.ToInt32(tmpStr);

            tmpStr = str.Substring(3, 2);
            int day = Convert.ToInt32(tmpStr);

            tmpStr = str.Substring(6, 4);
            int year = Convert.ToInt32(tmpStr);
            set(day, month, year);
        }

        public static int DaysInMonth(int aMonth, int aYear)
        {
            int numDays = 31;
            switch (aMonth)
            {
                case 4:
                case 6:
                case 9:
                case 11: numDays = 30;
                    break;
                case 2: if (((aYear % 4 == 0) && (aYear % 100) != 0) || (aYear % 400 == 0))
                        numDays = 29;
                    else
                        numDays = 28;
                    break;
            }
            return numDays;
        }

        public int DaysInMonth()
        {
            int Days = 31;
            switch (Month)
            {
                case 4:
                case 6:
                case 9:
                case 11:	Days = 30;
                            break;
                case 2: if( ((Year%4==0) && (Year%100)!=0) || (Year%400==0) )
                            Days = 29;
                        else
                            Days = 28;
                            break;
            }
            return Days;
        }
        
        public override String ToString()
        {
            return Day + "/" + Month + "/" + Year;
        }
    }
}
