using partI.DB_Layer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace partI
{
    public partial class MapTable : Form
    {
        
        public int ID { get; set; }
        public string Status { get; set; }
        
        public MapTable(int ID)
        {
            InitializeComponent();
            this.ID = ID;
            Create();
            timer1.Start();
        }
        private void Create()
        {
            CTable gTable = new CTable();
            List<GetTable_Result> tables = new List<GetTable_Result>();
            tables = gTable.GetTable();
            Point P = new Point(40, 80);
            int j = 0;
            for (int i = 0; i < tables.Count; i++)
            {

                if (j == 4)
                {
                    j = 0;
                    P.X = 40;
                    P.Y = P.Y + 80;
                }
                Button btn = new Button()
                {
                    Font = new Font(Font.FontFamily, 11), // ForeColor=Color.Orange,
                    Text = tables[i].Location.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Width = 100,
                    Height = 40,
                    Location = P
                };
                if (tables[i].Status == "No")
                {
                    btn.BackColor = Color.Khaki;
                }
                else if (tables[i].Status == "Wait")
                {
                    btn.BackColor = Color.Blue;
                }
                else
                    btn.BackColor = Color.PaleGreen;
                P.X = P.X + 120;
                j++;
                this.panel1.Controls.Add(btn);
                btn.Click += Btn_Click;
                System.GC.Collect();
                
            }
        }
        public void changeColor()
        {
            CTable gTable = new CTable();
            List<GetTable_Result> tables = new List<GetTable_Result>();
            tables = gTable.GetTable();
            for(int i=0;i<this.panel1.Controls.Count;i++)
                if (tables[i].Status == "No")
                {
                    this.panel1.Controls[i].BackColor = Color.Khaki;
                }
                else if (tables[i].Status == "Wait")
                {
                    this.panel1.Controls[i].BackColor = Color.Blue;
                }
                else
                    this.panel1.Controls[i].BackColor = Color.PaleGreen;

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            CTable cTable = new CTable();
            string status = cTable.StateTable(Convert.ToInt32(btn.Text));
            if (status == "Wait")
            {
                MessageBox.Show("Bàn đang được gọi món vui lòng chọn bàn khác");
            }
            else
            {
                FFoodOrder f = new FFoodOrder(Convert.ToInt32(btn.Text), ID, status);
                if (btn.BackColor == Color.Khaki)
                    f.thanhToan = true;
                timer1.Stop();
                f.ActiveThanhToan();
                this.Hide();
                f.ShowDialog();
               
                this.Show();
                timer1.Start();
                changeColor();
                System.GC.Collect();
            }
           
        }

        private void order_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void MapTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            changeColor();
        }
    }
}