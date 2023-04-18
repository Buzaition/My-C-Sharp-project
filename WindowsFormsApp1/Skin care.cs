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
    public partial class ItemsShow : Form
    {
       
         /*public Image retrive()
        {

        }*/
        
        public ItemsShow()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=A:\My Projects\C#\.OurProject\WindowsFormsApp1\Database1.mdf;Integrated Security=True");

        private void populateItems()
        {
            try
            {
                //poplate 
                item[] ListItems = new item[100];

                //Loop throught each item
                 int i = 0;
                Con.Open();
                SqlCommand cmd = new SqlCommand("Select ProductId,ProductName,ProductPrice,ProductImage from Items Where ProductType='Skin Care'", Con);
                SqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    
                    ListItems[i] = new item();
                    ListItems[i].Text = dr[i].ToString();
                    ListItems[i].Product_ID = dr.GetValue(0).ToString();
                    ListItems[i].Product_Name = dr.GetValue(1).ToString();
                    ListItems[i].ProductPrice = dr.GetValue(2).ToString();
                    ListItems[i].ProductImgPath=dr.GetValue(3).ToString();

                    Image image = Image.FromFile(dr.GetValue(3).ToString());
                    ListItems[i].ProductImage = image;

                    flowLayoutPanel1.Controls.Add(ListItems[i]);
                    i++;

                }

                Con.Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void ItemsShow_Load(object sender, EventArgs e)
        {
            populateItems();
        }
    }
}
