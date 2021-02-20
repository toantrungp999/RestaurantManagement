using partI.DB_Layer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace partI
{
    class CreateMenu
    {
        private int ID_bill = 0;
        private int ID_Employee;
        private int location;
        public bool them = true;
        Label lb1;
        public List<int> listCount = new List<int>();
        public List<int> OldListCount = new List<int>();
        public int Total = 0;
        public List<GetFood_Result> listFood = new List<GetFood_Result>();
        List<UserControl> listUser = new List<UserControl>();
        public bool Click { get; set; } 
        public Panel Bill { get; set; }

        public DataGridView DgvBill { get; set; }
        public CreateMenu(Panel Bill, DataGridView dgvBill, int location, int ID_Employee)
        {
            this.ID_Employee = ID_Employee;
            this.Bill = Bill;
            this.location = location;
            this.DgvBill = dgvBill;
            this.DgvBill.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.DataPropertyName = "Amount";
            c1.HeaderText = "Số lượng";
            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.DataPropertyName = "Name";
            c2.HeaderText = "Tên món ăn";
            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.DataPropertyName = "Price";
            c3.HeaderText = "Giá";
            c2.Width = 160;
            c1.Width = 50;
            c3.Width = 100;
            this.DgvBill.Columns.Add(c1);
            this.DgvBill.Columns.Add(c2);
            this.DgvBill.Columns.Add(c3);

        }
        public void CreateFoodbtn(Panel Order)
        {
            CBill SBill = new CBill();
            them = SBill.GetID_Bill(location, ref ID_bill);
            CFood sFood = new CFood();
            List<GetFood_Result> dtFood = new List<GetFood_Result>();
            dtFood = sFood.GetFood("All","All","Yes");
            listFood = dtFood;
            
            if (them == false)
            {
                LoadAmount(listCount);
            }
            else
            {
                for (int i = 0; i < dtFood.Count; i++)
                {
                    listCount.Add(0);
                }
            }
            CreateUser(Order);

            lb1 = new Label()
            {
                Location = new Point(20, 220)
            };
            lb1.AutoSize = true;
            this.Bill.Controls.Add(lb1);
            if (them == false)
                load();
            LoadAmount(OldListCount);
        }

        public void CreateUser(Panel Order)
        {
            Order.Controls.Clear();
            Point P = new Point(0, 20);
            for (int i = 0; i < listFood.Count; i++)
            {
                if (listFood[i].Status == "Yes")
                {
                    UCMonAn UserFood = new UCMonAn(listFood[i].Name, listFood[i].Price.Value, listFood[i].Sale.Value, listFood[i].ID_Food.ToString())
                    {
                        Location = P
                    };
                    UserFood.K = i;
                    UserFood.changeNumberUpDown(listCount[i]);
                    listUser.Add(UserFood);
                    UserFood.Click += UserFood_Click;
                    P.X = 0;
                    P.Y = P.Y + 150;
                    Order.Controls.Add(UserFood);
                }
            }
            System.GC.Collect();
        }
        public void CreateUser(string t, Panel Order)
        {
            Order.Controls.Clear();
            Point P = new Point(0, 0);
            for (int i = 0; i < listFood.Count; i++)
            {
                if (listFood[i].Status == "Yes" && listFood[i].Types == t || listFood[i].Status == "Yes" && t == "Tất cả")
                {
                    listUser[i].Location = P;
                    Order.Controls.Add(listUser[i]);
                    P.Y = P.Y + 150;
                }
            }
            System.GC.Collect();
        }
        private void UserFood_Click(object sender, EventArgs e)
        {
            UCMonAn user = sender as UCMonAn;
            if (user.Choose)
            {
                listCount[user.K] = user.CountFood;
                load();
                user.Choose = false;
            }
        }
        public void load()///load hoadon
        {
            List<RowBill> ListBill = new List<RowBill>();
            Total = 0;
            this.DgvBill.Width = 300;
            this.DgvBill.Height = 75;
            for (int i = 0; i < listCount.Count; i++)
            {
                Total = Total + listCount[i] * Convert.ToInt32(listFood[i].Price * (100 - listFood[i].Sale) / 100);
                if (listCount[i] > 0)
                {
                    RowBill rb = new RowBill(listCount[i].ToString(), listFood[i].Name.ToString(), ((listFood[i].Price * listCount[i] * (100-listFood[i].Sale)/100).ToString()));
                    ListBill.Add(rb);
                    if (DgvBill.Height < 200)
                        DgvBill.Height = DgvBill.Height + 20;
                }
            }
            DgvBill.DataSource = ListBill;
            string strTotal = Total.ToString();
            AddSpace.Space(ref strTotal);
            lb1.Text = "Tổng: " + strTotal;

        }
        public void OrderFood()
        {

            CBill SBill = new CBill();
            try
            {

                if (them)
                {
                    ID_bill = SBill.InsertBill(ID_Employee, DateTime.Now.ToString(), Total, location);
                    SBill.InserDetailBill(ID_bill, listFood, listCount, ID_Employee);
                    MessageBox.Show("Order thành công");
                    OldListCount = new List<int>();
                    LoadAmount(OldListCount);
                    Click = true;
                    them = false;
                }
                else
                {
                    List<GetDetailBill_Result> dtDetailBill = new List<GetDetailBill_Result>();
                    dtDetailBill = SBill.GetDetailBill(ID_bill);
                    FCancelBill Cancel;
                    bool chinhSua = false;
                    bool _continue = true;
                    List<int> list_Amount = new List<int>();
                    for (int i = 0; i < listFood.Count; i++)
                    {
                        int t = OldListCount[i] - listCount[i];
                        if (t > 0)
                            list_Amount.Add(t);
                        else
                            list_Amount.Add(0);
                        if (listCount[i] < OldListCount[i])
                        {
                            chinhSua = true;
                        }
                    }
                    if (chinhSua)
                    {
                        string warning = "Chắc xóa các món này không??\n Việc này cần quản lý xác nhận!\n";
                        for (int i = 0; i < list_Amount.Count; i++)
                        {
                            if (list_Amount[i] > 0)
                            {
                                warning = warning + listFood[i].Name + "   " + list_Amount[i].ToString() + "\n";
                            }
                        }
                        DialogResult traloi;
                        traloi = MessageBox.Show(warning, "Trả lời",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (traloi == DialogResult.Yes)
                        {
                            List<int> list_ID = new List<int>();

                            for (int i = 0; i < listFood.Count; i++)
                            {
                                list_ID.Add(listFood[i].ID_Food);
                            }
                            Cancel = new FCancelBill(ID_bill, list_ID, ID_Employee, list_Amount);
                            Cancel.ShowDialog();
                            if (Cancel.Status == false || traloi == DialogResult.No)
                            {
                                _continue = false;
                            }
                        }
                        else
                            _continue = false;
                    }
                    if (_continue)
                    {
                        if (Total != 0)
                        {
                            SBill.UpdateBill(ID_bill, ID_Employee, DateTime.Now, Total, "No");
                            for (int i = 0; i < listFood.Count; i++)
                            {
                                if (listCount[i] > 0)
                                {
                                    SBill.ProInsertOrUpdateDTBill(ID_bill, listFood[i].ID_Food, listCount[i], listFood[i].Sale.Value, listFood[i].Price.Value, ID_Employee);
                                }
                                else
                                {
                                    for (int j = 0; j < dtDetailBill.Count; j++)
                                    {
                                        if (listFood[i].ID_Food == dtDetailBill[j].ID_Food && dtDetailBill[j].Amount > 0)
                                            SBill.DeleteDetailBill(ID_bill, listFood[i].ID_Food);
                                    }
                                }
                            }
                            MessageBox.Show("Chỉnh sửa hóa đơn thành công");
                            OldListCount = new List<int>();
                            LoadAmount(OldListCount);
                        }

                    }

                }

            }
            catch
            {
                MessageBox.Show("vui lòng thử lại");
            }
            them = false;
        }
        public void ThanhToan()
        {
            CBill SBill = new CBill();
            SBill.UpdateBill(ID_bill, ID_Employee, DateTime.Now, Total, "Yes");
            them = true;
            Total = 0;
            Click = true;
        }
        public bool HuyBan()
        {
            
            List<int> list_ID = new List<int>();
            for (int i = 0; i < listFood.Count; i++)
                list_ID.Add(listFood[i].ID_Food);
            FCancelBill Cancel = new FCancelBill(ID_bill, list_ID, ID_Employee, listCount);
            Cancel.ShowDialog();
            if (Cancel.Status)
            {
                Click = true;
                CBill SBill = new CBill();
                SBill.UpdateBill(ID_bill,ID_Employee,DateTime.Now, 0, "Yes");
                return true;
            }
            else
                return false;
        }
        void LoadAmount(List<int> list)
        {
            for (int i = 0; i < listFood.Count; i++)
            {
                list.Add(0);
            }
            if(!them)
            {
                CBill SBill = new CBill();
            List<GetDetailBill_Result> listDetailBills = new List<GetDetailBill_Result>();
            listDetailBills = SBill.GetDetailBill(ID_bill);
            for (int i = 0; i < listDetailBills.Count; i++)
            {

                for (int j = 0; j < list.Count; j++)
                {
                    if (listFood[j].ID_Food == listDetailBills[i].ID_Food)
                    {
                        list[j] = listDetailBills[i].Amount.Value;//////
                    }
                }
            }
            }
            
        }
    }
    class RowBill
    {
        public string Amount { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public RowBill(string soLuong, string ten, string gia)
        {
            this.Amount = soLuong;
            this.Name = ten;
            AddSpace.Space(ref gia);
            this.Price = gia;
        }
    }
}
