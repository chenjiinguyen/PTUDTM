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
    public partial class EditEpisodeAudio : UserControl
    {
        long idepi, idbook;
        public EditEpisodeAudio()
        {
            InitializeComponent();
        }

        public EditEpisodeAudio(long idepi, long idbook)
        {
            this.idepi = idepi;
            this.idbook = idbook;
            InitializeComponent();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void EditEpisodeAudio_Load(object sender, EventArgs e)
        {
            episode epi = Businesses.episode.GetByID(idepi);
            txtTitle.Text = epi.name;
            txtLink.Text = epi.content;
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

            //((Form)this.TopLevelControl).FormClosing += FormDialog_FormClosing;
            //this.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            string title = txtTitle.Text;
            string contentLink = txtLink.Text;
            long countTitle = title.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
            if ((countTitle > 0 && countTitle <= 100) && contentLink.Trim().Length > 0)
            {
                string regexLink = @"(?:https?:\/\/)?(?:www\.)?youtu\.?be(?:\.com)?\/?.*(?:watch|embed)?(?:.*v=|v\/|\/)([\w\-_]+)\&?";
                bool match = Regex.IsMatch(contentLink, regexLink);
                if (match)
                {
                    episode epi = new episode();
                    epi.name = title;
                    epi.content = contentLink;
                    epi.updatedat = DateTime.Now;

                    bool update = Businesses.episode.UpdateEpi(idepi, epi);
                    if (!update)
                    {
                        MessageBox.Show("Thất bại", "Thông báo");
                    }
                    else
                    {

                        MessageBox.Show("Thành công", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Link ảnh không hợp lệ", "Thông báo");
                }
            }
            else if (countTitle == 0 || contentLink.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng không để trống!", "Thông báo");
            }
            else if (countTitle > 100)
            {
                MessageBox.Show("Tiêu đề không được quá 100 từ!", "Thông báo");
            }
        }

        private void EditEpisodeAudio_VisibleChanged(object sender, EventArgs e)
        {
            //if (this.Visible == true)
            //{
            //    ((Form)this.TopLevelControl).FormClosing += FormDialog_FormClosing_ABC;
            //}
        }

        private void txtLink_KeyUp(object sender, KeyEventArgs e)
        {
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

        private void FormDialog_FormClosing_ABC(object sender, FormClosingEventArgs e)
        {
            ((Form)this.TopLevelControl).FormClosing -= FormDialog_FormClosing_ABC;
            Program.LoadDialog(new DetailBook(idbook), "Chi tiết sách - Book Community");

        }
    }
}
