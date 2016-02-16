using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * Homework# 2: Michael Banks
 * This form program determines if the user is a Vampire. 
 * When the user clicks Apply, show a message box telling them if they can be a Vampire.
 */

namespace Vampire_Form
{
    public partial class Form1 : Form
    {
        TextBox txtUser;
        Button btnApply, btnClear, btnExit;
        Label lblName, lblTitle, lblSleep, lblLike;        
        Panel likePanel;
        RadioButton rbDay, rbNight;
        CheckBox cbLike1, cbLike2, cbLike3;

 public Form1()
        {
            InitializeComponent();
            Size = new Size(500, 300);		
            
            //labels      
            lblTitle = new Label();
            lblTitle.Location = new Point(180, 20);
            lblTitle.Text = "Vampire Application Form";
            lblTitle.Size = new Size(lblTitle.PreferredWidth, lblTitle.PreferredHeight);
            Controls.Add(lblTitle);

            lblName = new Label();
            lblName.Location = new Point(70, 70);
            lblName.Text = "Name: ";
            lblName.Size = new Size(75, 15);
            Controls.Add(lblName);        

            lblSleep = new Label();
            lblSleep.Location = new Point(50, 120);
            lblSleep.Text = "Sleeps during: ";
            lblSleep.Size = new Size(120, 15);
            Controls.Add(lblSleep);
     
            lblLike = new Label();
            lblLike.Location = new Point(70, 150);
            lblLike.Text = "Like: ";
            lblLike.Size = new Size(75, 15);
            Controls.Add(lblLike);

            //radio buttons
            likePanel = new Panel();
            likePanel.Location = new Point(500,300);            
            likePanel.Controls.Add(rbDay);
            likePanel.Controls.Add(rbNight);
            Controls.Add(likePanel);
            
            rbDay = new RadioButton();
            rbDay.Location = new Point(190, 120);
            rbDay.AutoSize = true;
            rbDay.Text = "Day";
            rbDay.Checked = false;
            Controls.Add(rbDay);

            rbNight = new RadioButton();
            rbNight.Location = new Point(270, 120);
            rbNight.AutoSize = true;
            rbNight.Text = "Night";
            rbNight.Checked = false;
            Controls.Add(rbNight);

            //Checkboxes
            cbLike1 = new CheckBox();
            cbLike1.Location = new Point(150, 145);
            cbLike1.Text = "Wooden Stakes";
            cbLike1.Checked = false;
            Controls.Add(cbLike1);

            cbLike2 = new CheckBox();
            cbLike2.Location = new Point(150, 168);
            cbLike2.Text = "Mirrors";
            cbLike2.Checked = false;
            Controls.Add(cbLike2);

            cbLike3 = new CheckBox();
            cbLike3.Location = new Point(150, 191);
            cbLike3.Text = "Dentists";
            cbLike3.Checked = false;
            Controls.Add(cbLike3);
            
            //textboxes
            txtUser = new TextBox();            	
            txtUser.Location = new Point(150, 70);
            txtUser.Size = new Size(200, 20);
            Controls.Add(txtUser);

	        // buttons
            btnApply = new Button();
            btnApply.Location = new Point(100, 230);
            btnApply.Text = "Apply";
            Controls.Add(btnApply);

            btnClear = new Button();
            btnClear.Location = new Point(20, 230);
            btnClear.Text = "Clear";
            Controls.Add(btnClear);

            btnExit = new Button();
            btnExit.Location = new Point(180, 230);
            btnExit.Text = "Exit";
            Controls.Add(btnExit);

            btnClear.Click += new EventHandler(btnClearHandler);
            btnApply.Click += new EventHandler(btnApplyHandler);
            btnExit.Click += new EventHandler(btnExit_Click);
        }

        void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnApplyHandler(object sender, EventArgs e)
        {      
            //Algorithm
            
                if (rbDay.Checked == true)
                {
                    if (cbLike1.Checked == false && cbLike2.Checked == false && cbLike3.Checked == false)
                    {
                        MessageBox.Show(txtUser.Text + " is a Vampire!");
                    }
                    else if (cbLike1.Checked == true || cbLike2.Checked == true || cbLike3.Checked == true)
                    {
                        MessageBox.Show(txtUser.Text + " could be a Vampire!");
                    }
                }
            else
                MessageBox.Show(txtUser.Text + " is not likely a Vampire.");
        
        }
        private void btnClearHandler(object sender, EventArgs e)
        {
            //Clears Form
            MessageBox.Show("Your Form Has Been Cleared.");
            txtUser.Text = "";
            cbLike1.Checked = false;
            cbLike2.Checked = false;
            cbLike3.Checked = false;
            rbDay.Checked = false;
            rbNight.Checked = false;

        }
      }
    }     
        
    



