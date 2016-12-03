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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_Assignment4
{
    public partial class OrderForm : Form
    {
        public ProductInfoForm previousForm;
        public OrderForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Show the about box when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.ShowDialog();
        }


        /// <summary>
        /// Populate the text box fields when the form is loaded, show a picture and calculate 
        /// cost of the computer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Load(object sender, EventArgs e)
        {
            ConditionTextBox.Text = Program.product.condition.ToString();
            PlatformTextBox.Text = Program.product.platform.ToString();
            ManufacturerTextBox.Text = Program.product.manufacturer.ToString();
            OSTextBox.Text = Program.product.OS.ToString();
            ModelTextBox.Text = Program.product.model.ToString();
            MemoryTextBox.Text = Program.product.RAM_size.ToString();
            LCDSizeTextBox.Text = Program.product.screensize.ToString();
            HDDTextBox.Text = Program.product.HDD_size.ToString();
            CPUBrandTextBox.Text = Program.product.CPU_brand.ToString();
            CPUNumberTextBox.Text = Program.product.CPU_number.ToString();
            CPUTypeTextBox.Text = Program.product.CPU_type.ToString();
            CPUSpeedTextBox.Text = Program.product.CPU_speed.ToString();
            WebCamTextBox.Text = Program.product.webcam.ToString();
            GPUTextBox.Text = Program.product.GPU_Type.ToString();

            PriceTextBox.Text = Program.product.cost.ToString();

            double tax = Convert.ToDouble(Program.product.cost) * .13;
            SalesTaxTextBox.Text = tax.ToString("C2");

            double total = tax + Convert.ToDouble(Program.product.cost);
            TotalTextBox.Text = total.ToString("C2");

            if (ManufacturerTextBox.Text == "Acer")
            {
                ComputerPictureBox.Image = Properties.Resources.acer;
            }
            else if (ManufacturerTextBox.Text == "Apple")
            {
                ComputerPictureBox.Image = Properties.Resources.apple;
            }
            else if (ManufacturerTextBox.Text == "Asus" || ManufacturerTextBox.Text == "Asus ")
            {
                ComputerPictureBox.Image = Properties.Resources.asus;
            }
            else if (ManufacturerTextBox.Text == "CybertronPC")
            {
                ComputerPictureBox.Image = Properties.Resources.cybertronpc;
            }
            else if (ManufacturerTextBox.Text == "Gateway")
            {
                ComputerPictureBox.Image = Properties.Resources.gateway;
            }
            else if (ManufacturerTextBox.Text == "HP")
            {
                ComputerPictureBox.Image = Properties.Resources.hp;
            }
            else if (ManufacturerTextBox.Text == "iBUYPOWER")
            {
                ComputerPictureBox.Image = Properties.Resources.ibuypower;
            }
            else if (ManufacturerTextBox.Text == "Lenovo")
            {
                ComputerPictureBox.Image = Properties.Resources.lenovo;
            }
            else if (ManufacturerTextBox.Text == "Toshiba")
            {
                ComputerPictureBox.Image = Properties.Resources.toshiba;
            }
        }


        /// <summary>
        /// Hide this form and load the previous form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }


        /// <summary>
        /// Close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Notify the user that their order is printing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your selection is now printing.", "Print");
        }


        /// <summary>
        /// Notify the user that their order will ship and close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            string msg = "Thank you for you business." + Environment.NewLine + 
                Environment.NewLine + "Your order will be processed in 7 - 10 business days.";
            MessageBox.Show(msg, "Thank you.");
            Application.Exit();
        }
    }
}
