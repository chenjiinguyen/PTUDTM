using DLL;
using MODEL.Model;
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

        public List<User> GetAll()
        {
            List<User> users = Services.user.GetAll();
            return users;
        }
    }
}
