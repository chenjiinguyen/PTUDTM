using BLL;
using DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PTUDTM.helper.ExcelTemplate;

namespace PTUDTM.form
{
    public partial class UserStatistical : UserControl
    {
        public UserStatistical()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            List<user> users = Businesses.user.GetAll();
            cbxUser.DataSource = users;
            cbxUser.ValueMember = "username";
            cbxUser.DisplayMember = "name";


            cbxDate.Text = "";
            cbxDate.Items.Clear();
            DateTime DateBegin = DateTime.Parse("2000/01/01 00:00:00");
            DateTime DateEnd = DateTime.Now.Date.Add(new TimeSpan(23, 59, 59));
            DateTime dt = DateEnd;
            while (dt >= DateBegin)
            {
                cbxDate.Items.Add(dt.ToString("MM/yyyy"));
                dt = dt.AddMonths(-1);
            }
        }

        private void UserStatistical_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void rdThangNam_CheckedChanged(object sender, EventArgs e)
        {
            cbxDate.Text = "";
            cbxDate.Items.Clear();
            DateTime DateBegin = DateTime.Parse("2000/01/01 00:00:00");
            DateTime DateEnd = DateTime.Now.Date.Add(new TimeSpan(23, 59, 59));
            if (rdNam.Checked)
            {
                DateTime dt = DateEnd;
                while (dt >= DateBegin)
                {
                    cbxDate.Items.Add(dt.ToString("yyyy"));
                    dt = dt.AddYears(-1);
                }
            }
            else
            {
                DateTime dt = DateEnd;
                while (dt >= DateBegin)
                {
                    cbxDate.Items.Add(dt.ToString("MM/yyyy"));
                    dt = dt.AddMonths(-1);
                }
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (cbxDate.Text.Trim() != "")
            {
                guna2DataGridView1.DataSource = null;
                string username = cbxUser.SelectedValue.ToString();
                string ThangNam = cbxDate.Text.Trim();
                DateTime begin;
                DateTime end;
                DataTable result;
                string format = "dd/MM/yyyy HH:mm:ss";
                CultureInfo provider = CultureInfo.InvariantCulture;
                if (rdNam.Checked)
                {
                    begin = DateTime.ParseExact("01/01/" + ThangNam + " 00:00:00", format, provider);
                    end = DateTime.ParseExact("31/12/" + ThangNam + " 23:59:59", format, provider);
                }
                else
                {
                    begin = DateTime.ParseExact("01/" + ThangNam + " 00:00:00", format, provider);
                    end = DateTime.ParseExact("01/" + ThangNam + " 23:59:59", format, provider).AddMonths(1).AddDays(-1);
                }

                guna2DataGridView1.AutoGenerateColumns = false;
                result = Businesses.statistical.pointStatistical(username, begin, end, rdThang.Checked);
                guna2DataGridView1.DataSource = result;


            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (cbxDate.Text.Trim() != "")
            {
              
                string username = cbxUser.SelectedValue.ToString();
                string ThangNam = cbxDate.Text.Trim();
                DateTime begin;
                DateTime end;
                DataTable result;
                string format = "dd/MM/yyyy HH:mm:ss";
                CultureInfo provider = CultureInfo.InvariantCulture;
                if (rdNam.Checked)
                {
                    begin = DateTime.ParseExact("01/01/" + ThangNam + " 00:00:00", format, provider);
                    end = DateTime.ParseExact("31/12/" + ThangNam + " 23:59:59", format, provider);
                }
                else
                {
                    begin = DateTime.ParseExact("01/" + ThangNam + " 00:00:00", format, provider);
                    end = DateTime.ParseExact("01/" + ThangNam + " 23:59:59", format, provider).AddMonths(1).AddDays(-1);
                }

               
                result = Businesses.statistical.pointStatistical(username, begin, end, rdThang.Checked);
                user author = Businesses.user.GetUsername(username);
                var info = new DataTable();
                info.Columns.Add("exporter");
                info.Columns.Add("export_date");
                info.Columns.Add("author_username");
                info.Columns.Add("author_name");
                info.Columns.Add("author_role");
                info.Columns.Add("author_birthday");
                info.Columns.Add("author_gender");
                info.Columns.Add("author_point");
                info.Rows.Add(Program.me.name, DateTime.Now.ToString(), author.username, author.name, author.usergroup1.name, author.birthday.Date.ToString("dd/MM/yyyy"), author.gender,author.point.ToString()) ;
                info.TableName = "info";

                var data = new DataTable();
                data.TableName = "data";
                data.Columns.Add("date", typeof(string));
                data.Columns.Add("income", typeof(string));
                data.Columns.Add("spending", typeof(string));

                foreach(DataRow row in result.Rows)
                {
                    data.Rows.Add(row["date"], row["income"], row["spending"]);
                }    

                var ds = new DataSet();
                ds.Tables.Add(info);
                ds.Tables.Add(data);

                TemplateExcel.FillReport("export.xlsx", "TemplateTKDT.xlsx", ds, new string[] { "{", "}" });
                Process.Start("export.xlsx");




            }
        }
    }
}
