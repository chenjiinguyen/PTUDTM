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

        public bool CheckCensor(long idbook)
        {
            try
            {
                int data = db.moderation_episode.Where(x => x.episode.idbook == idbook && x.review == false).ToList().Count;
                if (data == 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(long idepisode, moderation_episode input)
        {
            try
            {
                episode episode = db.episodes.SingleOrDefault(x => x.idepisode == idepisode && x.status >= 0);

                if(episode != null)
                {
                    moderation_episode data = db.moderation_episode.SingleOrDefault(x => x.idepisode == idepisode && x.review == false);
                    if (data != null)
                    {
                        data.moderator = input.moderator;
                        data.moderation = input.moderation;
                        data.content = input.content;
                        data.review = true;
                        data.updatedat = DateTime.Now;
                        episode.status = (int)input.moderation;
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
    }
}
