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
    public partial class LOGIN : Form
    {

        private String customerID;
        private String customername;
        private String customertype;
        private String gender;
        private String customertelno;
        private String point;

        private string conn = "server = localhost; user id = root; password = 1234567890; persistsecurityinfo=True; database = final_cafe; allowuservariables=True";
        int i;

        public LOGIN()
        {
            InitializeComponent();
        }

        private void Getdata(String username)
        {
            MySqlConnection connection = new MySqlConnection(conn);
            connection.ConnectionString = conn;
            String query = "SELECT CustomerID , CustomerName, CustomerType, Gender, CustomerTelNo, Point FROM customers WHERE UserName = '" + Username.Text + "'";
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    this.customerID = rdr["CustomerID"].ToString();
                    this.customername = rdr["CustomerName"].ToString();
                    this.customertype = rdr["CustomerType"].ToString();
                    this.gender = rdr["Gender"].ToString();
                    this.customertelno = rdr["CustomerTelNo"].ToString();
                    this.point = rdr["Point"].ToString();
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

        private void Login_button_Click(object sender, EventArgs e)
        {
            i = 0;
            MySqlConnection connection = new MySqlConnection(conn);
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from customers where UserName ='" + Username.Text + "' and Password ='" + Pass.Text + "'";
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
                Getdata(Username.Text);
                this.Hide();
                string CustomerID = this.customerID.Trim();
                string CustomerName = this.customername.Trim();
                string Gender = this.gender.Trim();
                string CustomerType = this.customertype.Trim();
                string CustomerTelNo = this.customertelno.Trim();
                string Point = this.point.Trim();
                Menu manu = new Menu(CustomerName, Point);
                manu.Show();
                
            }

            connection.Close();
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
        }



        private void X_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
           private void login_Load(object sender, EventArgs e)
        {

        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff Staff = new Staff();
            Staff.ShowDialog();
        }
    } 
}   
