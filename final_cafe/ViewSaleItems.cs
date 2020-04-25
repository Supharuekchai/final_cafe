using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_cafe
{
    public partial class ViewSaleItems : Form
    {
        public ViewSaleItems(int SaleID)
        {
            InitializeComponent();

            this.SaleID = SaleID;
        }

        int SaleID = 0;

        private void ViewSaleItems_Load(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();

            foreach (Details SaleItemsDetails in _DataAccess.RetreiveSaleItems(SaleID))
            {
                SaleItemsGridView.Rows.Add(SaleItemsDetails.Name, SaleItemsDetails.Price, SaleItemsDetails.Quantity, SaleItemsDetails.Total);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor = Color.Black;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.White;
        }
    }
}
