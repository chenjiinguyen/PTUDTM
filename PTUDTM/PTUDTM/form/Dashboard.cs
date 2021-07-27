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
using System.Windows.Forms.DataVisualization.Charting;

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

            List<string> category_name = Businesses.category.GetAll().Select(a => a.name).ToList();
            List<int> category_default = category_name.Select(x => 0).ToList();
            //Get the Total of Orders for each City.
            List<int> category_total = books.Aggregate(category_default, (acc, a) => {
                int index = category_name.IndexOf(a.category1.name);
                acc[index]++;
                return acc;
            });

            chartBook.Series[0].ChartType = SeriesChartType.Pie;
            chartBook.Series[0].Points.DataBindXY(category_name, category_total);
            chartBook.Legends[0].Enabled = true;


            List<string> seven_day = new List<string>();
            for(int i = 7; i > -1; i--)
            {
                seven_day.Add(String.Format("{0:dd/MM}", DateTime.Today.AddDays(-i)));
            }
            List<int> book_create_in_seven_day_default = seven_day.Select(x => 0).ToList();
           List<int> book_create_in_seven_day = books.Where(x=> x.createdat >= DateTime.Today.AddDays(-7).Date && x.status == 3).Aggregate(book_create_in_seven_day_default, (acc, a) => {
                int index = seven_day.IndexOf(String.Format("{0:dd/MM}", a.updatedat));
                if(index != -1) acc[index]++;
                return acc;
            });

            charUser.Series[0].LegendText = "Sách";
            charUser.Series[0].ChartType = SeriesChartType.Column;
            charUser.Series[0].Points.DataBindXY(seven_day, book_create_in_seven_day);
            charUser.Legends[0].Enabled = true;

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

   
