using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUDTM
{
    public partial class frmCreateEpisodeAudio : Form
    {
        public frmCreateEpisodeAudio()
        {
            InitializeComponent();
        }

        private void frmCreateEpisodeAudio_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void txtLink_KeyUp(object sender, KeyEventArgs e)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' style='width: 100%; height: 420px' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";
            this.webBrowser1.DocumentText = string.Format(html, txtLink.Text.Split('=')[1]);
        }
    }
}
