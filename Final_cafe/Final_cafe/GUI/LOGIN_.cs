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

        private String costomerID;
        private String customername;
        private String customertype;
        private String gender;
        private String customertelno;

        public string conn = "server = localhost; user id = root; password = 1234567890; persistsecurityinfo=True; database = final_cafe; allowuservariables=True";

        

        private void getTheName(String username)
        {
            MySqlConnection connection = new MySqlConnection(conn);
            connection.ConnectionString = conn;
            String query = "SELECT CostomerID,CustomerName,Gender,CustomerType,CustomerTelNo  FROM customerss WHERE UserName = " + Username.Text;
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    this.costomerID = rdr["CostomerID"].ToString();
                    this.customername = rdr["CustomerName"].ToString();
                    this.gender = rdr["Gender"].ToString();
                    this.customertype = rdr["CustomerType"].ToString();
                    this.customertelno = rdr["CustomerTelNo"].ToString();

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

        public LOGIN()
        {
            InitializeComponent();
        }


        private void X_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            int i = 0;
            MySqlConnection connection = new MySqlConnection(conn);
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from customers where UserName ='" + Username.Text + "' and Pass ='" + Pass.Text + "'";
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
                this.getTheName(Username.Text);
                this.Hide();
                string CostomerID = this.costomerID;
                string CustomerName = this.customername;
                string Gender = this.gender;
                string CustomerType = this.customertype;
                string CustomerTelNo = this.customertelno;
                Menu manu = new Menu(CustomerName, CostomerID, CustomerType, Gender, CustomerTelNo);
                manu.Show();
                
            }

            connection.Close();
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            /* this.Hide();
               Register register = new Register();
               register.ShowDialog();*/
        }
    }
}
