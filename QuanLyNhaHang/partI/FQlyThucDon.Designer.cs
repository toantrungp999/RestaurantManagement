namespace partI
{
    partial class FQlyThucDon
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
            this.tp = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btMonCu = new System.Windows.Forms.Button();
            this.pnMonAn = new System.Windows.Forms.Panel();
            this.btQuayLai = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.tp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tp
            // 
            this.tp.Controls.Add(this.tabPage6);
            this.tp.Controls.Add(this.tabPage1);
            this.tp.Controls.Add(this.tabPage2);
            this.tp.Controls.Add(this.tabPage3);
            this.tp.Controls.Add(this.tabPage4);
            this.tp.Controls.Add(this.tabPage5);
            this.tp.Location = new System.Drawing.Point(2, 0);
            this.tp.Name = "tp";
            this.tp.SelectedIndex = 0;
            this.tp.Size = new System.Drawing.Size(458, 24);
            this.tp.TabIndex = 10;
            this.tp.SelectedIndexChanged += new System.EventHandler(this.tp_SelectedIndexChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(450, 0);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Tất cả";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(450, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Món khô";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(450, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lẩu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(450, 0);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tráng miệng";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(450, 0);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Nước";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(450, 0);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Khác";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btMonCu
            // 
            this.btMonCu.BackgroundImage = global::partI.Properties.Resources.btnSua;
            this.btMonCu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMonCu.ForeColor = System.Drawing.Color.DarkRed;
            this.btMonCu.Location = new System.Drawing.Point(116, 384);
            this.btMonCu.Name = "btMonCu";
            this.btMonCu.Size = new System.Drawing.Size(88, 37);
            this.btMonCu.TabIndex = 6;
            this.btMonCu.Text = "Món Cũ";
            this.btMonCu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMonCu.UseVisualStyleBackColor = true;
            this.btMonCu.Click += new System.EventHandler(this.btMonCu_Click);
            // 
            // pnMonAn
            // 
            this.pnMonAn.AutoScroll = true;
            this.pnMonAn.BackColor = System.Drawing.Color.LightGreen;
            this.pnMonAn.Location = new System.Drawing.Point(2, 24);
            this.pnMonAn.Name = "pnMonAn";
            this.pnMonAn.Size = new System.Drawing.Size(458, 357);
            this.pnMonAn.TabIndex = 9;
            this.pnMonAn.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMonAn_Paint);
            // 
            // btQuayLai
            // 
            this.btQuayLai.BackgroundImage = global::partI.Properties.Resources.btnTroVe;
            this.btQuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btQuayLai.Location = new System.Drawing.Point(368, 384);
            this.btQuayLai.Name = "btQuayLai";
            this.btQuayLai.Size = new System.Drawing.Size(80, 34);
            this.btQuayLai.TabIndex = 8;
            this.btQuayLai.Text = "Quay lại";
            this.btQuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btQuayLai.UseVisualStyleBackColor = true;
            this.btQuayLai.Click += new System.EventHandler(this.btQuayLai_Click);
            // 
            // btThem
            // 
            this.btThem.BackgroundImage = global::partI.Properties.Resources.btnThem;
            this.btThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThem.ForeColor = System.Drawing.Color.ForestGreen;
            this.btThem.Location = new System.Drawing.Point(10, 384);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 37);
            this.btThem.TabIndex = 7;
            this.btThem.Text = "Thêm món";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // FQlyThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 425);
            this.Controls.Add(this.tp);
            this.Controls.Add(this.btMonCu);
            this.Controls.Add(this.pnMonAn);
            this.Controls.Add(this.btQuayLai);
            this.Controls.Add(this.btThem);
            this.Name = "FQlyThucDon";
            this.Text = "Quản lý thực đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FQlyThucDon_FormClosing);
            this.Load += new System.EventHandler(this.QlyThucDon_Load);
            this.tp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tp;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btMonCu;
        private System.Windows.Forms.Panel pnMonAn;
        private System.Windows.Forms.Button btQuayLai;
        private System.Windows.Forms.Button btThem;
    }
}