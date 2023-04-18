using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SignIn : Form
    {


        
        //for move a form
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public SignIn()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=A:\My Projects\C#\.OurProject\WindowsFormsApp1\Database1.mdf;Integrated Security=True");
        SqlCommand com=new SqlCommand();
        private void label1_Click(object sender, EventArgs e)
        {


            Application.Exit();
            

        }
        
        

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (Usertxt.Text=="User Name")
            Usertxt.Text = "";
            ANUSERLBL.Text = "User Name";
            Userbtn.BackColor = Color.FromArgb(42,207,151);
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (Passtxt.Text=="Password")
            Passtxt.Text = "";
            if(ShowPassChBx.Checked!=true)
            Passtxt.PasswordChar = '•';
            ANPASSLBL.Text = "Password";
            Passwordbtn.BackColor = Color.FromArgb(42, 207, 151);
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (Usertxt.Text == "")
                Usertxt.Text = "User Name";
            ANUSERLBL.Text = "";
            Userbtn.BackColor = Color.Gray;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (Passtxt.Text == "")
            {
                Passtxt.PasswordChar = '\0';
                Passtxt.Text = "Password";
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
                Passtxt.PasswordChar = '\0';
            else if(ShowPassChBx.Checked==false && Passtxt.Text != "Password")
                Passtxt.PasswordChar = '•';

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if ((Usertxt.Text == " " || Usertxt.Text == "User Name") && (Passtxt.Text == "Password" || Passtxt.Text == " "))
                MessageBox.Show("Please Enter User Name and Password");
            else if (Usertxt.Text == " " || Usertxt.Text == "User Name")
                MessageBox.Show("Please, Enter User Name");
            else if (Passtxt.Text == "Password" || Passtxt.Text == " ")
                MessageBox.Show("Please, Enter Your Password");
            else if (Passtxt.Text.Length < 6)
                MessageBox.Show("Please, Password Must be Equal or More Than 6 Digit");

            else
            {
                Con.Open();
                com.Connection = Con;
                com.CommandText = "Select * FROM Users";
                SqlDataReader dr = com.ExecuteReader();
                bool tempCheck = false;
                while(dr.Read())
                {
                    if (Usertxt.Text.Equals(dr.GetValue(0).ToString()) && Passtxt.Text.Equals(dr.GetValue(1).ToString()))
                    {
                        Dashbord.LoginUserName = dr.GetValue(0).ToString();
                        Dashbord.LoginUserID = int.Parse(dr.GetValue(8).ToString());
                        MessageBox.Show("Login Done", "congrates", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new Dashbord().Show();
                        this.Close();
                        tempCheck = true;
                       
                    }
                    else
                    {
                        tempCheck = false;
                    }

      
                }
                if(tempCheck==false)
                {
                    MessageBox.Show("User name or password is inccorect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                Con.Close();
                Dashbord.Admin = false;
               
               



            }
        }
           

        private void label4_Click(object sender, EventArgs e)
        {
            new SignUp1().Show();
            this.Close();

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
             button2.ForeColor = Color.FromArgb(43,37,112);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
        }
        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromArgb(43, 37, 112);
        }

        private void Label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromArgb(42, 207, 151);
        }
        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            new Admin_Login().Show();
            this.Close();
        }
    }
}