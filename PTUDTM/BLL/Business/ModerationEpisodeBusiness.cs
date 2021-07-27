using DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Business
{
    public class ModerationEpisodeBusiness
    {
        public ModerationEpisodeBusiness()
        {
        }

        public bool Update(long idepisode, moderation_episode input)
        {
            return Services.modepi.Update(idepisode, input);
        }

        public bool CheckCensor(long idbook)
        {
            return Services.modepi.CheckCensor(idbook);
        }
    }
}
