namespace WindowsFormsApp1
{
    partial class Add_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Product));
            this.SecondNamelbl = new System.Windows.Forms.Label();
            this.Firstnamelbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ProPricetxt = new System.Windows.Forms.TextBox();
            this.ProNametxt = new System.Windows.Forms.TextBox();
            this.ProPicImg = new System.Windows.Forms.PictureBox();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ProTypeCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProPicImg)).BeginInit();
            this.SuspendLayout();
            // 
            // SecondNamelbl
            // 
            this.SecondNamelbl.AutoSize = true;
            this.SecondNamelbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SecondNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondNamelbl.ForeColor = System.Drawing.Color.Gold;
            this.SecondNamelbl.Location = new System.Drawing.Point(744, 107);
            this.SecondNamelbl.Name = "SecondNamelbl";
            this.SecondNamelbl.Size = new System.Drawing.Size(128, 25);
            this.SecondNamelbl.TabIndex = 15;
            this.SecondNamelbl.Text = "Product Price";
            // 
            // Firstnamelbl
            // 
            this.Firstnamelbl.AutoSize = true;
            this.Firstnamelbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Firstnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstnamelbl.ForeColor = System.Drawing.Color.Gold;
            this.Firstnamelbl.Location = new System.Drawing.Point(482, 107);
            this.Firstnamelbl.Name = "Firstnamelbl";
            this.Firstnamelbl.Size = new System.Drawing.Size(136, 25);
            this.Firstnamelbl.TabIndex = 16;
            this.Firstnamelbl.Text = "Product Name";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(715, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 39);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add Product";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // ProPricetxt
            // 
            this.ProPricetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProPricetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProPricetxt.Location = new System.Drawing.Point(715, 147);
            this.ProPricetxt.Multiline = true;
            this.ProPricetxt.Name = "ProPricetxt";
            this.ProPricetxt.Size = new System.Drawing.Size(219, 39);
            this.ProPricetxt.TabIndex = 9;
            // 
            // ProNametxt
            // 
            this.ProNametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProNametxt.Location = new System.Drawing.Point(443, 147);
            this.ProNametxt.Multiline = true;
            this.ProNametxt.Name = "ProNametxt";
            this.ProNametxt.Size = new System.Drawing.Size(219, 39);
            this.ProNametxt.TabIndex = 10;
            // 
            // ProPicImg
            // 
            this.ProPicImg.Image = ((System.Drawing.Image)(resources.GetObject("ProPicImg.Image")));
            this.ProPicImg.Location = new System.Drawing.Point(131, 66);
            this.ProPicImg.Name = "ProPicImg";
            this.ProPicImg.Size = new System.Drawing.Size(250, 294);
            this.ProPicImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProPicImg.TabIndex = 5;
            this.ProPicImg.TabStop = false;
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Emaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillbl.ForeColor = System.Drawing.Color.Gold;
            this.Emaillbl.Location = new System.Drawing.Point(482, 224);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(129, 25);
            this.Emaillbl.TabIndex = 14;
            this.Emaillbl.Text = "Product Type";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(131, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Upload";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UpIMG_Click);
            // 
            // ProTypeCombo
            // 
            this.ProTypeCombo.FormattingEnabled = true;
            this.ProTypeCombo.Items.AddRange(new object[] {
            "Skin Care",
            "Sport Machine",
            "Splints",
            "Supplements"});
            this.ProTypeCombo.Location = new System.Drawing.Point(443, 267);
            this.ProTypeCombo.Name = "ProTypeCombo";
            this.ProTypeCombo.Size = new System.Drawing.Size(219, 24);
            this.ProTypeCombo.TabIndex = 17;
            // 
            // Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1035, 501);
            this.Controls.Add(this.ProTypeCombo);
            this.Controls.Add(this.Emaillbl);
            this.Controls.Add(this.SecondNamelbl);
            this.Controls.Add(this.Firstnamelbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ProPricetxt);
            this.Controls.Add(this.ProNametxt);
            this.Controls.Add(this.ProPicImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Product";
            this.Text = "Add_Product";
            ((System.ComponentModel.ISupportInitialize)(this.ProPicImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SecondNamelbl;
        private System.Windows.Forms.Label Firstnamelbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ProPricetxt;
        private System.Windows.Forms.TextBox ProNametxt;
        private System.Windows.Forms.PictureBox ProPicImg;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ProTypeCombo;
    }
}