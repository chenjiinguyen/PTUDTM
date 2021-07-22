using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Service
{
    public class CategoryService
    {
        BOOKCOMMUNITYEntities db;

        public CategoryService(BOOKCOMMUNITYEntities db)
        {
            this.db = db;
        }

        public List<category> GetAll()
        {
            return db.categories.ToList();
        }

    }
}
