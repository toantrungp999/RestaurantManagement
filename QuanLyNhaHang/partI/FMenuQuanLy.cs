
using System;
using System.Windows.Forms;

namespace partI
{
    public partial class FMenuQuanLy : Form
    {
        CEmployee SEmploy = new CEmployee();
        int ID;
        string name;
        string service;
        public FMenuQuanLy(int ID, string name, string service)
        {
            InitializeComponent();
          //  Employ = new DataTable();
            this.ID = ID;
            this.name = name;
            this.service = service;
            Label_Information.Text = "ID: " + ID.ToString() + "  Tên: " + name + "   Bộ phận: " + service;
            if(this.service!="Manager" && this.service != "TopManager")
            {
                btnQlyThucDon.Hide();
                btnQLyNhanSu.Hide();
                btnReport.Hide();
            }
            
        }

        private void btnQLyNhanSu_Click(object sender, EventArgs e)
        {
            FQlyNhanSu Form3 = new FQlyNhanSu(service);
            Form3.ShowDialog();
            Form3 = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MapTable f4 = new MapTable(ID);
            f4.ShowDialog();
            f4 = null;
        }

        private void MenuQuanLy_Load(object sender, EventArgs e)
        {

        }

        private void btnQlyThucDon_Click(object sender, EventArgs e)
        {
            FQlyThucDon FQlyThucDon = new FQlyThucDon();
            FQlyThucDon.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //Report.FReportMenu fReport = new Report.FReportMenu();
            //fReport.ShowDialog();
        }
    }
}
