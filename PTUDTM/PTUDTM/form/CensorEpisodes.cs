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
    public partial class CensorEpisodes : UserControl
    {

        Thread thread;
        DataTable episodes;
        long id;
        book book;
        public CensorEpisodes()
        {
            InitializeComponent();
        }

        private void CensorEpisodes_Load(object sender, EventArgs e)
        {

        }
    }
}
