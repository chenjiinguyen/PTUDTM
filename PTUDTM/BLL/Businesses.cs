using BLL.Business;
using DLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Businesses
    {
        public static BookBusiness book = new BookBusiness();

        public static AuthBusiness auth = new AuthBusiness();

        public static UserBusiness user = new UserBusiness();

        public static CategoryBusiness category = new CategoryBusiness();

        public static EpisodeBusiness episode = new EpisodeBusiness();

        public static ModerationBookBusiness modbook = new ModerationBookBusiness();

        public static ModerationEpisodeBusiness modepi = new ModerationEpisodeBusiness();

        public static UserGroupBusiness usergroup = new UserGroupBusiness();

        public static StatisticalBusiness statistical = new StatisticalBusiness();

        public static RoleBusiness role = new RoleBusiness();
    }
}
