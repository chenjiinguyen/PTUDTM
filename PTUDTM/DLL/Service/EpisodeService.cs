using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Service
{
    public class EpisodeService
    {
        BOOKCOMMUNITYEntities db;
        public EpisodeService(BOOKCOMMUNITYEntities db)
        {
            this.db = db;
        }

        public List<episode> GetEpisodesByBook(long idbook)
        {
            return db.episodes.Where(x => x.idbook == idbook).OrderByDescending(x => x.index).ToList();
        }

        public long Create(episode epi)
        {
            try
            {
                db.episodes.Add(epi);
                db.SaveChanges();
                return epi.idepisode;
            }
            catch
            {
                return (long)-1;
            }
        }
    }
}
