using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_cafe
{
    public partial class UpdateProducts : Form
    {
        int ProductID;
        string ProductName, ProductCategory, ProductDescription;
        decimal ProductPrice;
        byte[] ProductPicture;

        public UpdateProducts(int GivenProductID, string GivenProductName, decimal GivenProductPrice, string GivenProductCategory, string GivenProductDescription, byte[] GivenProductPicture)
        {
            InitializeComponent();

            ProductID = GivenProductID;
            ProductName = GivenProductName;
            ProductPrice = GivenProductPrice;
            ProductCategory = GivenProductCategory;
            ProductDescription = GivenProductDescription;
            ProductPicture = GivenProductPicture;
        }

        private void UpdateProducts_Load(object sender, EventArgs e)
        {
            ProductIDBox.Text = ProductID.ToString();
            ProductNameBox.Text = ProductName;
            ProductPriceBox.Text = ProductPrice.ToString();
            ProductCategoryComboBox.Text = ProductCategory;
            ProductDescriptionRBox.Text = ProductDescription;
            MemoryStream ms = new MemoryStream(ProductPicture);
            ProductPictureBox.Image = Image.FromStream(ms);

            DataAccess _DataAccess = new DataAccess();

            foreach (Details CategoryDetail in _DataAccess.RetreiveAllCategoriesFromDatabase())
            {
                ProductCategoryComboBox.Items.Add(CategoryDetail.Name);
            }
        }

        private void UploadPictureButton_Click(object sender, EventArgs e)
        {
            /*selecting image*/

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select Image file..";
            ofd.DefaultExt = ".jpg";
            ofd.Filter = "Media Files|*.jpg;*.png;*.gif;*.bmp;*.jpeg|All Files|*.*";

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                /*if picture selected then load in the picture box*/
                ProductPictureBox.Load(ofd.FileName);
            }
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

        private void UploadPictureButton_MouseEnter(object sender, EventArgs e)
        {
            UploadPictureButton.ForeColor = Color.White;
        }

        private void UploadPictureButton_MouseLeave(object sender, EventArgs e)
        {
            UploadPictureButton.ForeColor = Color.Black;
        }

        private void CancelButton_MouseEnter(object sender, EventArgs e)
        {
            CancelButton.ForeColor = Color.White;
        }

        private void CancelButton_MouseLeave(object sender, EventArgs e)
        {
            CancelButton.ForeColor = Color.Black;
        }

        private void UpdateProductButton_MouseLeave(object sender, EventArgs e)
        {
            UploadPictureButton.ForeColor = Color.Black;
        }

        private void UpdateProductButton_MouseEnter(object sender, EventArgs e)
        {
            UploadPictureButton.ForeColor = Color.White;
        }

        private void UpdateProductButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการที่จะแก้ไขสินค้า ใช่หรือไม่?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataAccess _DataAccess = new DataAccess();

                int ProductID = Convert.ToInt32(ProductIDBox.Text);

                string ProductName = ProductNameBox.Text;

                decimal ProductPrice = Convert.ToDecimal(ProductPriceBox.Text);

                string ProductCategory = ProductCategoryComboBox.Text;

                int ProductCategoryID = _DataAccess.ReturnCategoryID(ProductCategory);

                string ProductDescription = ProductDescriptionRBox.Text;

                /*initializing memory stream class for creating a stream of binary numbers*/
                MemoryStream ms = new MemoryStream();

                /*saving the image in raw format from picture box*/
                ProductPictureBox.Image.Save(ms, ProductPictureBox.Image.RawFormat);

                /*Array of Binary numbers that have been converted*/
                byte[] MyProductPicture = ms.GetBuffer();

                /*closing the memory stream*/
                ms.Close();

                if (_DataAccess.UpdateProduct(ProductID, ProductName, ProductPrice, ProductCategoryID, ProductDescription, MyProductPicture))
                {
                    this.Close();
                }
                else MessageBox.Show("แก้ไขไม่สำเร็จ", "Error", MessageBoxButtons.OK);
            }
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
