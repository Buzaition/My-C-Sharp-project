using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text=="User Name")
            textBox3.Text = "";
            ANUSERLBL.Text = "User Name";
            Userbtn.BackColor = Color.FromArgb(42,207,151);
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text=="Password")
            textBox4.Text = "";
            if(ShowPassChBx.Checked!=true)
            textBox4.PasswordChar = '•';
            ANPASSLBL.Text = "Password";
            Passwordbtn.BackColor = Color.FromArgb(42, 207, 151);
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
                textBox3.Text = "User Name";
            ANUSERLBL.Text = "";
            Userbtn.BackColor = Color.Gray;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.PasswordChar = '\0';
                textBox4.Text = "Password";
            }
            ANPASSLBL.Text = "";
            Passwordbtn.BackColor = Color.Gray;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ShowPassChBx_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowPassChBx.Checked==true)
                textBox4.PasswordChar = '\0';
            else
                textBox4.PasswordChar = '•';

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if ((textBox3.Text == " " || textBox3.Text == "User Name") && (textBox4.Text == "Password" || textBox4.Text == " "))
                MessageBox.Show("Please Enter User Name and Password");
            else if(textBox3.Text == " " || textBox3.Text == "User Name")
                MessageBox.Show("Please, Enter User Name");
            else if(textBox4.Text == "Password" || textBox4.Text == " ")
                MessageBox.Show("Please, Enter Your Password");
            else if(textBox4.Text.Length<6)
                MessageBox.Show("Please, Password Must be Equal or More Than 6 Digit");




        }
    }
}