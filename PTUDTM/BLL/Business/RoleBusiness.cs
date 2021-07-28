using DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Business
{
    public class RoleBusiness
    {
        public RoleBusiness()
        {
        }

        public bool Check(string idgroup, string role)
        {
            return Services.role.Check(idgroup, role);
        }
    }
}
