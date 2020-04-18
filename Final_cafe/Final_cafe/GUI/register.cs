using System;
using System.Data;
using System.Windows.Forms;
using Final_cafe.GUI;
using MySql.Data.MySqlClient;

namespace Final_cafe
{
    public partial class Register : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; password = 1234567890; persistsecurityinfo=True; database = final_cafe; allowuservariables=True");
        public Register()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void X_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LOGIN login = new LOGIN();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String point = "10";

            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO customers(CustomerID,CustomerName,Gender,CustomerType,CustomerTelNo,Password,username, Point) VALUES ('" + null + "','" + flname.Text + "','" + comboBox1 + "','" + comboBox2 + "','" + telNo.Text + "','" + pass.Text + "','" + user.Text + "','" + point + "')";
            cmd.ExecuteNonQuery(); 
            conn.Close();
            flname.Text = "";
            telNo.Text = "";
            user.Text = "";
            pass.Text = "";
            MessageBox.Show("Register Complete");
            this.Dispose();
            LOGIN login = new LOGIN();
            login.Show();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void telNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
