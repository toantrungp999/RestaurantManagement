namespace partI
{
    partial class UCMonAn
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
            this.btnPictureFood = new System.Windows.Forms.Button();
            this.lbPrice1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSale = new System.Windows.Forms.Label();
            this.lbPrice2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPictureFood
            // 
            this.btnPictureFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPictureFood.Location = new System.Drawing.Point(0, 0);
            this.btnPictureFood.Name = "btnPictureFood";
            this.btnPictureFood.Size = new System.Drawing.Size(150, 150);
            this.btnPictureFood.TabIndex = 0;
            this.btnPictureFood.UseVisualStyleBackColor = true;
            this.btnPictureFood.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbPrice1
            // 
            this.lbPrice1.AutoSize = true;
            this.lbPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice1.Location = new System.Drawing.Point(321, 53);
            this.lbPrice1.Name = "lbPrice1";
            this.lbPrice1.Size = new System.Drawing.Size(38, 20);
            this.lbPrice1.TabIndex = 1;
            this.lbPrice1.Text = "Giá:";
            this.lbPrice1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(432, 53);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(37, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(156, 50);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(71, 20);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Tên món";
            // 
            // lbSale
            // 
            this.lbSale.AutoSize = true;
            this.lbSale.Location = new System.Drawing.Point(322, 84);
            this.lbSale.Name = "lbSale";
            this.lbSale.Size = new System.Drawing.Size(31, 13);
            this.lbSale.TabIndex = 4;
            this.lbSale.Text = "Sale:";
            // 
            // lbPrice2
            // 
            this.lbPrice2.AutoSize = true;
            this.lbPrice2.Location = new System.Drawing.Point(306, 114);
            this.lbPrice2.Name = "lbPrice2";
            this.lbPrice2.Size = new System.Drawing.Size(85, 13);
            this.lbPrice2.TabIndex = 5;
            this.lbPrice2.Text = "Giá sau khi giảm";
            // 
            // UCMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.lbPrice2);
            this.Controls.Add(this.lbSale);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbPrice1);
            this.Controls.Add(this.btnPictureFood);
            this.Name = "UCMonAn";
            this.Size = new System.Drawing.Size(513, 151);
            this.Load += new System.EventHandler(this.QLNhaHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPictureFood;
        private System.Windows.Forms.Label lbPrice1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSale;
        private System.Windows.Forms.Label lbPrice2;
    }
}
