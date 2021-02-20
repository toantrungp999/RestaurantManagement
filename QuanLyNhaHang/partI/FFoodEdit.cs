using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using partI.DB_Layer;

namespace partI
{
    public partial class FFoodEdit : Form
    {
        private string id;
        private bool them;
        private bool sua;
        private bool luu;

        CFood cFood;


        public FFoodEdit(string id, string ten, string gia, string giamgia, string trangthai, string loai)
        {
            cFood = new CFood();
            sua = false;
            luu = false;
            them = false;
            InitializeComponent();
            this.id = id;
            tbTen.Text = ten;
            tbGia.Text = gia;
            tbGiamGia.Text = giamgia;
            cbbLoai.Text = loai;
            if (trangthai == "Hiện có")
                cbTrangThai.Checked = true;
            else
                cbTrangThai.Checked = false;
            try
            {
                Bitmap bm1 = new Bitmap(Application.StartupPath + "\\image\\" + id.ToString().Trim() + ".jpg");
                Bitmap bm2 = new Bitmap(bm1);
                bm1.Dispose();
                btHinh.BackgroundImage = bm2;
            }
            catch { }
        }
        public FFoodEdit()
        {
            InitializeComponent();
            cFood = new CFood();
            them = true;
            sua = false;
            luu = false;
            cbTrangThai.Checked = true;
   
        }
        private void FoodEdit_Load(object sender, EventArgs e)
        {
            if (them)
                btHinh.Text = "Chọn Hình";
            else
                btHinh.Text = "";
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbGia.Text == "" || tbGiamGia.Text == "" || tbTen.Text == "")
                {
                    throw new Exception();
                }
                if (!them)
                {
                    DialogResult traloi;
                    traloi = MessageBox.Show("Bạn có muốn lưu thay đổi", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (traloi == DialogResult.Yes)
                    {

                        string tt;
                        if (cbTrangThai.Checked == true)
                            tt = "Yes";
                        else
                            tt = "No";
                        //string err = "";                
                        cFood.UpdateFood(Convert.ToInt32(this.id), tbTen.Text, Convert.ToInt32(tbGia.Text), tt, Convert.ToInt32(tbGiamGia.Text), "Yes", cbbLoai.Text);
                        luu = true;
                    }

                    //else
                    //{
                    //    XuLyAnhHuyThaoTac();
                    //}
                }
                if (them)
                {
                    DialogResult traloi;
                    traloi = MessageBox.Show("Bạn có muốn lưu thay đổi", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (traloi == DialogResult.Yes)
                    {
                        string a = Application.StartupPath + "\\image\\backup.jpg";
                        if (!File.Exists(a))
                            throw new Exception();
                        string tt;
                        if (cbTrangThai.Checked == true)
                            tt = "Yes";
                        else
                            tt = "No";

                        //string err = "";
                        int id =cFood.InsertFoodAndGetInsertedFood(tbTen.Text, Convert.ToInt32(tbGia.Text), tt, Convert.ToInt32(tbGiamGia.Text), "Yes", cbbLoai.Text);

                        ThemHinhAnh(id);
                        luu = true;
                    }
                }


                this.Close();

            }
            catch (FormatException)
            {
                MessageBox.Show("Nhập sai định dạng", "Nhập Sai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Không được để trống thông tin", "Nhập Sai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btHinh_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName.Substring(ofd.FileName.Length - 4) != ".jpg" && ofd.FileName.Substring(ofd.FileName.Length - 4) != ".jpe")
                    MessageBox.Show("Vui lòng chọn ảnh định dạng .jpg hoặc .jpe", "Không đúng định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (them)
                {
                    sua = true;
                    string a = ofd.FileName;
                    string b = Application.StartupPath + "\\image\\backup.jpg";
                    if (File.Exists(b))
                        File.Delete(b);
                    File.Copy(a, b);

                    Bitmap bm = new Bitmap(Application.StartupPath + "\\image\\backup.jpg");
                    Bitmap bm2 = new Bitmap(bm);
                    bm.Dispose();
                    btHinh.BackgroundImage = bm2;
                    btHinh.Text = "";
                }
                else
                {
                    sua = true;
                    string a = ofd.FileName;
                    string b = Application.StartupPath + "\\image\\" + id.ToString().Trim() + ".jpg";
                    if (File.Exists(b))
                    {
                        string c = Application.StartupPath + "\\image\\backup.jpg";
                        if (File.Exists(c))
                            File.Delete(c);
                        File.Copy(b, c);
                        File.Delete(b);
                    }

                    File.Copy(a, Application.StartupPath + "\\image\\" + id.ToString().Trim() + ".jpg");

                    Bitmap bm = new Bitmap(Application.StartupPath + "\\image\\" + id.ToString().Trim() + ".jpg");
                    Bitmap bm2 = new Bitmap(bm);
                    bm.Dispose();
                    btHinh.BackgroundImage = bm2;
                    btHinh.Text = "";
                }

            }
        }
        void ThemHinhAnh(int? id)
        {
            try
            {
                if (id == null)
                    throw new Exception();
                string a = Application.StartupPath + "\\image\\backup.jpg";
                string b = Application.StartupPath + "\\image\\" + id.ToString().Trim() + ".jpg";
                if (File.Exists(b))
                    File.Delete(b);
                File.Move(a, b);
            }
            catch
            {
                MessageBox.Show("Lỗi thực thi!!! \n Vui lòng thử lại", "Mã Nhân viên Null", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void XuLyAnhHuyThaoTac()
        {
            if (sua && !luu && !them)
            {
                string b = Application.StartupPath + "\\image\\" + id.ToString().Trim() + ".jpg";
                if (File.Exists(b))
                    File.Delete(b);
                File.Move(Application.StartupPath + "\\image\\backup.jpg", b);
            }
            if (sua && !luu && them)
            {
                string b = Application.StartupPath + "\\image\\backup.jpg";
                if (File.Exists(b))
                    File.Delete(b);
            }
        }

        private void FFoodEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            XuLyAnhHuyThaoTac();
        }

        private void FFoodEdit_Load(object sender, EventArgs e)
        {
            if (them)
                btHinh.Text = "Chọn Hình";
            else
                btHinh.Text = "";
        }
    }
}
