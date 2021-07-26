using DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public DataTable GetAllDataTableByIdBook(long id)
        {
            IEnumerable<episode> episodes = Services.episode.GetAllByIdBook(id).OrderBy(x => x.index);
            

            DataTable table = new DataTable();
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(episode));
            table.Columns.Add("sharp", typeof(long));
            for (int i = 0; i < props.Count; i++)
            {

                PropertyDescriptor prop = props[i];

                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);


            }
            object[] values = new object[props.Count+1];
            long sharp = 1;
            foreach (episode epi in episodes)
            {
                values[0] = sharp++;
                for (int i = 0; i < values.Length-1; i++)
                {
                    var x = props[i].GetValue(epi);
                    values[i+1] = x;


                }
                table.Rows.Add(values);
            }
            return table;
        }

        public episode GetByID(long idepi)
        {
            return Services.episode.GetByID(idepi);
        }

        public bool UpdateEpi(long idepi, episode input)
        {
            return Services.episode.UpdateEpi(idepi, input);
        }

        public bool DeleteEpi(long idepi)
        {
            return Services.episode.DeleteEpi(idepi);
        }
    }
}
