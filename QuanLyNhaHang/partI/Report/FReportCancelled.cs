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
    public partial class FReportCancelled : Form
    {
        CReport cReport;
        public FReportCancelled()
        {
            InitializeComponent();
            cReport = new CReport();
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

        private void FReportCancelledBill_Load(object sender, EventArgs e)
        {
            dtpMot.Enabled = true;
            dtpStart.Enabled = false;
            dtpEnd.Enabled = false;
            rbNgay.Checked = true;
            rbMot.Checked = true;
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

        private void rbThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThang.Checked)
            {
                dtpMot.CustomFormat = "'Tháng' MM  'Năm' yyyy";
                dtpStart.CustomFormat = "'Tháng' MM  'Năm' yyyy";
                dtpEnd.CustomFormat = "'Tháng' MM  'Năm' yyyy";
            }
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            if (rbNgay.Checked)
            {
                DateTime start = new DateTime();
                DateTime end = new DateTime();
                string status = "";
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
                dgv.DataSource = cReport.ReportHoaDonHuy(start, end, status);
                dgv.Columns["ID_Bill"].HeaderText = "Mã hóa đơn";
                dgv.Columns["ID_Food"].HeaderText = "Mã món ăn";
                dgv.Columns["FoodName"].HeaderText = "Tên món ăn";
                dgv.Columns["Price"].HeaderText = "Đơn giá (VND)";
                dgv.Columns["Sale"].HeaderText = "Giảm giá (%)";
                dgv.Columns["Location"].HeaderText = "Bàn";
                dgv.Columns["ID_Employee"].HeaderText = "Mã nhân viên hủy";
                dgv.Columns["Name"].HeaderText = "Tên nhân viên";
                dgv.Columns["Time"].HeaderText = "Thời gian";
                dgv.Columns["Reason"].HeaderText = "Lý do";
            }
            else if (rbThang.Checked)
            {
                DateTime start = new DateTime();
                DateTime end = new DateTime();
                string status = "";
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
                dgv.DataSource = cReport.ReportHoaDonHuy(start, end, status);
                dgv.Columns["ID_Bill"].HeaderText = "Mã hóa đơn";
                dgv.Columns["ID_Food"].HeaderText = "Mã món ăn";
                dgv.Columns["FoodName"].HeaderText = "Tên món ăn";
                dgv.Columns["Price"].HeaderText = "Đơn giá (VND)";
                dgv.Columns["Sale"].HeaderText = "Giảm giá (%)";
                dgv.Columns["Location"].HeaderText = "Bàn";
                dgv.Columns["ID_Employee"].HeaderText = "Mã nhân viên hủy";
                dgv.Columns["Name"].HeaderText = "Tên nhân viên";
                dgv.Columns["Time"].HeaderText = "Thời gian";
                dgv.Columns["Reason"].HeaderText = "Lý do";
            }
        }
    }
}
