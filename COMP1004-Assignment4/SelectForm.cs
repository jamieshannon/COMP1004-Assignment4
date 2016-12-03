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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
