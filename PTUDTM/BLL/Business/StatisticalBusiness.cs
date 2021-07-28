using DLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Business
{
    public class StatisticalBusiness
    {
        public StatisticalBusiness()
        {
        }

        public DataTable pointStatistical(string username, DateTime begin, DateTime end, bool month_check)
        {
            string format = "dd/MM/yyyy HH:mm:ss";
            CultureInfo provider = CultureInfo.InvariantCulture;
            DataTable data = new DataTable();
            data.Columns.Add("date");
            data.Columns.Add("income");
            data.Columns.Add("spending");

            List<point> points = Services.point.getByUsername(username);
   
            if (month_check)
            {
                for(int day = 1; day <= end.Day; day++)
                {
                    DataRow row = data.NewRow();
                    DateTime day_dt = DateTime.ParseExact(day.ToString("D2") + "/" + end.Month.ToString("D2") + "/" + end.Year + " 00:00:00", format, provider);
                    DateTime day_dt_end = DateTime.ParseExact(day.ToString("D2") + "/" + end.Month.ToString("D2") + "/" + end.Year + " 23:59:59", format, provider);
                    long income = points.Where(x => x.createdat >= day_dt && x.createdat <= day_dt_end && x.charge == true).Aggregate((long)0, (x, y) => x + y.point1);
                    long spending = points.Where(x => x.createdat >= day_dt && x.createdat <= day_dt_end && x.charge == false).Aggregate((long)0, (x, y) => x + y.point1);
                    row["date"] = day_dt.ToString("dd/MM/yyyy");
                    row["income"] = (income == 0) ? "0" : "+" + income.ToString();
                    row["spending"] = (spending == 0) ? "0" : "-" + spending.ToString();
                    data.Rows.Add(row);
                }    
                
            }
            else
            {
                for (int month = 1; month <= end.Month; month++)
                {
                    DataRow row = data.NewRow();

                    DateTime day_dt = DateTime.ParseExact( "01/" + month.ToString("D2") + "/" + end.Year + " 00:00:00", format, provider);
                    int endday_in_month = day_dt.AddMonths(1).AddSeconds(-1).Day;
                    DateTime day_dt_end = DateTime.ParseExact(endday_in_month.ToString("D2")+ "/" + month.ToString("D2") + "/" + end.Year + " 23:59:59", format, provider);
                    long income = points.Where(x => x.createdat >= day_dt && x.createdat <= day_dt_end && x.charge == true).Aggregate((long)0, (x, y) => x + y.point1);
                    long spending = points.Where(x => x.createdat >= day_dt && x.createdat <= day_dt_end && x.charge == false).Aggregate((long)0, (x, y) => x + y.point1);
                    row["date"] = day_dt.ToString("MM/yyyy");
                    row["income"] = (income == 0)?"0":"+" +income.ToString();
                    row["spending"] = (spending == 0) ? "0" : "-" + spending.ToString();
                    data.Rows.Add(row);
                }
            }
            return data;
        }
    }
}
