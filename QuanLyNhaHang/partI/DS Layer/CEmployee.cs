using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using partI.DB_Layer;
namespace partI
{
    class CEmployee
    {
        QlyNhaHangEntities qLy = new QlyNhaHangEntities();
        public string Service { get; set; }
        public List<GetEmployee_Result> GetEmployee(string active)
        {
            List<GetEmployee_Result> employee = qLy.GetEmployee(active).ToList<GetEmployee_Result>();
            return employee;
        }
        public int InsertEmployee(string name, string iD_Code, DateTime birth, string sex, string service, int salary, DateTime DaytoWork, int phoneNumber,string address, ref string err)
        {
            if (Service == "TopManager")
            {
                ObjectParameter id = new ObjectParameter("id", typeof(int));
                qLy.ProcInsertEmployee(name, iD_Code, birth, sex, service, salary, DaytoWork, "yes", phoneNumber, address, id);
                return Convert.ToInt32(id.Value);
            }
            else
            {
                err = "Bạn không đủ quyền!";
                return -1;
            }
               
        }
        public bool DeleteEmployee(int ID_Employee, ref string err)
        {
            if (Service == "TopManager")
            {
                try
                {
                    qLy.ProcUpdateStatus(ID_Employee, "No");
                    
                    return true;
                }
                catch (Exception e)
                {
                    err = e.Message;
                    return false;
                }
            }
            else
            {
                err = "Bạn không đủ quyền!";
                return false;
            }
        }
        public bool UpdateEmployee(int ID, string name, string iD_Code, DateTime birth, string sex, string service, int salary, DateTime DaytoWork, string active ,int phoneNumber, string address, ref string err)
        { 
            if (Service == "TopManager")
            {
                try
                {
                    qLy.ProcUpdateEmployee(ID, name, iD_Code, birth, sex, service, salary, DaytoWork, phoneNumber, address);
                    qLy.ProcUpdateStatus(ID, active);
                    return true;
                }
                catch (Exception e)
                {
                    err = e.Message;
                    return false;
                }
            }
            else
            {
                err = "Bạn không đủ quyền!";
                return false;
            }
            
        }
    }
}
