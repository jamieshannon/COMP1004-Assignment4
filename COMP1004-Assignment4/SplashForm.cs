using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_Assignment4
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            //hide the splash form
            this.Hide();

            //create an object for the next form
            StartForm startForm = new StartForm();

            //point this form to the parent form
            startForm.previousForm = this;

            //show the next form
            startForm.Show();

            //disable the timer event
            SplashFormTimer.Enabled = false;
        }
    }
}
