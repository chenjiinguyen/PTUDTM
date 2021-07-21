using BLL;
using MODEL.Model;
using PTUDTM.component;
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
    public partial class frmMain : Form
    {
        private User me;
        public frmMain()
        {
            InitializeComponent();
            LoadData();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {



            List<string> data_title = new List<string>() { "Dashboard", "Books", "Users" };
            List<Image> data_icon= new List<Image>() { Properties.Resources.icon_dashboard , Properties.Resources.icon_books, Properties.Resources.icon_users };
            for (int i = 0; i < data_title.Count;i++)
            {
                ButtonFeature btn = new ButtonFeature();

                btn.btnFeature.Text = data_title[i];
                btn.LoadImage(data_icon[i]);
                pnFeature.Controls.Add(btn);
            }


        }

        void LoadData()
        {
            me = Businesses.auth.me(Program.token);

            lbName.Text = me.Name;
            imageAvatar.Load(me.Avatar);

            var control = new Dashboard();
            control.Dock = DockStyle.Fill;
            pnMain.Controls.Add(control);
        }



        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            Program.frmLogin.Show();

        }
    }
}
