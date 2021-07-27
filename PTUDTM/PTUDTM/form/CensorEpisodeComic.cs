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
    public partial class CensorEpisodeComic : UserControl {
        DataTable links = new DataTable();
        long idepi;

        public CensorEpisodeComic(long idepi)
        {
            this.idepi = idepi;
            InitializeComponent();
        }

        private void CensorEpisodeComic_Load(object sender, EventArgs e)
        {
            episode epi = Businesses.episode.GetByID(idepi);
            links.Columns.Add("URL", typeof(string));
            txtTitle.Text = epi.name;
            List<string> contents = epi.content.Split('|').ToList();
            foreach (string content in contents)
            {
                DataRow row = links.NewRow();
                row.SetField<string>("URL", content);
                links.Rows.Add(row);
            }
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = links;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void btnRefuse_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thực hiện hành động này ?", "Cảnh báo !!!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                string content = txtContentCensor.Text;
                moderation_episode input = new moderation_episode();
                input.content = content;
                input.moderation = 2;
                input.moderator = Program.me.username;
                bool result = Businesses.modepi.Update(idepi, input);
                if (result)
                {
                    MessageBox.Show("Thành Công", "Thông Báo");
                    Program.LoadForm(new CensorBooks());
                    ((Form)this.TopLevelControl).Close();
                }
                else
                {
                    MessageBox.Show("Thất Bại", "Thông Báo");
                }
            }
        }

        private void btnAllow_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thực hiện hành động này ?", "Cảnh báo !!!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                string content = txtContentCensor.Text;
                moderation_episode input = new moderation_episode();
                input.content = content;
                input.moderation = 3;
                input.moderator = Program.me.username;
                bool result = Businesses.modepi.Update(idepi, input);
                if (result)
                {
                    MessageBox.Show("Thành Công", "Thông Báo");
                    Program.LoadForm(new CensorBooks());
                    ((Form)this.TopLevelControl).Close();
                }
                else
                {
                    MessageBox.Show("Thất Bại", "Thông Báo");
                }
            }
        }
    }
}
