using System;
using System.Collections.Generic;
using System.Linq;
using partI.DB_Layer;

namespace partI.DS_Layer
{
    public class CAccount
    {
        QlyNhaHangEntities qLy = new QlyNhaHangEntities();
        public GetAccount_Result GetAccount(int ID)
        {
            GetAccount_Result account = qLy.GetAccount(ID).SingleOrDefault();
            return account;
        }
        public List<LoadAccount_Result> LoadAccount()
        {
            List<LoadAccount_Result> account = qLy.LoadAccount().ToList<LoadAccount_Result>();
            return account;
        }        
        public void InsertAccount(string User, string Pass, int ID_Employee)
        {
            qLy.ProcInsertAccount(User, Pass, ID_Employee);
        }
        public void UpdateAccount(string User, string Pass, int ID_Employee, ref string err)
        {
            var account = qLy.GetAccount(ID_Employee);

            if (account.Count() == 1)
            {
                qLy.ProcUpdateAccount(User, Pass, ID_Employee);
            }
            else
            {
                err = "Không tìm thấy tài khoản";
            }
        }
        public LoginCheck_Result Login(string User, string Pass)
        {
            LoginCheck_Result list = qLy.LoginCheck(User, Pass).SingleOrDefault();
            return list;
        }
    }
}
