using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Service
{
    public class ModerationBookService
    {

        BOOKCOMMUNITYEntities db;

        public ModerationBookService(BOOKCOMMUNITYEntities db)
        {
            this.db = db;
        }

        public bool Update(long idbook, moderation_book input)
        {
            try
            {
                book book = db.books.SingleOrDefault(x => x.idbook == idbook && x.status >= 0);

                if (book != null)
                {
                    moderation_book data = db.moderation_book.SingleOrDefault(x => x.idbook == idbook && x.review == false);
                    if (data != null)
                    {
                        data.moderator = input.moderator;
                        data.moderation = input.moderation;
                        data.content = input.content;
                        data.review = true;
                        data.updatedat = DateTime.Now;
                        book.status = (int)input.moderation;
                        db.SaveChanges();
                        return true;
                    }
                }
                return false;

            }
            catch
            {
                return false;
            }
        }

        public bool CheckCensor(long idbook)
        {
            try
            {
                moderation_book data = db.moderation_book.SingleOrDefault(x => x.idbook == idbook && x.review == false);
                if (data == null)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }

        public long Create(moderation_book modbook)
        {
            try
            {
                db.moderation_book.Add(modbook);
                db.SaveChanges();
                return modbook.id;
            }
            catch
            {
                return (long)-1;
            }
        }
    }
}
