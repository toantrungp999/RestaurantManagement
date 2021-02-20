using partI.DB_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using partI.DS_Layer;

namespace partI
{
    public partial class FQlyTaiKhoan : Form
    {
        public bool Them;
        int t = 0;
        string err;
        int ID;
        CAccount setAccount = new CAccount();
        public FQlyTaiKhoan(int ID)
        {
            InitializeComponent();
            this.ID = ID;
            List<string> id = new List<string>();
            id.Add(ID.ToString());
            CbID.DataSource = id;
            CbID.SelectedText = ID.ToString();
            CbID.Enabled = false;
        }
        public FQlyTaiKhoan()
        {
            InitializeComponent();
            List<LoadAccount_Result> loadAccount = setAccount.LoadAccount();
            t = 1;
            CbID.ValueMember = "ID_Employee";
            CbID.DisplayMember = "ID_Employee";
            CbID.DataSource = loadAccount;
            CbID.Enabled = true;
            CbID.SelectedItem = loadAccount[0].ID_Employee.ToString();
            ID = loadAccount[0].ID_Employee;
            load();
        }
        void load()
        {
            if (t != 0)
            {
               
                t = 0;
               
            }
            else
            {
                ID = Convert.ToInt32(CbID.Text);
            }
            

            tbUser.ResetText();
            tbPass.ResetText();
            GetAccount_Result account = new GetAccount_Result();
            account = setAccount.GetAccount(ID);
            if (account != null)
            {
                tbUser.Text = account.User.ToString();
                tbPass.Text = account.Pass.ToString();
                Them = false;
            }
            else
                Them = true;

        }
        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbID_SelectedValueChanged(object sender, EventArgs e)
        {
            load();
        }

        private void CbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (tbUser.Text == "" || tbPass.Text == "")
                MessageBox.Show("Không được bỏ trống bất kỳ ô nào!");
            else
            {
                if (Them)
                {
                    try
                    {
                        setAccount.InsertAccount(tbUser.Text, tbPass.Text, Convert.ToInt32(CbID.Text));
                        load();
                        MessageBox.Show("Đã đăng ký thành công!");
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không thêm được. Lỗi rồi!");
                    }

                }
                else
                {
                    try
                    {
                        setAccount.UpdateAccount(tbUser.Text, tbPass.Text, Convert.ToInt32(CbID.Text), ref err);
                        load();
                        MessageBox.Show("Đã sửa xong!");
                    }
                    catch
                    {
                        MessageBox.Show("Không sửa được. Lỗi rồi!");
                    }
                }
            }
        }

        private void FQlyTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }
    }
}
