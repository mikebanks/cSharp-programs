using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace projZ
{
    public class Zombie : MyObject
    {
        const int distance = 20;

        public override void MoveMe(List<MyObject> myObjects)
        {
            for (int i = 0; i < myObjects.Count; i++)
            {
                if (myObjects[i].GetType().Name == "Person" &&
                    Math.Abs(X - myObjects[i].X) < distance && Math.Abs(Y - myObjects[i].Y) < distance)
                {
                    int curX = myObjects[i].X;
                    int curY = myObjects[i].Y;
                    TopLevelControl.Controls.Remove(myObjects[i]);               // remove from form
                    myObjects[i] = new Infected();                              // replace in array
                    myObjects[i].X = curX;
                    myObjects[i].Y = curY;
                    myObjects[i].Location = new Point(curX, curY);
                    TopLevelControl.Controls.Add(myObjects[i]);                  // add new control to form
                    return;      // one bite per turn
                }
            }
            //                Location = new Point(Location.X + randomNumbers.Next(-3, 2), Location.Y + randomNumbers.Next(-3, 2));
            //               X = Location.X; Y = Location.Y;

        }

        public Zombie()
        {
            Image = Image.FromFile("PicZombie.jpg");
            Size = Image.Size;
            X = randomNumbers.Next(48, 575);
            Y = randomNumbers.Next(41, 497);
            Location = new Point(X, Y);
        }

    }

}
