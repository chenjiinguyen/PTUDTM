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
    public partial class CreateEpisodeText : UserControl
    {
        long idbook;
        public CreateEpisodeText()
        {
            InitializeComponent();
        }

        public CreateEpisodeText(long idbook)
        {
            this.idbook = idbook;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            char[] delimiters = new char[] { ' ', '\r', '\n' };

            string title = txtTitle.Text;
            string content = txtContent.Text;
            long countTitle = title.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
            long countContent = content.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
            if ((countTitle > 0 && countTitle <= 100) && (countContent > 0 && countContent <= 500))
            {

                episode episode = new episode();
                episode.index = Businesses.episode.GetLastIndex(idbook) + 1;
                episode.idbook = idbook;
                episode.name = title;
                episode.content = content;
                episode.view = 0;
                episode.status = 1;
                episode.createdat = episode.updatedat = DateTime.Now;

                long idepi = Businesses.episode.Create(episode);
                if (idepi == -1)
                {
                    MessageBox.Show("Thất bại", "Thông báo");
                }
                else { MessageBox.Show("Thành công", "Thông báo"); }


            }
            else if (countTitle == 0 || countContent == 0)
            {
                MessageBox.Show("Vui lòng không để trống!", "Thông báo");
            }
            else if (countTitle > 100)
            {
                MessageBox.Show("Tiêu đề không được quá 100 từ!", "Thông báo");
            }
            else if (countContent > 500)
            {
                MessageBox.Show("Nội dung không được quá 500 từ!", "Thông báo");
            }
        }
    }
}
