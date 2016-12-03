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
    public partial class StartForm : Form
    {
        public SplashForm previousForm;
        public StartForm()
        {
            InitializeComponent();
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            //hide this form
            this.Hide();

            //create an object for the next form
            SelectForm selectForm = new SelectForm();

            //point this form to the parent form
            selectForm.previousForm = this;

            //show the next form
            selectForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
