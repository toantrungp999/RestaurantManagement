using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using partI.DB_Layer;
namespace partI
{
    class CBill
    {
        QlyNhaHangEntities qLy = new QlyNhaHangEntities();
        public List<GetDetailBill_Result> GetDetailBill(int ID_Bill)
        {   
            List<GetDetailBill_Result> DetailBills = qLy.GetDetailBill(ID_Bill).ToList();
            return DetailBills;
        }
        public int InsertBill(int ID_Employee, string time, int total, int location)
        {
            ObjectParameter id = new ObjectParameter("id", typeof(int));
            qLy.ProcInsertBill(ID_Employee, Convert.ToDateTime(time), total, "No", location, id);
            return Convert.ToInt32(id.Value);
        }
        public void UpdateBill(int ID_Bill, int ID_Employee ,DateTime time, int total, string status)
        {
            qLy.ProcUpdateBill(ID_Bill, ID_Employee, time, total, status);
        }
        
        public void InserDetailBill(int ID_Bill, List<GetFood_Result> listFood, List<int> listCount,int ID_Employess)
        {
            for (int i = 0; i < listFood.Count; i++)
            {
                if (listCount[i] > 0)
                {
                    qLy.ProcInsertDetailBill(ID_Bill, Convert.ToInt32(listFood[i].ID_Food), listCount[i], listFood[i].Sale, listFood[i].Price, ID_Employess);

                }
            }
        }
        public void ProInsertOrUpdateDTBill(int ID_Bill, int ID_Food, int amount, int sale, int price, int ID_Employee)
        {
            qLy.ProInsertOrUpdateDTBill(ID_Bill, ID_Food, amount, sale, price, ID_Employee);
        }
        public void DeleteDetailBill(int ID_Bill, int ID_Food)
        {
            qLy.ProcDeleteDetailBill(ID_Bill, ID_Food);
        }
        public bool GetID_Bill(int Location, ref int ID_Bill)
        {
            GetID_Bill_Result result = qLy.GetID_Bill(Location).SingleOrDefault();
            if (result != null)
            {
                ID_Bill = result.ID;
                return false;
            }
            return true;
        }
    }
}
