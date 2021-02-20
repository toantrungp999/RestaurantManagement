using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using partI.DS_Layer;
using partI.DB_Layer;

namespace partI
{
    public partial class FQlyMonCu : Form
    {
        CFood cFood;
        List<GetFood_Result> lFood;
        public FQlyMonCu()
        {
            InitializeComponent();
            cFood = new CFood();
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void pnMonCu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QlyMonCu_Load(object sender, EventArgs e)
        {
            List<GetFood_Result> lFood = cFood.GetFood("All", "Yes", "No");

            Point p = new Point(20, 10);
            for (int i = 0; i < lFood.Count; i++)
            {
                UCMonAnQlyThucDon MonAnn = new UCMonAnQlyThucDon(lFood[i].ID_Food.ToString(), lFood[i].Name.ToString(), lFood[i].Price.ToString(), lFood[i].Sale.ToString()
                 , lFood[i].Status.ToString(), lFood[i].Active, lFood[i].Types.ToString());
                //listMonAn.Add(MonAnn);
                MonAnn.Location = p;
                pnMonCu.Controls.Add(MonAnn);
                p.Y = p.Y + 10 + MonAnn.Height;
            }
        }
        public void Reload()
        {
            pnMonCu.Controls.Clear();
            //listMonAn.Clear();
            if (tp.SelectedTab.Text.Trim() == "Tất cả")
                lFood = cFood.GetFood("All", "Yes", "No");
            else
                lFood = cFood.GetFood(tp.SelectedTab.Text.Trim(), "Yes", "Yes");


            Point p = new Point(20, 10);
            for (int i = 0; i < lFood.Count; i++)
            {
                UCMonAnQlyThucDon MonAn = new UCMonAnQlyThucDon(lFood[i].ID_Food.ToString(), lFood[i].Name.ToString(), lFood[i].Price.ToString(), lFood[i].Sale.ToString()
                           , lFood[i].Status.ToString(), lFood[i].Active, lFood[i].Active.ToString());
                MonAn.Location = p;
                pnMonCu.Controls.Add(MonAn);
                //listMonAn.Add(MonAn);
                p.Y = p.Y + 10 + MonAn.Height;
            }
            System.GC.Collect();
        }
    }

}
