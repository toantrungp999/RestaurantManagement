using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using partI.DB_Layer;
using System.Collections.Generic;
using partI.DS_Layer;

namespace partI
{
    public partial class FQlyNhanSu : Form
    {
        bool Them;
        string err;
        List<GetEmployee_Result> employees;
        CEmployee SEmploy = new CEmployee();
        string Service;
        public FQlyNhanSu(string Service)
        {

            InitializeComponent();
            SEmploy.Service = Service;
            this.Service = Service;
            this.cbGioiTinh.Items.Add("Nam");
            this.cbGioiTinh.Items.Add("Nữ");
            this.cbStatus.Items.Add("Đang làm việc");
            this.cbStatus.Items.Add("Đã nghỉ việc");
            this.cbChucVu.Items.Add("Nhân viên phục vụ");
            this.cbChucVu.Items.Add("Nhân viên bảo vệ");
            this.cbChucVu.Items.Add("Nhân viên lao công");
            this.cbGioiTinh.Text = "Nam";
            this.cbChucVu.Items.Add("Manager");
            this.cbChucVu.Text = "Nhân viên phục vụ";
            this.cbChucVu.Items.Add("TopManager");
        }
        void load()
        {
            try
            {
                employees = new List<GetEmployee_Result>();
                this.dgv.Enabled = true;
                employees.Clear();
                employees = SEmploy.GetEmployee("All");
                resetText();
                dgv.DataSource = employees;
                dgv.AutoResizeColumns();         
                this.tbID.Enabled = false;
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.cbStatus.Enabled = false;
                this.btnDKTK.Enabled = true;
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnTroVe.Enabled = true;
                this.plMain.Enabled = false;
                if(Service!="TopManager")
                {
                    this.btnLuu.Hide();
                    this.btnHuy.Hide();
                    this.btnDKTK.Hide();
                    this.btnThem.Hide();
                    this.btnSua.Hide();
                    this.btnXoa.Hide();
                    this.btnTroVe.Hide();
                }
                dgv_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Employee. Lỗi rồi!!!");
            }
        }
        private void resetText()
        {
            this.cbChucVu.ResetText();
            this.cbStatus.ResetText();
            this.cbGioiTinh.ResetText();
            this.tbID.ResetText();
            this.tbLuong.ResetText();
            this.tbName.ResetText();
            this.tbTimKiem.ResetText();
            this.tbID_code.ResetText();
            this.tbAddress.ResetText();
            this.tbPhoneNumber.ResetText();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv.CurrentCell.RowIndex;
            this.tbID.Text =
            dgv.Rows[r].Cells[0].Value.ToString();
            this.tbName.Text =
            dgv.Rows[r].Cells[1].Value.ToString();
            this.dateTimePicker1.Text = dgv.Rows[r].Cells[3].Value.ToString();
            this.cbGioiTinh.Text = dgv.Rows[r].Cells[4].Value.ToString();
            this.cbChucVu.Text = dgv.Rows[r].Cells[5].Value.ToString();
            this.tbLuong.Text = dgv.Rows[r].Cells[6].Value.ToString();
            this.dateTimePicker2.Text = dgv.Rows[r].Cells[7].Value.ToString();
            this.tbID_code.Text = dgv.Rows[r].Cells[2].Value.ToString();
            this.tbPhoneNumber.Text = dgv.Rows[r].Cells[9].Value.ToString();
            this.tbAddress.Text = dgv.Rows[r].Cells[10].Value.ToString();

            if (dgv.Rows[r].Cells[8].Value.ToString().Trim() == "Yes")
                this.cbStatus.Text = "Đang làm việc";
            else
                this.cbStatus.Text = "Đã nghỉ việc";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            this.plMain.Enabled = true;
            employees = new List<GetEmployee_Result>();
            employees = SEmploy.GetEmployee("All");
            resetText();
            this.tbID.Enabled = false;
            this.btnDKTK.Enabled = false;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            this.dgv.Enabled = false;
            this.tbID.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int r = dgv.CurrentCell.RowIndex;
            if (this.Service == "TopManager")
            {
                if (dgv.Rows[r].Cells[8].Value.ToString().Trim() == "No")
                    this.cbStatus.Enabled = true;
                Them = false;
                this.plMain.Enabled = true;
                dgv_CellClick(null, null);
                this.btnLuu.Enabled = true;
                this.btnHuy.Enabled = true;
                this.btnDKTK.Enabled = false;
                this.btnThem.Enabled = false;
                this.btnSua.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnTroVe.Enabled = false;
                this.tbID.Enabled = false;
                this.tbName.Focus();
                this.dgv.Enabled = false;
            }
            else
            {
                MessageBox.Show("Bạn không có quyền!");

            }



        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.plMain.Enabled = false;
            resetText();
            this.btnDKTK.Enabled = true;
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTroVe.Enabled = true;
            this.cbStatus.Enabled = false;
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.tbID.Enabled = true;
            this.dgv.Enabled = true;
            dgv_CellClick(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (this.Service != "TopManager")
            {
                MessageBox.Show("Bạn không đủ quyền để cấp chức này. Vui lòng chọn chức vụ khác!");
            }
            else
            {
                if (Them)
                {
                    try
                    {

                        int ID_Employee = -1;
                        ID_Employee = SEmploy.InsertEmployee(this.tbName.Text.Trim(), this.tbID_code.Text.Trim(), this.dateTimePicker1.Value, this.cbGioiTinh.Text.Trim(), this.cbChucVu.Text.Trim(), Convert.ToInt32(this.tbLuong.Text), this.dateTimePicker2.Value, Convert.ToInt32(this.tbPhoneNumber.Text.Trim()), this.tbAddress.Text.Trim(), ref err);
                        load();
                        FQlyTaiKhoan Form4 = new FQlyTaiKhoan(ID_Employee);
                        Form4.Them = true;
                        MessageBox.Show("Đã thêm xong, vui lòng đăng kí tài khoản!");
                        Form4.ShowDialog();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không thêm được. Lỗi rồi!");
                    }
                }
                else
                {
                    string active = "No";
                    if (this.cbStatus.Text=="Đang làm việc")
                        active="Yes";
                    SEmploy.UpdateEmployee(Convert.ToInt32(this.tbID.Text), this.tbName.Text.Trim(), this.tbID_code.Text.Trim(), this.dateTimePicker1.Value, this.cbGioiTinh.Text.Trim(), this.cbChucVu.Text.Trim(), Convert.ToInt32(this.tbLuong.Text), this.dateTimePicker2.Value, active, Convert.ToInt32(this.tbPhoneNumber.Text.Trim()), this.tbAddress.Text.Trim(), ref err);
                    load();
                    MessageBox.Show("Đã sửa xong!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            delete();
        }
        void delete()
        {
            try
            {

                int r = dgv.CurrentCell.RowIndex;
                string strID =
                dgv.Rows[r].Cells[0].Value.ToString().Trim();
                string service = dgv.Rows[r].Cells[4].Value.ToString();
                if ( service != "TopManager")
                {
                    CAccount SA = new CAccount();
                    DialogResult traloi;
                    traloi = MessageBox.Show("Bạn muốn cho người này thôi việc?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (traloi == DialogResult.Yes)
                    {
                        SEmploy.DeleteEmployee(Convert.ToInt32(strID), ref err);
                        //SA.DeleteAcc(Convert.ToInt32(strID), ref err);
                        load();
                        MessageBox.Show("Hoàn thành!");
                    }
                    else
                    {
                        MessageBox.Show("Không thực hiện được! "+err);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn không thể tự xóa chính bạn nếu bạn cần trợ giúp liên hệ\ntoantrungp999@gmail.com", "Trợ giúp");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDKTK_Click(object sender, EventArgs e)
        {
            FQlyTaiKhoan Form4 = new FQlyTaiKhoan();
            Form4.Them = false;
            Form4.ShowDialog();
        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            employees = new List<GetEmployee_Result>();
            employees.Clear();
            employees = SEmploy.GetEmployee(tbTimKiem.Text);
            dgv.DataSource = employees;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employees = new List<GetEmployee_Result>();
            employees.Clear();
            employees = SEmploy.GetEmployee(tbTimKiem.Text);
            dgv.DataSource = employees;
        }

        private void cbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tbPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            TextNumber(tbPhoneNumber);
        }
        void TextNumber(TextBox tb)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tb.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tb.Text = tb.Text.Remove(tb.Text.Length - 1);
            }
        }

        private void tbLuong_TextChanged(object sender, EventArgs e)
        {
            TextNumber(tbLuong);
        }

        private void FQlyNhanSu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }
    }
}
