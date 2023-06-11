using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Form1 : Form
    {

        bool formopen = false;
       
        public Form1()
        {
            InitializeComponent();
            passwordRTB.PasswordChar = '*';
            //   Admin a = new Admin();
            //a.ShowDialog();

            Dashboard d = new Dashboard();
            d.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  Form1 naviagte = new Form1();
            string username = "shubhangi";
            string password = "piya";

           

           
            if (username == usernameRTB.Text && password == passwordRTB.Text)
            {
                //this.Close();
                //    clearDetails();
                Dashboard dashboard = new Dashboard();

                MessageBoxButtons buttons = MessageBoxButtons.OK;

                DialogResult result = MessageBox.Show("Login Successful", "Message", buttons);
               // dashboard.ShowDialog();
               
               if(result == DialogResult.OK)
                {
                    dashboard.Show();
                }
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;

                DialogResult result = MessageBox.Show("Wrong username & password", "Message", buttons);

            }
            //f.Close();

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void passwordRTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameRTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
