using DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Business
{
    public class ModerationBookBusiness
    {
        public ModerationBookBusiness()
        {
        }

        public bool Update(long idbook, moderation_book input)
        {
            return Services.modbook.Update(idbook, input);
        }

        public bool CheckCensor(long idbook)
        {
            return Services.modbook.CheckCensor(idbook);
        }
    }
}
