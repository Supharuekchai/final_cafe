using System;
using System.Windows.Forms;

namespace final_cafe
{
    public partial class CashFrom : Form
    {
        public CashFrom()
        {
            InitializeComponent();
        }

        private void CashGivenBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CashReturnBox.Text = (Convert.ToDecimal(CashGivenBox.Text) - Convert.ToDecimal(TotalBillBox.Text)).ToString();
            }
            catch
            {
                CashReturnBox.Text = string.Empty;
            }
        }
    }
}
