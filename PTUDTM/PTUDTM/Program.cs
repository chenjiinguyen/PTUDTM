using DLL;
using PTUDTM.form;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUDTM
{
    static class Program
    {
        public static user me = null;
        public static Panel mainPanel;
        public static Form dialog = null;
        public static frmMain frmMain;
        public static frmLogin frmLogin;
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

        public static void LoadForm(Control c)
        {
            mainPanel.Controls.Clear();
            c.Parent = mainPanel;
            c.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(c);
        }

        public static void LoadDialog(UserControl c, string title)
        {
            if(dialog != null)
            {
                dialog.Close();
                dialog.Hide();
                dialog = null;
            }
            dialog = new Form()
            {
                Text = title,
                TopLevel = true,
                StartPosition = FormStartPosition.CenterScreen,
                Size = new Size(1200, 900),
                MinimumSize = new Size(1200, 900),

            };
            dialog.Controls.Clear();
            c.Parent = dialog;
            c.Dock = DockStyle.Fill;
            dialog.Controls.Add(c);
            dialog.ShowDialog();
        }

    }





   
}
