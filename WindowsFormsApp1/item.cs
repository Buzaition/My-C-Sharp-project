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
    public partial class item : UserControl
    {
        public item()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=A:\My Projects\C#\.OurProject\WindowsFormsApp1\Database1.mdf;Integrated Security=True");


        #region Properties


        private string  _ProductName;
        private string _productPrice;
        private string Pro_ID;
        private string ImgPath;
        private Image image;


        [Category("Custom props")]
        public Image ProductImage
        {
            get { return image; }
            set { image = value; ItemPic.Image = value; }
        }

        [Category("Custom props")]
        public string  Product_Name
        {
            get { return _ProductName; }
            set { _ProductName = value; ItemName.Text = value; }
        }

        [Category("Custom props")]
        public string ProductPrice
        {
            get { return _productPrice; }
            set { _productPrice = value; ItemPrice.Text = value; }
        }
        [Category("Custom props")]
        public string Product_ID
        {
            get { return Pro_ID; }
            set { Pro_ID = value; ItemID.Text = value; }
        }
        
        [Category("Custom props")]
        public string ProductImgPath
        {
            get { return ImgPath; }
            set { ImgPath = value; }
        }


        #endregion

        private void CartPic_MouseEnter(object sender, EventArgs e)
        {
            CartPic.Size= new Size (54, 49);
            this.BackColor = Color.Orange;
            //CartPic.Location = new Point(186, 158);
        }

        private void CartPic_MouseLeave(object sender, EventArgs e)
        {
            CartPic.Size = new Size(41, 34);
            this.BackColor = Color.DarkViolet; 
            //CartPic.Location = new Point(189, 170);
        }

        private void item_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;

        }

        private void item_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkViolet;            
        }

        private void CartPic_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                Con.Open();
                string query = "IF NOT EXISTS (select * from Cart where ProductId ='" + Product_ID + "')BEGIN INSERT into Cart values('"+Product_ID+ "','" + Product_Name + "','" + ProductPrice + "','" + ImgPath + "',1)END";
               //  string query = "IF NOT EXISTS (select ProductId,ProductName,ProductPrice,ProductImage from Cart where ProductId ='" + Product_ID + "')BEGIN INSERT into Cart values('"+Product_ID+ "','" + Product_Name + "','" + ProductPrice + "','" + ImgPath + "')END";

                SqlCommand Sqlcmd = new SqlCommand(query, Con);
                Sqlcmd.ExecuteNonQuery();
                


                MessageBox.Show("Added");
                

                Con.Close();






           /* }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
    }
}
