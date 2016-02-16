using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace projZ
{
    public abstract class MyObject : PictureBox
    {
        protected static Random randomNumbers = new Random();

        private int mPositionX;
        public int X
        {
            get { return mPositionX; }
            set
            {
                if (value >= 0 && TopLevelControl != null && (value - Width) < TopLevelControl.Width)
                    mPositionX = value;
                else if (value >= 0)
                    mPositionX = value;
            }
        }

        private int mPositionY;
        public int Y
        {
            get { return mPositionY; }
            set
            {
                if (value >= 0 && TopLevelControl != null && (value - Height) < TopLevelControl.Height)
                    mPositionY = value;
                else if (value >= 0)
                    mPositionY = value;
            }
        }

        public virtual void MoveMe(List<MyObject> myObjects)
        { }
    }


}
