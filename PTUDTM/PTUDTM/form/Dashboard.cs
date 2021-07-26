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
        List<book> books, censor_books;
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
            String censorCount = censor_books.Count.ToString();
            wnTongSach.Number = bookCount;
            wnView.Number = viewCount;
            wnMembers.Number = userCount;
            wnCensorBook.Number = censorCount;

          

            

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
                censor_books = Businesses.book.GetAllUncensor();
                Action action = new Action(LoadData);
                this.BeginInvoke(action);
            });
            thread.Start();
            
        }



    }
}

   
