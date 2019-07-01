using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class StockMain : Form
    {


        public StockMain()
        {
            InitializeComponent();
        }

        private void StockMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void categorySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
        }

        private void companySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.Show();
        }

        private void itemSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Show();
        }

        private void stockInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StockIn stockin = new StockIn();
            stockin.Show();
        }

        private void stockOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockOut stockout = new StockOut();
            stockout.Show();
        }

        private void searchViewItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Searchview searchview = new Searchview();
            searchview.Show();
        }

        private void betweenTwoDatesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dates dates = new Dates();
            dates.Show();
        }
    }
}
