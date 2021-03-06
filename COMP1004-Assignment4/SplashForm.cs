﻿/*
 * App Name: Assignment 4
 * Name: Jamie Shannon
 * StudentID: 200328763
 * Date: Dec 2/16
 * Description: Multi-form application that allows the user to select a computer from a database.
 * Calculates the cost of the computer and notifies that user that the order is complete when finished.
 */

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


        /// <summary>
        /// Show the next form and hide this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
