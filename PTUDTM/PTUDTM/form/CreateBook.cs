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
    public partial class CreateBook : UserControl
    {
        public CreateBook()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void CreateBook_Load(object sender, EventArgs e)
        {
            List<category> cateogories = Businesses.category.GetAll();

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = cateogories;

            cboCate.DataSource = bindingSource1.DataSource;
            cboCate.DisplayMember = "name";
            cboCate.ValueMember = "idcategory";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            char[] delimiters = new char[] { ' ', '\r', '\n' };

            string author = txtAuthorName.Text;
            string title = txtTitle.Text;
            string cate = cboCate.SelectedValue.ToString();
            string poster = txtPicCover.Text;
            string description = txtIntro.Text;
            long countTitle = title.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
            long countAuthor = author.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;

            if (countTitle == 0 || countAuthor == 0 || poster.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng không để trống!", "Thông báo");

            }
            else if (countTitle > 100)
            {
                MessageBox.Show("Tiêu đề không được quá 100 từ!", "Thông báo");
            }
            else if (countAuthor > 100)
            {
                MessageBox.Show("Tên tác giả không được quá 100 từ!", "Thông báo");
            }
            else
            {
                string regexLink = @"^(http(s?):)([/|.|\w|\s|-])*\.(?:jpg|jpeg|png)$";
                bool match = Regex.IsMatch(poster, regexLink);
                if(match)
                {
                    book book = new book();
                    book.title = title;
                    book.author = author;
                    book.category = cate;
                    book.poster = poster;
                    book.description = description;
                    book.status = 1;
                    book.uploader = Program.me.username;
                    book.createdat = book.updatedat = DateTime.Now;

                    long id = Businesses.book.Create(book);
                    if(id == -1)
                    {
                        MessageBox.Show("Thất bại", "Title");
                    }
                    else
                    {
                        MessageBox.Show("Thành công", "Title");
                        if(cate == "TEXT")
                        {
                            Program.LoadDialog(new CreateEpisodeText(id), "Đăng chương - Book Community");
                        }    

                        
                        
                    }

                }
                else
                {
                    MessageBox.Show("Link ảnh không hợp lệ", "Title");
                }
            }
        }
    }
}
