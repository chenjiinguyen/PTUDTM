using PTUDTM.form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUDTM
{
    static class Program
    {
        public static string token = "";
        public static frmMain frmMain;
        public static frmLogin frmLogin;
        public static frmCreateEpisodeAudio frmDeTail;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin = new frmLogin();
            Application.Run(frmLogin);
        }
    }
}
