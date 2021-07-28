using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Service
{
    public class PointService
    {
        BOOKCOMMUNITYEntities db;

        public PointService(BOOKCOMMUNITYEntities db)
        {
            this.db = db;
        }

        public List<point> getByUsername(string username)
        {
            return db.points.Where(x => x.username == username).ToList();
        }
    }
}
