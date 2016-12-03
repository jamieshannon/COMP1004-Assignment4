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
    public partial class ProductInfoForm : Form
    {
        public SelectForm previousForm;
        public ProductInfoForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Populate the text fields 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            ProductIDTextBox.Text = Program.product.productID.ToString();
            ConditionTextBox.Text = Program.product.condition.ToString();
            CostTextBox.Text = Program.product.cost.ToString();
            PlatformTextBox.Text = Program.product.platform.ToString();
            ManufacturerTextBox.Text = Program.product.manufacturer.ToString();
            OSTextBox.Text = Program.product.OS.ToString();
            ModelTextBox.Text = Program.product.model.ToString();
            MemoryTextBox.Text = Program.product.RAM_size.ToString();
            LCDSizeTextBox.Text = Program.product.screensize.ToString();
            HDDTextBox.Text = Program.product.HDD_size.ToString();
            CPUBrandTextBox.Text = Program.product.CPU_brand.ToString();
            CPUNumberTextBox.Text = Program.product.CPU_number.ToString();
            GPUTypeTextBox.Text = Program.product.GPU_Type.ToString();
            CPUTypeTextBox.Text = Program.product.CPU_type.ToString();
            CPUSpeedTextBox.Text = Program.product.CPU_speed.ToString();
            WebCamTextBox.Text = Program.product.webcam.ToString();

        }


        /// <summary>
        /// Hide this form and load the previous form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAnotherButton_Click(object sender, EventArgs e)
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
        /// Show the next form and hide this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            //hide this form
            this.Hide();

            //create an object for the next form
            OrderForm orderForm = new OrderForm();

            //point this form to the parent form
            orderForm.previousForm = this;

            //show the next form
            orderForm.Show();
        }
    }
}
