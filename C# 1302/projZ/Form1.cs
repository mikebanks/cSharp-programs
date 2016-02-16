using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projZ
{
    public partial class Form1 : Form
    {
        Button btnDone;
        protected static Random randomNumbers = new Random();

        Label lblEmpty = new Label();
        Timer timer = new Timer();

        // ========= Create a list that holds MyObjects =======================================
        List<MyObject> TheList = new List<MyObject>();
        
        // ====================================================================================

        public Form1()
        {
            BackgroundImage = Image.FromFile("PicMap2.jpg");
            Size = new Size(BackgroundImage.Width - 25, BackgroundImage.Height - 25);

            timer.Interval = 1;
            timer.Tick += new EventHandler(Ticker);
            timer.Start();            

            btnDone = new Button();
            btnDone.Location = new Point(Size.Width - 90, Size.Height - 50);
            btnDone.Text = "Exit";
            Controls.Add(btnDone);
            btnDone.Click += new EventHandler(btnExitHandler);

            Text = "Zombies Simulation";
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            btnDone.Location = new Point(100, Size.Height - 90);


            // ===== Add some Person, Infected, and Zombie objects to your list ===================
            int count = 0;

            Random rnd1 = new Random();

            while (count != rnd1.Next(0,100))
            {
                TheList.Add(new Person());
                TheList.Add(new Infected());
                TheList.Add(new Zombie());
            }        

            // ====================================================================================
            
            foreach (MyObject m in TheList) // put your list's name in the blank
                Controls.Add(m);           
            
            // ====================================================================================

        }

        private void btnExitHandler(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void Ticker(object sender, EventArgs e)
        {
            // ===== for loop that calls MoveMe method on each object in your list ================
            // =====  for list class, use ______.Count instead of ______.Length

            for (int i = 0; i < 100; i++ )
            {
                TheList[i].MoveMe(TheList);
            }
                



            // ====================================================================================
            btnDone.Location = new Point(btnDone.Location.X + randomNumbers.Next(-3, 5), btnDone.Location.Y);

        }
    }

}
