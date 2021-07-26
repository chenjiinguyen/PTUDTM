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

        public string GetNameByID(string id)
        {
            category cate = db.categories.SingleOrDefault(x => x.idcategory.Equals(id));
            if (cate != null)
                return cate.name;
            return "Truyện";
        }

    }
}
