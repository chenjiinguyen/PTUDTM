using DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Business
{
    public class UserBusiness
    {
        public UserBusiness()
        {
        }

        public List<user> GetAll()
        {
            List<user> users = Services.user.GetAll();
            return users;
        }
        public DataTable GetAllDataTable()
        {
            IEnumerable<user> users = Services.user.GetAll();

            DataTable table = new DataTable();
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(user));
            for (int i = 0; i < props.Count; i++)
            {

                PropertyDescriptor prop = props[i];

                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);


            }
            object[] values = new object[props.Count];
            foreach (user t in users)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    var x = props[i].GetValue(t);
                    values[i] = x;




                }
                table.Rows.Add(values);
            }
            return table;
        }

        public user GetUsername(string username) {
            return Services.user.GetUsername(username);
        }
        public bool UpdateUser(string idepi, user input)
        {
            return Services.user.UpdateUser(idepi, input);
        }
    }
}
