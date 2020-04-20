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
    public partial class Customer_Login : Form
    {
        public Customer_Login()
        {
            InitializeComponent();

            this.Customer_Password.AutoSize = false;
            this.Customer_Password.Size = new Size(this.Customer_Password.Size.Width, 50);

        }

        private void cus_signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Signup op_signup = new Customer_Signup();
            op_signup.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Login op_staff = new Staff_Login();
            op_staff.ShowDialog();
        }

        private void cus_login_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            String username = Customer_ID.Text;
            String password = Customer_Password.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `customers` WHERE `UserName` = @usn and `Password` = @pass", db.getConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("YES");
            }
            else
            {
                MessageBox.Show("NO");
            }
        }


        public bool ConfirmUser(string UserName)
        {
            UserName = UserName.Trim();
            if (UserName == string.Empty)
            {
                return false;
            }
            else return true;
        }


        public bool ConfirmPassword(string Password)
        {
            Password = Password.Trim();

            if (Password == "")
            {
                return false;
            }
            else return true;
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor = Color.Black;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.White;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cus_login_MouseEnter(object sender, EventArgs e)
        {
            cus_login.ForeColor = Color.White;
        }

        private void cus_login_MouseLeave(object sender, EventArgs e)
        {
            cus_login.ForeColor = Color.Black;
        }

        private void cus_signup_MouseLeave(object sender, EventArgs e)
        {
            cus_signup.ForeColor = Color.Black;
        }

        private void cus_signup_MouseEnter(object sender, EventArgs e)
        {
            cus_signup.ForeColor = Color.White;
        }
    }
}
