namespace partI.Report
{
    partial class FReportMenu
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
            this.btDoanhThu = new System.Windows.Forms.Button();
            this.btDoanhSo = new System.Windows.Forms.Button();
            this.btBill = new System.Windows.Forms.Button();
            this.btCancelled = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btDoanhThu
            // 
            this.btDoanhThu.Location = new System.Drawing.Point(286, 75);
            this.btDoanhThu.Name = "btDoanhThu";
            this.btDoanhThu.Size = new System.Drawing.Size(75, 23);
            this.btDoanhThu.TabIndex = 0;
            this.btDoanhThu.Text = "Doanh Thu";
            this.btDoanhThu.UseVisualStyleBackColor = true;
            this.btDoanhThu.Click += new System.EventHandler(this.btDoanhThu_Click);
            // 
            // btDoanhSo
            // 
            this.btDoanhSo.Location = new System.Drawing.Point(286, 131);
            this.btDoanhSo.Name = "btDoanhSo";
            this.btDoanhSo.Size = new System.Drawing.Size(75, 23);
            this.btDoanhSo.TabIndex = 1;
            this.btDoanhSo.Text = "Doanh số";
            this.btDoanhSo.UseVisualStyleBackColor = true;
            this.btDoanhSo.Click += new System.EventHandler(this.btDoanhSo_Click);
            // 
            // btBill
            // 
            this.btBill.Location = new System.Drawing.Point(286, 190);
            this.btBill.Name = "btBill";
            this.btBill.Size = new System.Drawing.Size(75, 23);
            this.btBill.TabIndex = 2;
            this.btBill.Text = "Hóa đơn";
            this.btBill.UseVisualStyleBackColor = true;
            this.btBill.Click += new System.EventHandler(this.btBill_Click);
            // 
            // btCancelled
            // 
            this.btCancelled.Location = new System.Drawing.Point(286, 242);
            this.btCancelled.Name = "btCancelled";
            this.btCancelled.Size = new System.Drawing.Size(75, 23);
            this.btCancelled.TabIndex = 3;
            this.btCancelled.Text = "Món bị hủy";
            this.btCancelled.UseVisualStyleBackColor = true;
            this.btCancelled.Click += new System.EventHandler(this.btCancelled_Click);
            // 
            // FReportMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCancelled);
            this.Controls.Add(this.btBill);
            this.Controls.Add(this.btDoanhSo);
            this.Controls.Add(this.btDoanhThu);
            this.Name = "FReportMenu";
            this.Text = "FReportMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDoanhThu;
        private System.Windows.Forms.Button btDoanhSo;
        private System.Windows.Forms.Button btBill;
        private System.Windows.Forms.Button btCancelled;
    }
}