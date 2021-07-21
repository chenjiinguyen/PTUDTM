using MODEL.Model;
using PTUDTM.component;
using PTUDTM.form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUDTM
{
    public static class ThreadHelperClass
    {
        delegate void SetTextCallback(Form f, Control ctrl, string text);
        /// <summary>
        /// Set text property of various controls
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="ctrl"></param>
        /// <param name="text"></param>
        public static void SetText(Form form, Control ctrl, string text)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (ctrl.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                form.Invoke(d, new object[] { form, ctrl, text });
            }
            else
            {
                ctrl.Text = text;
            }
        }



        delegate void SetNumberDashboardCallback(Dashboard f, WidgetNumber wn, string text);
        /// <summary>
        /// Set Number property of various controls
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="wn"></param>
        /// <param name="text"></param>
        public static void SetNumberDashboard(Dashboard form, WidgetNumber wn, string text)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (wn.InvokeRequired)
            {
                SetNumberDashboardCallback d = new SetNumberDashboardCallback(SetNumberDashboard);
                form.Invoke(d, new object[] { form, wn, text });
            }
            else
            {
                wn.Number = text;
            }
        }

        delegate void SetPanelBookListDashboardCallback(Dashboard f, Panel panel, List<Book> books);
        /// <summary>
        /// Set Number property of various controls
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="wn"></param>
        /// <param name="text"></param>
        public static void SetPanelListDashboard(Dashboard form, Panel panel, List<Book> books)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (panel.InvokeRequired)
            {
                SetPanelBookListDashboardCallback d = new SetPanelBookListDashboardCallback(SetPanelListDashboard);
                form.Invoke(d, new object[] { form, panel, books });
            }
            else
            {
                panel.Controls.Clear();

                books.ForEach(x =>
                {
                    var item = new StoryList();
                    item.Title = x.Title;
                    item.AuthorName = x.Author;
                    item.ViewNumber = x.View.ToString();
                    string category = "";
                    switch (x.Category)
                    {
                        case "TEXT":
                            category = "Truyện Chữ";
                            break;
                        case "IMAGE":
                            category = "Truyện Tranh";
                            break;
                        case "AUDIO":
                            category = "Truyện Audio";
                            break;
                    }
                    item.CategoryName = category;
                    item.LoadImage(x.Poster);
                    panel.Controls.Add(item);
                });
            }
        }

        delegate void SetPanelUserListDashboardCallback(Dashboard f, Panel panel, List<User> users);
        /// <summary>
        /// Set Number property of various controls
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="wn"></param>
        /// <param name="text"></param>
        public static void SetPanelListDashboard(Dashboard form, Panel panel, List<User> users)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (panel.InvokeRequired)
            {
                SetPanelUserListDashboardCallback d = new SetPanelUserListDashboardCallback(SetPanelListDashboard);
                form.Invoke(d, new object[] { form, panel, users });
            }
            else
            {
                panel.Controls.Clear();

                users.ForEach(x =>
                {
                    var item = new UserList();
                    item.NameUser = x.Name;
                    item.Role = x.Usergroup;
                    item.LoadImage(x.Avatar);
                    panel.Controls.Add(item);
                });
            }
        }
    }
}
