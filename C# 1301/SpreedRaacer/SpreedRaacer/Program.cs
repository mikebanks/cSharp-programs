using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

using SpreedRaacer;

class MainForm : Form
{
    Timer timer = new Timer();
    Car car1;

    MainForm()
    {
        Text = "Speed Racer";        // for the window's title
        Size = new Size(450, 450);
        MaximizeBox = false;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        SetStyle(ControlStyles.UserPaint, true);
        SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        SetStyle(ControlStyles.DoubleBuffer, true);

        Paint += new PaintEventHandler(OnPaint);    // creates an "alarm" that goes off every 8 milliseconds
        

        car1 = new Car(12, 5, Brushes.DeepPink, 3);     // x position, y position, brush, speed
       
    }

    void OnPaint(Object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        car1.Draw(g);
        
    }

    static void Main(string[] args)
    {
        Application.Run(new MainForm());
    }

   
}
