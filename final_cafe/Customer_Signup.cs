using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace final_cafe
{
    public partial class Customer_Signup : Form
    {
        public Customer_Signup()
        {
            InitializeComponent();
        }

        private void bt_cancer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Login op_cuslogin = new Customer_Login();
            op_cuslogin.ShowDialog();
        }

        private void bt_sign_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `customers`(`CustomerName`, `Gender`, `CustomerType`, `CustomerTelNo`, `Password`, `UserName`) VALUES (@cn, @cgd, @ct, @ctn, @pass, @usn)", db.getConnection());

            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cus_name.Text;
            command.Parameters.Add("@cgd", MySqlDbType.VarChar).Value = cus_gender.SelectedItem.ToString();
            command.Parameters.Add("@ct", MySqlDbType.VarChar).Value = cus_type.SelectedItem.ToString();
            command.Parameters.Add("@ctn", MySqlDbType.VarChar).Value = cus_telno.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = cus_pass.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = cus_user.Text;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("ACCOUNT CREATED");
            }
            else 
            {
                MessageBox.Show("ERROR");
            }
            db.closeConnection();
        }

        public Boolean checkUsername()
        {
            return false;
        }
    }
}
