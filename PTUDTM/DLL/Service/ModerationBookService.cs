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
