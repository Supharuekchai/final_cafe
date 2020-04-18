using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_cafe.GUI
{
    public partial class CashForm : Form
    {
        public CashForm(String CustomerName, String Point, String ProProductQuantity)
        {
            InitializeComponent();
            label2.Text = CustomerName;
            label3.Text = (Convert.ToDecimal(Point) + Convert.ToDecimal(ProProductQuantity)).ToString();
         }

        private void ConfirmCheckoutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ขอบคุณที่มาอุดหนุน ครับ");
        }
    }
}
