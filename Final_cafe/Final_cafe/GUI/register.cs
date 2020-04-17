using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Random rnd = new Random();
            int rnd1 = rnd.Next(0, 9);
            int rnd2 = rnd.Next(0, 9);
            int rnd3 = rnd.Next(0, 9);
            int rnd4 = rnd.Next(0, 9);
            int rnd5 = rnd.Next(0, 9);
            int rnd6 = rnd.Next(0, 9);
            int rnd7 = rnd.Next(0, 9);
            int rnd8 = rnd.Next(0, 9);
            int rnd9 = rnd.Next(0, 9);
            int rnd10 = rnd.Next(0, 9);
            int rnd11 = rnd.Next(0, 9);
      

            string userid = "" + rnd1 + rnd2 + rnd3 + rnd4 + rnd5 + rnd6 + rnd7 + rnd8 + rnd9 + rnd10 + rnd11 ;

            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO customers(CustomerID,CustomerName,Gender,CustomerType,CustomerTelNo,Password,username) VALUES ('" + userid + "','" + flname.Text + "','" + gender.Text + "','" + type.Text + "','" + telNo.Text + "','" + pass.Text + "','" + user.Text + "')";
            cmd.ExecuteNonQuery(); 
            conn.Close();
            flname.Text = "";
            gender.Text = "";
            type.Text = "";
            telNo.Text = "";
            user.Text = "";
            pass.Text = "";
            MessageBox.Show("Register Complete");
            flname.Clear();
            gender.Clear();
            type.Clear();
            telNo.Clear();
            user.Clear();
            pass.Clear();

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
    }
}
