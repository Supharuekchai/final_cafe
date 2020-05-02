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
    public partial class UpdateStaff : Form
    {
        int StaffID = 0;
        string StaffName = string.Empty;
        string StaffCode = string.Empty;
        string Gender = string.Empty;
        string StaffPassword = string.Empty;
        string StaffLevel = string.Empty;
        public UpdateStaff(int StaffID, string StaffName, string StaffCode, string Gender, string StaffPassword, string StaffLevel)
        {
            InitializeComponent();
            this.StaffID = StaffID;
            this.StaffName = StaffName;
            this.StaffCode = StaffCode;
            this.Gender = Gender;
            this.StaffPassword = StaffPassword;
            this.StaffLevel = StaffLevel;
        }

        private void UpdateStaff_Load(object sender, EventArgs e)
        {
            StaffNameTextBox.Text = StaffName;
            StaffCodeTextBox.Text = StaffCode;
            StaffPasswordTextBox.Text = StaffPassword;
            GenderComboBox.Text = Gender;
            StaffLevelComboBox.Text = StaffLevel;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            if (dataAccess.UpdateStaff(StaffID, StaffNameTextBox.Text, StaffCodeTextBox.Text, GenderComboBox.Text, StaffPasswordTextBox.Text, StaffLevelComboBox.Text))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("แก้ไขไม่สำเร็จ", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
