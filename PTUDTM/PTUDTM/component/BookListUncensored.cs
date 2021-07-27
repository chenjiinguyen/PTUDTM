using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTUDTM.form;
using BLL;

namespace PTUDTM.component
{
    public partial class BookListUncensored : UserControl
    {
        public long id;
        public BookListUncensored()
        {
            InitializeComponent();
        }

        public BookListUncensored(long id)
        {
            this.id = id;
            InitializeComponent();
        }

        public void LoadImage(string url)
        {
            picturePoster.LoadAsync(url);
        }

        private void btnBookCensor_Click(object sender, EventArgs e)
        {
            Program.LoadDialog(new BookCensorship(id), "Kiểm Duyệt Truyện - Book Community");
        }

        private void btnEpisodeCensor_Click(object sender, EventArgs e)
        {
            Program.LoadDialog(new CensorEpisodes(id), "Kiểm Duyệt Chương - Book Community");
        }

        private void BookListUncensored_Load(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            bool book_check = Businesses.modbook.CheckCensor(id);
            bool episode_check = Businesses.modepi.CheckCensor(id);

            btnBookCensor.Enabled = !book_check;
            btnEpisodeCensor.Enabled = !episode_check;
        }
    }
}
