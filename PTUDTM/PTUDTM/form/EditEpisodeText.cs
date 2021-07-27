using DLL;
using BLL;
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
    public partial class EditEpisodeText : UserControl
    {
        long id;
        long idbook;
        public EditEpisodeText()
        {
            InitializeComponent();
        }

        public EditEpisodeText(long id, long idbook)
        {
            this.id = id;
            this.idbook = idbook;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
            
        }

        private void FormDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((Form)this.TopLevelControl).FormClosing -= FormDialog_FormClosing;
            Program.LoadDialog(new DetailBook(idbook), "Chi tiết sách - Book Community");
            
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            string title = txtTitle.Text;
            string content = txtContent.Text;
            long countTitle = title.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
            long countContent = content.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
            if (countTitle == 0 || countContent == 0)
            {
                MessageBox.Show("Vui lòng không để trống!", "Thông báo");

            }
            else if (countTitle > 100)
            {
                MessageBox.Show("Tiêu đề không được quá 100 từ!", "Thông báo");
            }
            else
            {
                episode epi = new episode();
                epi.name = title;
                epi.content = content;
                epi.updatedat = DateTime.Now;

                bool update = Businesses.episode.UpdateEpi(id, epi);
                if (!update)
                {
                    MessageBox.Show("Thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thành công", "Thông báo");
                    ((Form)this.TopLevelControl).Close();

                }
            }
        }

        private void EditEpisodeText_Load(object sender, EventArgs e)
        {
            episode epi = Businesses.episode.GetByID(id);
            txtTitle.Text = epi.name;
            txtContent.Text = epi.content;
            //this.Visible = false;
        }

        private void EditEpisodeText_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                ((Form)this.TopLevelControl).FormClosing += FormDialog_FormClosing;
            }
        }
    }
}
