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
    public partial class UsersList : UserControl
    {
        Thread thread;
        DataTable users;

        public UsersList()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            List<usergroup> data_usergr = Businesses.usergroup.GetAll();
            List<usergroup> usergroups = new List<usergroup>();
            usergroup all_usergr = new usergroup();
            all_usergr.name = "Tất cả";
            all_usergr.idgroup = "";
            all_usergr.users = null;
            usergroups.Add(all_usergr);
            usergroups.AddRange(data_usergr);

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = usergroups;

            cboRole.DataSource = bindingSource1.DataSource;
            cboRole.DisplayMember = "name";
            cboRole.ValueMember = "idgroup";


            guna2DataGridView1.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            guna2DataGridView1.AutoGenerateColumns = false;
            guna2DataGridView1.DataSource = users;
            
            thread.Join();


        }
        private void UsersList_Load(object sender, EventArgs e)
        {
            thread = new Thread(() =>
            {
                users = Businesses.user.GetAllDataTable();

                Action action = new Action(LoadData);
                this.BeginInvoke(action);
            });
            thread.Start();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            string role = cboRole.SelectedValue.ToString();
            DataTable tblFiltered = users.Clone();
            if (role == "")
            {
                var rows = users.AsEnumerable().Where(row => row.Field<String>("username").Contains(keyword) || row.Field<String>("email").Contains(keyword) || row.Field<String>("name").Contains(keyword)).OrderByDescending(row => row.Field<String>("name"));
                foreach (var row in rows)
                    tblFiltered.ImportRow(row);
            }
            else
            {
                var rows = users.AsEnumerable().Where(row => (row.Field<String>("username").Contains(keyword) || row.Field<String>("email").Contains(keyword) || row.Field<String>("name").Contains(keyword)) && row.Field<String>("usergroup") == role).OrderByDescending(row => row.Field<String>("name"));
                foreach (var row in rows)
                    tblFiltered.ImportRow(row);
            }


            tableLayoutPanel1.RowStyles[1].SizeType = SizeType.Absolute;
            tableLayoutPanel1.RowStyles[1].Height = 0;
            guna2DataGridView1.DataSource = tblFiltered;
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = guna2DataGridView1.CurrentRow.Index;
            if (i >= 0)
            {
                tableLayoutPanel1.RowStyles[1].SizeType = SizeType.Absolute;
                tableLayoutPanel1.RowStyles[1].Height = 240;

                string username = guna2DataGridView1.CurrentRow.Cells["username"].Value.ToString();

                DataRow row = users.AsEnumerable().Single(x => x.Field<string>("username") == username);
                userDetail1.NameTitle = row.Field<String>("name");
                userDetail1.Role = row.Field<String>("usergroup");
                userDetail1.Birthday = String.Format("{0:dd/MM/yyyy}", row.Field<DateTime>("birthday"));
                userDetail1.Gender = row.Field<String>("gender");
                userDetail1.Email = row.Field<String>("email");
                userDetail1.LoadImage(row.Field<String>("avatar"));
                userDetail1.iduser = username;
            }
        }

        private void userDetail1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
