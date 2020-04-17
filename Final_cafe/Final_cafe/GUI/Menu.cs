using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_cafe.GUI
{
    public partial class Menu : Form
    {

        private string customername;
        private string CustomerName
        {
           get { return customername; }
           set { customername = value; }
        }
        private string customerID;
        private string CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        private string customertype;
        private string CustomerType
        {
            get { return customertype; }
            set { customertype = value; }
        }
        private string gender;
        private string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private string customertelno;
        private string CustomerTelNo
        {
            get { return customertelno; }
            set { customertelno = value; }
        }
        private string point;
        private string Point
        {
            get { return point; }
            set { point = value; }
        }


        public Menu(string CustomerName, string CustomerID, string CustomerType, string Gender, string CustomerTelNo, string Point)
        {
            InitializeComponent();
            this.name.Text = string.Format("ยินดีต้อนรับสู่ final cafe {0} จำนวน Point ของคุณคือ : {1}", CustomerName, Point);
            this.CustomerName = CustomerName;
            this.CustomerID = CustomerID;
            this.CustomerType = CustomerType;
            this.Gender = Gender;
            this.CustomerTelNo = CustomerTelNo;
            this.Point = Point;

        }

        public Menu()
        {
            InitializeComponent();
        }


        private void X_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LOGIN login = new LOGIN();
            login.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
            Products _DataAccess = new Products(CustomerID);
            ArrayList AllCategories = _DataAccess.RetreiveAllCategoriesFromDatabase();

            foreach (Details Category in AllCategories)
            {
                Button btn = new Button();
                //btn.Text = Category.Name;
                btn.Size = new System.Drawing.Size(100, 100);
                btn.ForeColor = Color.Black;

                MemoryStream ms = new MemoryStream(Category.Picture);
                btn.Image = Image.FromStream(ms);
                btn.Image = new Bitmap(btn.Image, btn.Size);

                btn.Tag = Category.ID;

                CategoriesFlowPanel.Controls.Add(btn);

                //btn.Click += CategoryButtonClick;
            }
        }
    }
}


