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
    public partial class CensorBooks : UserControl
    {
        DataTable books;
        Thread thread;
        public CensorBooks()
        {
            InitializeComponent();
            this.SetTopLevel(false);
        }

        private void LoadData()
        {
            List<category> data_categories = Businesses.category.GetAll();
            List<category> categories = new List<category>();
            category all_category = new category();
            all_category.name = "Tất cả";
            all_category.idcategory = "";
            all_category.books = null;
            categories.Add(all_category);
            categories.AddRange(data_categories);

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = categories;

            cboCate.DataSource = bindingSource1.DataSource;
            cboCate.DisplayMember = "name";
            cboCate.ValueMember = "idcategory";

            guna2DataGridView1.AutoGenerateColumns = false;
            guna2DataGridView1.DataSource = books;

            thread.Join();


        }

        private void CensorBooks_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.RowStyles[1].SizeType = SizeType.Absolute;
            tableLayoutPanel1.RowStyles[1].Height = 0;
            thread = new Thread(() =>
            {
                books = Businesses.book.GetAllUncensorDataTable();
                Action action = new Action(LoadData);
                this.BeginInvoke(action);
            });
            thread.Start();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            string category = cboCate.SelectedValue.ToString();
            DataTable tblFiltered = books.Clone();
            if (category == "")
            {
                var rows = books.AsEnumerable().Where(row => row.Field<String>("title").Contains(keyword) || row.Field<String>("author").Contains(keyword)).OrderByDescending(row => row.Field<String>("title"));
                foreach (var row in rows)
                    tblFiltered.ImportRow(row);
            }
            else
            {
                var rows = books.AsEnumerable().Where(row => (row.Field<String>("title").Contains(keyword) || row.Field<String>("author").Contains(keyword)) && row.Field<String>("category") == category).OrderByDescending(row => row.Field<String>("title"));
                foreach (var row in rows)
                    tblFiltered.ImportRow(row);
            }


            tableLayoutPanel1.RowStyles[1].SizeType = SizeType.Absolute;
            tableLayoutPanel1.RowStyles[1].Height = 0;
            guna2DataGridView1.DataSource = tblFiltered;
        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {
            int i = guna2DataGridView1.CurrentRow.Index;
            if (i >= 0)
            {
                tableLayoutPanel1.RowStyles[1].SizeType = SizeType.Absolute;
                tableLayoutPanel1.RowStyles[1].Height = 240;

                int id = int.Parse(guna2DataGridView1.CurrentRow.Cells["id"].Value.ToString());

                DataRow row = books.AsEnumerable().Single(x => (int)x.Field<long>("idbook") == id);
                bookDetail.id = id;
                bookDetail.Title = row.Field<String>("title");
                bookDetail.AuthorName = row.Field<String>("author");
                bookDetail.LoadImage(row.Field<String>("poster"));
                bookDetail.CategoryName = Businesses.category.GetNameByID(row.Field<String>("category"));
                bookDetail.Time = (row.Field<DateTime>("createdat")).ToString();
                bookDetail.ViewNumber = row.Field<long>("view").ToString();
                bookDetail.LoadData();
            }
        }
    }
}
