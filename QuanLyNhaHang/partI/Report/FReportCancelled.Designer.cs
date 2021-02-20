namespace partI.Report
{
    partial class FReportCancelled
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpMot = new System.Windows.Forms.DateTimePicker();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbKhoang = new System.Windows.Forms.RadioButton();
            this.rbMot = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btReport = new System.Windows.Forms.Button();
            this.rbThang = new System.Windows.Forms.RadioButton();
            this.rbNgay = new System.Windows.Forms.RadioButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpEnd);
            this.groupBox2.Controls.Add(this.dtpStart);
            this.groupBox2.Controls.Add(this.dtpMot);
            this.groupBox2.Controls.Add(this.rbAll);
            this.groupBox2.Controls.Add(this.rbKhoang);
            this.groupBox2.Controls.Add(this.rbMot);
            this.groupBox2.Location = new System.Drawing.Point(146, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "\'Ngày\' dd   \'Tháng\' MM  \'Năm\' yyyy";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(372, 43);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 5;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "\'Ngày\' dd   \'Tháng\' MM  \'Năm\' yyyy";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(152, 43);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 4;
            // 
            // dtpMot
            // 
            this.dtpMot.CustomFormat = "\'Ngày\' dd   \'Tháng\' MM  \'Năm\' yyyy";
            this.dtpMot.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMot.Location = new System.Drawing.Point(152, 15);
            this.dtpMot.Name = "dtpMot";
            this.dtpMot.Size = new System.Drawing.Size(200, 20);
            this.dtpMot.TabIndex = 3;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(38, 66);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(56, 17);
            this.rbAll.TabIndex = 2;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Tất cả";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbKhoang
            // 
            this.rbKhoang.AutoSize = true;
            this.rbKhoang.Location = new System.Drawing.Point(38, 43);
            this.rbKhoang.Name = "rbKhoang";
            this.rbKhoang.Size = new System.Drawing.Size(105, 17);
            this.rbKhoang.TabIndex = 1;
            this.rbKhoang.TabStop = true;
            this.rbKhoang.Text = "Khoảng thời gian";
            this.rbKhoang.UseVisualStyleBackColor = true;
            this.rbKhoang.CheckedChanged += new System.EventHandler(this.rbKhoang_CheckedChanged);
            // 
            // rbMot
            // 
            this.rbMot.AutoSize = true;
            this.rbMot.Location = new System.Drawing.Point(38, 18);
            this.rbMot.Name = "rbMot";
            this.rbMot.Size = new System.Drawing.Size(90, 17);
            this.rbMot.TabIndex = 0;
            this.rbMot.TabStop = true;
            this.rbMot.Text = "Ngày (Tháng)";
            this.rbMot.UseVisualStyleBackColor = true;
            this.rbMot.CheckedChanged += new System.EventHandler(this.rbMot_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btReport);
            this.groupBox1.Controls.Add(this.rbThang);
            this.groupBox1.Controls.Add(this.rbNgay);
            this.groupBox1.Location = new System.Drawing.Point(21, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btReport
            // 
            this.btReport.Location = new System.Drawing.Point(6, 63);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(113, 31);
            this.btReport.TabIndex = 6;
            this.btReport.Text = "Thống kê";
            this.btReport.UseVisualStyleBackColor = true;
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // rbThang
            // 
            this.rbThang.AutoSize = true;
            this.rbThang.Location = new System.Drawing.Point(6, 42);
            this.rbThang.Name = "rbThang";
            this.rbThang.Size = new System.Drawing.Size(80, 17);
            this.rbThang.TabIndex = 1;
            this.rbThang.TabStop = true;
            this.rbThang.Text = "Theo tháng";
            this.rbThang.UseVisualStyleBackColor = true;
            this.rbThang.CheckedChanged += new System.EventHandler(this.rbThang_CheckedChanged);
            // 
            // rbNgay
            // 
            this.rbNgay.AutoSize = true;
            this.rbNgay.Location = new System.Drawing.Point(6, 19);
            this.rbNgay.Name = "rbNgay";
            this.rbNgay.Size = new System.Drawing.Size(76, 17);
            this.rbNgay.TabIndex = 0;
            this.rbNgay.TabStop = true;
            this.rbNgay.Text = "Theo ngày";
            this.rbNgay.UseVisualStyleBackColor = true;
            this.rbNgay.CheckedChanged += new System.EventHandler(this.rbNgay_CheckedChanged);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 161);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1048, 206);
            this.dgv.TabIndex = 7;
            // 
            // FReportCancelled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FReportCancelled";
            this.Text = "FReportCancelledBill";
            this.Load += new System.EventHandler(this.FReportCancelledBill_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpMot;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbKhoang;
        private System.Windows.Forms.RadioButton rbMot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btReport;
        private System.Windows.Forms.RadioButton rbThang;
        private System.Windows.Forms.RadioButton rbNgay;
        private System.Windows.Forms.DataGridView dgv;
    }
}