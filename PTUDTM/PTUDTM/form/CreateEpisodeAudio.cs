using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DLL;
using BLL;
using System.Windows.Forms;

namespace PTUDTM.form
{
    public partial class CreateEpisodeAudio : UserControl
    {
        public long idbook;
        public CreateEpisodeAudio()
        {
            InitializeComponent();
        }

        public CreateEpisodeAudio(long idbook)
        {
            this.idbook = idbook;
            InitializeComponent();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            string title = txtTitle.Text;
            string contentLink = txtLink.Text;
            long countTitle = title.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
            if((countTitle > 0 && countTitle <= 100) && contentLink.Trim().Length > 0)
            {
                string regexLink = @"(?:https?:\/\/)?(?:www\.)?youtu\.?be(?:\.com)?\/?.*(?:watch|embed)?(?:.*v=|v\/|\/)([\w\-_]+)\&?";
                bool match = Regex.IsMatch(contentLink, regexLink);
                if(match)
                {
                    episode epi = new episode();
                    epi.index = Businesses.episode.GetLastIndex(idbook) + 1;
                    epi.idbook = idbook;
                    epi.name = title;
                    epi.content = contentLink;
                    epi.view = 0;
                    epi.status = 1;
                    epi.createdat = epi.updatedat = DateTime.Now;

                    long idepi = Businesses.episode.Create(epi);
                    if(idepi == -1)
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
            else if(countTitle == 0 || contentLink.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng không để trống!", "Thông báo");
            }
            else if(countTitle > 100)
            {
                MessageBox.Show("Tiêu đề không được quá 100 từ!", "Thông báo");
            }
        }
    }
}
