using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;
using NUnit.Framework;

namespace WindowsFormsApp1
{


    public partial class SignUp1 : Form
    {

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=A:\My Projects\C#\.OurProject\WindowsFormsApp1\Database1.mdf;Integrated Security=True");
       
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;



        public SignUp1()
        {
            InitializeComponent();

        }
        
        


         

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (Passwordtxt.Text == "Password")
                Passwordtxt.Text = "";
            if (ShowPassChBx.Checked != true)
                Passwordtxt.PasswordChar = '•';
            ANPASSLBL.Text = "Password";
            Passwordbtn.BackColor = Color.FromArgb(42, 207, 151);
        }






        //---------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------
        private void Repasswordtxt_Enter(object sender, EventArgs e)
        {
            if (Repasswordtxt.Text == "Re-Enter Password")
                Repasswordtxt.Text = "";
            if (ShowPassChBx.Checked != true)
                Repasswordtxt.PasswordChar = '•';
            ANREPASSLBL.Text = "Re-Enter Password";
            rePasswordbtn.BackColor = Color.FromArgb(42, 207, 151);
        }






        //---------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------
        private void Emailtxt_Enter(object sender, EventArgs e)
        {
            if (Emailtxt.Text == "Email")
            {
                Emailtxt.ForeColor = Color.Gray;
                Emailtxt.Text = "someone@example.com";
                Emailtxt1.Visible = false;
            }
            Emaillbl.Text = "Email";
            Emailbtn.BackColor = Color.FromArgb(42, 207, 151);
        }



        //-------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------
        //*************************************************************************************************************************************







