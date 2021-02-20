using partI.DB_Layer;
using System;
using System.Windows.Forms;

namespace partI
{
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            Login LG = new Login();
            string err = "";
            LoginCheck_Result account = LG.Log(tbUser.Text, tbPass.Text, ref err);
            if (account != null)
            {
                FMenuQuanLy Form2 = new FMenuQuanLy(account.ID, account.Name, account.Service);
                this.Hide();
                Form2.ShowDialog();
                this.Show();
                Form2 = null;
            }
            else
            {
                MessageBox.Show("Không đúng tên người dùng / mật khẩu !!!",
                "Thông báo");
                tbUser.Focus();
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }
    }
}
