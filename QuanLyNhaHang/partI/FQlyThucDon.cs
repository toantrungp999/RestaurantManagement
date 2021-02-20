using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using partI.DB_Layer;

namespace partI
{
    public partial class FQlyThucDon : Form
    {
        CFood cFood;
        List<GetFood_Result> lFood;
        public FQlyThucDon()
        {
            InitializeComponent();
            cFood = new CFood();
        }

        private void QlyThucDon_Load(object sender, EventArgs e)
        {
            List<GetFood_Result> lFood = cFood.GetFood("All", "Yes", "Yes");

            Point p = new Point(20, 10);
            for (int i = 0; i < lFood.Count; i++)
            {
                UCMonAnQlyThucDon MonAnn = new UCMonAnQlyThucDon(lFood[i].ID_Food.ToString(), lFood[i].Name.ToString(), lFood[i].Price.ToString(), lFood[i].Sale.ToString()
                 , lFood[i].Status.ToString(), lFood[i].Active, lFood[i].Types.ToString());
                //listMonAn.Add(MonAnn);
                MonAnn.Location = p;
                pnMonAn.Controls.Add(MonAnn);
                p.Y = p.Y + 10 + MonAnn.Height;
            }
        }
        public void Reload()
        {
            pnMonAn.Controls.Clear();
            //listMonAn.Clear();
            if (tp.SelectedTab.Text.Trim() == "Tất cả")
                lFood = cFood.GetFood("All", "Yes", "Yes");
            else
                lFood = cFood.GetFood(tp.SelectedTab.Text.Trim(), "Yes", "Yes");


            Point p = new Point(20, 10);
            for (int i = 0; i < lFood.Count; i++)
            {
                UCMonAnQlyThucDon MonAn = new UCMonAnQlyThucDon(lFood[i].ID_Food.ToString(), lFood[i].Name.ToString(), lFood[i].Price.ToString(), lFood[i].Sale.ToString()
                           , lFood[i].Status.ToString(), lFood[i].Active, lFood[i].Types.ToString());
                MonAn.Location = p;
                pnMonAn.Controls.Add(MonAn);
                //listMonAn.Add(MonAn);
                p.Y = p.Y + 10 + MonAn.Height;
            }
            System.GC.Collect();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            FFoodEdit ThemMon = new FFoodEdit();
            ThemMon.FormClosing += ThemMon_FormClosing;
            ThemMon.ShowDialog();
        }

        private void ThemMon_FormClosing(object sender, FormClosingEventArgs e)
        {
            Reload();
        }

        private void btMonCu_Click(object sender, EventArgs e)
        {
            FQlyMonCu MenuMonCu = new FQlyMonCu();
            MenuMonCu.FormClosing += MenuMonCu_FormClosing;
            MenuMonCu.ShowDialog();
        }

        private void MenuMonCu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Reload();
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void pnMonAn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FQlyThucDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            pnMonAn.Controls.Clear();
            System.GC.Collect();
        }
    }
}
