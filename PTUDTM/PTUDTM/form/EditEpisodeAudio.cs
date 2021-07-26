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
            //((Form)this.TopLevelControl).FormClosing += FormDialog_FormClosing;
            this.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void EditEpisodeAudio_VisibleChanged(object sender, EventArgs e)
        {
            //if (this.Visible == true)
            //{
            //    ((Form)this.TopLevelControl).FormClosing += FormDialog_FormClosing_ABC;
            //}
        }

        private void FormDialog_FormClosing_ABC(object sender, FormClosingEventArgs e)
        {
            ((Form)this.TopLevelControl).FormClosing -= FormDialog_FormClosing_ABC;
            Program.LoadDialog(new DetailBook(idbook), "Chi tiết sách - Book Community");

        }
    }
}
