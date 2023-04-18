using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Dashbord : Form
    {
        
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=A:\My Projects\C#\.OurProject\WindowsFormsApp1\Database1.mdf;Integrated Security=True");
       //for moving between forms
        public static double totalPrice;
        public static bool Admin;
        public static String LoginUserName="Username";
        public static int LoginUserID=0;
        

        //for move a form
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        //Fields
        private Button currentButton;
        private Random random;
        private int TempIndex;
        public Dashbord()
        {
            InitializeComponent();
            random = new Random();
        }


        
        
       
        
        private void DelContFromPanel ()
        {
            
        }

        private Color SelThemCol()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (TempIndex == index)
            {
                random.Next(ThemeColor.ColorList.Count);
            }
            TempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }


        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelThemCol();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                   // flowLayoutPanel1.BackColor = color;
                    //SideMenu.BackColor = color;
                    UserNamelbl.ForeColor = color;
                    StoreCloselbl.ForeColor = color;

                }
            }

        }
        private void DisableButton()
        {
           
            foreach (Control prevBtn in SideMenu.Controls)
            {
                if (prevBtn.GetType() == typeof(Button))
                {
                    prevBtn.BackColor = Color.Orange;
                    prevBtn.ForeColor = Color.White;
                    prevBtn.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            } 


        }



        private void StoreCloselbl_Click_1(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            ItemsShow IS = new ItemsShow() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.formView.Controls.Clear();
            this.formView.Controls.Add(IS);
            refLBL.Hide();
            CartRef.Hide();
            IS.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            SportMachine SM = new SportMachine() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.formView.Controls.Clear();
            this.formView.Controls.Add(SM);
            SM.Show();
            refLBL.Hide();
            CartRef.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            Splints SP = new Splints() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.formView.Controls.Clear();
            this.formView.Controls.Add(SP);
            SP.Show();
            refLBL.Hide();
            CartRef.Hide();
        }

        private void AddPro_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            Add_Product  AP = new Add_Product() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.formView.Controls.Clear();
            this.formView.Controls.Add(AP);
            AP.Show();
            refLBL.Hide();
            CartRef.Hide();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            Supplements ST = new Supplements() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.formView.Controls.Clear();
            this.formView.Controls.Add(ST);
            ST.Show(); ActiveButton(sender);
            refLBL.Hide();
            CartRef.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            Cart CT =new Cart(){ Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.formView.Controls.Clear();
            this.formView.Controls.Add(CT);
            CT.Show();
            refLBL.Show();
            CartRef.Show();
            
            
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            Settings ST = new Settings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.formView.Controls.Clear();
            this.formView.Controls.Add(ST);
            ST.Show();
            refLBL.Hide();
            CartRef.Hide();
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

        private void Form1_Load(object sender, EventArgs e)
        {
           DisableButton();
            if(Admin==true)
            UserNamelbl.Text = LoginUserName;
            UserNamelbl.Text = LoginUserName;
                DelContFromPanel();
            Main main = new Main() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.formView.Controls.Clear();
            this.formView.Controls.Add(main);
            main.Show();

            

            if (UserNamelbl.Text != "Admin")
            {

                foreach (Control c in SideMenu.Controls)
                {
                    if (c.Name == "Add_Productbtn" || c.Name == "EditItems")
                        c.Hide();
                    
                }
            }

            else
            {
                foreach (Control c in SideMenu.Controls)
                {
                    if (c.Name == "SkinCare" || c.Name == "SportMa" || c.Name == "Splints" || c.Name == "Supplements" || c.Name == "Cart"|| c.Name == "Settings")
                        c.Hide();

                }

                UserNamelbl.Text = "Admin";
            }
        }

        private void Side_Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CartRef_Click(object sender, EventArgs e)
        {
            Cart AP = new Cart() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.formView.Controls.Clear();
            this.formView.Controls.Add(AP);
            AP.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new SignIn().Show();
            this.Close();
        }

        private void EditItems_Click(object sender, EventArgs e)
        {
            Edit ed = new Edit() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.formView.Controls.Clear();
            this.formView.Controls.Add(ed);
            ed.Show();
        }
    }
}
