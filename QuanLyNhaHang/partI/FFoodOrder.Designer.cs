namespace partI
{
    partial class FFoodOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOder = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnHuyBan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.tC = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.lbName = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.tC.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(10, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 343);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnOder
            // 
            this.btnOder.BackColor = System.Drawing.Color.LightGreen;
            this.btnOder.Location = new System.Drawing.Point(530, 282);
            this.btnOder.Name = "btnOder";
            this.btnOder.Size = new System.Drawing.Size(75, 32);
            this.btnOder.TabIndex = 1;
            this.btnOder.Text = "Gửi bếp";
            this.btnOder.UseVisualStyleBackColor = false;
            this.btnOder.Click += new System.EventHandler(this.btnOder_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.AliceBlue;
            this.btnThanhToan.Location = new System.Drawing.Point(531, 320);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 32);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnDatBan_Click);
            // 
            // btnHuyBan
            // 
            this.btnHuyBan.BackgroundImage = global::partI.Properties.Resources.btnHuy;
            this.btnHuyBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHuyBan.Location = new System.Drawing.Point(739, 280);
            this.btnHuyBan.Name = "btnHuyBan";
            this.btnHuyBan.Size = new System.Drawing.Size(82, 34);
            this.btnHuyBan.TabIndex = 3;
            this.btnHuyBan.Text = "Hủy bàn";
            this.btnHuyBan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyBan.UseVisualStyleBackColor = true;
            this.btnHuyBan.Click += new System.EventHandler(this.btnHuyBan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = global::partI.Properties.Resources.btnTroVe;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.Location = new System.Drawing.Point(740, 324);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(81, 44);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.dgvBill);
            this.panel2.Location = new System.Drawing.Point(530, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 241);
            this.panel2.TabIndex = 0;
            // 
            // dgvBill
            // 
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(-2, -2);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.Size = new System.Drawing.Size(367, 107);
            this.dgvBill.TabIndex = 5;
            // 
            // tC
            // 
            this.tC.Controls.Add(this.tabPage1);
            this.tC.Controls.Add(this.tabPage2);
            this.tC.Controls.Add(this.tabPage3);
            this.tC.Controls.Add(this.tabPage4);
            this.tC.Controls.Add(this.tabPage5);
            this.tC.Controls.Add(this.tabPage6);
            this.tC.Location = new System.Drawing.Point(10, 3);
            this.tC.Name = "tC";
            this.tC.SelectedIndex = 0;
            this.tC.Size = new System.Drawing.Size(512, 21);
            this.tC.TabIndex = 17;
            this.tC.SelectedIndexChanged += new System.EventHandler(this.tC_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(504, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tất cả";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(504, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lẩu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(504, 0);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Món khô";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(504, 0);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tráng miệng";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(504, 0);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Nước";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(504, 0);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Khác";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Honeydew;
            this.lbName.Location = new System.Drawing.Point(626, 306);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(109, 29);
            this.lbName.TabIndex = 18;
            this.lbName.Text = "Tên bàn";
            // 
            // FFoodOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::partI.Properties.Resources.b7b6e07367f534efcb60b98a7e9a0c21_blurry_green_nature_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 379);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tC);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuyBan);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnOder);
            this.Controls.Add(this.panel1);
            this.Name = "FFoodOrder";
            this.Text = "FoodOrder";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FFoodOrder_FormClosed);
            this.Load += new System.EventHandler(this.FoodOrder_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.tC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOder;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnHuyBan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.TabControl tC;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label lbName;
    }
}