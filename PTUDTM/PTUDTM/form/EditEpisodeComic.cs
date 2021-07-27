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
    public partial class EditEpisodeComic : UserControl
    {
        DataTable links = new DataTable();
        long idepi, idbook;
        public EditEpisodeComic()
        {
            InitializeComponent();
        }
        public EditEpisodeComic(long idepi, long idbook)
        {
            this.idepi = idepi;
            this.idbook = idbook;
            InitializeComponent();
            
        }

        public void LoadData()
        {
            
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = links;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void EditEpisodeComic_Load(object sender, EventArgs e)
        {
            episode epi = Businesses.episode.GetByID(idepi);
            links.Columns.Add("URL", typeof(string));
            txtChapterTitle.Text = epi.name;
            List<string> contents = epi.content.Split('|').ToList();
            foreach(string content in contents)
            {
                DataRow row = links.NewRow();
                row.SetField<string>("URL", content);
                links.Rows.Add(row);
            }
            ((Form)this.TopLevelControl).FormClosing += FormDialog_FormClosing;
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow row = links.NewRow();
            links.Rows.Add(row);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                DataRow dataRow = links.Rows[rowIndex];
                dataRow.Delete();
            }
            else if (dialogResult == DialogResult.No)
            {


            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa tất cả không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                links.Rows.Clear();
            }
            else if (dialogResult == DialogResult.No)
            {


            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            string title = txtChapterTitle.Text;
            long countTitle = title.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
            List<string> links_data = links.AsEnumerable().Select(row => row.Field<string>("URL")).Where(x => x != null).ToList();
            string contentLink = string.Join("|", links_data);
            bool check_links = links_data.AsEnumerable().All(x =>
            {
                string regexLink = @"^(http(s?):)([/|.|\w|\s|-])*\.(?:jpg|jpeg|png)$";
                bool match = Regex.IsMatch(x, regexLink);
                return match;
            });


            if ((countTitle > 0 && countTitle <= 100) && links.Rows.Count > 0)
            {

                if (!check_links)
                {

                    MessageBox.Show("Link nhập vào phải là link ảnh hợp lệ", "Thông báo");
                }
                else
                {
                    episode epi = new episode();
                    epi.name = title;
                    epi.content = contentLink;
                    epi.updatedat = DateTime.Now;
                    bool update = Businesses.episode.UpdateEpi(idepi, epi);
                    if (!update)
                    {
                        MessageBox.Show("Thất bại", "Thông báo");
                    }
                    else
                    {

                        MessageBox.Show("Thành công", "Thông báo");
                        ((Form)this.TopLevelControl).Close();
                    }
                }

            }

            else if (countTitle == 0 || links.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng không để trống!", "Thông báo");
            }
            else if (countTitle > 100)
            {
                MessageBox.Show("Tiêu đề không được quá 100 từ!", "Thông báo");
            }

        }

        private void FormDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((Form)this.TopLevelControl).FormClosing -= FormDialog_FormClosing;
            Program.LoadDialog(new DetailBook(idbook), "Chi tiết sách - Book Community");

        }
    }
}
