namespace WindowsFormsApp1
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.database1DataSet1 = new WindowsFormsApp1.Database1DataSet1();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new WindowsFormsApp1.Database1DataSet1TableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Database1DataSet1TableAdapters.TableAdapterManager();
            this.UserImage = new System.Windows.Forms.PictureBox();
            this.Firsttxt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Lasttxt = new System.Windows.Forms.TextBox();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Firstnamelbl = new System.Windows.Forms.Label();
            this.SecondNamelbl = new System.Windows.Forms.Label();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.Phonelbl = new System.Windows.Forms.Label();
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.Userlbl = new System.Windows.Forms.Label();
            this.adresstxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.database1DataSet1;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CartTableAdapter = null;
            this.tableAdapterManager.ItemsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // UserImage
            // 
            this.UserImage.Image = ((System.Drawing.Image)(resources.GetObject("UserImage.Image")));
            this.UserImage.Location = new System.Drawing.Point(66, 87);
            this.UserImage.Name = "UserImage";
            this.UserImage.Size = new System.Drawing.Size(250, 294);
            this.UserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserImage.TabIndex = 0;
            this.UserImage.TabStop = false;
            // 
            // Firsttxt
            // 
            this.Firsttxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Firsttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firsttxt.Location = new System.Drawing.Point(408, 131);
            this.Firsttxt.Multiline = true;
            this.Firsttxt.Name = "Firsttxt";
            this.Firsttxt.Size = new System.Drawing.Size(219, 39);
            this.Firsttxt.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Lasttxt
            // 
            this.Lasttxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lasttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lasttxt.Location = new System.Drawing.Point(680, 131);
            this.Lasttxt.Multiline = true;
            this.Lasttxt.Name = "Lasttxt";
            this.Lasttxt.Size = new System.Drawing.Size(219, 39);
            this.Lasttxt.TabIndex = 1;
            // 
            // Emailtxt
            // 
            this.Emailtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emailtxt.Location = new System.Drawing.Point(408, 236);
            this.Emailtxt.Multiline = true;
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(219, 39);
            this.Emailtxt.TabIndex = 1;
            // 
            // phonetxt
            // 
            this.phonetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phonetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonetxt.Location = new System.Drawing.Point(680, 236);
            this.phonetxt.Multiline = true;
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(219, 39);
            this.phonetxt.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(535, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Update";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(940, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Log Out";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(890, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1420, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Log Out";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Firstnamelbl
            // 
            this.Firstnamelbl.AutoSize = true;
            this.Firstnamelbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Firstnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstnamelbl.ForeColor = System.Drawing.Color.Gold;
            this.Firstnamelbl.Location = new System.Drawing.Point(478, 91);
            this.Firstnamelbl.Name = "Firstnamelbl";
            this.Firstnamelbl.Size = new System.Drawing.Size(106, 25);
            this.Firstnamelbl.TabIndex = 4;
            this.Firstnamelbl.Text = "First Name";
            this.Firstnamelbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // SecondNamelbl
            // 
            this.SecondNamelbl.AutoSize = true;
            this.SecondNamelbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SecondNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondNamelbl.ForeColor = System.Drawing.Color.Gold;
            this.SecondNamelbl.Location = new System.Drawing.Point(718, 91);
            this.SecondNamelbl.Name = "SecondNamelbl";
            this.SecondNamelbl.Size = new System.Drawing.Size(137, 25);
            this.SecondNamelbl.TabIndex = 4;
            this.SecondNamelbl.Text = "Second Name";
            this.SecondNamelbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Emaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillbl.ForeColor = System.Drawing.Color.Gold;
            this.Emaillbl.Location = new System.Drawing.Point(478, 208);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(60, 25);
            this.Emaillbl.TabIndex = 4;
            this.Emaillbl.Text = "Email";
            this.Emaillbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Phonelbl
            // 
            this.Phonelbl.AutoSize = true;
            this.Phonelbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Phonelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phonelbl.ForeColor = System.Drawing.Color.Gold;
            this.Phonelbl.Location = new System.Drawing.Point(723, 208);
            this.Phonelbl.Name = "Phonelbl";
            this.Phonelbl.Size = new System.Drawing.Size(143, 25);
            this.Phonelbl.TabIndex = 4;
            this.Phonelbl.Text = "Phone Number";
            this.Phonelbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Usernametxt
            // 
            this.Usernametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usernametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernametxt.Location = new System.Drawing.Point(408, 342);
            this.Usernametxt.Multiline = true;
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.ReadOnly = true;
            this.Usernametxt.Size = new System.Drawing.Size(219, 39);
            this.Usernametxt.TabIndex = 1;
            this.Usernametxt.TextChanged += new System.EventHandler(this.Usernametxt_TextChanged);
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Userlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userlbl.ForeColor = System.Drawing.Color.Gold;
            this.Userlbl.Location = new System.Drawing.Point(466, 314);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(110, 25);
            this.Userlbl.TabIndex = 4;
            this.Userlbl.Text = "User Name";
            this.Userlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // adresstxt
            // 
            this.adresstxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adresstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresstxt.Location = new System.Drawing.Point(680, 342);
            this.adresstxt.Multiline = true;
            this.adresstxt.Name = "adresstxt";
            this.adresstxt.Size = new System.Drawing.Size(219, 39);
            this.adresstxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(738, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(87, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Upload";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UpIMG_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(1035, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Userlbl);
            this.Controls.Add(this.Phonelbl);
            this.Controls.Add(this.Emaillbl);
            this.Controls.Add(this.SecondNamelbl);
            this.Controls.Add(this.Firstnamelbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.adresstxt);
            this.Controls.Add(this.Usernametxt);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.Lasttxt);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Firsttxt);
            this.Controls.Add(this.UserImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Database1DataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox UserImage;
        private System.Windows.Forms.TextBox Firsttxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Lasttxt;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Firstnamelbl;
        private System.Windows.Forms.Label SecondNamelbl;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.Label Phonelbl;
        private System.Windows.Forms.TextBox Usernametxt;
        private System.Windows.Forms.Label Userlbl;
        private System.Windows.Forms.TextBox adresstxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}