using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

class MainForm : Form
{
    Timer timer = new Timer();
    Image background = Image.FromFile("pizza.jpg");
    Image greenPepper2 = Image.FromFile("anchovy.png");
    int x = 0, y = 0, xmove = 3, ymove = 2; int count = 0;
    int x2 = 150, y2 = 80, xmove2 = 4, ymove2 = 7;
    Label label1;

    MainForm()
    {
        Text = "Mmmmm Pizza";        // for the window's title
        Size = new Size(600, 450);
        MaximizeBox = false;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        SetStyle(ControlStyles.UserPaint, true);
        SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        SetStyle(ControlStyles.DoubleBuffer, true);

        Paint += new PaintEventHandler(OnPaint);
        timer.Interval = 10;
        timer.Tick += new EventHandler(Ticker);
        timer.Start();
    }

    void OnPaint(Object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.DrawImage(background, 0, 0);

        g.DrawImage(greenPepper2, x2, y2);
    }

    static void Main(string[] args)
    {
        Application.Run(new MainForm());
    }

    public void InitializeComponent()
    {
        this.label1 = new System.Windows.Forms.Label();
        
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(13, 13);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(35, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = ("Hi");
        
        // 
        // MainForm
        // 
        
        this.Controls.Add(this.label1);
        this.Name = "MainForm";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    void Ticker(object sender, EventArgs e)    // runs whenever the timer goes off
    {
        
        x = x + xmove;
        y = y + ymove;
        
       
            
            if (x > 550)
            {
                xmove *= -1;
                x += xmove;
            }
            if (y < 0)
            {
                ymove *= -1;
                y += ymove;
            }
            if (x < 0)
            {
                xmove *= -1;
                x += xmove;
            }
            if (y > 355)
            {
                ymove *= -1;
                y += ymove;
            }

        x2 = x2 + xmove2;
        y2 = y2 + ymove2;

            if (x2 > 550)
            {
                xmove2 *= -1;
                x2 += xmove2;
            }
            if (y2 < 0)
            {
                ymove2 *= -1;
                y2 += ymove2;
            }
            if (x2 < 0)
            {
                xmove2 *= -1;
                x2 += xmove2;
            }
            if (y2 > 355)
            {
                ymove2 *= -1;
                y2 += ymove2;
                
            }


            if (((Math.Abs(x-x2))<25) && ((Math.Abs(y-y2))<25))
            {
                Console.Beep();
                count++;
                xmove *= -1;
                ymove *= -1;
                xmove2 *= -1;
                ymove2 *= -1;
            }
            
       
// ====================================================================
// Add code here to change xmove's value
// When it hits the right edge of the screen (>450) change xmov to a negative value
// When it hits the left edge of the screen (<0) change xmov to a positive value
// Do the same for ymove
// ====================================================================

        Invalidate();    // causes OnPaint to be called eventually
    }

    
}