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

        public episode GetByID(long idepi)
        {
            return db.episodes.SingleOrDefault(x => x.idepisode == idepi);
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


        public List<episode> GetAllByIdBook(long id)
        {
            return db.episodes.Where(x => x.status == 3 && x.idbook == id).ToList();
        }

        public bool UpdateEpi(long idepi, episode input)
        {
            episode epi = GetByID(idepi);
            try
            {
                if(epi != null)
                {
                    epi.name = input.name;
                    epi.content = input.content;
                    epi.updatedat = DateTime.Now;
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

        public bool DeleteEpi(long idepi)
        {
            episode epi = GetByID(idepi);
            try
            {
                if (epi != null)
                {
                    epi.updatedat = DateTime.Now;
                    epi.status = -1;
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
    }
}
