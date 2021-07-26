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
            try{
                moderation_book data = db.moderation_book.SingleOrDefault(x => x.idbook == idbook && x.review == false);
                if(data != null)
                {
                    data.moderation = input.moderation;
                    data.content = input.content;
                    data.review = true;
                    data.updatedat = DateTime.Now;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }catch{
                return false;
            }
        }
    }
}
