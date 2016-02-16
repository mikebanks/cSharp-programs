using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Vampire_Form
{
    static class Program
    {
        /*
         * Homework# 2: Michael Banks
         * This form program determines if the user is a Vampire. 
         * When the user clicks Apply, show a message box telling them if they can be a Vampire.
         */

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
