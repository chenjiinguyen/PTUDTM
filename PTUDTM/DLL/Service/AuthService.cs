using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Service
{
    public class AuthService
    {
        BOOKCOMMUNITYEntities db;

        public AuthService(BOOKCOMMUNITYEntities db)
        {
            this.db = db;
        }

        public user Signin(string username, string password)
        {
            user user = db.users.SingleOrDefault(x => x.username == username);
            if(user != null)
            {
                bool check = BCrypt.Net.BCrypt.Verify(password, user.password);
                if (check) return user;
                return null;
            }
            return null;
        }

    }
}