        //controles Leave**********************************************************************************************************************
        //controles Leave----------------------------------------------------------------------------------------------------------------------
        //controles Leave----------------------------------------------------------------------------------------------------------------------
        //controles Leave----------------------------------------------------------------------------------------------------------------------
        //first
        private void Emailtxt_Leave(object sender, EventArgs e)
        {
            if (Emailtxt.Text == "" || Emailtxt.Text == "someone@example.com")
            {
                Emailtxt1.Visible = true;
                Emailtxt.Text = "Email";
            }
            Emaillbl.Text = "";
            Emailbtn.BackColor = Color.Gray;
            Emailtxt.ForeColor = Color.Black;
        }
        //---------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------
        //Second
        private void Repasswordtxt_Leave(object sender, EventArgs e)
        {
            if (Repasswordtxt.Text == "" || Repasswordtxt.Text == "Re-Enter Password")
            {
                Repasswordtxt.PasswordChar = '\0';
                Repasswordtxt.Text = "Re-Enter Password";
            }
            ANREPASSLBL.Text = "";
            rePasswordbtn.BackColor = Color.Gray;
        }
        //---------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (Usertxt.Text == "")
                Usertxt.Text = "User Name";
            ANUSERLBL.Text = "";
            Userbtn.BackColor = Color.Black;
        }


        //---------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (Passwordtxt.Text == "")
            {
                Passwordtxt.PasswordChar = '\0';
                Passwordtxt.Text = "Password";
            }
            ANPASSLBL.Text = "";
            Passwordbtn.BackColor = Color.Gray;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------
        //*******************************************************************************************************************************************






        private void label1_Click(object sender, EventArgs e)
        {
           
            Application.Exit();

        }
        
        



       
       

       

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ShowPassChBx_CheckedChanged(object sender, EventArgs e)
        {

            if (ShowPassChBx.Checked == true)
            { 
                Passwordtxt.PasswordChar = '\0'; 
                Repasswordtxt.PasswordChar = '\0'; 
            }
            if (ShowPassChBx.Checked == false)
            {
                if (Passwordtxt.Text != ""&&Passwordtxt.Text != "Password")
                    Passwordtxt.PasswordChar = '•';

                if (Repasswordtxt.Text != "" && Repasswordtxt.Text != "Re-Enter Password")
                    Repasswordtxt.PasswordChar = '•';
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {


 //------------------------------------------------------------------------------------------------------------------------------------------------------
            bool a = (Usertxt.Text == " " || Usertxt.Text == "User Name") && (Passwordtxt.Text == "Password" || Passwordtxt.Text == " ");
            bool b = (Usertxt.Text == " " || Usertxt.Text == "User Name") && (Passwordtxt.Text == "Password");
            bool c = Usertxt.Text == " " || Usertxt.Text == "User Name";
            bool d = Passwordtxt.Text == "Password" || Passwordtxt.Text == " ";
            bool h = Repasswordtxt.Text == "Re-Enter Password" || Repasswordtxt.Text == " ";
            bool f = Passwordtxt.Text.Length < 6;
            bool g = Repasswordtxt.Text != Passwordtxt.Text;
//------------------------------------------------------------------------------------------------------------------------------------------------------
            
            //first case
            if (a)
                MessageBox.Show("Please Enter User Name and Password");


            //seconed case----------------------------------------------------------------------
            else if (c && h)
                MessageBox.Show("Enter User Name and Re-Enter passwords");


            //3RD case--------------------------------------------------------------------------
            else if (c && g)
                MessageBox.Show("Enter User Name and similar passwords");


            //4TH case--------------------------------------------------------------------------
            else if (f && g)
                MessageBox.Show("passwords should be similar and Equal or More Than 6 Digit");


            //5TH case--------------------------------------------------------------------------
            else if (c)
                MessageBox.Show("Please, Enter User Name");


            //6TH case--------------------------------------------------------------------------
            else if (d)
                MessageBox.Show("Please, Enter Your Password");


            //7TH case--------------------------------------------------------------------------
            else if (h)
                MessageBox.Show("Please, Re-Enter Your Password");


            //8TH case--------------------------------------------------------------------------
            else if (f)
                MessageBox.Show("Please, Password Must be Equal or More Than 6 Digit");


            //9TH case--------------------------------------------------------------------------
            else if (g)
                MessageBox.Show("Passwords are different,Please Enter similar passwords");

            else
            {
                try
                {
                    string tempPath = "A:/My Projects/C#/.OurProject/WindowsFormsApp1/Icon/hacking_128px.png";

                    Con.Open();
                    string query = "IF NOT EXISTS (select * from Users where username ='"+ Usertxt.Text + "')BEGIN INSERT into Users values('" + Usertxt.Text + "','" + Passwordtxt.Text + "','" + Emailtxt.Text + "','"+tempPath+"',NULL,NULL,NULL,NULL)END"; 

                    SqlCommand Sqlcmd=new SqlCommand(query,Con);
                    Sqlcmd.ExecuteNonQuery();

                    MessageBox.Show("Account created sucsusfully");
                    Usertxt.Text = Passwordtxt.Text = Repasswordtxt.Text = Emailbtn.Text = "";
                    Con.Close();
                    new SignIn().Show();
                    this.Close();





                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            
            





        }

        private void label4_Click(object sender, EventArgs e)
        {
           new SignIn().Show();
            this.Close();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            SignUpbtn.ForeColor = Color.FromArgb(43, 37, 112);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            SignUpbtn.ForeColor = Color.WhiteSmoke;
        }


        private void Label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromArgb(42, 207, 151);
        }

        private void Emailtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Emailtxt.Text== "someone@example.com")
            {
            Emailtxt.Text = "";
                Emailtxt.ForeColor = Color.Black ;

            }
            
        }

       

        private void SignUp1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Users' table. You can move, or remove it, as needed.
           // this.usersTableAdapter.Fill(this.database1DataSet.Users);

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

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Usertxt_TextChanged(object sender, EventArgs e)
        {
            if (Usertxt.Text == "User Name")
                Usertxt.Text = "";
            
            ANUSERLBL.Text = "User Name";
            Userbtn.BackColor = Color.FromArgb(42, 207, 151);

        }
    }
}