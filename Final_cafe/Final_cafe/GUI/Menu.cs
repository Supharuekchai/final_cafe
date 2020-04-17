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

        public int SalesmanID = 0;
        public string Username = string.Empty;

        public int RowIndex = 0;


        public Menu(string CustomerName, string Point)
        {
            InitializeComponent();
            this.name.Text = string.Format("ยินดีต้อนรับสู่ final cafe {0} จำนวน Point ของคุณคือ : {1}", CustomerName, Point);
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
            
            DataAccess _DataAccess = new DataAccess();
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

                btn.Click += CategoryButtonClick;
            }
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
                ProductButton.Size = new System.Drawing.Size(80, 80);
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

        void ProductButton_MouseClick(object sender, MouseEventArgs e)
        {
            //for loweing one quantity. do this.. <---------------------
            switch (e.Button)
            {
                case MouseButtons.Right:
                    MessageBox.Show("Right Click");
                    break;
                case MouseButtons.Left:
                    MessageBox.Show("Left Click");
                    break;
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
                ProductsGridView.Rows.Add(ProductID, ProductDetails.Name, ProductDetails.Price, 1, ProductDetails.Price * 1);

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
    }
}


