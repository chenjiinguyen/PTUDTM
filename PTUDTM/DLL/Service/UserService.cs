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

        public user GetUsername(string username)
        {
            return db.users.SingleOrDefault(x => x.username == username);
        }

        public bool UpdateUser(string iduser, user input)
        {
            user id = GetUsername(iduser);
            try
            {
                if (id != null)
                {
                    id.email = input.email;
                    id.avatar = input.avatar;
                    id.name = input.name;
                    id.birthday = input.birthday;
                    id.usergroup = input.usergroup;
                    id.gender = input.gender;
                    id.updatedat = DateTime.Now;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
