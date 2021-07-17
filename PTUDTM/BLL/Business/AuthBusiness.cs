using DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Business
{
    public class AuthBusiness
    {
        public AuthBusiness()
        {
        }

        public string Signin(string username, string password,bool remember)
        {
            string token = Services.auth.Signin(username, password, remember);
            return token;

        }
    }
}
