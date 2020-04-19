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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
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
                CategoryPictureBox.Load(ofd.FileName);
            }
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();

            bool CategoryAddedOrNot = _DataAccess.AddNewCategoryToDatabase(CategoryNameBox.Text, CategoryDescriptionRBox.Text, CategoryPictureBox);

            if (CategoryAddedOrNot)
            {
                MessageBox.Show("Category Added");
            }
            else MessageBox.Show("Category Not Added");
        }
    }
}
