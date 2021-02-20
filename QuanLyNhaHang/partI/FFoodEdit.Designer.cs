namespace partI
{
    partial class FFoodEdit
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbTrangThai = new System.Windows.Forms.CheckBox();
            this.tbGiamGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btHuy = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btHinh = new System.Windows.Forms.Button();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "%";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.AutoSize = true;
            this.cbTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrangThai.Location = new System.Drawing.Point(225, 101);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(177, 19);
            this.cbTrangThai.TabIndex = 22;
            this.cbTrangThai.Text = "Trạng thái (Chọn là hiện có)";
            this.cbTrangThai.UseVisualStyleBackColor = false;
            // 
            // tbGiamGia
            // 
            this.tbGiamGia.Location = new System.Drawing.Point(246, 60);
            this.tbGiamGia.Name = "tbGiamGia";
            this.tbGiamGia.Size = new System.Drawing.Size(39, 20);
            this.tbGiamGia.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(182, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Giảm giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tên";
            // 
            // btHuy
            // 
            this.btHuy.BackColor = System.Drawing.Color.SandyBrown;
            this.btHuy.BackgroundImage = global::partI.Properties.Resources.btnTroVe;
            this.btHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btHuy.Location = new System.Drawing.Point(320, 130);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(75, 34);
            this.btHuy.TabIndex = 17;
            this.btHuy.Text = "Thoát";
            this.btHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btHuy.UseVisualStyleBackColor = false;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btLuu
            // 
            this.btLuu.BackColor = System.Drawing.Color.Honeydew;
            this.btLuu.BackgroundImage = global::partI.Properties.Resources.btnLuu;
            this.btLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLuu.ForeColor = System.Drawing.Color.ForestGreen;
            this.btLuu.Location = new System.Drawing.Point(206, 130);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(69, 34);
            this.btLuu.TabIndex = 16;
            this.btLuu.Text = "Lưu";
            this.btLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLuu.UseVisualStyleBackColor = false;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btHinh
            // 
            this.btHinh.BackColor = System.Drawing.Color.PaleGreen;
            this.btHinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btHinh.Location = new System.Drawing.Point(10, 5);
            this.btHinh.Name = "btHinh";
            this.btHinh.Size = new System.Drawing.Size(150, 150);
            this.btHinh.TabIndex = 15;
            this.btHinh.Text = "btHinh";
            this.btHinh.UseVisualStyleBackColor = false;
            this.btHinh.Click += new System.EventHandler(this.btHinh_Click);
            // 
            // tbGia
            // 
            this.tbGia.Location = new System.Drawing.Point(225, 31);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(100, 20);
            this.tbGia.TabIndex = 14;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(225, 6);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(190, 20);
            this.tbTen.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(182, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Loại";
            // 
            // cbbLoai
            // 
            this.cbbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Items.AddRange(new object[] {
            "Lẩu",
            "Món Khô",
            "Nước",
            "Tráng miệng",
            "Khác"});
            this.cbbLoai.Location = new System.Drawing.Point(246, 79);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(121, 21);
            this.cbbLoai.TabIndex = 24;
            // 
            // FFoodEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::partI.Properties.Resources.b7b6e07367f534efcb60b98a7e9a0c21_blurry_green_nature_background;
            this.ClientSize = new System.Drawing.Size(439, 175);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.tbGiamGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btHinh);
            this.Controls.Add(this.tbGia);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbLoai);
            this.Name = "FFoodEdit";
            this.Text = "Chỉnh sửa món ăn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FFoodEdit_FormClosing);
            this.Load += new System.EventHandler(this.FFoodEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbTrangThai;
        private System.Windows.Forms.TextBox tbGiamGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btHinh;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbLoai;
    }
}