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

namespace Final_cafe
{
    public partial class Mainmenu : Form
    {
        private string customername;
        private string CustomerName
        {
            get { return customername; }
            set { customername = value; }
        }
        private string costomerID;
        private string CostomerID
        {
            get { return costomerID; }
            set { costomerID = value; }
        }
        private string customerType;
        private string CustomerType
        {
            get { return customerType; }
            set { customerType = value; }
        }
        private string gender;
        private string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private string customerTelNo;
        private string CustomerTelNo
        {
            get { return customerTelNo; }
            set { customerTelNo = value; }
        }
        public Mainmenu(string CustomerName, string CostomerID, string CustomerType, string Gender, string CustomerTelNo)
        {
            InitializeComponent();
            //this.label1.Text = string.Format("{0} {1}", CostomerID, CustomerName);
            this.CustomerName = CustomerName;
            this.CostomerID = CostomerID;
            this.CustomerType = CustomerType;
            this.Gender = Gender;
            this.CustomerTelNo = CustomerTelNo;
        }

        private void X_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
            login login = new login();
            login.ShowDialog();
        }
    }
}
