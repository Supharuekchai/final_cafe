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
    public partial class ViewAllSales : Form
    {
        public ViewAllSales()
        {
            InitializeComponent();
        }

        private void ViewAllSales_Load(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();

            foreach (Details SaleDetails in _DataAccess.RetreiveAllSales())
            {
                SalesGridView.Rows.Add(SaleDetails.SaleID, SaleDetails.SaleTime, SaleDetails.Name, SaleDetails.Total, "View Products");
            }
        }

        private void SalesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (SalesGridView.Columns[e.ColumnIndex].Name == "ProductsColumn")
                {
                    int SaleID = Convert.ToInt32(SalesGridView.Rows[e.RowIndex].Cells["SaleIDColumn"].Value);

                    ViewSaleItems _ViewSaleItems = new ViewSaleItems(SaleID);

                    _ViewSaleItems.ShowDialog();
                }
            }
        }
    }
}
