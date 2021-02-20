using System;
using System.Drawing;
using System.Windows.Forms;

namespace partI
{
    public partial class UCMonAnQlyThucDon : UserControl
    {
        public string Id;
        bool luulai;
        CFood cFood;
        public UCMonAnQlyThucDon()
        {
            InitializeComponent();
            cFood = new CFood();
        }

        private void MonAnQlyThucDon_Load(object sender, EventArgs e)
        {
            if (!luulai)
                btLuuLai.Hide();
            else
            {
                btSua.Hide();
                btXoa.Hide();
            }
        }
        private void btLuuLai_Click_1(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn lưu lại món cũ", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                string active = "Yes";
                string tt;
                if (lbTrangThai.Text == "Hiện có")
                    tt = "Yes";
                else
                    tt = "No";
                cFood.UpdateFood(Convert.ToInt32(Id), lbTen.Text, Convert.ToInt32(lbGia.Text), tt, Convert.ToInt32(lbGiamGia.Text), active, lbLoai.Text);
                FQlyMonCu qlyMonCu = (FQlyMonCu)this.ParentForm;
                qlyMonCu.Reload();
            }
        }
        public UCMonAnQlyThucDon(bool luulai)
        {
            InitializeComponent();
            this.luulai = luulai;
        }
        public UCMonAnQlyThucDon(string id, string ten, string gia, string giamgia, string trangthai, string active, string loai)
        {
            InitializeComponent();
            cFood = new CFood();
            Id = id;
            lbTen.Text = ten;
            lbGia.Text = gia;
            lbGiamGia.Text = giamgia;
            lbLoai.Text = loai;
            if (active == "Yes")
                luulai = false;
            else
                luulai = true;
            if (trangthai == "Yes")
            {
                lbTrangThai.Text = "Hiện có";
                lbTrangThai.ForeColor = Color.Green;
            }
            else
            {
                lbTrangThai.Text = "Hiện không có";
                lbTrangThai.ForeColor = Color.Red;
            }
            try
            {
                Bitmap bm1 = new Bitmap(Application.StartupPath + "\\image\\" + id.ToString().Trim() + ".jpg");
                Bitmap bm2 = new Bitmap(bm1);
                bm1.Dispose();
                btnPictureFood.BackgroundImage = bm2;
            }
            catch { }

        }

        private void btSua_Click_1(object sender, EventArgs e)
        {
            FFoodEdit FSuaMonAn = new FFoodEdit(Id, lbTen.Text, lbGia.Text, lbGiamGia.Text, lbTrangThai.Text,lbLoai.Text);
            FSuaMonAn.FormClosed += FSuaMonAn_FormClosed; ;
            FSuaMonAn.ShowDialog();
        }

        private void FSuaMonAn_FormClosed(object sender, FormClosedEventArgs e)
        {
            FQlyThucDon qlyThucDon = (FQlyThucDon)this.ParentForm;
            qlyThucDon.Reload();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn lưu xóa \n Vẫn có thể khôi phục trong phần Món cũ", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                string active = "No";
                string tt;
                if (lbTrangThai.Text == "Hiện có")
                    tt = "Yes";
                else
                    tt = "No";
                cFood.UpdateFood(Convert.ToInt32(Id), lbTen.Text, Convert.ToInt32(lbGia.Text), tt, Convert.ToInt32(lbGiamGia.Text), active, lbLoai.Text);
                FQlyThucDon qlyThucDon = (FQlyThucDon)this.ParentForm;
                qlyThucDon.Reload();
            }
        }
    }
}
