using BLL;
using DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUDTM.form
{
    public partial class CensorEpisodeAudio : UserControl
    {
        private long idepi;
        episode episode;
        public CensorEpisodeAudio()
        {
            InitializeComponent();
        }

        public CensorEpisodeAudio(long idepi)
        {
            this.idepi = idepi;
            InitializeComponent();
        }

        private void CensorEpisodeAudio_Load(object sender, EventArgs e)
        {
            episode = Businesses.episode.GetByID(idepi);
            txtTitle.Text = episode.name;
            txtLink.Text = episode.content;
            string regexLink = @"(?:https?:\/\/)?(?:www\.)?youtu\.?be(?:\.com)?\/?.*(?:watch|embed)?(?:.*v=|v\/|\/)([\w\-_]+)\&?";
            var match = Regex.Match(txtLink.Text, regexLink);
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' style='width: 100%; height: 420px' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";
            if (match.Value != "")
            {
                html = string.Format(html, match.Groups[1]);
                webBrowser1.Navigate("about:blank");
                webBrowser1.Document.OpenNew(false);
                webBrowser1.Document.Write(html);
                webBrowser1.Refresh();
            }
          
        }

        private void btnAllow_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thực hiện hành động này ?", "Cảnh báo !!!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }
    }
}
