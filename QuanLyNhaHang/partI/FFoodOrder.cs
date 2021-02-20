using System;
using System.Windows.Forms;

namespace partI
{
    public partial class FFoodOrder : Form
    {
        CreateMenu CreateUS;
        public bool thanhToan = false;
        public int location { get; set; }
        public string status { get; set; }
        public FFoodOrder(int location, int ID, string status)
        {
            InitializeComponent();
            this.location = location;
            this.status = status;
            this.Text = "Order món ăn - Bàn: " + location.ToString();
            lbName.Text = "Bàn: " + location.ToString();
            CreateUS = new CreateMenu(panel2, dgvBill, location, ID);
            CreateUS.CreateFoodbtn(panel1);
        }
        public void ActiveThanhToan()
        {
            if (thanhToan)
            {
                btnThanhToan.Enabled = true;
                btnHuyBan.Enabled = true;
            }
            else
            {
                btnThanhToan.Enabled = false;
                btnHuyBan.Enabled = false;
            }
        }
        private void FoodOrder_Load(object sender, EventArgs e)
        {
        }

        private void btnOder_Click(object sender, EventArgs e)
        {
            if (CreateUS.Total > 0 || CreateUS.them == false)
            {

                CreateUS.OrderFood();
                thanhToan = true;
                if (CreateUS.Total == 0)
                {
                    CreateUS.ThanhToan();
                    MessageBox.Show("Bạn vừa hủy bàn");
                    btnThanhToan.Enabled = false;
                    CreateUS.them = false;
                    thanhToan = false;
                    this.Dispose();
                }

            }
            else
            {
                thanhToan = false;
                MessageBox.Show("Bạn chưa chọn món!");
            }
            ActiveThanhToan();
        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            CreateUS.ThanhToan();
            btnThanhToan.Enabled = false;
            thanhToan = false;
            MessageBox.Show("Thanh toán thành công!");
            this.Dispose();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnHuyBan_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc hủy bàn không?\n Việc này cần quản lý xác nhận", "Trả lời",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                if (CreateUS.HuyBan())
                {
                    MessageBox.Show("Hủy bàn thành công!");
                    thanhToan = false;
                    this.Dispose();
                }
            }

        }
        private void tC_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateUS.CreateUser(tC.SelectedTab.Text.Trim(), panel1);
        }

        private void FFoodOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.panel1.Controls.Clear();
            this.Dispose();
            System.GC.Collect();
        }

        private void FFoodOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!CreateUS.Click)
            {
                CTable cTable = new CTable();
                cTable.UpdateTable(location, status);
            }
            
        }
    }
}
