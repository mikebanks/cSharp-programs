using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace projZ
{
    public class Infected : Person
    {
        private int mCount = 0;
        public override void MoveMe(List<MyObject> myObjects)
        {
            mCount++;
            if (mCount > randomNumbers.Next(5, 35) + 5)
            {
                Zombie z = new Zombie(); z.X = X; z.Y = Y;
                z.Location = new Point(X, Y);
                TopLevelControl.Controls.Add(z);
                myObjects.Add(z);

                TopLevelControl.Controls.Remove(this);
                myObjects.Remove(this);
            }
            else
                base.MoveMe(myObjects);
        }

        public Infected()
        {
            Image = Image.FromFile("PicInfected.jpg");
            Size = Image.Size;

            X = randomNumbers.Next(40, 595);
            Y = randomNumbers.Next(40, 457);
            Location = new Point(X, Y);
        }
    }
}
