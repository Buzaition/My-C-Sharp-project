using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Add_Product : Form
    {
       
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=A:\My Projects\C#\.OurProject\WindowsFormsApp1\Database1.mdf;Integrated Security=True");
        string ImgLocation="";
        public Add_Product()
        {
            
            InitializeComponent();
        }
       bool imagefound=false;
        String tempPath;
        private void UpIMG_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*JPG", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagefound=true;
                    ImgLocation = ofd.FileName.ToString();
                    ProPicImg.Image = Image.FromFile(ofd.FileName);
                    tempPath = ofd.FileName;
                }
            }
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
                        
            try {
                if (imagefound == false)
                {
                      tempPath= "A:/My Projects/C#/.OurProject/WindowsFormsApp1/Icon/Close_200px.png";
                }
                if(ProNametxt.Text!="" && ProPricetxt.Text != "" && ProTypeCombo.SelectedItem.ToString()!="")
                {                    
                    if(int.TryParse(ProPricetxt.Text,out int result))
                    {
                        Con.Open();
                        string query = "INSERT into Items values('" + ProNametxt.Text + "','" + ProPricetxt.Text + "','" + tempPath + "','" + ProTypeCombo.SelectedItem.ToString() + "')";

                        SqlCommand Sqlcmd = new SqlCommand(query, Con);
                        int n = Sqlcmd.ExecuteNonQuery();

                        MessageBox.Show(n.ToString() + " Product Added Sucssfully");
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Enter correct Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Enter All Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                imagefound = false;
                ProPricetxt.Text = ProNametxt.Text = "";
                ProPicImg.Image = Image.FromFile("A:/My Projects/C#/.OurProject/WindowsFormsApp1/Icon/Close_200px.png");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
