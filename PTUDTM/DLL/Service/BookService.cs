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
            return db.books.SingleOrDefault(x => x.idbook == id && x.status >= 0);
        }

        public book GetID(long id)
        {
            return db.books.SingleOrDefault(x => x.idbook == id && x.status >= 0);
        }

        public List<book> GetAll()
        {
            return db.books.Where(x => x.status >= 0).OrderByDescending(x => x.createdat).ToList();
        }
        public long Create(book book)
        {
            try {  
                db.books.Add(book);
                db.SaveChanges();
                return book.idbook;
            }
            catch
            {
                return (long)-1;
            }
        }

        public bool Update(long idbook, book input)
        {
            book book = GetByID(idbook);
            try
            {
                if (book != null)
                {

                    book.title = input.title;
                    book.author = input.author;
                    book.poster = input.poster;
                    book.description = input.description;
                    book.updatedat = DateTime.Now;
                    db.SaveChanges();
                    return true;
                }
                else { return false; }
               
            }
             catch
            {
                return false;
            }
        }

        public bool Delete(long idbook)
        {
            book book = GetByID(idbook);
            try
            {
                if (book != null)
                {
                    book.updatedat = DateTime.Now;
                    book.status = -1;
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

        public List<book> GetAllUncensor()
        {
                List<long> listBookID = db.moderation_book.Where(x => x.review == false).Select(x => x.idbook).ToList();
                listBookID.AddRange(db.episodes.Where(e => (db.moderation_episode.Where(a => a.review == false).Select(z => z.idepisode).ToList()).Contains(e.idepisode)).Select(b => b.idbook).ToList());

                return db.books.Where(x => listBookID.Contains(x.idbook) && x.status >= 0).ToList();
        }

    }
}

