namespace WindowsFormsApp1
{
    partial class SignUp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp1));
            this.SignUpbtn = new System.Windows.Forms.Button();
            this.Userbtn = new System.Windows.Forms.Button();
            this.Usertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Passwordbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShowPassChBx = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ANUSERLBL = new System.Windows.Forms.Label();
            this.ANPASSLBL = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Repasswordtxt = new System.Windows.Forms.TextBox();
            this.rePasswordbtn = new System.Windows.Forms.Button();
            this.ANREPASSLBL = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.Emailbtn = new System.Windows.Forms.Button();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.Emailtxt1 = new System.Windows.Forms.Label();
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Database1DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SignUpbtn
            // 
            this.SignUpbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignUpbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.SignUpbtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SignUpbtn.Location = new System.Drawing.Point(619, 421);
            this.SignUpbtn.Name = "SignUpbtn";
            this.SignUpbtn.Size = new System.Drawing.Size(254, 44);
            this.SignUpbtn.TabIndex = 5;
            this.SignUpbtn.Text = "Sign Up";
            this.SignUpbtn.UseVisualStyleBackColor = false;
            this.SignUpbtn.Click += new System.EventHandler(this.button2_Click);
            this.SignUpbtn.MouseEnter += new System.EventHandler(this.button2_MouseHover);
            this.SignUpbtn.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // Userbtn
            // 
            this.Userbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Userbtn.BackColor = System.Drawing.Color.Gray;
            this.Userbtn.Enabled = false;
            this.Userbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userbtn.Location = new System.Drawing.Point(613, 209);
            this.Userbtn.Name = "Userbtn";
            this.Userbtn.Size = new System.Drawing.Size(260, 11);
            this.Userbtn.TabIndex = 10;
            this.Userbtn.TabStop = false;
            this.Userbtn.Text = " ";
            this.Userbtn.UseVisualStyleBackColor = false;
            // 
            // Usertxt
            // 
            this.Usertxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Usertxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usertxt.Location = new System.Drawing.Point(619, 188);
            this.Usertxt.MaxLength = 35;
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.Size = new System.Drawing.Size(254, 21);
            this.Usertxt.TabIndex = 0;
            this.Usertxt.Text = "User Name";
            this.Usertxt.Enter += new System.EventHandler(this.Usertxt_TextChanged);
            this.Usertxt.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(207)))), ((int)(((byte)(151)))));
            this.label1.Location = new System.Drawing.Point(958, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Passwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtxt.Location = new System.Drawing.Point(619, 244);
            this.Passwordtxt.MaxLength = 100;
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(254, 21);
            this.Passwordtxt.TabIndex = 1;
            this.Passwordtxt.Text = "Password";
            this.Passwordtxt.Enter += new System.EventHandler(this.textBox4_Enter);
            this.Passwordtxt.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // Passwordbtn
            // 
            this.Passwordbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Passwordbtn.BackColor = System.Drawing.Color.Gray;
            this.Passwordbtn.Enabled = false;
            this.Passwordbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordbtn.Location = new System.Drawing.Point(612, 264);
            this.Passwordbtn.Name = "Passwordbtn";
            this.Passwordbtn.Size = new System.Drawing.Size(261, 11);
            this.Passwordbtn.TabIndex = 10;
            this.Passwordbtn.TabStop = false;
            this.Passwordbtn.Text = " ";
            this.Passwordbtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(207)))), ((int)(((byte)(151)))));
            this.label2.Location = new System.Drawing.Point(917, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "_";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(649, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ShowPassChBx
            // 
            this.ShowPassChBx.AutoSize = true;
            this.ShowPassChBx.BackColor = System.Drawing.Color.Transparent;
            this.ShowPassChBx.Location = new System.Drawing.Point(766, 340);
            this.ShowPassChBx.Name = "ShowPassChBx";
            this.ShowPassChBx.Size = new System.Drawing.Size(125, 20);
            this.ShowPassChBx.TabIndex = 3;
            this.ShowPassChBx.Text = "Show Password";
            this.ShowPassChBx.UseVisualStyleBackColor = false;
            this.ShowPassChBx.CheckedChanged += new System.EventHandler(this.ShowPassChBx_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(645, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Already Have an Account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(207)))), ((int)(((byte)(151)))));
            this.label4.Location = new System.Drawing.Point(695, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sign-In Now";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseLeave += new System.EventHandler(this.Label4_MouseLeave);
            // 
            // ANUSERLBL
            // 
            this.ANUSERLBL.AutoSize = true;
            this.ANUSERLBL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ANUSERLBL.Cursor = System.Windows.Forms.Cursors.Default;
            this.ANUSERLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ANUSERLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(207)))), ((int)(((byte)(151)))));
            this.ANUSERLBL.Location = new System.Drawing.Point(697, 167);
            this.ANUSERLBL.Name = "ANUSERLBL";
            this.ANUSERLBL.Size = new System.Drawing.Size(0, 20);
            this.ANUSERLBL.TabIndex = 13;
            // 
            // ANPASSLBL
            // 
            this.ANPASSLBL.AutoSize = true;
            this.ANPASSLBL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ANPASSLBL.Cursor = System.Windows.Forms.Cursors.Default;
            this.ANPASSLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ANPASSLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(207)))), ((int)(((byte)(151)))));
            this.ANPASSLBL.Location = new System.Drawing.Point(697, 221);
            this.ANPASSLBL.Name = "ANPASSLBL";
            this.ANPASSLBL.Size = new System.Drawing.Size(0, 20);
            this.ANPASSLBL.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Verdana", 20.2F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(84)))), ((int)(((byte)(46)))));
            this.textBox2.Location = new System.Drawing.Point(691, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(154, 41);
            this.textBox2.TabIndex = 14;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "SignUp";
            // 
            // Repasswordtxt
            // 
            this.Repasswordtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Repasswordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Repasswordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repasswordtxt.Location = new System.Drawing.Point(619, 302);
            this.Repasswordtxt.MaxLength = 100;
            this.Repasswordtxt.Name = "Repasswordtxt";
            this.Repasswordtxt.Size = new System.Drawing.Size(254, 21);
            this.Repasswordtxt.TabIndex = 2;
            this.Repasswordtxt.Text = "Re-Enter Password";
            this.Repasswordtxt.Enter += new System.EventHandler(this.Repasswordtxt_Enter);
            this.Repasswordtxt.Leave += new System.EventHandler(this.Repasswordtxt_Leave);
            // 
            // rePasswordbtn
            // 
            this.rePasswordbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rePasswordbtn.BackColor = System.Drawing.Color.Gray;
            this.rePasswordbtn.Enabled = false;
            this.rePasswordbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rePasswordbtn.Location = new System.Drawing.Point(612, 322);
            this.rePasswordbtn.Name = "rePasswordbtn";
            this.rePasswordbtn.Size = new System.Drawing.Size(261, 11);
            this.rePasswordbtn.TabIndex = 10;
            this.rePasswordbtn.TabStop = false;
            this.rePasswordbtn.Text = " ";
            this.rePasswordbtn.UseVisualStyleBackColor = false;
            // 
            // ANREPASSLBL
            // 
            this.ANREPASSLBL.AutoSize = true;
            this.ANREPASSLBL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ANREPASSLBL.Cursor = System.Windows.Forms.Cursors.Default;
            this.ANREPASSLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ANREPASSLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(207)))), ((int)(((byte)(151)))));
            this.ANREPASSLBL.Location = new System.Drawing.Point(680, 279);
            this.ANREPASSLBL.Name = "ANREPASSLBL";
            this.ANREPASSLBL.Size = new System.Drawing.Size(0, 20);
            this.ANREPASSLBL.TabIndex = 13;
            // 
            // Emailtxt
            // 
            this.Emailtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Emailtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emailtxt.Location = new System.Drawing.Point(619, 366);
            this.Emailtxt.MaxLength = 50;
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(254, 21);
            this.Emailtxt.TabIndex = 4;
            this.Emailtxt.Text = "Email";
            this.Emailtxt.Enter += new System.EventHandler(this.Emailtxt_Enter);
            this.Emailtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Emailtxt_KeyPress);
            this.Emailtxt.Leave += new System.EventHandler(this.Emailtxt_Leave);
            this.Emailtxt.Validated += new System.EventHandler(this.Emailtxt_Leave);
            // 
            // Emailbtn
            // 
            this.Emailbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Emailbtn.BackColor = System.Drawing.Color.Gray;
            this.Emailbtn.Enabled = false;
            this.Emailbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emailbtn.Location = new System.Drawing.Point(613, 387);
            this.Emailbtn.Name = "Emailbtn";
            this.Emailbtn.Size = new System.Drawing.Size(260, 11);
            this.Emailbtn.TabIndex = 10;
            this.Emailbtn.TabStop = false;
            this.Emailbtn.Text = " ";
            this.Emailbtn.UseVisualStyleBackColor = false;
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Emaillbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.Emaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(207)))), ((int)(((byte)(151)))));
            this.Emaillbl.Location = new System.Drawing.Point(708, 345);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(0, 20);
            this.Emaillbl.TabIndex = 13;
            // 
            // Emailtxt1
            // 
            this.Emailtxt1.AutoSize = true;
            this.Emailtxt1.BackColor = System.Drawing.Color.White;
            this.Emailtxt1.Location = new System.Drawing.Point(666, 370);
            this.Emailtxt1.Name = "Emailtxt1";
            this.Emailtxt1.Size = new System.Drawing.Size(65, 16);
            this.Emailtxt1.TabIndex = 15;
            this.Emailtxt1.Text = "(Optional)";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.database1DataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // SignUp1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1017, 543);
            this.Controls.Add(this.Emailtxt1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ANREPASSLBL);
            this.Controls.Add(this.ANPASSLBL);
            this.Controls.Add(this.Emaillbl);
            this.Controls.Add(this.ANUSERLBL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rePasswordbtn);
            this.Controls.Add(this.Passwordbtn);
            this.Controls.Add(this.Emailbtn);
            this.Controls.Add(this.Userbtn);
            this.Controls.Add(this.SignUpbtn);
            this.Controls.Add(this.Repasswordtxt);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.Usertxt);
            this.Controls.Add(this.ShowPassChBx);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignUp1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SignUp1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SignUpbtn;
        private System.Windows.Forms.Button Userbtn;
        private System.Windows.Forms.TextBox Usertxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Button Passwordbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ShowPassChBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ANUSERLBL;
        private System.Windows.Forms.Label ANPASSLBL;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Repasswordtxt;
        private System.Windows.Forms.Button rePasswordbtn;
        private System.Windows.Forms.Label ANREPASSLBL;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.Button Emailbtn;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.Label Emailtxt1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Database1DataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

