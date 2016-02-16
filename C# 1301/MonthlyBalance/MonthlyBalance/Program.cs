using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace MonthlyBalance
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new myForm());
        }
    }

    public class myForm: Form
    {

        TextBox txtUser, txtUser2;
        Button btnCompute, btnClear, btnExit;
        Label lblExpenses, lblIncome, lblTitle;
        double balance;

        public myForm()
        {            
            lblTitle = new Label();
            lblTitle.Location = new Point(180, 10);
            lblTitle.Text = "Compute Monthly Balance";
            lblTitle.Size = new Size(lblTitle.PreferredWidth, lblTitle.PreferredHeight);
            Controls.Add(lblTitle);

            lblExpenses = new Label();
            lblExpenses.Location = new Point(70, 62);
            lblExpenses.Text = "Expenses: $";
            lblExpenses.Size = new Size(75, 15);
            Controls.Add(lblExpenses);

            lblIncome = new Label();
            lblIncome.Location = new Point(70, 92);
            lblIncome.Text = "Income: $";
            lblIncome.Size = new Size(75, 15);
            Controls.Add(lblIncome);           

            txtUser = new TextBox();            	// create the text box and add it
            txtUser.Location = new Point(150, 60);
            txtUser.Size = new Size(200, 20);
            Controls.Add(txtUser);

            txtUser2 = new TextBox();            	// create the text box and add it
            txtUser2.Location = new Point(150, 90);
            txtUser2.Size = new Size(200, 20);
            Controls.Add(txtUser2);

	    // create the buttons
            btnCompute = new Button();
            btnCompute.Location = new Point(100, 130);
            btnCompute.Text = "Compute";
            Controls.Add(btnCompute);

            btnClear = new Button();
            btnClear.Location = new Point(20, 130);
            btnClear.Text = "Clear";
            Controls.Add(btnClear);

            btnExit = new Button();
            btnExit.Location = new Point(180, 130);
            btnExit.Text = "Exit";
            Controls.Add(btnExit);

            Size = new Size(500, 200);		// size the form

            btnClear.Click += new EventHandler(btnClearHandler);
            btnCompute.Click += new EventHandler(btnEventHandler);
            btnExit.Click += new EventHandler(btnExit_Click);
        }

        void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEventHandler(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("You have not entered an Expense.");
                throw new Exception();
            }
            if (txtUser2.Text == "")
            {
                MessageBox.Show("You have not entered an Income.");
                throw new Exception();
            }
                balance = Convert.ToDouble(txtUser2.Text) - Convert.ToDouble(txtUser.Text);
                MessageBox.Show("Your balance is: " + balance);
            
        }
        private void btnClearHandler(object sender, EventArgs e)
        {
            MessageBox.Show("Your Form Has Been Cleared.");
            txtUser.Text = "";
            txtUser2.Text = "";
        }
      }
    }

