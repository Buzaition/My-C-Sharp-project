namespace WindowsFormsApp1
{
    partial class item
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
            this.CartPic = new System.Windows.Forms.PictureBox();
            this.ItemPic = new System.Windows.Forms.PictureBox();
            this.ItemName = new System.Windows.Forms.Label();
            this.ItemPrice = new System.Windows.Forms.Label();
            this.ItemID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CartPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPic)).BeginInit();
            this.SuspendLayout();
            // 
            // CartPic
            // 
            this.CartPic.Image = global::WindowsFormsApp1.Properties.Resources.add_shopping_cart_40px;
            this.CartPic.Location = new System.Drawing.Point(187, 158);
            this.CartPic.Margin = new System.Windows.Forms.Padding(4);
            this.CartPic.Name = "CartPic";
            this.CartPic.Size = new System.Drawing.Size(41, 34);
            this.CartPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CartPic.TabIndex = 0;
            this.CartPic.TabStop = false;
            this.CartPic.Click += new System.EventHandler(this.CartPic_Click);
            this.CartPic.MouseEnter += new System.EventHandler(this.CartPic_MouseEnter);
            this.CartPic.MouseLeave += new System.EventHandler(this.CartPic_MouseLeave);
            // 
            // ItemPic
            // 
            this.ItemPic.Location = new System.Drawing.Point(19, 4);
            this.ItemPic.Margin = new System.Windows.Forms.Padding(4);
            this.ItemPic.Name = "ItemPic";
            this.ItemPic.Size = new System.Drawing.Size(211, 151);
            this.ItemPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ItemPic.TabIndex = 0;
            this.ItemPic.TabStop = false;
            this.ItemPic.MouseEnter += new System.EventHandler(this.item_MouseEnter);
            this.ItemPic.MouseLeave += new System.EventHandler(this.item_MouseLeave);
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.Location = new System.Drawing.Point(26, 160);
            this.ItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(90, 19);
            this.ItemName.TabIndex = 1;
            this.ItemName.Text = "ItemName";
            this.ItemName.MouseEnter += new System.EventHandler(this.item_MouseEnter);
            this.ItemName.MouseLeave += new System.EventHandler(this.item_MouseLeave);
            // 
            // ItemPrice
            // 
            this.ItemPrice.AutoSize = true;
            this.ItemPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemPrice.Location = new System.Drawing.Point(26, 184);
            this.ItemPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.Size = new System.Drawing.Size(81, 19);
            this.ItemPrice.TabIndex = 1;
            this.ItemPrice.Text = "ItemPrice";
            this.ItemPrice.MouseEnter += new System.EventHandler(this.item_MouseEnter);
            this.ItemPrice.MouseLeave += new System.EventHandler(this.item_MouseLeave);
            // 
            // ItemID
            // 
            this.ItemID.AutoSize = true;
            this.ItemID.Font = new System.Drawing.Font("Microsoft YaHei UI", 5F, System.Drawing.FontStyle.Bold);
            this.ItemID.Location = new System.Drawing.Point(1, 3);
            this.ItemID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemID.Name = "ItemID";
            this.ItemID.Size = new System.Drawing.Size(38, 14);
            this.ItemID.TabIndex = 1;
            this.ItemID.Text = "ItemID";
            this.ItemID.MouseEnter += new System.EventHandler(this.item_MouseEnter);
            this.ItemID.MouseLeave += new System.EventHandler(this.item_MouseLeave);
            // 
            // item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.Controls.Add(this.ItemPrice);
            this.Controls.Add(this.ItemID);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.ItemPic);
            this.Controls.Add(this.CartPic);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "item";
            this.Size = new System.Drawing.Size(245, 209);
            this.MouseEnter += new System.EventHandler(this.item_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.item_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.CartPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CartPic;
        private System.Windows.Forms.PictureBox ItemPic;
        private System.Windows.Forms.Label ItemName;
        private System.Windows.Forms.Label ItemPrice;
        private System.Windows.Forms.Label ItemID;
    }
}
