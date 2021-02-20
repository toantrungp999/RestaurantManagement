using System;
using System.Collections.Generic;
using System.Linq;
using partI.DB_Layer;
using System.Data.Entity.Core.Objects;

namespace partI
{
    class CFood
    {
        QlyNhaHangEntities QlyNhaHang = new QlyNhaHangEntities();
        public List<GetFood_Result> GetFood(string type, string status, string active)
        {
            List<GetFood_Result> list = QlyNhaHang.GetFood(status, active, type).ToList<GetFood_Result>();
            return list;

        }

        public void UpdateFood(int id, string name, int price, string status, int sale, string active, string type)
        {
            QlyNhaHang.ProcUpdateFood(id, name, price, status, sale, active, type);
        }

        public int InsertFoodAndGetInsertedFood(string name, int price, string status, int sale, string active, string type)
        {
            ObjectParameter id = new ObjectParameter("id", typeof(int));
            QlyNhaHang.ProcInsertFoodAndGetInsertedFood(name, price, status, sale, active, type, id);

            return Convert.ToInt32(id.Value);
        }

    }
}
