using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace final_cafe
{
    public partial class Staff_Login : Form
    {

        public Staff_Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string StaffCode = Staff_Code.Text;

            if (ConfirmStffCode(StaffCode))
            {
                string StaffPassword = Staff_Password.Text;

                if (ConfirmPassword(StaffPassword))
                {
                    DataAccess _DataAccess = new DataAccess();

                    if (_DataAccess.ConfirmUser(StaffCode, StaffPassword))
                    {
                        int UserID = Convert.ToInt32(_DataAccess.ReturnUserID(StaffCode));

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
    

        public bool ConfirmStffCode(string StaffCode)
        {
            StaffCode = StaffCode.Trim();
            if (StaffCode == string.Empty)
            {
                return false;
            }
            else return true;
        }    
        
        
        public bool ConfirmPassword(string StaffPassword)
        {
            StaffPassword = StaffPassword.Trim();

            if (StaffPassword == "")
            {
                return false;
            }
            else return true;
        }

        private void back_Click(object sender, EventArgs e)
        {

        }
    }
}
