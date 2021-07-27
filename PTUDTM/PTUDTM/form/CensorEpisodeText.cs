using BLL;
using DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUDTM.form
{
    public partial class CensorEpisodeText : UserControl
    {
        private long idepi;
        episode episode;
        public CensorEpisodeText()
        {
            InitializeComponent();
        }

        public CensorEpisodeText(long idepi)
        {
            this.idepi = idepi;
            InitializeComponent();
        }

        private void CensorEpisodeText_Load(object sender, EventArgs e)
        {
            episode = Businesses.episode.GetByID(idepi);
            txtTitle.Text = episode.name;
            txtContent.Text = episode.content;
        }

        private void btnAllow_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thực hiện hành động này ?", "Cảnh báo !!!",MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                string content = txtContentCensor.Text;
                moderation_episode input = new moderation_episode();
                input.content = content;
                input.moderation = 3;
                input.moderator = Program.me.username;
                bool result = Businesses.modepi.Update(idepi, input);
                if (result)
                {
                    MessageBox.Show("Thành Công", "Thông Báo");
                    Program.LoadForm(new CensorBooks());
                    ((Form)this.TopLevelControl).Close();
                }
                else
                {
                    MessageBox.Show("Thất Bại", "Thông Báo");
                }
            }
           
        }

        private void btnRefuse_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thực hiện hành động này ?", "Cảnh báo !!!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                string content = txtContentCensor.Text;
                moderation_episode input = new moderation_episode();
                input.content = content;
                input.moderation = 2;
                input.moderator = Program.me.username;
                bool result = Businesses.modepi.Update(idepi, input);
                if (result)
                {
                    MessageBox.Show("Thành Công", "Thông Báo");
                    Program.LoadForm(new CensorBooks());
                    ((Form)this.TopLevelControl).Close();
                }
                else
                {
                    MessageBox.Show("Thất Bại", "Thông Báo");
                }
            }
        }
    }
}
