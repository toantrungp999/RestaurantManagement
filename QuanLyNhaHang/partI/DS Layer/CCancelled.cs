using partI.DB_Layer;

namespace partI
{
    class CCancelled
    {
        QlyNhaHangEntities qLy = new QlyNhaHangEntities();
        public void TransprotDTBillToCancelled(int ID_Bill, int ID_Food, int ID_Employee, int amount, string reason, ref string err)
        {
            qLy.TransprotDTBillToCancelled(ID_Bill, ID_Food, ID_Employee, amount, reason);
        }
    }
}
