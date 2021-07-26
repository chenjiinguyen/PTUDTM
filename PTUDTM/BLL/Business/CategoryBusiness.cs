using DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Business
{
    public class CategoryBusiness
    {

        public CategoryBusiness()
        {
        }

        public List<category> GetAll()
        {
            List<category> categories = Services.category.GetAll();
            return categories;

        }

        public string GetNameByID(string id)
        {
            return Services.category.GetNameByID(id);
        }
    }
}
