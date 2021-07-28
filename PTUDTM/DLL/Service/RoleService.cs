using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Service
{
    public class RoleService
    {
        BOOKCOMMUNITYEntities db;

        public RoleService(BOOKCOMMUNITYEntities db)
        {
            this.db = db;
        }

        public bool Check(string idgroup, string role)
        {
            try
            {
                if (idgroup == "MODERATOR" || idgroup == "ADMIN") return true;
                    return false;    
            }catch
            {
                return false;
            }
        }
    }
}
