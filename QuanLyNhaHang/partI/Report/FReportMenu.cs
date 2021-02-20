using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace partI.Report
{
    public partial class FReportMenu : Form
    {
        public FReportMenu()
        {
            InitializeComponent();
        }

        private void btDoanhThu_Click(object sender, EventArgs e)
        {
            FReportDoanhThu formDoanhThu = new FReportDoanhThu();
            formDoanhThu.ShowDialog();
        }

        private void btDoanhSo_Click(object sender, EventArgs e)
        {
            FReportDoanhSo formDoanhSo = new FReportDoanhSo();
            formDoanhSo.ShowDialog();
        }

        private void btBill_Click(object sender, EventArgs e)
        {
            FReportBill formBill = new FReportBill();
            formBill.ShowDialog();
        }

        private void btCancelled_Click(object sender, EventArgs e)
        {
            FReportCancelled formCancelled = new FReportCancelled();
            formCancelled.ShowDialog();
        }
    }
}
