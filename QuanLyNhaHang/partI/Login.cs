using partI.DB_Layer;
using partI.DS_Layer;

namespace partI
{
    class Login
    {
        CAccount account = new CAccount();
        public LoginCheck_Result Log(string User, string Pass, ref string err)
        {
            LoginCheck_Result data = new LoginCheck_Result();
            data = account.Login(User, Pass);
            return data;
        }
    }
}
