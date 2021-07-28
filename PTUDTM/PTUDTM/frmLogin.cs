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
using System.Net.Http;
using System.Net.Http.Headers;
using BLL;
using DLL;

namespace PTUDTM
{

    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnLogin_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            user me = Businesses.auth.Signin(username, password);


            if (me != null)
            {
                bool check_role = Businesses.role.Check(me.usergroup, "QUANTRI");
                if (check_role)
                {
                    Program.me = me;
                    Program.frmMain = new frmMain();
                    this.Hide();
                    Program.frmMain.Show();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền truy cập vào", "thông báo");
                }

            }
            else
            {
                MessageBox.Show("sai tên đăng nhập hoặc mật khẩu !!!", "thông báo");
            }

        }

        private void pnLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
  
        }
    }
}
