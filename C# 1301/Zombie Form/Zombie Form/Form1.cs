using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * Homework# 12: Michael Banks
 * This form program determines if the user is a Zombie. 
 * When the user clicks Apply, show a message box telling them if they can be a Zombie.
 */

namespace Zombie_Form
{
    public partial class Form1 : Form
    {
        TextBox txtUser, txtUser2;
        Button btnApply, btnClear, btnExit;
        Label lblName, lblSpeed, lblTitle, lblLikes, lblEat;        
        Panel likePanel;
        RadioButton rbYes, rbNo;
        CheckBox cbEat1, cbEat2, cbEat3;

 public Form1()
        {
            InitializeComponent();
            Size = new Size(500, 300);		
            
            //labels      
            lblTitle = new Label();
            lblTitle.Location = new Point(180, 10);
            lblTitle.Text = "Zombie Application Form";
            lblTitle.Size = new Size(lblTitle.PreferredWidth, lblTitle.PreferredHeight);
            Controls.Add(lblTitle);

            lblName = new Label();
            lblName.Location = new Point(70, 60);
            lblName.Text = "Name: ";
            lblName.Size = new Size(75, 15);
            Controls.Add(lblName);

            lblSpeed = new Label();
            lblSpeed.Location = new Point(50, 90);
            lblSpeed.Text = "Walking Speed: ";
            lblSpeed.Size = new Size(100, 15);
            Controls.Add(lblSpeed);

            lblLikes = new Label();
            lblLikes.Location = new Point(50, 120);
            lblLikes.Text = "Likes Zombie Hunters: ";
            lblLikes.Size = new Size(120, 15);
            Controls.Add(lblLikes);
     
            lblEat = new Label();
            lblEat.Location = new Point(70, 150);
            lblEat.Text = "Will Eat: ";
            lblEat.Size = new Size(75, 15);
            Controls.Add(lblEat);

            //radio buttons
            likePanel = new Panel();
            likePanel.Location = new Point(500,300);            
            likePanel.Controls.Add(rbYes);
            likePanel.Controls.Add(rbNo);
            Controls.Add(likePanel);
            
            rbYes = new RadioButton();
            rbYes.Location = new Point(190,120);
            rbYes.AutoSize = true;
            rbYes.Text = "Yes";
            rbYes.Checked = false;
            Controls.Add(rbYes);

            rbNo = new RadioButton();
            rbNo.Location = new Point(270, 120);
            rbNo.AutoSize = true;
            rbNo.Text = "No";
            rbNo.Checked = false;
            Controls.Add(rbNo);

            //Checkboxes
            cbEat1 = new CheckBox();
            cbEat1.Location = new Point(150, 145);
            cbEat1.Text = "Human Brains";
            cbEat1.Checked = false;            
            Controls.Add(cbEat1);
            
            cbEat2 = new CheckBox();
            cbEat2.Location = new Point(150, 168);
            cbEat2.Text = "Sheep Brains";
            cbEat2.Checked = false;
            Controls.Add(cbEat2);
            
            cbEat3 = new CheckBox();
            cbEat3.Location = new Point(150, 191);
            cbEat3.Text = "Vegetables";
            cbEat3.Checked = false;
            Controls.Add(cbEat3);
            
            //textboxes
            txtUser = new TextBox();            	
            txtUser.Location = new Point(150, 60);
            txtUser.Size = new Size(200, 20);
            Controls.Add(txtUser);

            txtUser2 = new TextBox();            	
            txtUser2.Location = new Point(150, 90);
            txtUser2.Size = new Size(200, 20);
            txtUser2.MaxLength = 3;
            Controls.Add(txtUser2);

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
           //Error Checking
            if (rbNo.Checked == false && rbYes.Checked == false)
                throw new ArgumentException("You have not answered wheter you like zombie hunter or not.");
            if (Convert.ToInt32(txtUser2.Text) < 0)            
                throw new ArgumentException("Walking Speed cannot be less than 0.");
            if (cbEat1.Checked == false && cbEat2.Checked == false && cbEat3.Checked == false)
                throw new ArgumentException("You have not answered your eating preferences.");

            //Algorithm
            if (Convert.ToInt32(txtUser2.Text) <= 5 && Convert.ToInt32(txtUser2.Text) > 0)
            {
                if (rbNo.Checked == true)
                {
                     if (cbEat1.Checked == true || cbEat2.Checked == true)
                        MessageBox.Show(txtUser.Text + " is a Zombie!");
                }
            else
                MessageBox.Show(txtUser.Text + " is not likely a Zombie.");
            }
        }
        private void btnClearHandler(object sender, EventArgs e)
        {
            //Clears Form
            MessageBox.Show("Your Form Has Been Cleared.");
            txtUser.Text = "";
            txtUser2.Text = "";
            cbEat1.Checked = false;
            cbEat2.Checked = false;
            cbEat3.Checked = false;
            rbYes.Checked = false;
            rbNo.Checked = false;

        }
      }
    }     
        
    



