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

            if (!checkTextBoxesValues())
            {
                if (checkUsername())
                {
                    MessageBox.Show("This Username Already Exists, Select A Different One","Duplicate Username",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }
                else
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Your Account Has Been Created","Account",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter Your Inormations First","Empty Data",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }

           
            db.closeConnection();
        }

        public Boolean checkUsername()
        {
            DB db = new DB();
            String username = cus_user.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `customers` WHERE `UserName` = @usn", db.getConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean checkTextBoxesValues()
        {
            String name = cus_name.Text;
            String gender = cus_gender.SelectedItem.ToString();
            String type = cus_type.SelectedItem.ToString();
            String telno = cus_telno.Text;
            String user = cus_user.Text;
            String pass = cus_pass.Text;

            if (name.Equals("Your Name") || gender.Equals("Your Gender") || type.Equals("Your Type")
                || telno.Equals("Your telephone number ") || user.Equals("Your User") || pass.Equals("Youer Password"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
