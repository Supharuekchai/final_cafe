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
    public partial class Customer_Login : Form
    {
        public Customer_Login()
        {
            InitializeComponent();
        }

        private void Staff_Code_TextChanged(object sender, EventArgs e)
        {

        }

        private void cus_signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Signup op_signup = new Customer_Signup();
            op_signup.ShowDialog();
        }
    }
}
