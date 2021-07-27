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
        List<user> users;

        public UsersList()
        {
            InitializeComponent();
        }

        private void LoadData()
        {

            guna2DataGridView1.AutoGenerateColumns = false;
            guna2DataGridView1.DataSource = users;
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                row.Cells[4].Value = "Sửa";
                row.Cells[5].Value = "Xóa";
            }
            
            thread.Join();


        }
        private void UserList_Load(object sender, EventArgs e)
        {
            thread = new Thread(() =>
            {
                users = Businesses.user.GetAll();

                Action action = new Action(LoadData);
                this.BeginInvoke(action);
            });
            thread.Start();
        }
    }
}
