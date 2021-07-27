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
    public partial class DetailBook : UserControl
    {
        Thread thread;
        DataTable episodes;
        long id;
        book book;
        public DetailBook()
        {
            InitializeComponent();
        }

        public DetailBook(long id)
        {
            this.id = id;
            InitializeComponent();
        }
        private void LoadData()
        {
            lblTitle.Text = book.title;
            txtDetail.Text = book.description;
            lblCateName.Text = book.category1.name;
            lblAuthorName.Text = book.author;
            guna2PictureBox1.LoadAsync(book.poster);
            guna2DataGridView1.AutoGenerateColumns = false;
            guna2DataGridView1.DataSource = episodes;
            foreach(DataGridViewRow row in guna2DataGridView1.Rows)
            {
                row.Cells[4].Value = "Sửa";
                row.Cells[5].Value = "Xóa";
            }
            switch(book.status)
            {
                case 0:
                    btnStatus.Text = "Bản thảo";

                    btnStatus.FillColor = Color.Aqua;
                    break;
                case 1:
                    btnStatus.Text = "Nộp chờ";
                    btnStatus.FillColor = Color.Aqua;
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
        private void DetailBook_Load(object sender, EventArgs e)
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
        private void dataGridView_EditClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                long idepi = episodes.Rows[index].Field<long>("idepisode");

                if (e.ColumnIndex == guna2DataGridView1.Columns["edit"].Index)
                {
                    if (book.category == "TEXT")
                    {

                        Program.LoadDialog(new EditEpisodeText(idepi, id), "Chỉnh sửa chương - Book Community");
                    }
                    else if (book.category == "IMAGE")
                    {
                        Program.LoadDialog(new EditEpisodeComic(idepi, id), "Chỉnh sửa chương - Book Community");
                    }
                    else if (book.category == "AUDIO")
                    {
                        Program.LoadDialog(new EditEpisodeAudio(idepi, id), "Chỉnh sửa chương - Book Community");
                    }
                }

                if (e.ColumnIndex == guna2DataGridView1.Columns["delete"].Index)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        bool delete = Businesses.book.Delete(id);
                        if (!delete)
                        {
                            MessageBox.Show("Thất bại", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Thành công", "Thông báo");
                            Program.LoadDialog(new DetailBook(id), "Chi tiết sách - Book Community");

                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {


                    }
                }
            }
                
        

        }
    }
}
