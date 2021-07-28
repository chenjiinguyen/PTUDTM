using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Service
{
    public class UserGroupService
    {
        BOOKCOMMUNITYEntities db;
         
        public UserGroupService(BOOKCOMMUNITYEntities db)
        {
            this.db = db;
        }

        public List<usergroup> GetAll()
        {
            return db.usergroups.ToList();
        }

    }
}
