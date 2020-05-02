using System;
using System.Collections;
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
    public partial class Staff : Form
    {
        public Staff(int staffID)
        {
            InitializeComponent();
            StaffID = staffID;
        }

        public int StaffID = 0;
        ArrayList StaffList;
    
        private void SalesSummary_Load(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();

            foreach (Details StaffDetails in _DataAccess.ReturnStaffList())
            {
                StaffGridView.Rows.Add(StaffDetails.SalesmanID, StaffDetails.StaffName, StaffDetails.StaffCode, StaffDetails.Gender, StaffDetails.StaffPassword, StaffDetails.StaffLevel, "แก้ไข", "ลบ");
            }
        }

        private void StaffGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (StaffGridView.Columns[e.ColumnIndex].Name == "DeleteStaffColumn")
                {
                    if (MessageBox.Show("คุณต้องการลบพนังงานคนนี้\nออกจาก ฐานข้อมูล หรือไม่?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int StaffID = Convert.ToInt32(StaffGridView.Rows[e.RowIndex].Cells["StaffIDColumn"].Value);

                        DataAccess _DataAccess = new DataAccess();

                        if (_DataAccess.DeleteProduct(StaffID))
                        {
                            StaffGridView.Rows.RemoveAt(e.RowIndex);
                        }
                        else if (!_DataAccess.DeleteProduct(StaffID))
                        {
                            MessageBox.Show("ไม่สามารถลบข้อมูลได้");
                        }
                    }
                }
                else if (StaffGridView.Columns[e.ColumnIndex].Name == "EditStaffColumn")
                {
                    int StaffID = Convert.ToInt32(StaffGridView.Rows[e.RowIndex].Cells["StaffIDColumn"].Value);

                    string StaffName = StaffGridView.Rows[e.RowIndex].Cells["StaffNameColumn"].Value.ToString();

                    string StaffCode = StaffGridView.Rows[e.RowIndex].Cells["StaffCodeColumn"].Value.ToString();

                    string Gender = StaffGridView.Rows[e.RowIndex].Cells["GenderColumn"].Value.ToString();

                    string StaffPassword = StaffGridView.Rows[e.RowIndex].Cells["StaffPasswordColumn"].Value.ToString();

                    string StaffLevel = StaffGridView.Rows[e.RowIndex].Cells["StaffLevelColumn"].Value.ToString();

                    UpdateStaff UpdateStaffForm = new UpdateStaff(StaffID, StaffName, StaffCode, Gender, StaffPassword, StaffLevel);

                    if (UpdateStaffForm.ShowDialog() == DialogResult.OK)
                    {
                        DataAccess _DataAccess = new DataAccess();

                        Details UpdatedStaffDetail = _DataAccess.RetreiveStaffDetails(StaffID);

                        StaffGridView.Rows[e.RowIndex].Cells["StaffNameColumn"].Value = UpdatedStaffDetail.StaffName;
                        StaffGridView.Rows[e.RowIndex].Cells["StaffCodeColumn"].Value = UpdatedStaffDetail.StaffCode;
                        StaffGridView.Rows[e.RowIndex].Cells["GenderColumn"].Value = UpdatedStaffDetail.Gender;
                        StaffGridView.Rows[e.RowIndex].Cells["StaffPasswordColumn"].Value = UpdatedStaffDetail.StaffPassword;
                        StaffGridView.Rows[e.RowIndex].Cells["StaffLevelColumn"].Value = UpdatedStaffDetail.StaffLevel;
                    }
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
