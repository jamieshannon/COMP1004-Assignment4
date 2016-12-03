/*
 * App Name: Assignment 4
 * Name: Jamie Shannon
 * StudentID: 200328763
 * Date: Dec 2/16
 * Description: Multi-form application that allows the user to select a computer from a database.
 * Calculates the cost of the computer and notifies that user that the order is complete when finished.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using COMP1004_Assignment4.Models;

namespace COMP1004_Assignment4
{
    static class Program
    {
        public static Product product;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}
