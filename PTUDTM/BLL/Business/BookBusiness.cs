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
    public class BookBusiness
    {
        public BookBusiness()
        {
        }

        public List<book> GetAll()
        {
            List<book> books = Services.book.GetAll();
            return books;

        }

        public List<book> GetAllUncensor()
        {
            List<book> books = Services.book.GetAllUncensor();
            return books;

        }

        

        public book GetByID(long id)
        {
            book book = Services.book.GetByID(id);
            return book;
        }

        public book GetID(long id)
        {
            book book = Services.book.GetID(id);
            return book;
        }
        

        public DataTable GetAllDataTable()
        {
            List<book> books = Services.book.GetAll();

            DataTable table = new DataTable();
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(book));
            for (int i = 0; i < props.Count; i++)
            {

                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                
              
            }
            object[] values = new object[props.Count];
            foreach (book t in books)
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

        public DataTable GetAllUncensorDataTable()
        {
            List<book> books = Services.book.GetAllUncensor();

            DataTable table = new DataTable();
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(book));
            for (int i = 0; i < props.Count; i++)
            {

                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);


            }
            object[] values = new object[props.Count];
            foreach (book t in books)
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

    }

  
}
