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
            return db.books.SingleOrDefault(x => x.idbook == id && x.status == 3);
        }

        public book GetID(long id)
        {
            return db.books.SingleOrDefault(x => x.idbook == id);
        }

        public List<book> GetAll()
        {
            return db.books.Where(x =>  x.status == 3).OrderByDescending(x => x.createdat).ToList();
        }


        public List<book> GetAllUncensor()
        {
            List<long> listBookID = db.moderation_book.Where(x => x.review == false).Select(x => x.idbook).ToList();
            listBookID.AddRange(db.episodes.Where(e => (db.moderation_episode.Where(a => a.review == false).Select(z => z.idepisode).ToList()).Contains(e.idepisode)).Select(b => b.idbook).ToList());

            return db.books.Where(x => listBookID.Contains(x.idbook)).ToList();
        }    
    }
}

