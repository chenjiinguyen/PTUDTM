using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Service
{
    public class UserService
    {
        BOOKCOMMUNITYEntities db;

        public UserService(BOOKCOMMUNITYEntities db)
        {
            this.db = db;
        }

        public List<user> GetAll()
        {
            return db.users.OrderByDescending(x => x.createdat).ToList();
        }
    }
}
