namespace WindowsFormsApp1
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.button2 = new System.Windows.Forms.Button();
            this.Userbtn = new System.Windows.Forms.Button();
            this.Usertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Passtxt = new System.Windows.Forms.TextBox();
            this.Passwordbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShowPassChBx = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ANUSERLBL = new System.Windows.Forms.Label();
            this.ANPASSLBL = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(653, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "Log In";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // Userbtn
            // 
            this.Userbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Userbtn.BackColor = System.Drawing.Color.Gray;
            this.Userbtn.Enabled = false;
            this.Userbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userbtn.Location = new System.Drawing.Point(609, 307);
            this.Userbtn.Name = "Userbtn";
            this.Userbtn.Size = new System.Drawing.Size(272, 11);
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
            this.Usertxt.Location = new System.Drawing.Point(615, 286);
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.Size = new System.Drawing.Size(266, 21);
            this.Usertxt.TabIndex = 0;
            this.Usertxt.Text = "User Name";
            this.Usertxt.Enter += new System.EventHandler(this.textBox3_Enter);
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
            this.label1.Location = new System.Drawing.Point(942, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Passtxt
            // 
            this.Passtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Passtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passtxt.Location = new System.Drawing.Point(615, 349);
            this.Passtxt.Name = "Passtxt";
            this.Passtxt.Size = new System.Drawing.Size(266, 21);
            this.Passtxt.TabIndex = 1;
            this.Passtxt.Text = "Password";
            this.Passtxt.Enter += new System.EventHandler(this.textBox4_Enter);
            this.Passtxt.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // Passwordbtn
            // 
            this.Passwordbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Passwordbtn.BackColor = System.Drawing.Color.Gray;
            this.Passwordbtn.Enabled = false;
            this.Passwordbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordbtn.Location = new System.Drawing.Point(608, 369);
            this.Passwordbtn.Name = "Passwordbtn";
            this.Passwordbtn.Size = new System.Drawing.Size(273, 11);
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
            this.label2.Location = new System.Drawing.Point(890, -6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "_";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(634, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(273, 58);
            this.textBox1.TabIndex = 10;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "WELCOME";
            this.textBox1.Enter += new System.EventHandler(this.textBox3_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(686, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ShowPassChBx
            // 
            this.ShowPassChBx.AutoSize = true;
            this.ShowPassChBx.BackColor = System.Drawing.Color.Transparent;
            this.ShowPassChBx.Location = new System.Drawing.Point(782, 386);
            this.ShowPassChBx.Name = "ShowPassChBx";
            this.ShowPassChBx.Size = new System.Drawing.Size(125, 20);
            this.ShowPassChBx.TabIndex = 2;
            this.ShowPassChBx.Text = "Show Password";
            this.ShowPassChBx.UseVisualStyleBackColor = false;
            this.ShowPassChBx.CheckedChanged += new System.EventHandler(this.ShowPassChBx_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(657, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Don\'t Have an Account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(207)))), ((int)(((byte)(151)))));
            this.label4.Location = new System.Drawing.Point(673, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Creat New Account";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseLeave += new System.EventHandler(this.Label4_MouseLeave);
            this.label4.MouseHover += new System.EventHandler(this.label4_MouseHover);
            // 
            // ANUSERLBL
            // 
            this.ANUSERLBL.AutoSize = true;
            this.ANUSERLBL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ANUSERLBL.Cursor = System.Windows.Forms.Cursors.Default;
            this.ANUSERLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ANUSERLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(207)))), ((int)(((byte)(151)))));
            this.ANUSERLBL.Location = new System.Drawing.Point(701, 265);
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
            this.ANPASSLBL.Location = new System.Drawing.Point(701, 326);
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
            this.textBox2.Location = new System.Drawing.Point(695, 203);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(126, 41);
            this.textBox2.TabIndex = 10;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "SignIn";
            this.textBox2.Enter += new System.EventHandler(this.textBox3_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(207)))), ((int)(((byte)(151)))));
            this.label5.Location = new System.Drawing.Point(711, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Admin";
            this.label5.Click += new System.EventHandler(this.Admin_Click);
            this.label5.MouseLeave += new System.EventHandler(this.Label4_MouseLeave);
            this.label5.MouseHover += new System.EventHandler(this.label4_MouseHover);
            // 
            // SignIn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 543);
            this.Controls.Add(this.ANPASSLBL);
            this.Controls.Add(this.ANUSERLBL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShowPassChBx);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Passwordbtn);
            this.Controls.Add(this.Userbtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Passtxt);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Usertxt);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Userbtn;
        private System.Windows.Forms.TextBox Usertxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Passtxt;
        private System.Windows.Forms.Button Passwordbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ShowPassChBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ANUSERLBL;
        private System.Windows.Forms.Label ANPASSLBL;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
    }
}

