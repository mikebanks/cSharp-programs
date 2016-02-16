using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class Date
    {        
        private int mMonth;
        public int Month
        {
            get{ return mMonth;}
            set
            {
                if (value > 0 && value <= 12)
                    mMonth = value;
                else
                    throw new ArgumentOutOfRangeException("There are 12 Months in a year...");
            }
        }

        private int mYear;
        public int Year
        {
            get { return mYear; }
            set
            {
                if (value > 0)
                    mYear = value;
                else
                    throw new ArgumentOutOfRangeException("Your number must be greater than 0");
            }
        }

        private int mDay;
        public int Day
        {
            get { return mDay; }
            set
            {
                if (value > 0 && value <= 31)
                    mDay = value;
                else
                    throw new ArgumentOutOfRangeException("There are from 1 to 31 Days in a month");
            }
        }

        public Date(int aMonth, int aDay, int aYear)
        {
            mMonth = aMonth;
            mDay = aDay;
            mYear = aYear;
        }
    }
}
