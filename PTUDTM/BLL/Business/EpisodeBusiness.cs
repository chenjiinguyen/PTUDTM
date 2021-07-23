using DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Business
{
    public class EpisodeBusiness
    {
        public EpisodeBusiness() { }

        public long GetLastIndex(long idbook)
        {
            long index = -1;
            List<episode> episodes = Services.episode.GetEpisodesByBook(idbook);
            if(episodes.Count > 0)
            {
                index = episodes[0].index;
            }
            return index;
        }

        public long Create(episode episode)
        {
            long id = Services.episode.Create(episode);
            if (id == -1)
            {
                return -1;
            }
            else
            {
                moderation_episode modepi = new moderation_episode();
                modepi.idepisode = id;
                modepi.review = false;
                modepi.createdat = modepi.updatedat = DateTime.Now;
                long idmod = Services.modepi.Create(modepi);
                if (idmod == -1)
                {
                    return -1;
                }
                else
                {
                    return id;
                }

            }
        }
    }
}
