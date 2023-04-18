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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=A:\My Projects\C#\.OurProject\WindowsFormsApp1\Database1.mdf;Integrated Security=True");
        bool imagefound = false;
        String tempPath;
        string ImgLocation = "";


        private void CloseFormExpect(string Formname)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != Formname)
                    f.Close();
            }
        }


        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);
            
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            try
            {
            
                Con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Users Where UserID='"+Dashbord.LoginUserID.ToString()+"'", Con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                { 
                    Firsttxt.Text = dr.GetValue(5).ToString();
                    Lasttxt.Text= dr.GetValue(6).ToString();
                    Usernametxt.Text= dr.GetValue(0).ToString();
                    adresstxt.Text = dr.GetValue(7).ToString();
                    phonetxt.Text = dr.GetValue(4).ToString();
                    Emailtxt.Text = dr.GetValue(2).ToString();
                    Image image = Image.FromFile(dr.GetValue(3).ToString());
                    UserImage.Image = image;


                }

                Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }

            if (Dashbord.Admin == true)
            {
                //UserImage.image=  Image.FromFile(@"A\My Projects\C#\.OurProject\WindowsFormsApp1\Icon\hacking_128px.png.bmp");
                Image image = Image.FromFile("A:/My Projects/C#/.OurProject/WindowsFormsApp1/Icon/hacking_128px.png");
                this.UserImage.Image = image;


            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            new SignIn().Show();
            CloseFormExpect("SignIn");
        }
        private void Update_Click(object sender, EventArgs e)
        {
            if (imagefound == false)
            {
                tempPath = "A:/My Projects/C#/.OurProject/WindowsFormsApp1/Icon/hacking_128px.png";
            }

            Con.Open();
            string query = "update Users Set FirstName='" + Firsttxt.Text + "',LastName='" + Lasttxt.Text + "',Adress='" + adresstxt.Text + "',PhoneNumber='" + phonetxt.Text + "',Email='" + Emailtxt.Text + "',UserImage='"+tempPath+"'  where UserID ='" + Dashbord.LoginUserID.ToString() + "'";
            SqlCommand Sqlcmd = new SqlCommand(query, Con);
            Sqlcmd.ExecuteNonQuery();
            MessageBox.Show("User Data Update");
            Con.Close();
        }
            
           

        private void UpIMG_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*JPG", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagefound = true;
                    ImgLocation = ofd.FileName.ToString();
                    UserImage.Image = Image.FromFile(ofd.FileName);
                    tempPath = ofd.FileName;
                }
                Image Personimage = Image.FromFile(@"A:\My Projects\C#\.OurProject\WindowsFormsApp1\Icon\girl_running_50px.png");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        { 

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new SignIn().Show();
            CloseFormExpect("SignIn");
           
        }

        private void Usernametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
