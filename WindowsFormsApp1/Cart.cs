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
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=A:\My Projects\C#\.OurProject\WindowsFormsApp1\Database1.mdf;Integrated Security=True");


        public static void CalcTotalPrice(SqlConnection Con1,Label lbl)
        {
            try
            {
                double total = 0;
                if (Con1.State != ConnectionState.Open) {Con1.Open(); }
                
                string query = "Select ProductPrice,ProductCount from Cart";

                SqlCommand Sqlcmd = new SqlCommand(query, Con1);
                SqlDataReader dr = Sqlcmd.ExecuteReader();
                while (dr.Read())
                {
                    total += Double.Parse(dr.GetValue(1).ToString()) * Double.Parse(dr.GetValue(0).ToString());

                }
                Con1.Close();
                lbl.Text= "Amount will be paid: " + total.ToString();

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con1.Close();
            }
        }
        //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=A:\My Projects\C#\.OurProject\WindowsFormsApp1\Database1.mdf;Integrated Security=True");
        /*private string Calc_Price(FlowLayoutPanel pan, CartItems CI)
        {
            foreach (var item in pa)
            {

            }

        }*/
        public static double TotalPrice=0;
        private void populateItems()
        {
            try
            {
                //poplate 
                CartItems[] ListItems = new CartItems[100];

                //Loop throught each item
                int i = 0;
                Con.Open();
                SqlCommand cmd = new SqlCommand("Select ProductId,ProductName,ProductPrice,ProductImage,ProductCount from Cart", Con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    ListItems[i] = new CartItems();
                    ListItems[i].Product_ID = dr.GetValue(0).ToString();
                    ListItems[i].Product_Name = dr.GetValue(1).ToString();
                    ListItems[i].ProductPrice = dr.GetValue(2).ToString();
                    Image image = Image.FromFile(dr.GetValue(3).ToString());
                    ListItems[i].ProductCount= int.Parse(dr.GetValue(4).ToString());
                    ListItems[i].ProductImage = image;

                    flowLayoutPanel1.Controls.Add(ListItems[i]);
                    i++;

                }

                Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        

        private void ItemsShow_Load(object sender, EventArgs e)
        {
            populateItems();
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            Con.Open();
            SqlCommand cmd = new SqlCommand("Delete FROM Cart", Con);
            SqlDataReader dr = cmd.ExecuteReader();
            Con.Close();
            
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

            Con.Open();
            SqlCommand cmd = new SqlCommand("Delete FROM Cart", Con);
            SqlDataReader dr = cmd.ExecuteReader();
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double total = 0;
                Con.Open();
                string query = "Select ProductPrice,ProductCount from Cart";

                SqlCommand Sqlcmd = new SqlCommand(query, Con);
                SqlDataReader dr = Sqlcmd.ExecuteReader();
                while (dr.Read())
                {
                    total += Double.Parse(dr.GetValue(1).ToString()) * Double.Parse(dr.GetValue(0).ToString());

                }
                MessageBox.Show("Amount will be paid: " + total.ToString());

                Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            CalcTotalPrice(Con, pricelbl);
        }
    }
}

