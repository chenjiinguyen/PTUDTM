using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace BLL.Business
{
   public class UserGroupBusiness
    {
        public UserGroupBusiness() { }
        public List<usergroup> GetAll()
        {
            List<usergroup> usergroups = Services.usergroup.GetAll();
            return usergroups;

        }
    }
}
