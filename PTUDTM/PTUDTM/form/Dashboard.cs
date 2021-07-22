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
    public partial class Dashboard : UserControl
    {
        List<user> users;
        List<book> books;
        Thread thread;
        public Dashboard()
        {
            InitializeComponent();
            this.SetTopLevel(false);
        }

        public void LoadData()
        {
            
            
            String viewCount = books.Select(x => (int)x.view).Aggregate(0, (acc, x) => acc + x).ToString();
            String userCount = users.Count.ToString();
            String bookCount = books.Count.ToString();

            wnTongSach.Number = bookCount;
            wnView.Number = viewCount;
            wnMembers.Number = userCount;

            pnUser.Controls.Clear();
            
            users.ForEach(x =>
            {
                var item = new UserList();
                item.NameUser = x.name;
                item.Role = x.usergroup;
                item.LoadImage(x.avatar);
                pnUser.Controls.Add(item);
            });


            pnBook.Controls.Clear();
            books.ForEach(x =>
            {
                var item = new StoryList();
                item.Title = x.title;
                item.AuthorName = x.author;
                item.ViewNumber = x.view.ToString();
                string category = "";
                switch (x.category)
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
                item.LoadImage(x.poster);
                pnBook.Controls.Add(item);
            });

            thread.Join();




        }

        private void wnView_Load(object sender, EventArgs e)
        {
            

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
 
            thread = new Thread(() =>
            {
                users = Businesses.user.GetAll();
                books = Businesses.book.GetAll();
                Action action = new Action(LoadData);
                this.BeginInvoke(action);
            });
            thread.Start();
            
        }



    }
}

   
