using Microsoft.AspNet.SignalR.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_cafe.GUI
{
    public partial class Register : Form
    {
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
            /*int amu = 500;
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
            int rnd12 = rnd.Next(0, 9);
            int rnd13 = rnd.Next(0, 9);

            string userid = "" + rnd1 + rnd2 + rnd3 + rnd4 + rnd5 + rnd6 + rnd7 + rnd8 + rnd9 + rnd10 + rnd11 + rnd12 + rnd13;

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO bank_member(First_Name,Last_Name,ID,Password,Username) VALUES ('" + fname.Text + "','" + lname.Text + "','" + userid + "','" + pass.Text + "','" + user.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO bank_account(ID,Balance) VALUES ('" + userid + "','" + amu + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
            fname.Text = "";
            lname.Text = "";
            user.Text = "";
            pass.Text = "";
            MessageBox.Show("Register Complete");
            fname.Clear();
            lname.Clear();
            user.Clear();
            pass.Clear();*/

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
