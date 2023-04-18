namespace WindowsFormsApp1
{
    partial class Dashbord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button LogOut;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashbord));
            System.Windows.Forms.Button EditItems;
            System.Windows.Forms.Button Add_Productbtn;
            System.Windows.Forms.Button Settings;
            System.Windows.Forms.Button Cart;
            System.Windows.Forms.Button Supplements;
            System.Windows.Forms.Button Splints;
            System.Windows.Forms.Button SportMa;
            System.Windows.Forms.Button SkinCare;
            this.SideMenu = new System.Windows.Forms.Panel();
            this.Side_Menu = new System.Windows.Forms.Panel();
            this.FYHlbl = new System.Windows.Forms.Label();
            this.ManIconPicBox = new System.Windows.Forms.PictureBox();
            this.UserNamelbl = new System.Windows.Forms.Label();
            this.StoreCloselbl = new System.Windows.Forms.Label();
            this.formView = new System.Windows.Forms.Panel();
            this.refLBL = new System.Windows.Forms.Label();
            this.CartRef = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            LogOut = new System.Windows.Forms.Button();
            EditItems = new System.Windows.Forms.Button();
            Add_Productbtn = new System.Windows.Forms.Button();
            Settings = new System.Windows.Forms.Button();
            Cart = new System.Windows.Forms.Button();
            Supplements = new System.Windows.Forms.Button();
            Splints = new System.Windows.Forms.Button();
            SportMa = new System.Windows.Forms.Button();
            SkinCare = new System.Windows.Forms.Button();
            this.SideMenu.SuspendLayout();
            this.Side_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManIconPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartRef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogOut
            // 
            LogOut.BackColor = System.Drawing.Color.Orange;
            LogOut.Dock = System.Windows.Forms.DockStyle.Top;
            LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            LogOut.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LogOut.Image = ((System.Drawing.Image)(resources.GetObject("LogOut.Image")));
            LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            LogOut.Location = new System.Drawing.Point(0, 808);
            LogOut.Margin = new System.Windows.Forms.Padding(4);
            LogOut.Name = "LogOut";
            LogOut.Size = new System.Drawing.Size(292, 74);
            LogOut.TabIndex = 13;
            LogOut.Text = "LogOut";
            LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            LogOut.UseVisualStyleBackColor = false;
            LogOut.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // EditItems
            // 
            EditItems.BackColor = System.Drawing.Color.Orange;
            EditItems.Dock = System.Windows.Forms.DockStyle.Top;
            EditItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            EditItems.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            EditItems.Image = ((System.Drawing.Image)(resources.GetObject("EditItems.Image")));
            EditItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            EditItems.Location = new System.Drawing.Point(0, 734);
            EditItems.Margin = new System.Windows.Forms.Padding(4);
            EditItems.Name = "EditItems";
            EditItems.Size = new System.Drawing.Size(292, 74);
            EditItems.TabIndex = 12;
            EditItems.Text = "Edit Products";
            EditItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            EditItems.UseVisualStyleBackColor = false;
            EditItems.Click += new System.EventHandler(this.EditItems_Click);
            // 
            // Add_Productbtn
            // 
            Add_Productbtn.BackColor = System.Drawing.Color.Orange;
            Add_Productbtn.Dock = System.Windows.Forms.DockStyle.Top;
            Add_Productbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Add_Productbtn.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Add_Productbtn.Image = ((System.Drawing.Image)(resources.GetObject("Add_Productbtn.Image")));
            Add_Productbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Add_Productbtn.Location = new System.Drawing.Point(0, 660);
            Add_Productbtn.Margin = new System.Windows.Forms.Padding(4);
            Add_Productbtn.Name = "Add_Productbtn";
            Add_Productbtn.Size = new System.Drawing.Size(292, 74);
            Add_Productbtn.TabIndex = 8;
            Add_Productbtn.Text = "Add Product";
            Add_Productbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            Add_Productbtn.UseVisualStyleBackColor = false;
            Add_Productbtn.Click += new System.EventHandler(this.AddPro_Click);
            // 
            // Settings
            // 
            Settings.BackColor = System.Drawing.Color.Orange;
            Settings.Dock = System.Windows.Forms.DockStyle.Top;
            Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Settings.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Settings.Location = new System.Drawing.Point(0, 586);
            Settings.Margin = new System.Windows.Forms.Padding(4);
            Settings.Name = "Settings";
            Settings.Size = new System.Drawing.Size(292, 74);
            Settings.TabIndex = 11;
            Settings.Text = "Settings";
            Settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            Settings.UseVisualStyleBackColor = false;
            Settings.Click += new System.EventHandler(this.button7_Click);
            // 
            // Cart
            // 
            Cart.BackColor = System.Drawing.Color.Orange;
            Cart.Dock = System.Windows.Forms.DockStyle.Top;
            Cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Cart.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Cart.ForeColor = System.Drawing.SystemColors.ControlText;
            Cart.Image = ((System.Drawing.Image)(resources.GetObject("Cart.Image")));
            Cart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Cart.Location = new System.Drawing.Point(0, 512);
            Cart.Margin = new System.Windows.Forms.Padding(4);
            Cart.Name = "Cart";
            Cart.Size = new System.Drawing.Size(292, 74);
            Cart.TabIndex = 10;
            Cart.Text = "Cart";
            Cart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            Cart.UseVisualStyleBackColor = false;
            Cart.Click += new System.EventHandler(this.button6_Click);
            // 
            // Supplements
            // 
            Supplements.BackColor = System.Drawing.Color.Orange;
            Supplements.Dock = System.Windows.Forms.DockStyle.Top;
            Supplements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Supplements.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Supplements.Image = ((System.Drawing.Image)(resources.GetObject("Supplements.Image")));
            Supplements.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Supplements.Location = new System.Drawing.Point(0, 438);
            Supplements.Margin = new System.Windows.Forms.Padding(4);
            Supplements.Name = "Supplements";
            Supplements.Size = new System.Drawing.Size(292, 74);
            Supplements.TabIndex = 9;
            Supplements.Text = "Supplements";
            Supplements.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            Supplements.UseVisualStyleBackColor = false;
            Supplements.Click += new System.EventHandler(this.button5_Click);
            // 
            // Splints
            // 
            Splints.BackColor = System.Drawing.Color.Orange;
            Splints.Dock = System.Windows.Forms.DockStyle.Top;
            Splints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Splints.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Splints.Image = ((System.Drawing.Image)(resources.GetObject("Splints.Image")));
            Splints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Splints.Location = new System.Drawing.Point(0, 364);
            Splints.Margin = new System.Windows.Forms.Padding(4);
            Splints.Name = "Splints";
            Splints.Size = new System.Drawing.Size(292, 74);
            Splints.TabIndex = 7;
            Splints.Text = "Splints";
            Splints.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            Splints.UseVisualStyleBackColor = false;
            Splints.Click += new System.EventHandler(this.button2_Click);
            // 
            // SportMa
            // 
            SportMa.BackColor = System.Drawing.Color.Orange;
            SportMa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            SportMa.Dock = System.Windows.Forms.DockStyle.Top;
            SportMa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SportMa.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SportMa.Image = ((System.Drawing.Image)(resources.GetObject("SportMa.Image")));
            SportMa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            SportMa.Location = new System.Drawing.Point(0, 290);
            SportMa.Margin = new System.Windows.Forms.Padding(4);
            SportMa.Name = "SportMa";
            SportMa.Size = new System.Drawing.Size(292, 74);
            SportMa.TabIndex = 6;
            SportMa.Text = "Sport Machine";
            SportMa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            SportMa.UseVisualStyleBackColor = false;
            SportMa.Click += new System.EventHandler(this.button1_Click);
            // 
            // SkinCare
            // 
            SkinCare.BackColor = System.Drawing.Color.Purple;
            SkinCare.Dock = System.Windows.Forms.DockStyle.Top;
            SkinCare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SkinCare.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SkinCare.Image = ((System.Drawing.Image)(resources.GetObject("SkinCare.Image")));
            SkinCare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            SkinCare.Location = new System.Drawing.Point(0, 216);
            SkinCare.Margin = new System.Windows.Forms.Padding(4);
            SkinCare.Name = "SkinCare";
            SkinCare.Size = new System.Drawing.Size(292, 74);
            SkinCare.TabIndex = 4;
            SkinCare.Text = "Skin Care";
            SkinCare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            SkinCare.UseVisualStyleBackColor = false;
            SkinCare.Click += new System.EventHandler(this.button3_Click);
            SkinCare.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            SkinCare.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            SkinCare.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.Orange;
            this.SideMenu.Controls.Add(LogOut);
            this.SideMenu.Controls.Add(EditItems);
            this.SideMenu.Controls.Add(Add_Productbtn);
            this.SideMenu.Controls.Add(Settings);
            this.SideMenu.Controls.Add(Cart);
            this.SideMenu.Controls.Add(Supplements);
            this.SideMenu.Controls.Add(Splints);
            this.SideMenu.Controls.Add(SportMa);
            this.SideMenu.Controls.Add(SkinCare);
            this.SideMenu.Controls.Add(this.Side_Menu);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Margin = new System.Windows.Forms.Padding(4);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(292, 735);
            this.SideMenu.TabIndex = 0;
            // 
            // Side_Menu
            // 
            this.Side_Menu.BackColor = System.Drawing.Color.DimGray;
            this.Side_Menu.Controls.Add(this.FYHlbl);
            this.Side_Menu.Controls.Add(this.ManIconPicBox);
            this.Side_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Side_Menu.Location = new System.Drawing.Point(0, 0);
            this.Side_Menu.Name = "Side_Menu";
            this.Side_Menu.Size = new System.Drawing.Size(292, 216);
            this.Side_Menu.TabIndex = 5;
            this.Side_Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.Side_Menu_Paint);
            // 
            // FYHlbl
            // 
            this.FYHlbl.AutoSize = true;
            this.FYHlbl.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FYHlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FYHlbl.Location = new System.Drawing.Point(3, 153);
            this.FYHlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FYHlbl.Name = "FYHlbl";
            this.FYHlbl.Size = new System.Drawing.Size(277, 33);
            this.FYHlbl.TabIndex = 1;
            this.FYHlbl.Text = " 4 Your Health";
            this.FYHlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ManIconPicBox
            // 
            this.ManIconPicBox.Image = ((System.Drawing.Image)(resources.GetObject("ManIconPicBox.Image")));
            this.ManIconPicBox.Location = new System.Drawing.Point(47, -1);
            this.ManIconPicBox.Margin = new System.Windows.Forms.Padding(4);
            this.ManIconPicBox.Name = "ManIconPicBox";
            this.ManIconPicBox.Size = new System.Drawing.Size(198, 172);
            this.ManIconPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ManIconPicBox.TabIndex = 0;
            this.ManIconPicBox.TabStop = false;
            // 
            // UserNamelbl
            // 
            this.UserNamelbl.AutoSize = true;
            this.UserNamelbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNamelbl.Location = new System.Drawing.Point(1201, 45);
            this.UserNamelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNamelbl.Name = "UserNamelbl";
            this.UserNamelbl.Size = new System.Drawing.Size(118, 27);
            this.UserNamelbl.TabIndex = 4;
            this.UserNamelbl.Text = "User Name";
            // 
            // StoreCloselbl
            // 
            this.StoreCloselbl.AutoSize = true;
            this.StoreCloselbl.Font = new System.Drawing.Font("Dungeon", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreCloselbl.Location = new System.Drawing.Point(1296, 11);
            this.StoreCloselbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StoreCloselbl.Name = "StoreCloselbl";
            this.StoreCloselbl.Size = new System.Drawing.Size(34, 31);
            this.StoreCloselbl.TabIndex = 4;
            this.StoreCloselbl.Text = "X";
            this.StoreCloselbl.Click += new System.EventHandler(this.StoreCloselbl_Click_1);
            // 
            // formView
            // 
            this.formView.AllowDrop = true;
            this.formView.Location = new System.Drawing.Point(298, 104);
            this.formView.Name = "formView";
            this.formView.Size = new System.Drawing.Size(1043, 624);
            this.formView.TabIndex = 5;
            // 
            // refLBL
            // 
            this.refLBL.AutoSize = true;
            this.refLBL.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.refLBL.Location = new System.Drawing.Point(354, 70);
            this.refLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.refLBL.Name = "refLBL";
            this.refLBL.Size = new System.Drawing.Size(106, 23);
            this.refLBL.TabIndex = 4;
            this.refLBL.Text = "Refresh cart";
            // 
            // CartRef
            // 
            this.CartRef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CartRef.Image = ((System.Drawing.Image)(resources.GetObject("CartRef.Image")));
            this.CartRef.Location = new System.Drawing.Point(300, 65);
            this.CartRef.Margin = new System.Windows.Forms.Padding(4);
            this.CartRef.Name = "CartRef";
            this.CartRef.Size = new System.Drawing.Size(70, 32);
            this.CartRef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CartRef.TabIndex = 3;
            this.CartRef.TabStop = false;
            this.CartRef.Click += new System.EventHandler(this.CartRef_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1103, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 735);
            this.Controls.Add(this.formView);
            this.Controls.Add(this.StoreCloselbl);
            this.Controls.Add(this.refLBL);
            this.Controls.Add(this.UserNamelbl);
            this.Controls.Add(this.CartRef);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashbord";
            this.Text = "Skin Care";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            this.SideMenu.ResumeLayout(false);
            this.Side_Menu.ResumeLayout(false);
            this.Side_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManIconPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartRef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SideMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UserNamelbl;
        private System.Windows.Forms.Panel Side_Menu;
        private System.Windows.Forms.PictureBox ManIconPicBox;
        private System.Windows.Forms.Label FYHlbl;
        private System.Windows.Forms.Label StoreCloselbl;
        private System.Windows.Forms.Panel formView;
        private System.Windows.Forms.PictureBox CartRef;
        private System.Windows.Forms.Label refLBL;
    }
}