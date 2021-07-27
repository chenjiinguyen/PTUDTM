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
    public partial class BookList : UserControl
    {
        public long id;

        public BookList()
        {
            InitializeComponent();
        }
        public BookList(long id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void BookList_Load(object sender, EventArgs e)
        {

        }

        public void LoadImage(string url)
        {
            picturePoster.LoadAsync(url);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Program.LoadDialog(new EditBook(id), "Chỉnh Sửa Thông Tin Sách - Book Community");
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
                    Program.LoadForm(new Books());

                }
            }
            else if (dialogResult == DialogResult.No)
            {


            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            Program.LoadDialog(new DetailBook(id), "Chi tiết sách - Book Community");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
