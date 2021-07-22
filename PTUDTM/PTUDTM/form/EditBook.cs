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
    public partial class EditBook : UserControl
    {
        long id;
        public EditBook()
        {
            InitializeComponent();
            this.SetTopLevel(false);
        }

        public EditBook(long id)
        {
            InitializeComponent();
            this.SetTopLevel(false);
            this.id = id;
        }

        private void EditBook_Load(object sender, EventArgs e)
        {
            book book = Businesses.book.GetByID(id);
            List<category> cateogories = Businesses.category.GetAll();

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = cateogories;

            cboCate.DataSource = bindingSource1.DataSource;
            cboCate.DisplayMember = "name";
            cboCate.ValueMember = "idcategory";

            cboCate.SelectedValue = book.category;
            txtTitle.Text = book.title;
            txtIntro.Text = book.description;
            txtPicCover.Text = book.poster;
            txtAuthorName.Text = book.author;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }
    }
}
