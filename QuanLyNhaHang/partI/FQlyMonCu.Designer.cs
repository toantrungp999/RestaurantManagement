namespace partI
{
    partial class FQlyMonCu
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
            this.btQuayLai = new System.Windows.Forms.Button();
            this.pnMonCu = new System.Windows.Forms.Panel();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tp = new System.Windows.Forms.TabControl();
            this.tp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btQuayLai
            // 
            this.btQuayLai.BackgroundImage = global::partI.Properties.Resources.btnTroVe;
            this.btQuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btQuayLai.Location = new System.Drawing.Point(256, 462);
            this.btQuayLai.Margin = new System.Windows.Forms.Padding(4);
            this.btQuayLai.Name = "btQuayLai";
            this.btQuayLai.Size = new System.Drawing.Size(114, 45);
            this.btQuayLai.TabIndex = 8;
            this.btQuayLai.Text = "Quay Lại";
            this.btQuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btQuayLai.UseVisualStyleBackColor = true;
            this.btQuayLai.Click += new System.EventHandler(this.btQuayLai_Click);
            // 
            // pnMonCu
            // 
            this.pnMonCu.AutoScroll = true;
            this.pnMonCu.BackColor = System.Drawing.Color.PeachPuff;
            this.pnMonCu.Location = new System.Drawing.Point(0, 31);
            this.pnMonCu.Margin = new System.Windows.Forms.Padding(4);
            this.pnMonCu.Name = "pnMonCu";
            this.pnMonCu.Size = new System.Drawing.Size(611, 423);
            this.pnMonCu.TabIndex = 7;
            this.pnMonCu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMonCu_Paint);
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(603, 0);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Khác";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(603, 0);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Nước";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(603, 0);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tráng miệng";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(603, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lẩu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(603, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Món khô";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(603, 0);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Tất cả";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tp
            // 
            this.tp.Controls.Add(this.tabPage6);
            this.tp.Controls.Add(this.tabPage1);
            this.tp.Controls.Add(this.tabPage2);
            this.tp.Controls.Add(this.tabPage3);
            this.tp.Controls.Add(this.tabPage4);
            this.tp.Controls.Add(this.tabPage5);
            this.tp.Location = new System.Drawing.Point(0, 2);
            this.tp.Margin = new System.Windows.Forms.Padding(4);
            this.tp.Name = "tp";
            this.tp.SelectedIndex = 0;
            this.tp.Size = new System.Drawing.Size(611, 25);
            this.tp.TabIndex = 9;
            this.tp.SelectedIndexChanged += new System.EventHandler(this.tp_SelectedIndexChanged);
            // 
            // FQlyMonCu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 510);
            this.Controls.Add(this.pnMonCu);
            this.Controls.Add(this.btQuayLai);
            this.Controls.Add(this.tp);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FQlyMonCu";
            this.Text = "Quản lý món cũ";
            this.Load += new System.EventHandler(this.QlyMonCu_Load);
            this.tp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btQuayLai;
        private System.Windows.Forms.Panel pnMonCu;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabControl tp;
    }
}