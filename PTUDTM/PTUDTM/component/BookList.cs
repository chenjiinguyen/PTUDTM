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
    }
}
