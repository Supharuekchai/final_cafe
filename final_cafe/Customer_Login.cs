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
            string UserName = Customer_ID.Text;

            if (ConfirmUser(UserName))
            {
                string Password = Customer_Password.Text;

                if (ConfirmPassword(Password))
                {
                    DataAccess _DataAccess = new DataAccess();

                    if (_DataAccess.ConfirmUser(UserName, Password))
                    {
                        int UserID = Convert.ToInt32(_DataAccess.ReturnUserID(UserName));

                        Staff_Form _Dashboard = new Staff_Form(UserID);

                        this.Hide();

                        _Dashboard.Show();
                    }
                    else MessageBox.Show("Incorrect Password. Please try again.");
                }
                else MessageBox.Show("Please Enter Password");
            }
            else MessageBox.Show("Please Enter Correct Email");
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
    }
}
