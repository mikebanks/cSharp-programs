using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace projZ
{
    public class Person : MyObject
    {
        public override void MoveMe(List<MyObject> myObjects)
        {
            if (X + xmove + 25 > TopLevelControl.Width)
                xmove = -randomNumbers.Next(1, 7);
            else if (X + xmove <= 0)
                xmove = randomNumbers.Next(1, 7);
            if (Y + ymove + 25 > TopLevelControl.Height)
                ymove = -randomNumbers.Next(1, 6);
            else if (Y + ymove <= 0)
                ymove = randomNumbers.Next(1, 6);

            X = X + xmove;
            Y = Y + ymove;
            Location = new Point(X, Y);
        }

        private int xmove, ymove;

        public Person()
        {
            xmove = randomNumbers.Next(-3, 8);
            ymove = randomNumbers.Next(-1, 6);
            Image = Image.FromFile("PicPerson.jpg");

            Size = Image.Size;
            X = randomNumbers.Next(5, 265);
            Y = randomNumbers.Next(3, 245);
            Location = new Point(X, Y);
        }
    }
}
