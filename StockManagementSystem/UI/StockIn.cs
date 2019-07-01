using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Model;

namespace StockManagementSystem
{
    public partial class StockIn : Form
    {
        public StockIn()
        {
            InitializeComponent();
        }
       

        
      

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                StockIn insGet = new StockIn();
                insGet.ComapanyName =CompanyComboBox.Text;
                insGet.CategoryName = CategoryComboBox.Text;
                insGet.Item = ItemComboBox.Text;
                insGet.ReorderLavel = ReorderTextBox.Text;
                insGet.StockInQuantity = StockTextBox.Text;
                insGet.AvailableQuantity = AvailableTextBox.Text;

                StockInManager manager = new StockInManager();
                bool chk = manager.Insert(insGet);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
