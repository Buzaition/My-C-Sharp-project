namespace WindowsFormsApp1
{
    partial class CartItems
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartItems));
            this.ItemPrice = new System.Windows.Forms.Label();
            this.ItemID = new System.Windows.Forms.Label();
            this.ItemName = new System.Windows.Forms.Label();
            this.ItemPic = new System.Windows.Forms.PictureBox();
            this.CartPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartPic)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemPrice
            // 
            this.ItemPrice.AutoSize = true;
            this.ItemPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemPrice.Location = new System.Drawing.Point(11, 184);
            this.ItemPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.Size = new System.Drawing.Size(81, 19);
            this.ItemPrice.TabIndex = 4;
            this.ItemPrice.Text = "ItemPrice";
            this.ItemPrice.MouseEnter += new System.EventHandler(this.item_MouseEnter);
            this.ItemPrice.MouseLeave += new System.EventHandler(this.item_MouseLeave);
            // 
            // ItemID
            // 
            this.ItemID.AutoSize = true;
            this.ItemID.Font = new System.Drawing.Font("Microsoft YaHei UI", 5F, System.Drawing.FontStyle.Bold);
            this.ItemID.Location = new System.Drawing.Point(5, 3);
            this.ItemID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemID.Name = "ItemID";
            this.ItemID.Size = new System.Drawing.Size(38, 14);
            this.ItemID.TabIndex = 5;
            this.ItemID.Text = "ItemID";
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.Location = new System.Drawing.Point(11, 160);
            this.ItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(90, 19);
            this.ItemName.TabIndex = 6;
            this.ItemName.Text = "ItemName";
            this.ItemName.MouseEnter += new System.EventHandler(this.item_MouseEnter);
            this.ItemName.MouseLeave += new System.EventHandler(this.item_MouseLeave);
            // 
            // ItemPic
            // 
            this.ItemPic.Location = new System.Drawing.Point(15, 4);
            this.ItemPic.Margin = new System.Windows.Forms.Padding(4);
            this.ItemPic.Name = "ItemPic";
            this.ItemPic.Size = new System.Drawing.Size(211, 151);
            this.ItemPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ItemPic.TabIndex = 2;
            this.ItemPic.TabStop = false;
            this.ItemPic.MouseEnter += new System.EventHandler(this.item_MouseEnter);
            this.ItemPic.MouseLeave += new System.EventHandler(this.item_MouseLeave);
            // 
            // CartPic
            // 
            this.CartPic.Image = ((System.Drawing.Image)(resources.GetObject("CartPic.Image")));
            this.CartPic.Location = new System.Drawing.Point(183, 158);
            this.CartPic.Margin = new System.Windows.Forms.Padding(4);
            this.CartPic.Name = "CartPic";
            this.CartPic.Size = new System.Drawing.Size(41, 34);
            this.CartPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CartPic.TabIndex = 3;
            this.CartPic.TabStop = false;
            this.CartPic.Click += new System.EventHandler(this.CartPic_Click);
            this.CartPic.MouseEnter += new System.EventHandler(this.CartPic_MouseEnter);
            this.CartPic.MouseLeave += new System.EventHandler(this.CartPic_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.item_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.item_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = " + \r\n  ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.item_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.item_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = " - \r\n ";
        this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseEnter += new System.EventHandler(this.item_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.item_MouseLeave);
            // 
            // CartItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemPrice);
            this.Controls.Add(this.ItemID);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.ItemPic);
            this.Controls.Add(this.CartPic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "CartItems";
            this.Size = new System.Drawing.Size(245, 209);
            this.Load += new System.EventHandler(this.CartItems_Load);
            this.MouseEnter += new System.EventHandler(this.item_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.item_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.ItemPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemPrice;
        private System.Windows.Forms.Label ItemID;
        private System.Windows.Forms.Label ItemName;
        private System.Windows.Forms.PictureBox ItemPic;
        private System.Windows.Forms.PictureBox CartPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
