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

namespace Final_cafe.GUI
{
    public partial class Staff : Form
    {
        private string staffID;
        private string staffName;
        private string gender;
        private string staffLevel;
        private string staffCode;

        private string conn = "server = localhost; user id = root; password = 1234567890; persistsecurityinfo=True; database = final_cafe; allowuservariables=True";
        int i;
        public Staff()
        {
            InitializeComponent();
        }
        private void Getdata(String username)
        {
            MySqlConnection connection = new MySqlConnection(conn);
            connection.ConnectionString = conn;
            String query = "SELECT StaffID , StaffName, Gender, StaffLevel, StaffCode FROM staffs WHERE StaffID = '" + Staff_ID.Text + "'";
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    this.staffID = rdr["StaffID"].ToString();
                    this.staffName = rdr["CustomerName"].ToString();
                    this.gender = rdr["Gender"].ToString();
                    this.staffLevel = rdr["StaffLevel"].ToString();
                    this.staffCode = rdr["StaffCode"].ToString();
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LOGIN login = new LOGIN();
            login.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            i = 0;
            MySqlConnection connection = new MySqlConnection(conn);
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from staffs where StaffID ='" + Staff_ID.Text + "' and Password ='" + Pass.Text + "'";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("you have entered invalid ID or Password");
            }

            else
            {
                Getdata(Staff_ID.Text);
                this.Hide();
                string StaffID = this.staffID.Trim();
                string StaffName = this.staffName.Trim();
                string StaffLevel = this.staffLevel.Trim();
                string StaffCode = this.staffCode.Trim();
                Staff_Form manu = new Staff_Form(StaffID, StaffName, StaffLevel, StaffCode);
                manu.Show();

            }

            connection.Close();
        }
    }
}
