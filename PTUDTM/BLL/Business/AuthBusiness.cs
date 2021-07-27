using BCrypt.Net;
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

        public user Signin(string username, string password)
        {

            return Services.auth.Signin(username, password);
        }

    }
}
