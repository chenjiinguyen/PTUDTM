using PTUDTM.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUDTM.component
{
    public partial class UserDetail : UserControl
    {
        public string iduser;
        public UserDetail()
        {
            InitializeComponent();
        }

        public void LoadImage(string url)
        {
            picterposter.LoadAsync(url);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Program.LoadDialog(new EditUser(iduser), "Chỉnh Sửa Thông Tin Sách - Book Community");
        }
    }
}
