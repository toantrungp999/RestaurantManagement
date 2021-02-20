using partI.DB_Layer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace partI
{
    public partial class FCancelBill : Form
    {
        int ID_Bill;
        List<int> ID_Food;
        int ID_Employee;
        List<int> Amount;
        public bool Status { get; set; }

        public FCancelBill(int ID_Bill, List<int> ID_Food, int ID_Employee, List<int> Amount)
        {
            InitializeComponent();
            Status = false;
            this.ID_Bill = ID_Bill;
            this.ID_Employee = ID_Employee;
            this.ID_Food = ID_Food;
            this.Amount = Amount;
        }

        private void CancelBill_Load(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string err = "";
            Login lg = new Login();
            CCancelled GCancelled = new CCancelled();
            LoginCheck_Result Info = lg.Log(tbUser.Text, tbPass.Text, ref err);
            if (Info!=null && Info.Service=="TopManager" )
            {
                for (int i = 0; i < ID_Food.Count; i++)
                {
                    if (Amount[i] > 0)
                    {
                        GCancelled.TransprotDTBillToCancelled(ID_Bill, ID_Food[i], ID_Employee, Amount[i], cbReason.Text, ref err);
                    }
                }
                Status = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai thông tin tài khoản hoặc bạn đang không sử dụng tài khoản của Manager. Vui lòng nhập lại!");
                Status = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Status = false;
            this.Close();
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
