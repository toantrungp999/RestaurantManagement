namespace partI
{
    partial class FMenuQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenuQuanLy));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLyNhanSu = new System.Windows.Forms.Button();
            this.btnQlyBanHang = new System.Windows.Forms.Button();
            this.btnQlyThucDon = new System.Windows.Forms.Button();
            this.Label_Information = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // btnQLyNhanSu
            // 
            this.btnQLyNhanSu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQLyNhanSu.BackgroundImage")));
            this.btnQLyNhanSu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLyNhanSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLyNhanSu.Location = new System.Drawing.Point(209, 94);
            this.btnQLyNhanSu.Name = "btnQLyNhanSu";
            this.btnQLyNhanSu.Size = new System.Drawing.Size(232, 65);
            this.btnQLyNhanSu.TabIndex = 1;
            this.btnQLyNhanSu.Text = "Quản lý nhân sự";
            this.btnQLyNhanSu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLyNhanSu.UseVisualStyleBackColor = true;
            this.btnQLyNhanSu.Click += new System.EventHandler(this.btnQLyNhanSu_Click);
            // 
            // btnQlyBanHang
            // 
            this.btnQlyBanHang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQlyBanHang.BackgroundImage")));
            this.btnQlyBanHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQlyBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQlyBanHang.Location = new System.Drawing.Point(209, 189);
            this.btnQlyBanHang.Name = "btnQlyBanHang";
            this.btnQlyBanHang.Size = new System.Drawing.Size(232, 65);
            this.btnQlyBanHang.TabIndex = 2;
            this.btnQlyBanHang.Text = "Quản lý bán hàng";
            this.btnQlyBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQlyBanHang.UseVisualStyleBackColor = true;
            this.btnQlyBanHang.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnQlyThucDon
            // 
            this.btnQlyThucDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQlyThucDon.BackgroundImage")));
            this.btnQlyThucDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQlyThucDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQlyThucDon.Location = new System.Drawing.Point(209, 294);
            this.btnQlyThucDon.Name = "btnQlyThucDon";
            this.btnQlyThucDon.Size = new System.Drawing.Size(232, 65);
            this.btnQlyThucDon.TabIndex = 3;
            this.btnQlyThucDon.Text = "Quản lý thực đơn";
            this.btnQlyThucDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQlyThucDon.UseVisualStyleBackColor = true;
            this.btnQlyThucDon.Click += new System.EventHandler(this.btnQlyThucDon_Click);
            // 
            // Label_Information
            // 
            this.Label_Information.AutoSize = true;
            this.Label_Information.BackColor = System.Drawing.Color.Transparent;
            this.Label_Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Information.ForeColor = System.Drawing.Color.SteelBlue;
            this.Label_Information.Location = new System.Drawing.Point(10, 41);
            this.Label_Information.Name = "Label_Information";
            this.Label_Information.Size = new System.Drawing.Size(78, 17);
            this.Label_Information.TabIndex = 4;
            this.Label_Information.Text = "Information";
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReport.BackgroundImage")));
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(209, 389);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(232, 65);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "Report          ";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // FMenuQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 470);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.Label_Information);
            this.Controls.Add(this.btnQlyThucDon);
            this.Controls.Add(this.btnQlyBanHang);
            this.Controls.Add(this.btnQLyNhanSu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMenuQuanLy";
            this.Text = "Quản Lý";
            this.Load += new System.EventHandler(this.MenuQuanLy_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Button btnQLyNhanSu;
        private System.Windows.Forms.Button btnQlyBanHang;
        private System.Windows.Forms.Button btnQlyThucDon;
        private System.Windows.Forms.Label Label_Information;
        private System.Windows.Forms.Button btnReport;
    }
}