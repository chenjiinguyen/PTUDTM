using PTUDTM.component;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            List<String> data = new List<string> { "Home", "Back", "Go" };
            for(int i = 0;i < 3;i++)
            {
                ButtonFeature btn = new ButtonFeature();
                btn.Location = new Point(0, 45 * i);
                btn.btnFeature.Text = data[i];
                pnFeature.Controls.Add(btn);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frmLogin.Show();
        }
    }
}
