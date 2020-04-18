using System;
using System.Collections;
using System.Drawing;
using System.IO;
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
        private string point;
        private string staffName;
        private string staffID;
        private string staffLevel;

        private string Point
        {
            get { return point; }
            set { point = value; }
        }

        public string StaffID;
        public string Username;
        public int RowIndex = 0;


        public Menu(string CustomerName, string Point, string CustomerID)
        {
            InitializeComponent();
            this.name.Text = string.Format("ยินดีต้อนรับสู่ final cafe {0} จำนวน Point ของคุณคือ : {1}", CustomerName, Point);
            StaffID = CustomerID;
            DataAccess _DataAccess = new DataAccess();
            Username = _DataAccess.ReturnUserName(CustomerID);

        }

        public Menu()
        {
            InitializeComponent();

        }

        public Menu(string staffName, string staffID, string gender, string staffLevel)
        {
            this.staffName = staffName;
            this.staffID = staffID;
            this.gender = gender;
            this.staffLevel = staffLevel;
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
                btn.Text = Category.Name;
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
                MessageBox.Show("Product Alraedy Exists in Datagrid view at Index : " + RowIndex);
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

        private void ProductsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (ProductsGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
                {
                    if (MessageBox.Show("Are You Sure You Want to Delete this Product", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        decimal DeletedProductTotal = Convert.ToDecimal(ProductsGridView.Rows[e.RowIndex].Cells["TotalPriceColumn"].Value);

                        decimal CurrentTotalBill = Convert.ToDecimal(TotalBillBox.Text);

                        CurrentTotalBill = CurrentTotalBill - DeletedProductTotal;

                        ProductsGridView.Rows.RemoveAt(e.RowIndex);
                        TotalBillBox.Text = CurrentTotalBill.ToString();
                    }
                }
            }
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            
            CashForm _CashForm = new CashForm(CustomerName, Point, CalculateTotalBill(ProductsGridView).ToString());

            _CashForm.TotalBillBox.Text = TotalBillBox.Text;


            if (_CashForm.ShowDialog() == DialogResult.OK)
            {
                ArrayList ProductsList = new ArrayList();

                foreach (DataGridViewRow Row in ProductsGridView.Rows)
                {
                    try
                    {
                        string ProductName = Row.Cells["ProductNameColumn"].Value.ToString();
                        decimal ProductPrice = Convert.ToDecimal(Row.Cells["ProductPriceColumn"].Value);
                        string ProductQuantity = Convert.ToString(Row.Cells["ProductQuantityColumn"].Value);
                        decimal ProductTotal = Convert.ToDecimal(Row.Cells["TotalPriceColumn"].Value);

                        ProductsList.Add(new Details() { Name = ProductName, Price = ProductPrice, Quantity = ProductQuantity, Total = ProductTotal });
                    }
                    catch
                    {
                        string ProductName = Row.Cells["ProductNameColumn"].Value.ToString();
                    }
                }

                DataAccess _DataAccess = new DataAccess();
                _DataAccess.RecordASale(ProductsList, DateTime.Now, StaffID, CustomerID, Convert.ToDecimal(_CashForm.TotalBillBox.Text));
            }
        }
    }
}


