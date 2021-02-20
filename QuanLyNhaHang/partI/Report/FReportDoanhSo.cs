using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using partI.DS_Layer;

namespace partI.Report
{
    public partial class FReportDoanhSo : Form
    {
        CReport cReport;
        public FReportDoanhSo()
        {
            InitializeComponent();
            cReport = new CReport();
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            if (rbNgay.Checked)
            {
                DateTime start = new DateTime();
                DateTime end = new DateTime();
                string status = "";
                string type = cbbLoai.Text.Trim(); 
                if (rbMot.Checked)
                {
                    start = dtpMot.Value.Date;
                    end = start.AddDays(1);
                }
                else if (rbKhoang.Checked)
                {
                    start = dtpStart.Value.Date;
                    end = dtpEnd.Value.Date;
                }
                else if (rbAll.Checked)
                {
                    start = DateTime.Now.Date;
                    end = DateTime.Now.Date;
                    status = "All";
                }
                dgv.DataSource = cReport.ReportDoanhSo(start, end, status, type);
                dgv.Columns["ID_Food"].HeaderText = "Mã món";
                dgv.Columns["Name"].HeaderText = "Tên món";
                dgv.Columns["Amount"].HeaderText = "Số lượng";
                dgv.Columns["TotalPrice"].HeaderText = "Tổng thu (VND)";
                dgv.Columns["TotalSale"].HeaderText = "Tổng giảm giá (VND)";
            }
            else if (rbThang.Checked)
            {
                DateTime start = new DateTime();
                DateTime end = new DateTime();
                string status = "";
                string type = cbbLoai.Text.Trim();
                if (rbMot.Checked)
                {
                    start = new DateTime(dtpMot.Value.Year, Convert.ToInt32(dtpMot.Value.Month), 1);
                    end = start.AddMonths(1);
                }
                else if (rbKhoang.Checked)
                {
                    start = new DateTime(dtpStart.Value.Year, Convert.ToInt32(dtpStart.Value.Month), 1);
                    end = new DateTime(dtpEnd.Value.Year, Convert.ToInt32(dtpEnd.Value.Month), 1).AddMonths(1);
                }
                else if (rbAll.Checked)
                {
                    start = DateTime.Now.Date;
                    end = DateTime.Now.Date;
                    status = "All";
                }
                dgv.DataSource = cReport.ReportDoanhSo(start, end, status, type);
                dgv.Columns["ID_Food"].HeaderText = "Mã món";
                dgv.Columns["Name"].HeaderText = "Tên món";
                dgv.Columns["Amount"].HeaderText = "Số lượng";
                dgv.Columns["TotalPrice"].HeaderText = "Tổng thu (VND)";
                dgv.Columns["TotalSale"].HeaderText = "Tổng giảm giá (VND)";
            }
        }

        private void rbNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNgay.Checked)
            {
                dtpMot.CustomFormat = "'Ngày' dd   'Tháng' MM  'Năm' yyyy";
                dtpStart.CustomFormat = "'Ngày' dd   'Tháng' MM  'Năm' yyyy";
                dtpEnd.CustomFormat = "'Ngày' dd   'Tháng' MM  'Năm' yyyy";
            }
        }

        private void rbThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThang.Checked)
            {
                dtpMot.CustomFormat = "'Tháng' MM  'Năm' yyyy";
                dtpStart.CustomFormat = "'Tháng' MM  'Năm' yyyy";
                dtpEnd.CustomFormat = "'Tháng' MM  'Năm' yyyy";
            }

        }

        private void rbMot_CheckedChanged(object sender, EventArgs e)
        {
            dtpMot.Enabled = rbMot.Checked;
        }

        private void rbKhoang_CheckedChanged(object sender, EventArgs e)
        {
            dtpStart.Enabled = rbKhoang.Checked;
            dtpEnd.Enabled = rbKhoang.Checked;
        }

        private void FReportDoanhSo_Load(object sender, EventArgs e)
        {
            dtpMot.Enabled = true;
            dtpStart.Enabled = false;
            dtpEnd.Enabled = false;
            rbNgay.Checked = true;
            rbMot.Checked = true;
            cbbLoai.Text = "Lẩu";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
