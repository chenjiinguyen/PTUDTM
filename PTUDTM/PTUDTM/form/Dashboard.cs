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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();

            Thread t = new Thread(LoadData);
            t.Start();
        }

        public void LoadData()
        {

            
            string token = Program.token;
            List<Book> books = Businesses.book.GetAll();
            List<User> users = Businesses.user.GetAll();
            int count_view = books.Select(x=> x.View).Aggregate(0, (acc, x) => acc + x);

            ThreadHelperClass.SetNumberDashboard(this, wnTongSach, books.Count.ToString());
            ThreadHelperClass.SetNumberDashboard(this, wnMembers, users.Count.ToString());
            ThreadHelperClass.SetNumberDashboard(this, wnView, count_view.ToString());

            ThreadHelperClass.SetPanelListDashboard(this, pnBook, books);
            ThreadHelperClass.SetPanelListDashboard(this, pnUser, users);


        }

        private void wnView_Load(object sender, EventArgs e)
        {

        }
    }
}

   
