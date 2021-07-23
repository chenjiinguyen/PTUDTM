using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Service
{
    public class ModerationEpisodeService
    {
        BOOKCOMMUNITYEntities db;
        public ModerationEpisodeService(BOOKCOMMUNITYEntities db)
        {
            this.db = db;
        }
        public long Create(moderation_episode modepi)
        {
            try
            {
                db.moderation_episode.Add(modepi);
                db.SaveChanges();
                return modepi.id;
            }
            catch
            {
                return (long)-1;
            }
        }
    }
}
