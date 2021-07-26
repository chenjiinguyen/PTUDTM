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
    public partial class BookCensorship : UserControl
    {
        long id;
        public BookCensorship(long id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void BookCensorship_Load(object sender, EventArgs e)
        {
            book book = Businesses.book.GetID(id);
            List<category> cateogories = Businesses.category.GetAll();

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = cateogories;

            cboCate.DataSource = bindingSource1.DataSource;
            cboCate.DisplayMember = "name";
            cboCate.ValueMember = "idcategory";
            cboCate.Enabled = false;

            cboCate.SelectedValue = book.category;
            txtTitle.Text = book.title;
            txtIntro.Text = book.description;
            picturePoster.LoadAsync(book.poster);
            txtAuthorName.Text = book.author;
        }

        private void btnRefuse_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thực hiện hành động này ?", "Cảnh báo", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                string content = txtContentCensor.Text;
                moderation_book input = new moderation_book();
                input.content = content;
                input.moderation = 2;
                input.moderator = Program.me.username;
                bool result = Businesses.modbook.Update(id, input);
                if(result)
                {
                    MessageBox.Show("Thành Công", "Thông Báo");
                    ((Form)this.TopLevelControl).Close();
                }
                else
                {
                    MessageBox.Show("Thất Bại", "Thông Báo");
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thực hiện hành động này ?", "Cảnh báo", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                string content = txtContentCensor.Text;
                moderation_book input = new moderation_book();
                input.content = content;
                input.moderation = 3;
                input.moderator = Program.me.username;
                bool result = Businesses.modbook.Update(id, input);
                if (result)
                {
                    MessageBox.Show("Thành Công", "Thông Báo");
                    ((Form)this.TopLevelControl).Close();
                }
                else
                {
                    MessageBox.Show("Thất Bại", "Thông Báo");
                }
            } 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }
    }
}
