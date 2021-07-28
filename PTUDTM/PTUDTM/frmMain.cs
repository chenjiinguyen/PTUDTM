using BLL;
using DLL;
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
        private user me;
        public frmMain()
        {
            InitializeComponent();
            Program.mainPanel = pnMain;
            LoadData();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            me = Program.me;
            lbName.Text = me.name;
            imageAvatar.LoadAsync(me.avatar);


            List<string> data_title = new List<string>() { "Dashboard", "Books", "Users", "Censorship" };
            List<Image> data_icon= new List<Image>() { Properties.Resources.icon_dashboard , Properties.Resources.icon_books, Properties.Resources.icon_users, Properties.Resources.icon_censor };
            List<string> data_tag = new List<string>() { "DB", "B", "U" , "CS" };
            for (int i = 0; i < data_title.Count;i++)
            {
                ButtonFeature btn = new ButtonFeature();
                btn.btnFeature.Text = data_title[i];
                btn.LoadImage(data_icon[i]);
                btn.btnFeature.Tag = data_tag[i];
                btn.btnFeature.Click += new System.EventHandler(this.btnMenu_Click);
                pnFeature.Controls.Add(btn);
            }


        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            string tag  = (sender as Control).Tag.ToString();
            switch (tag)
            {
                case "DB":
                    Program.LoadForm(new Dashboard());
                    break;
                case "B":
                    Program.LoadForm(new Books());
                    break;
                case "U":
                    Program.LoadForm(new UsersList());
                    break;
                case "CS":
                    Program.LoadForm(new CensorBooks());
                    break;
                default:
                    Program.LoadForm(new Dashboard());
                    break;
            }
           
        }

        void LoadData()
        {

            var c = new Dashboard();
            pnMain.Controls.Clear();
            c.Parent = pnMain;
            c.Dock = DockStyle.Fill;
            pnMain.Controls.Add(c);
        }

            


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            Program.frmLogin.Show();

        }
    }
}
