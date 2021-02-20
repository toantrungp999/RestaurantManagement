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
    public partial class FReportDoanhThu : Form
    {
        CReport cReport;
        public FReportDoanhThu()
        {
            InitializeComponent();
            cReport = new CReport();
        }

        private void rdMot_CheckedChanged(object sender, EventArgs e)
        {
            dtpMot.Enabled = rbMot.Checked;
        }

        private void rbKhoang_CheckedChanged(object sender, EventArgs e)
        {
            dtpStart.Enabled = rbKhoang.Checked;
            dtpEnd.Enabled = rbKhoang.Checked;
        }

        private void rbDoanhThuNgay_CheckedChanged(object sender, EventArgs e)
        {
            if(rbDoanhThuNgay.Checked)
            {
                dtpMot.CustomFormat = "'Ngày' dd   'Tháng' MM  'Năm' yyyy";
                dtpStart.CustomFormat = "'Ngày' dd   'Tháng' MM  'Năm' yyyy";
                dtpEnd.CustomFormat = "'Ngày' dd   'Tháng' MM  'Năm' yyyy";
            }
        }

        private void rbDoanhThuThang_CheckedChanged(object sender, EventArgs e)
        {
            if(rbDoanhThuThang.Checked)
            {
                dtpMot.CustomFormat = "'Tháng' MM  'Năm' yyyy";
                dtpStart.CustomFormat = "'Tháng' MM  'Năm' yyyy";
                dtpEnd.CustomFormat = "'Tháng' MM  'Năm' yyyy";
            }

        }

        private void FReportDoanhThu_Load(object sender, EventArgs e)
        {
            dtpMot.Enabled = true;
            dtpStart.Enabled = false;
            dtpEnd.Enabled = false;
            rbDoanhThuNgay.Checked = true;
            rbMot.Checked = true;
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rbDoanhThuNgay.Checked)
            {
                DateTime start = new DateTime();
                DateTime end = new DateTime();
                string status = "";
                if(rbMot.Checked)
                {
                    start = dtpMot.Value.Date;
                    end = start.AddDays(1);
                }
                else if(rbKhoang.Checked)
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
                dgv.DataSource = cReport.ReportDoanhThuNgay(start, end, status);
                dgv.Columns["Total"].HeaderText = "Doanh thu (VND)";
                dgv.Columns["Time"].HeaderText = "Thời gian";
            }
            else if (rbDoanhThuThang.Checked)
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
                dgv.DataSource = cReport.ReportDoanhThuThang(start, end, status);
                dgv.Columns["Total"].HeaderText = "Doanh thu (VND)";
                dgv.Columns["MonthOfDate"].HeaderText = "Tháng";
                dgv.Columns["YearOfDate"].HeaderText = "Năm";
            }
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
