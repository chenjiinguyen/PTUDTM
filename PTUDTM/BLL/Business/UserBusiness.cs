using DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Business
{
    public class UserBusiness
    {
        public UserBusiness()
        {
        }

        public List<user> GetAll()
        {
            List<user> users = Services.user.GetAll();
            return users;
        }
    }
}
