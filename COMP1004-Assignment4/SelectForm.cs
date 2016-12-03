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

using COMP1004_Assignment4.Models;

namespace COMP1004_Assignment4
{
    public partial class SelectForm : Form
    {
        public StartForm previousForm;
        // connect to the db using EF
        private ComputerContext db = new ComputerContext();

        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMP1004DataSet2.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.cOMP1004DataSet2.products);

        }

        /// <summary>
        /// Highlight the row that is selected and save the item to the class
        /// Enable the next button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[0];
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Yellow;

                // get the StudentID from the row that was clicked
                int ProductID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                Program.product = (from product in db.products
                                   where product.productID == ProductID
                                   select product).FirstOrDefault();

                UpdateHardwareTextBox();

                NextButton.Enabled = true;

            }
        }

        /// <summary>
        /// Display the hardware in the text field
        /// </summary>
        private void UpdateHardwareTextBox()
        {
            HardwareTextBox.Text = Program.product.manufacturer + " " + Program.product.model +
                ", $" + Program.product.cost;
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
        /// Open the next form and hide this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            //hide this form
            this.Hide();

            //create an object for the next form
            ProductInfoForm productInfoForm = new ProductInfoForm();

            //point this form to the parent form
            productInfoForm.previousForm = this;

            //show the next form
            productInfoForm.Show();
        }
    }
}
