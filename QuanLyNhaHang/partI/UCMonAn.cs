using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace partI
{
    public partial class UCMonAn : UserControl
    {
        public bool Choose { get; set; }


        public int CountFood { get; set; }

        public int K { get; set; }
        public UCMonAn(string name, int price, int sale, string ID)
        {
            InitializeComponent();
            lbName.Text = name;
            

            if (sale == 0)
            {
                string Price1 = price.ToString();
                AddSpace.Space(ref Price1);
                lbPrice1.Text = Price1;
                lbSale.Hide();
                lbPrice2.Hide();
            }
            else
            {
                lbSale.Text = "Sale: " + sale.ToString()+"%";
                string Price1 = (price * (100 - sale) / 100).ToString();
                AddSpace.Space(ref Price1);
                lbPrice1.Text = "Giá:" + Price1;
                string Price2 = price.ToString();
                AddSpace.Space(ref Price2);
                lbPrice2.Text = "Giá ban đầu: " + Price2;
          
            }
            btnPictureFood.BackColor = Color.Red;
            this.BackColor = Color.Orange;
            Bitmap bm1 = new Bitmap(Application.StartupPath + "\\image\\" + ID.ToString().Trim() + ".jpg");
            Bitmap bm2 = new Bitmap(bm1);
            bm1.Dispose();
            btnPictureFood.BackgroundImage = bm2;
        }
        private void QLNhaHang_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Choose = true;
            numericUpDown1.Value++;
            this.OnClick(e);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            CountFood = Convert.ToInt32(numericUpDown1.Value);
            Choose = true;
            this.OnClick(e);

        }
        public void changeNumberUpDown(int k)
        {
            numericUpDown1.Value = k;
           
        }

    }
}
