using MODEL.Response;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Service
{
    public class BookService
    {

        BOOKCOMMUNITYEntities db;

        public BookService(BOOKCOMMUNITYEntities db)
        {
            this.db = db;
        }

        public book GetByID(long id)
        {
            return db.books.Single(x => x.idbook == id);
        }

        public List<book> GetAll()
        {
            return db.books.OrderByDescending(x => x.createdat).ToList();
        }

    }
}

