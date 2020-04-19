using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace final_cafe
{
    public partial class CashFrom : Form
    {
        public CashFrom(string  Usermane)
        {
            InitializeComponent();
            using (MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; password = 1234567890; persistsecurityinfo=True; database = final_cafe; allowuservariables=True");
            this.Name_Cashfrom.Text = Usermane;
            this.Point_CashFrom.Text = string.Format("จำนวน Point : {0}");
        }

        private void CashGivenBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
