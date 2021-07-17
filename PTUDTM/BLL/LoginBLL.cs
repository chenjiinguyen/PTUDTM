using DLL;
using DLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class LoginBLL
    {
        LoginDLL login = new LoginDLL();

        public UserModel Login(string email, string password)
        {
            login.LoginAsync(email, password);
            return new UserModel();
        }
    }
}
