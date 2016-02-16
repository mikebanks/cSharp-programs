using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace SpreedRaacer
{
    class Car
    {
        const int hWidth = 20, vWidth = 9;
        const int hHeight = 9, vHeight = 20;
        int x, y, width = hWidth, height = hHeight;
        int xmove = 3, ymove = 0;
        int xMin = 12, xMax = 430;
        int yMin = 5, yMax = 405;
        Brush myBrush;
        int speed;

        public Car(int newX, int newY, Brush newBrush, int newSpeed)
        {
             x = newX;
            y = newY;
            speed = newSpeed;
            myBrush = newBrush;
        }
        // for version 2.0, ignore newBrush and speed, use them in version 2.1
        
        public void Draw(Graphics g)
        {
            if (width > height)     // going horizontal 
            {
                g.FillRectangle(myBrush, x, y, width, height);
                g.FillRectangle(Brushes.DarkBlue, x + 4, y - 2, 5, 3);  // window
                g.FillEllipse(Brushes.Black, x + 3, y + 4, 4, 5);       // left tire
                g.FillEllipse(Brushes.Black, x + width - 7, y + 4, 4, 5);   // right tire
            }

            else if (width < height)     // going horizontal 
            {
                g.FillRectangle(myBrush, x, y, width, height);
                g.FillRectangle(Brushes.DarkBlue, x + 4, y - 2, 5, 3);  // window
                g.FillEllipse(Brushes.Black, x + 3, y + 4, 4, 5);       // left tire
                g.FillEllipse(Brushes.Black, x + width - 7, y + 4, 4, 5);   // right tire
            }
            
            else                    // going vertical
            {
                g.FillRectangle(myBrush, x, y, width, height);
                g.FillRectangle(Brushes.DarkBlue, x + 4, y - 2, 5, 3);  // window
                g.FillEllipse(Brushes.Black, x + 3, y + 4, 4, 5);       // left tire
                g.FillEllipse(Brushes.Black, x + width - 7, y + 4, 4, 5);   // right tire
                g.FillEllipse(Brushes.Black, x + 3, y + 4, 4, 5);       // left tire
                g.FillEllipse(Brushes.Black, x + width - 7, y + 4, -4, -5);   // right tire

            }
        }
        // some of the code from version 1's OnPaint

        public void Move()
        {
            x = x + xmove;
            y = y + ymove;
            if (x > xMax && ymove == 0)     // go down right side
            {
                x = xMax;
                xmove = 0;
                ymove = speed;
                width = vWidth;
                height = vHeight;
            }
            else if (x < xMin && ymove == 0)    // go up left side
            {
                x = xMin;
                xmove = 0;
                ymove = -speed;
                width = vWidth;
                height = vHeight;
            }

            if (y > yMax && xmove == 0)     // go across bottom
            {
                y = yMax;
                xmove = -speed;
                ymove = 0;
                width = hWidth;
                height = hHeight;
            }
            else if (y < yMin && xmove == 0)    // go across top
            {
                y = yMin;
                xmove = speed;
                ymove = 0;
                width = hWidth;
                height = hHeight;
            }

        }
        // some of the code from version 1's Ticker method

    }
}
