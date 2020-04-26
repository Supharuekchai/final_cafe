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
using MySql.Data.MySqlClient;

namespace final_cafe
{
    public partial class Customer_Form : Form
    {
        public string CustomerName = string.Empty;
        public int CustomerID = 0;
        public int RowIndex = 1;
        public string Point;
        public Customer_Form(string username)
        {
            InitializeComponent();
            DataAccess dataAccess = new DataAccess();
            CustomerID = dataAccess.ReturnCustomerID(username);
            CustomerName = dataAccess.ReturnCustomerName(username);

            string ConnectionString = "server = localhost; user id = root; password = 1234567890; persistsecurityinfo=True; database = final_cafe; allowuservariables=True";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            MySqlCommand command = new MySqlCommand("SELECT Point FROM customers WHERE UserName = '" + username + "';", connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Point = reader.GetString(0);
                }
            }
            reader.Close();

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor = Color.Black;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.White;
        }



        private void Customer_Form_Load(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();

            ArrayList AllCategories = _DataAccess.RetreiveAllCategoriesFromDatabase();

            foreach (Details Category in AllCategories)
            {
                Button btn = new Button();
                btn.Text = Category.Name;
                btn.Size = new System.Drawing.Size(130, 130);
                btn.ForeColor = Color.White;

                MemoryStream ms = new MemoryStream(Category.Picture);
                btn.Image = Image.FromStream(ms);
                btn.Image = new Bitmap(btn.Image, btn.Size);

                btn.Tag = Category.ID;

                CategoriesFlowPanel.Controls.Add(btn);

                btn.Click += CategoryButtonClick;
            }

            UserName.Text = string.Format("ยินดีต้อนรับ คุณ {0} จำนวนแต้มของคุณคือ {1}", CustomerName, Point);
        }
        void CategoryButtonClick(object sender, EventArgs e)
        {
            ProductsFlowPanel.Controls.Clear();

            Button btn = (Button)sender;

            int CategoryID = Convert.ToInt32(btn.Tag);

            DataAccess _DataAccess = new DataAccess();

            foreach (Details Product in _DataAccess.RetreiveProductsFromCategory(CategoryID))
            {
                Button ProductButton = new Button();
                ProductButton.Text = Product.Name;
                ProductButton.Size = new System.Drawing.Size(130, 130);
                ProductButton.ForeColor = Color.White;

                MemoryStream ms = new MemoryStream(Product.Picture);
                ProductButton.Image = Image.FromStream(ms);
                ProductButton.Image = new Bitmap(ProductButton.Image, ProductButton.Size);

                ProductButton.Tag = Product.ID;

                ProductsFlowPanel.Controls.Add(ProductButton);

                ProductButton.Click += ProductButton_Click;

                //ProductButton.MouseClick += ProductButton_MouseClick;
            }
        }
        void ProductButton_Click(object sender, EventArgs e)
        {
            Button ProductButton = sender as Button;

            DataAccess _DataAccess = new DataAccess();

            int ProductID = Convert.ToInt32(ProductButton.Tag);

            Details ProductDetails = _DataAccess.RetreiveProductDetails(ProductID);

            if (CheckProductAlreadyAdded(ProductID))
            {
                // MessageBox.Show("Product Alraedy Exists in Datagrid view at Index : " + RowIndex);
                int Quantity = Convert.ToInt32(ProductsGridView.Rows[RowIndex].Cells["ProductQuantityColumn"].Value);
                decimal Price = Convert.ToInt32(ProductsGridView.Rows[RowIndex].Cells["ProductPriceColumn"].Value);

                Quantity++;

                /////////////<Do thisssss...... Important.. Have decimal part in the total price>
                double TotalPrice = Convert.ToDouble(Quantity * Price);

                ProductsGridView.Rows[RowIndex].Cells["ProductQuantityColumn"].Value = Quantity;
                ProductsGridView.Rows[RowIndex].Cells["TotalPriceColumn"].Value = TotalPrice;

                TotalBillBox.Text = CalculateTotalBill(ProductsGridView).ToString();
            }
            else
            {
                ProductsGridView.Rows.Add(ProductID, ProductDetails.Name, ProductDetails.Price, 1, ProductDetails.Price * 1, "ลบ");

                TotalBillBox.Text = CalculateTotalBill(ProductsGridView).ToString();
            }
        }

        public bool CheckProductAlreadyAdded(int ProductID)
        {
            foreach (DataGridViewRow Row in ProductsGridView.Rows)
            {
                if (Convert.ToInt32(Row.Cells["ProductIDColumn"].Value) == ProductID)
                {
                    RowIndex = Row.Index;
                    return true;
                }
            }
            return false;
        }

        public decimal CalculateTotalBill(DataGridView ProductsGridView)
        {
            decimal TotalBill = 0;

            foreach (DataGridViewRow Row in ProductsGridView.Rows)
            {
                decimal ProductTotal = Convert.ToDecimal(Row.Cells["TotalPriceColumn"].Value);

                TotalBill = TotalBill + ProductTotal;
            }

            return TotalBill;
        }


        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            decimal Totail = 0;
            ArrayList ProductsList = new ArrayList();

            foreach (DataGridViewRow Row in ProductsGridView.Rows)
            {
                try
                {
                    string ProductName = Row.Cells["ProductNameColumn"].Value.ToString();
                    decimal ProductPrice = Convert.ToDecimal(Row.Cells["ProductPriceColumn"].Value);
                    int ProductQuantity = Convert.ToInt32(Row.Cells["ProductQuantityColumn"].Value);
                    decimal ProductTotal = Convert.ToDecimal(Row.Cells["TotalPriceColumn"].Value);
                    ProductsList.Add(new Details() { Name = ProductName, Price = ProductPrice, Quantity = ProductQuantity, Total = ProductTotal });
                }
                catch
                {
                    //means Rows are ended
                }

            }
            DataAccess _DataAccess = new DataAccess();
            int StaffID = _DataAccess.ReturnStaffIDRandom();
            Totail = Convert.ToDecimal(TotalBillBox.Text);
            if (_DataAccess.RecordASale(ProductsList, DateTime.Now, StaffID, Totail, CustomerID))
            {
                _DataAccess.UpdatePoint(CustomerID, ProductsList, Point);
                ProductsGridView.Rows.Clear();
                TotalBillBox.Text = string.Empty;
                MessageBox.Show("ขอบคุณที่ใช้บริการ ครับ");
            }
            else MessageBox.Show("เกิดข้อผิดพลาด ขออภัยในความไม่สะดวก");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Login customer_Login = new Customer_Login();
            customer_Login.Show();
        }
    }
}
