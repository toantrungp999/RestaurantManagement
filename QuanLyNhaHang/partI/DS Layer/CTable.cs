using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using partI.DB_Layer;

namespace partI
{
    class CTable
    {
        QlyNhaHangEntities qLy = new QlyNhaHangEntities();
        public List<GetTable_Result> GetTable()
        {
            List<GetTable_Result> table = qLy.GetTable().ToList<GetTable_Result>();
            return table;
        }
        public string StateTable(int location)
        {
            ObjectParameter state=new ObjectParameter("State","None");
            qLy.ProcStateLocation(location, state);
            return Convert.ToString(state.Value);

        }
        public void UpdateTable(int location, string status)
        {
            qLy.ProcUpdateTable(location, status);
        }
    }
}
