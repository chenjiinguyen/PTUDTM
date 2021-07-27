using BLL;
using DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUDTM.form
{
    public partial class CensorEpisodes : UserControl
    {

        Thread thread;
        DataTable episodes;
        long id;
        book book;
        public CensorEpisodes()
        {
            InitializeComponent();
        }

        public CensorEpisodes(long id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void CensorEpisodes_Load(object sender, EventArgs e)
        {
            thread = new Thread(() =>
            {
                episodes = Businesses.episode.GetUncensorDataTableByIdBook(id);
                book = Businesses.book.GetByID(id);

                Action action = new Action(LoadData);
                this.BeginInvoke(action);
            });
            thread.Start();
        }

        private void LoadData()
        {
            lblTitle.Text = book.title;
            lblCateName.Text = book.category1.name;
            lblAuthorName.Text = book.author;
            txtDetail.Text = book.description;
            guna2PictureBox1.LoadAsync(book.poster);
            guna2DataGridView1.AutoGenerateColumns = false;
            guna2DataGridView1.DataSource = episodes;
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                row.Cells[2].Value = "Kiểm Duyệt";
            }
            switch (book.status)
            {
                case 0:
                    btnStatus.Text = "Bản thảo";

                    btnStatus.FillColor = Color.Black;
                    break;
                case 1:
                    btnStatus.Text = "Nộp chờ";
                    btnStatus.FillColor = Color.BlueViolet;
                    break;
                case 2:
                    btnStatus.Text = "Từ chối";
                    btnStatus.FillColor = Color.Red;
                    break;
                default:
                    btnStatus.Text = "Thành công";
                    btnStatus.FillColor = Color.Green;
                    break;
            }
            thread.Join();


        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {
            int index = guna2DataGridView1.CurrentRow.Index;
            if (index >= 0)
            {
                if (guna2DataGridView1.CurrentCell.ColumnIndex == guna2DataGridView1.Columns["button"].Index)
                {
                    long idepi = episodes.Rows[index].Field<long>("idepisode");

                    if (book.category == "TEXT")
                    {

                        Program.LoadDialog(new CensorEpisodeText(idepi), "Kiểm Duyệt Chương - Book Community");
                    }
                    else if (book.category == "IMAGE")
                    {
                        Program.LoadDialog(new CensorEpisodeComic(idepi), "Kiểm Duyệt Chương - Book Community");
                    }
                    else if (book.category == "AUDIO")
                    {
                        Program.LoadDialog(new CensorEpisodeAudio(idepi), "Kiểm Duyệt Chương - Book Community");
                    }
                }
            }
        }
    }
}
