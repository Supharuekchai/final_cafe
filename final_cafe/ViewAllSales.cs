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

            DateTimecomboBox.Items.Add("=====วันที่=====");

            foreach (Details DateTime in _DataAccess.ReturnDateTime())
            {
                DateTimecomboBox.Items.Add(DateTime.SaleTime);
            }

            DateTimecomboBox.SelectedIndex = 0;

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

        private void DateTimecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SalesGridView.Rows.Clear();

            if (DateTimecomboBox.SelectedIndex == 0)
            {
                DataAccess _DataAccess = new DataAccess();

                foreach (Details SaleDetails in _DataAccess.RetreiveAllSales())
                {
                    SalesGridView.Rows.Add(SaleDetails.SaleID, SaleDetails.SaleTime, SaleDetails.Name, SaleDetails.Total, "View Products");
                }
            }
            else if (DateTimecomboBox.SelectedIndex > 0)
            {
                DateTime dateTime = Convert.ToDateTime(DateTimecomboBox.SelectedItem);

                DataAccess _DataAccess = new DataAccess();

                int SaleID = _DataAccess.ReturnSaleID(dateTime);

                foreach (Details SaleDetails in _DataAccess.RetreiveAllSaleDetail(SaleID))
                {
                    SalesGridView.Rows.Add(SaleDetails.SaleID, SaleDetails.SaleTime, SaleDetails.Name, SaleDetails.Total, "View Products");
                }
            }
        }
    }
}
