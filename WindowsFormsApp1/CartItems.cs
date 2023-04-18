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
    public partial class CartItems : UserControl
    {
        public partial class s:Dashbord
        {
            
        }
        public CartItems()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=A:\My Projects\C#\.OurProject\WindowsFormsApp1\Database1.mdf;Integrated Security=True");

        #region Properties


        private string _ProductName;
        private string _productPrice;
        private string Pro_ID;
        private int ProCount;
        private Image image;


        [Category("Custom props")]
        public Image ProductImage
        {
            get { return image; }
            set { image = value; ItemPic.Image = value; }
        }
        
        
        [Category("Custom props")]
        public int ProductCount
        {
            get { return ProCount; }
            set { ProCount = value; label1.Text = value.ToString(); }
        }

        [Category("Custom props")]
        public string Product_Name
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

        public string Product_ID
        {
            get { return Pro_ID; }
            set { Pro_ID = value; ItemID.Text = value; }
        }


        #endregion

        private void CartPic_MouseEnter(object sender, EventArgs e)
        {
            CartPic.Size = new Size(54, 49);
            this.BackColor = Color.DarkViolet;
            //CartPic.Location = new Point(186, 158);
        }

        private void CartPic_MouseLeave(object sender, EventArgs e)
        {
            CartPic.Size = new Size(41, 34);
            this.BackColor = Color.Orange;
            //CartPic.Location = new Point(189, 170);
        }

        private void item_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkViolet;

        }

        private void item_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void CartPic_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "Delete from Cart where ProductId ='" + Product_ID+"'";

                SqlCommand Sqlcmd = new SqlCommand(query, Con);
                Sqlcmd.ExecuteNonQuery();

                MessageBox.Show("Deleted");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {


            Con.Open();
            string query = "update Cart Set ProductCount+=1 where ProductId ='" + Product_ID + "'";
            string query1 = "Select ProductCount From Cart where ProductId ='" + Product_ID + "'";

            SqlCommand Sqlcmd = new SqlCommand(query, Con);
            SqlCommand Sqlcmd1 = new SqlCommand(query1, Con);
            Sqlcmd.ExecuteNonQuery();
            SqlDataReader dr= Sqlcmd1.ExecuteReader();
            dr.Read();
            label1.Text=dr.GetValue(0).ToString();

            
            Con.Close();
            ProductCount++;
            Cart.TotalPrice = ProductCount * double.Parse(ProductPrice);

        }

        private void label3_Click(object sender, EventArgs e)
        {

            {
                Con.Open();
                string query = "update Cart Set ProductCount-=1 where ProductId ='" + Product_ID + "'";
                string query1 = "Select ProductCount From Cart where ProductId ='" + Product_ID + "'";

                SqlCommand Sqlcmd = new SqlCommand(query, Con);
                SqlCommand Sqlcmd1 = new SqlCommand(query1, Con);
                Sqlcmd.ExecuteNonQuery();
                SqlDataReader dr = Sqlcmd1.ExecuteReader();
                while (dr.Read())
                {
                    label1.Text = dr.GetValue(0).ToString();
                }
                


                    Con.Close();
                ProductCount--;
                Cart.TotalPrice = ProductCount * double.Parse(ProductPrice);
            }
            if(ProductCount==0)
            {
                MessageBox.Show("press Delete if You want to Delete Item");
                ProductCount++;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void CartItems_Load(object sender, EventArgs e)
        {
            
        }
    }
}
